using System;
using System.Drawing;
using System.Windows.Forms;
using System.Collections.Generic;

namespace SalonAppointmentSystem
{
    public partial class Form1 : Form
    {
        private readonly List<Appointment> appointments = new List<Appointment>();

        public Form1()
        {
            InitializeComponent();
            InitializeServices();
            SetupListView();
            CustomizeUI();
        }

        private void InitializeServices()
        {
            string[] services = new string[] {
                "Haircut - $30",
                "Hair Coloring - $80",
                "Manicure - $25",
                "Pedicure - $35",
                "Facial - $50"
            };
            comboBox1.Items.AddRange(services);
            comboBox1.SelectedIndex = 0;
        }

        private void SetupListView()
        {
            listView1.View = View.Details;
            listView1.FullRowSelect = true;
            listView1.GridLines = true;

            // Add columns
            listView1.Columns.Add("Customer Name", 150);
            listView1.Columns.Add("Phone", 100);
            listView1.Columns.Add("Service", 150);
            listView1.Columns.Add("Date & Time", 150);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Validate inputs
            if (string.IsNullOrWhiteSpace(textBox1.Text))
            {
                MessageBox.Show("Please enter customer name.", "Validation Error");
                return;
            }

            if (string.IsNullOrWhiteSpace(textBox2.Text))
            {
                MessageBox.Show("Please enter phone number.", "Validation Error");
                return;
            }

            if (comboBox1.SelectedItem == null)
            {
                MessageBox.Show("Please select a service.", "Validation Error");
                return;
            }

            // Validate appointment date
            if (dateTimePicker1.Value < DateTime.Now)
            {
                MessageBox.Show("Please select a future date and time.", "Validation Error");
                return;
            }

            string selectedService = comboBox1.SelectedItem.ToString();

            // Create new appointment
            var appointment = new Appointment
            {
                Id = appointments.Count + 1,
                CustomerName = textBox1.Text.Trim(),
                PhoneNumber = textBox2.Text.Trim(),
                Service = selectedService,
                DateTime = dateTimePicker1.Value
            };

            // Add to list
            appointments.Add(appointment);

            // Add to ListView
            var item = new ListViewItem(appointment.CustomerName);
            item.SubItems.AddRange(new[] {
                appointment.PhoneNumber,
                appointment.Service,
                appointment.DateTime.ToString("MM/dd/yyyy hh:mm tt")
            });
            listView1.Items.Add(item);

            // Clear inputs
            ClearInputs();

            MessageBox.Show("Appointment booked successfully!", "Success");
        }

        private void ClearInputs()
        {
            textBox1.Clear();
            textBox2.Clear();
            comboBox1.SelectedIndex = 0;
            dateTimePicker1.Value = DateTime.Now;
        }

        private void CustomizeUI()
        {
            this.BackColor = Color.FromArgb(245, 245, 245);

            // Customize the tab control
            foreach (TabPage tab in tabControl1.TabPages)
            {
                tab.BackColor = Color.White;
            }
            tabControl1.Appearance = TabAppearance.FlatButtons;
            tabControl1.ItemSize = new Size(100, 40);
            tabControl1.Font = new Font("Arial", 12F, FontStyle.Bold);

            // Customize all labels
            foreach (Control control in tabPage1.Controls)
            {
                if (control is Label label)
                {
                    label.ForeColor = Color.FromArgb(64, 64, 64);
                }
            }

            // Customize text boxes
            var textBoxStyle = new Action<TextBox>(tb =>
            {
                tb.BackColor = Color.FromArgb(245, 245, 245);
                tb.BorderStyle = BorderStyle.FixedSingle;
                tb.Font = new Font("Arial", 10F);
            });

            textBoxStyle(textBox1);
            textBoxStyle(textBox2);

            // Customize combo box
            comboBox1.BackColor = Color.FromArgb(245, 245, 245);
            comboBox1.FlatStyle = FlatStyle.Flat;
            comboBox1.Font = new Font("Arial", 10F);

            // Customize date time picker
            dateTimePicker1.CalendarForeColor = Color.FromArgb(64, 64, 64);
            dateTimePicker1.CalendarMonthBackground = Color.White;
            dateTimePicker1.Font = new Font("Arial", 10F);

            // Customize button
            button1.BackColor = Color.FromArgb(64, 64, 64);
            button1.ForeColor = Color.White;
            button1.Font = new Font("Arial", 10F, FontStyle.Bold);
            button1.FlatStyle = FlatStyle.Flat;
            button1.FlatAppearance.BorderSize = 0;

            // Customize ListView
            listView1.BackColor = Color.White;
            listView1.ForeColor = Color.FromArgb(64, 64, 64);
            listView1.Font = new Font("Arial", 10F);
            listView1.GridLines = true;
            listView1.OwnerDraw = true;
            listView1.DrawColumnHeader += ListViewColumnHeader_Draw;
            listView1.DrawSubItem += ListView1_DrawSubItem;
        }

        private void ListViewColumnHeader_Draw(object sender, DrawListViewColumnHeaderEventArgs e)
        {
            e.Graphics.FillRectangle(new SolidBrush(Color.FromArgb(245, 245, 245)), e.Bounds);
            using var font = new Font("Arial", 10F, FontStyle.Bold);
            e.Graphics.DrawString(e.Header.Text, font, new SolidBrush(Color.FromArgb(64, 64, 64)),
                new Rectangle(e.Bounds.X + 5, e.Bounds.Y, e.Bounds.Width - 5, e.Bounds.Height),
                new StringFormat { LineAlignment = StringAlignment.Center });
        }

        private void ListView1_DrawSubItem(object sender, DrawListViewSubItemEventArgs e)
        {
            e.Graphics.FillRectangle(new SolidBrush(e.ItemState.HasFlag(ListViewItemStates.Selected)
                ? Color.FromArgb(230, 230, 230)
                : Color.White), e.Bounds);

            using var font = new Font("Arial", 10F);
            e.Graphics.DrawString(e.SubItem.Text, font, new SolidBrush(Color.FromArgb(64, 64, 64)),
                new Rectangle(e.Bounds.X + 5, e.Bounds.Y, e.Bounds.Width - 5, e.Bounds.Height),
                new StringFormat { LineAlignment = StringAlignment.Center });
        }
    }

    [Serializable]
    public class Appointment
    {
        public int Id { get; set; }
        public required string CustomerName { get; set; }
        public required string PhoneNumber { get; set; }
        public required string Service { get; set; }
        public DateTime DateTime { get; set; }
    }
}