namespace SalonAppointmentSystem
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            button1 = new Button();
            dateTimePicker1 = new DateTimePicker();
            comboBox1 = new ComboBox();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            tabPage2 = new TabPage();
            listView1 = new ListView();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Appearance = TabAppearance.FlatButtons;
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tabControl1.ItemSize = new Size(100, 40);
            tabControl1.Location = new Point(0, 0);
            tabControl1.Margin = new Padding(4, 3, 4, 3);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(933, 519);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.BackColor = Color.White;
            tabPage1.Controls.Add(button1);
            tabPage1.Controls.Add(dateTimePicker1);
            tabPage1.Controls.Add(comboBox1);
            tabPage1.Controls.Add(textBox2);
            tabPage1.Controls.Add(textBox1);
            tabPage1.Controls.Add(label4);
            tabPage1.Controls.Add(label3);
            tabPage1.Controls.Add(label2);
            tabPage1.Controls.Add(label1);
            tabPage1.Location = new Point(4, 44);
            tabPage1.Margin = new Padding(4, 3, 4, 3);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(4, 3, 4, 3);
            tabPage1.Size = new Size(925, 471);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Book Appointment";
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(64, 64, 64);
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Arial", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Location = new Point(23, 182);
            button1.Margin = new Padding(4, 3, 4, 3);
            button1.Name = "button1";
            button1.Size = new Size(140, 35);
            button1.TabIndex = 8;
            button1.Text = "Book Appointment";
            button1.UseVisualStyleBackColor = false;
            button1.Click += new System.EventHandler(this.button1_Click);  // Add this line
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.CalendarForeColor = Color.FromArgb(64, 64, 64);
            dateTimePicker1.CalendarMonthBackground = Color.White;
            dateTimePicker1.CustomFormat = "MM/dd/yyyy hh:mm tt";
            dateTimePicker1.Font = new Font("Arial", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.Location = new Point(169, 127);
            dateTimePicker1.Margin = new Padding(4, 3, 4, 3);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(233, 23);
            dateTimePicker1.TabIndex = 7;
            // 
            // comboBox1
            // 
            comboBox1.BackColor = Color.FromArgb(245, 245, 245);
            comboBox1.FlatStyle = FlatStyle.Flat;
            comboBox1.Font = new Font("Arial", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(169, 92);
            comboBox1.Margin = new Padding(4, 3, 4, 3);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(233, 24);
            comboBox1.TabIndex = 6;
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.FromArgb(245, 245, 245);
            textBox2.BorderStyle = BorderStyle.FixedSingle;
            textBox2.Font = new Font("Arial", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox2.Location = new Point(169, 58);
            textBox2.Margin = new Padding(4, 3, 4, 3);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(233, 23);
            textBox2.TabIndex = 5;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.FromArgb(245, 245, 245);
            textBox1.BorderStyle = BorderStyle.FixedSingle;
            textBox1.Font = new Font("Arial", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(169, 23);
            textBox1.Margin = new Padding(4, 3, 4, 3);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(233, 23);
            textBox1.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = Color.FromArgb(64, 64, 64);
            label4.Location = new Point(23, 127);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(107, 19);
            label4.TabIndex = 3;
            label4.Text = "Date && Time:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.FromArgb(64, 64, 64);
            label3.Location = new Point(23, 92);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(72, 19);
            label3.TabIndex = 2;
            label3.Text = "Service:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.FromArgb(64, 64, 64);
            label2.Location = new Point(23, 58);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(130, 19);
            label2.TabIndex = 1;
            label2.Text = "Phone Number:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.FromArgb(64, 64, 64);
            label1.Location = new Point(23, 23);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(138, 19);
            label1.TabIndex = 0;
            label1.Text = "Customer Name:";
            // 
            // tabPage2
            // 
            tabPage2.BackColor = Color.White;
            tabPage2.Controls.Add(listView1);
            tabPage2.Location = new Point(4, 44);
            tabPage2.Margin = new Padding(4, 3, 4, 3);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(4, 3, 4, 3);
            tabPage2.Size = new Size(925, 471);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "View Appointments";
            // 
            // listView1
            // 
            listView1.BackColor = Color.White;
            listView1.Dock = DockStyle.Fill;
            listView1.Font = new Font("Arial", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            listView1.ForeColor = Color.FromArgb(64, 64, 64);
            listView1.FullRowSelect = true;
            listView1.GridLines = true;
            listView1.Location = new Point(4, 3);
            listView1.Margin = new Padding(4, 3, 4, 3);
            listView1.Name = "listView1";
            listView1.Size = new Size(917, 465);
            listView1.TabIndex = 0;
            listView1.UseCompatibleStateImageBehavior = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(245, 245, 245);
            ClientSize = new Size(933, 519);
            Controls.Add(tabControl1);
            Margin = new Padding(4, 3, 4, 3);
            Name = "Form1";
            Text = "Salon Appointment System";
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabPage2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListView listView1;
    }
}