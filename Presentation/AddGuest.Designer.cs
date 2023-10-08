namespace Phumla_Kamnandi_Hotel.Presentation
{
    partial class AddGuest
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
            id = new Label();
            bookbtn = new Button();
            backbtn = new Button();
            dateTimePicker1 = new DateTimePicker();
            textBox2 = new TextBox();
            textBox5 = new TextBox();
            textBox4 = new TextBox();
            textBox3 = new TextBox();
            textBox1 = new TextBox();
            label8 = new Label();
            phone = new Label();
            label7 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(id);
            groupBox1.Controls.Add(bookbtn);
            groupBox1.Controls.Add(backbtn);
            groupBox1.Controls.Add(dateTimePicker1);
            groupBox1.Controls.Add(textBox2);
            groupBox1.Controls.Add(textBox5);
            groupBox1.Controls.Add(textBox4);
            groupBox1.Controls.Add(textBox3);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(phone);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(823, 643);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Guest Details";
            // 
            // id
            // 
            id.AutoSize = true;
            id.Location = new Point(277, 76);
            id.Name = "id";
            id.Size = new Size(30, 25);
            id.TabIndex = 4;
            id.Text = "ID";
            // 
            // bookbtn
            // 
            bookbtn.Location = new Point(628, 569);
            bookbtn.Name = "bookbtn";
            bookbtn.Size = new Size(112, 34);
            bookbtn.TabIndex = 3;
            bookbtn.Text = "Book";
            bookbtn.UseVisualStyleBackColor = true;
            bookbtn.Click += bookbtn_Click;
            // 
            // backbtn
            // 
            backbtn.Location = new Point(45, 569);
            backbtn.Name = "backbtn";
            backbtn.Size = new Size(112, 34);
            backbtn.TabIndex = 3;
            backbtn.Text = "Back";
            backbtn.UseVisualStyleBackColor = true;
            backbtn.Click += button1_Click;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(277, 187);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(390, 31);
            dateTimePicker1.TabIndex = 2;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(277, 419);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(390, 31);
            textBox2.TabIndex = 1;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(277, 353);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(390, 31);
            textBox5.TabIndex = 1;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(277, 305);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(390, 31);
            textBox4.TabIndex = 1;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(277, 253);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(390, 31);
            textBox3.TabIndex = 1;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(277, 129);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(390, 31);
            textBox1.TabIndex = 1;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(45, 256);
            label8.Name = "label8";
            label8.Size = new Size(77, 25);
            label8.TabIndex = 0;
            label8.Text = "Address";
            label8.Click += label8_Click;
            // 
            // phone
            // 
            phone.AutoSize = true;
            phone.Location = new Point(45, 419);
            phone.Name = "phone";
            phone.Size = new Size(62, 25);
            phone.TabIndex = 0;
            phone.Text = "Phone";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(45, 356);
            label7.Name = "label7";
            label7.Size = new Size(103, 25);
            label7.TabIndex = 0;
            label7.Text = "Postal code";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(45, 305);
            label4.Name = "label4";
            label4.Size = new Size(42, 25);
            label4.TabIndex = 0;
            label4.Text = "City";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(45, 192);
            label3.Name = "label3";
            label3.Size = new Size(49, 25);
            label3.TabIndex = 0;
            label3.Text = "Date";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(45, 135);
            label2.Name = "label2";
            label2.Size = new Size(59, 25);
            label2.TabIndex = 0;
            label2.Text = "Name";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(45, 76);
            label1.Name = "label1";
            label1.Size = new Size(107, 25);
            label1.TabIndex = 0;
            label1.Text = "CustomerID";
            // 
            // AddGuest
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(850, 674);
            Controls.Add(groupBox1);
            Name = "AddGuest";
            Text = "AddGuest";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label label8;
        private Label label7;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button bookbtn;
        private Button backbtn;
        private DateTimePicker dateTimePicker1;
        private TextBox textBox5;
        private TextBox textBox4;
        private TextBox textBox3;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label phone;
        private Label id;
    }
}