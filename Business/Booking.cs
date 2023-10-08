using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phumla_Kamnandi_Hotel.Business
{
    internal class Booking
    {
        // Properties to store booking information
        public int BookingId { get; set; } // Unique identifier for the booking
        public DateTime BookingDate { get; set; } // Date when the booking was made
        public decimal TotalAmount { get; set; } // Total amount for the booking
        public bool IsConfirmed { get; set; } // Indicates whether the booking is confirmed
        public string Id { get; internal set; }

        // Constructor to initialize booking properties
        public Booking(int bookingId, DateTime bookingDate, decimal totalAmount, bool isConfirmed)
        {
            BookingId = bookingId;
            BookingDate = bookingDate;
            TotalAmount = totalAmount;//Display total accomadation cost ,additional charges,taxes and fees , discounts or promotios ,deposits and payments
            IsConfirmed = isConfirmed;
        }

        // Display booking information
        public void DisplayBookingInfo()
        {
            Console.WriteLine("Booking ID: " + BookingId);
            Console.WriteLine("Booking Date: " + BookingDate.ToShortDateString());
            Console.WriteLine("Total Amount: " + TotalAmount.ToString("C"));
            Console.WriteLine("Is Confirmed: " + (IsConfirmed ? "Yes" : "No"));
        }
    }
}
