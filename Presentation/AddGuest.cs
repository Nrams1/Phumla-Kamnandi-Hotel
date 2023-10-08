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

        #region Data Members
        Guest guest = new Guest();

        #endregion

        #region Constructor
        public AddGuest()
        {
            InitializeComponent();

            id.Text = guest.CustomerID;

        }
        #endregion


        #region Methods
        private void label8_Click(object sender, EventArgs e)
        {

        }


        // Bcak button
        private void button1_Click(object sender, EventArgs e)
        {
            LandingPage landingPage = new LandingPage();
            landingPage.Show();
            Hide();
        }

        //Book button
        private void bookbtn_Click(object sender, EventArgs e)
        {
            bool b = isInputEmpty();
            int numericValue;
            bool isNumber = int.TryParse(phoneText.Text, out numericValue);

            if(b || isNumber)
            {
                MessageBox.Show( " Invalid data. Please re-enter/");
            }
            else
            {

                populate();
                MessageBox.Show( guest.Name+" is successfully added as a Guest" );
                MakeBooking newBooking = new MakeBooking();
                newBooking.Show();
                Hide();

            }
           
        }

        // Check inputs are empty
        private bool isInputEmpty()
        {
            bool check = false;

            bool b1 = nameText.Text.Equals("");
            bool b2 = addressText.Text.Equals("");
            bool b3 = cityText.Text.Equals("");
            bool b4 = pcText.Text.Equals("");
            bool b5 = phoneText.Text.Equals("");

            if (b1 || b2 || b3 || b4 || b5 )
            {

                check = true;

            }

            return check;


        }

        private void populate()
        {

            guest.Name = nameText.Text.Trim();
            guest.Address = addressText.Text.Trim();
            guest.City = cityText.Text.Trim();
            guest.PostalCode = pcText.Text.Trim();
            guest.Date = phoneText.Text.Trim();
            guest.Phone = phoneText.Text.Trim();

        }



        #endregion


    }
}
