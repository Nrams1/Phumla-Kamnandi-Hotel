namespace Phumla_Kamnandi_Hotel.Presentation
{
    partial class MakeBooking
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
            groupBox1 = new GroupBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            dateTimePicker1 = new DateTimePicker();
            label6 = new Label();
            comboBox2 = new ComboBox();
            domainUpDown1 = new DomainUpDown();
            comboBox1 = new ComboBox();
            groupBox2 = new GroupBox();
            button1 = new Button();
            label7 = new Label();
            button2 = new Button();
            button3 = new Button();
            label8 = new Label();
            label9 = new Label();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(button3);
            groupBox1.Controls.Add(button2);
            groupBox1.Controls.Add(groupBox2);
            groupBox1.Controls.Add(domainUpDown1);
            groupBox1.Controls.Add(comboBox1);
            groupBox1.Controls.Add(comboBox2);
            groupBox1.Controls.Add(dateTimePicker1);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1192, 851);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Booking Details";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(50, 179);
            label1.Name = "label1";
            label1.Size = new Size(49, 25);
            label1.TabIndex = 0;
            label1.Text = "Date";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(50, 112);
            label2.Name = "label2";
            label2.Size = new Size(101, 25);
            label2.TabIndex = 0;
            label2.Text = "Booking ID";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(50, 232);
            label3.Name = "label3";
            label3.Size = new Size(68, 25);
            label3.TabIndex = 0;
            label3.Text = "Rooms";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(50, 294);
            label4.Name = "label4";
            label4.Size = new Size(87, 25);
            label4.TabIndex = 0;
            label4.Text = "Stay Type";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(50, 371);
            label5.Name = "label5";
            label5.Size = new Size(131, 25);
            label5.TabIndex = 0;
            label5.Text = "Booking Status";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(365, 179);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(348, 31);
            dateTimePicker1.TabIndex = 1;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(376, 112);
            label6.Name = "label6";
            label6.Size = new Size(38, 25);
            label6.TabIndex = 0;
            label6.Text = "Id0";
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(365, 291);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(348, 33);
            comboBox2.TabIndex = 2;
            // 
            // domainUpDown1
            // 
            domainUpDown1.Location = new Point(365, 230);
            domainUpDown1.Name = "domainUpDown1";
            domainUpDown1.Size = new Size(348, 31);
            domainUpDown1.TabIndex = 3;
            domainUpDown1.Text = "0";
            domainUpDown1.SelectedItemChanged += domainUpDown1_SelectedItemChanged;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(365, 363);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(348, 33);
            comboBox1.TabIndex = 2;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(button1);
            groupBox2.Location = new Point(113, 446);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(723, 319);
            groupBox2.TabIndex = 4;
            groupBox2.TabStop = false;
            groupBox2.Text = "Availability";
            // 
            // button1
            // 
            button1.Location = new Point(429, 237);
            button1.Name = "button1";
            button1.Size = new Size(235, 39);
            button1.TabIndex = 0;
            button1.Text = "Check Availability";
            button1.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point);
            label7.Location = new Point(35, 120);
            label7.Name = "label7";
            label7.Size = new Size(618, 25);
            label7.TabIndex = 1;
            label7.Text = "Click Check Availability to show room types and number of available rooms  ";
            label7.Click += label7_Click;
            // 
            // button2
            // 
            button2.Location = new Point(957, 781);
            button2.Name = "button2";
            button2.Size = new Size(136, 41);
            button2.TabIndex = 5;
            button2.Text = "Next";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(50, 790);
            button3.Name = "button3";
            button3.Size = new Size(126, 41);
            button3.TabIndex = 5;
            button3.Text = "Back";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button2_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(50, 58);
            label8.Name = "label8";
            label8.Size = new Size(147, 25);
            label8.TabIndex = 6;
            label8.Text = "Customer Details";
            label8.Click += label8_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(375, 52);
            label9.Name = "label9";
            label9.Size = new Size(102, 25);
            label9.TabIndex = 7;
            label9.Text = "customerId";
            // 
            // MakeBooking
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1238, 875);
            Controls.Add(groupBox1);
            Name = "MakeBooking";
            Text = "MakeBooking";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label label2;
        private Label label3;
        private Label label1;
        private DateTimePicker dateTimePicker1;
        private Label label5;
        private Label label4;
        private DomainUpDown domainUpDown1;
        private ComboBox comboBox2;
        private Label label6;
        private GroupBox groupBox2;
        private Label label7;
        private Button button1;
        private ComboBox comboBox1;
        private Button button2;
        private Button button3;
        private Label label8;
        private Label label9;
    }
}