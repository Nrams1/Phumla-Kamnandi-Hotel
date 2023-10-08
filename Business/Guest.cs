using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phumla_Kamnandi_Hotel.Business
{
    public class Guest



    {

        #region Data Members 
        private String customerId;
        private String name;
        private String date;
        private String phone;
        private String address;
        private String city;
        private String postalCode;
        private int generateID = 10000;

        #endregion

        #region Property Methods
        // Properties to store guest information
        public String CustomerID {
                get { return customerId; }
            set { customerId = value; }

           }
        public String Name
        {
            get { return name; }
            set { name = value; }

        }

        public String Date
        {
            get { return date; }
            set { date = value; }

        }
        public String Phone
        {
            get { return phone; }
            set { phone = value; }

        }

        public String Address
        {
            get { return address; }
            set { address= value; }

        }

        public String City
        {
            get { return city; }
            set { city = value; }

        }

        public String PostalCode
        {
            get { return postalCode; }
            set { postalCode = value; }

        }

        #endregion


        #region Constructor
        // Default constutor , to create a Guest object
        public Guest(){
            generateID++;
            customerId = generateID + "";
        }
        #endregion
     

        // Display guest information
       /* public void DisplayGuestInfo()
        {
            Console.WriteLine("Guest Name: " + FirstName + " " + LastName);
            Console.WriteLine("Email: " + Email);
            Console.WriteLine("Phone Number: " + PhoneNumber);
            Console.WriteLine("Credit Card Number: " + CreditCardNumber);

            // Display all bookings made by the guest
            Console.WriteLine("Bookings:");
            foreach (var booking in Bookings)
            {
                booking.DisplayBookingInfo();
            }



        }*/

   
    }
}
