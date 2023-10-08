namespace Phumla_Kamnandi_Hotel.Presentation
{
    partial class LandingPage
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
            components = new System.ComponentModel.Container();
            menuStrip1 = new MenuStrip();
            homeToolStripMenuItem = new ToolStripMenuItem();
            roomsToolStripMenuItem = new ToolStripMenuItem();
            manageBookingsToolStripMenuItem = new ToolStripMenuItem();
            ratesToolStripMenuItem = new ToolStripMenuItem();
            aboutToolStripMenuItem = new ToolStripMenuItem();
            groupBox1 = new GroupBox();
            guestList = new ListView();
            addGuestbtn = new Button();
            bindingSource1 = new BindingSource(components);
            menuStrip1.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            menuStrip1.ImageScalingSize = new Size(24, 24);
            menuStrip1.Items.AddRange(new ToolStripItem[] { homeToolStripMenuItem, roomsToolStripMenuItem, manageBookingsToolStripMenuItem, ratesToolStripMenuItem, aboutToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1735, 33);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // homeToolStripMenuItem
            // 
            homeToolStripMenuItem.Name = "homeToolStripMenuItem";
            homeToolStripMenuItem.Size = new Size(78, 29);
            homeToolStripMenuItem.Text = "Home";
            // 
            // roomsToolStripMenuItem
            // 
            roomsToolStripMenuItem.Name = "roomsToolStripMenuItem";
            roomsToolStripMenuItem.Size = new Size(85, 29);
            roomsToolStripMenuItem.Text = "Rooms";
            // 
            // manageBookingsToolStripMenuItem
            // 
            manageBookingsToolStripMenuItem.Name = "manageBookingsToolStripMenuItem";
            manageBookingsToolStripMenuItem.Size = new Size(177, 29);
            manageBookingsToolStripMenuItem.Text = "Manage Bookings";
            manageBookingsToolStripMenuItem.Click += manageBookingsToolStripMenuItem_Click;
            // 
            // ratesToolStripMenuItem
            // 
            ratesToolStripMenuItem.Name = "ratesToolStripMenuItem";
            ratesToolStripMenuItem.Size = new Size(73, 29);
            ratesToolStripMenuItem.Text = "Rates";
            // 
            // aboutToolStripMenuItem
            // 
            aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            aboutToolStripMenuItem.Size = new Size(80, 29);
            aboutToolStripMenuItem.Text = "About";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(guestList);
            groupBox1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox1.Location = new Point(24, 107);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1699, 720);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "List of Guests";
            // 
            // guestList
            // 
            guestList.Location = new Point(21, 30);
            guestList.Name = "guestList";
            guestList.Size = new Size(1659, 650);
            guestList.TabIndex = 0;
            guestList.UseCompatibleStateImageBehavior = false;
            // 
            // addGuestbtn
            // 
            addGuestbtn.Location = new Point(45, 55);
            addGuestbtn.Name = "addGuestbtn";
            addGuestbtn.Size = new Size(112, 34);
            addGuestbtn.TabIndex = 3;
            addGuestbtn.Text = "Add Guest";
            addGuestbtn.UseVisualStyleBackColor = true;
            addGuestbtn.Click += addGuestbtn_Click;
            // 
            // LandingPage
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1735, 881);
            Controls.Add(addGuestbtn);
            Controls.Add(groupBox1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "LandingPage";
            Text = "LandingPage";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)bindingSource1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem homeToolStripMenuItem;
        private ToolStripMenuItem roomsToolStripMenuItem;
        private ToolStripMenuItem manageBookingsToolStripMenuItem;
        private GroupBox groupBox1;
        private ListView guestList;
        private Button addGuestbtn;
        private ToolStripMenuItem ratesToolStripMenuItem;
        private ToolStripMenuItem aboutToolStripMenuItem;
        private BindingSource bindingSource1;
    }
}