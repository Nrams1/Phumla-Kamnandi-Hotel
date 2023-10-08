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
            dateTimePicker = new DateTimePicker();
            phoneText = new TextBox();
            pcText = new TextBox();
            cityText = new TextBox();
            addressText = new TextBox();
            nameText = new TextBox();
            addressLabel = new Label();
            phoneLabel = new Label();
            pcLabel = new Label();
            cityLabel = new Label();
            dateLabel = new Label();
            nameLabel = new Label();
            label1 = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(id);
            groupBox1.Controls.Add(bookbtn);
            groupBox1.Controls.Add(backbtn);
            groupBox1.Controls.Add(dateTimePicker);
            groupBox1.Controls.Add(phoneText);
            groupBox1.Controls.Add(pcText);
            groupBox1.Controls.Add(cityText);
            groupBox1.Controls.Add(addressText);
            groupBox1.Controls.Add(nameText);
            groupBox1.Controls.Add(addressLabel);
            groupBox1.Controls.Add(phoneLabel);
            groupBox1.Controls.Add(pcLabel);
            groupBox1.Controls.Add(cityLabel);
            groupBox1.Controls.Add(dateLabel);
            groupBox1.Controls.Add(nameLabel);
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
            // dateTimePicker
            // 
            dateTimePicker.Location = new Point(277, 187);
            dateTimePicker.Name = "dateTimePicker";
            dateTimePicker.Size = new Size(390, 31);
            dateTimePicker.TabIndex = 2;
            // 
            // phoneText
            // 
            phoneText.Location = new Point(277, 419);
            phoneText.Name = "phoneText";
            phoneText.Size = new Size(390, 31);
            phoneText.TabIndex = 1;
            // 
            // pcText
            // 
            pcText.Location = new Point(277, 353);
            pcText.Name = "pcText";
            pcText.Size = new Size(390, 31);
            pcText.TabIndex = 1;
            // 
            // cityText
            // 
            cityText.Location = new Point(277, 305);
            cityText.Name = "cityText";
            cityText.Size = new Size(390, 31);
            cityText.TabIndex = 1;
            // 
            // addressText
            // 
            addressText.Location = new Point(277, 253);
            addressText.Name = "addressText";
            addressText.Size = new Size(390, 31);
            addressText.TabIndex = 1;
            // 
            // nameText
            // 
            nameText.Location = new Point(277, 129);
            nameText.Name = "nameText";
            nameText.Size = new Size(390, 31);
            nameText.TabIndex = 1;
            // 
            // addressLabel
            // 
            addressLabel.AutoSize = true;
            addressLabel.Location = new Point(45, 256);
            addressLabel.Name = "addressLabel";
            addressLabel.Size = new Size(77, 25);
            addressLabel.TabIndex = 0;
            addressLabel.Text = "Address";
            addressLabel.Click += label8_Click;
            // 
            // phoneLabel
            // 
            phoneLabel.AutoSize = true;
            phoneLabel.Location = new Point(45, 419);
            phoneLabel.Name = "phoneLabel";
            phoneLabel.Size = new Size(62, 25);
            phoneLabel.TabIndex = 0;
            phoneLabel.Text = "Phone";
            // 
            // pcLabel
            // 
            pcLabel.AutoSize = true;
            pcLabel.Location = new Point(45, 356);
            pcLabel.Name = "pcLabel";
            pcLabel.Size = new Size(103, 25);
            pcLabel.TabIndex = 0;
            pcLabel.Text = "Postal code";
            // 
            // cityLabel
            // 
            cityLabel.AutoSize = true;
            cityLabel.Location = new Point(45, 305);
            cityLabel.Name = "cityLabel";
            cityLabel.Size = new Size(42, 25);
            cityLabel.TabIndex = 0;
            cityLabel.Text = "City";
            // 
            // dateLabel
            // 
            dateLabel.AutoSize = true;
            dateLabel.Location = new Point(45, 192);
            dateLabel.Name = "dateLabel";
            dateLabel.Size = new Size(49, 25);
            dateLabel.TabIndex = 0;
            dateLabel.Text = "Date";
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new Point(45, 135);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new Size(59, 25);
            nameLabel.TabIndex = 0;
            nameLabel.Text = "Name";
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
        private Label addressLabel;
        private Label pcLabel;
        private Label cityLabel;
        private Label dateLabel;
        private Label nameLabel;
        private Label label1;
        private Button bookbtn;
        private Button backbtn;
        private DateTimePicker dateTimePicker;
        private TextBox pcText;
        private TextBox cityText;
        private TextBox addressText;
        private TextBox nameText;
        private TextBox phoneText;
        private Label phoneLabel;
        private Label id;
    }
}