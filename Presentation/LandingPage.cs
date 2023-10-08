using Phumla_Kamnandi_Hotel.Business;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Phumla_Kamnandi_Hotel.Presentation
{
    public partial class LandingPage : Form
    {
        Guest guest;
        public LandingPage()
        {
            InitializeComponent();
        }

        private void addGuestbtn_Click(object sender, EventArgs e)
        {
            AddGuest newGuest = new AddGuest();
            newGuest.Show();
            Hide();

  
      
        }

        private void manageBookingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }
    }
}
