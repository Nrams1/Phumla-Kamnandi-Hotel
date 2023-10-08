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
    public partial class AddGuest : Form
    {
       Guest guest = new Guest();
        public AddGuest()
        {
            InitializeComponent();
            
            id.Text = guest.CustomerID;

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            LandingPage landingPage = new LandingPage();
            landingPage.Show();
            Hide();
        }

        private void bookbtn_Click(object sender, EventArgs e)
        {
            MakeBooking newBooking = new MakeBooking();
            newBooking.Show();
            Hide();
        }
    }
}
