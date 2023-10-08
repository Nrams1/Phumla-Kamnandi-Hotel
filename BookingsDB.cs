using Project1.Business;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;


namespace Project1.Data

{
    internal class BookingsDB : PhumlaDB
    {
        #region Data member 

        Booking anBooking;
        Guest anGuest;
        Rooms anRoom;

        private string table1 = "Bookings";
        private string table2 = "Guest";
        private string table3 = "Rooms";

        private string sqlLocal1 = "SELECT * FROM Bookings";
        private string sqlLocal2 = "SELECT * FROM Guest";
        private string sqlLocal3 = "SELECT * FROM Rooms";

        private Collection<Booking> bookings;
        private Collection<Guest> guests;
        private Collection<Rooms> rooms;
        #endregion

        #region Constructor
        public BookingsDB():base()
        {
            bookings = new Collection<Booking>();
            guests = new Collection<Guest>();
            rooms = new Collection<Rooms>();

        
            FillDataSet(sqlLocal1, table1);

            Add2Guests(table1); 


            FillDataSet(sqlLocal2, table2);

            Add2Bookings(table2);


            FillDataSet(sqlLocal3, table3);

            Add2Rooms(table3);//this error should go away soon

        }


        #endregion
        #region Utility Methods
        public DataSet GetDataSet()
        {
            return dsMain;
        }

        #region ADD Methods
      
        //this is the add Collection for the guest

        private void Add2Guests(string table2)                                                                //The Add2Collection Method for Guests
        {
            DataRow myRow = null;

            anGuest = new Guest();                                                                            //Initialize new guest


            //we dont need to declare and initialize anything so this part doest have to be added

            foreach (DataRow myRow_loopVariable in dsMain.Tables[table2].Rows)
            {
                myRow = myRow_loopVariable;
                if (!(myRow.RowState == DataRowState.Deleted))//why id deleted
                {
                    anGuest = new Guest();//i think we should used a parametirized instantiation
                    {
                        //obtain each booking attrivute from each specific field in the row in the tablle
                        anGuest.GuestId = Convert.ToString(myRow["GuestId"]).TrimEnd();
                        anGuest.Name = Convert.ToString(myRow["Name"]).TrimEnd();
                        anGuest.Date = Convert.ToDateTime(myRow["Date"]);
                        anGuest.City = Convert.ToString(myRow["City"]).TrimEnd();
                        anGuest.PostalCode = Convert.ToInt32(myRow["PostalCode"]);
                        anGuest.Address = Convert.ToString(myRow["Address"]).TrimEnd();
                    }
                }
            }
            guests.Add(anGuest);

        }


        private void Add2Bookings(string table)                                                             //The ADD2Collection method for Bookings
        {
            DataRow myRow = null;

            //we dont need to declare and initialize anything so this part doest have to be added

            foreach (DataRow myRow_loopVariable in dsMain.Tables[table].Rows)
            {
                myRow = myRow_loopVariable;
                if (!(myRow.RowState == DataRowState.Deleted))//why id deleted
                {
                    anBooking = new Booking();                                                          //Initlize new booking
                    {
                        //obtain each booking attrivute form each specific field in the row in the tablle
                        anBooking.BookingId = Convert.ToString(myRow["Booking ID"]).TrimEnd();
                        anBooking.BookingDate = Convert.ToDateTime(myRow["Booking Date"]);
                        anBooking.TotalAmount = Convert.ToDecimal(myRow["Total Amount"]);
                        anBooking.IsConfirmed = Convert.ToBoolean(myRow["Confirmation"]);
                    };

                }
                bookings.Add(anBooking);
            }

        }

        private void Add2Rooms (string table)                                                             //The ADD2Collection method for Rooms
        {
            DataRow myRow = null;

            anRoom = new Rooms();


            //we dont need to declare and initialize anything so this part doest have to be added

            foreach (DataRow myRow_loopVariable in dsMain.Tables[table].Rows)
            {
                myRow = myRow_loopVariable;
                if (!(myRow.RowState == DataRowState.Deleted))//why id deleted
                {
                    anBooking = new Booking();
                    {
                        //obtain each booking attrivute form each specific field in the row in the tablle
                        anBooking.BookingId = Convert.ToString(myRow["Booking ID"]).TrimEnd();
                        anBooking.BookingDate = Convert.ToDateTime(myRow["Booking Date"]);
                        anBooking.TotalAmount = Convert.ToDecimal(myRow["Total Amount"]);
                        anBooking.IsConfirmed = Convert.ToBoolean(myRow["Confirmation"]);
                    };

                }
                rooms.Add(anRoom);
            }

        }
        #endregion

        #region Fill Row Methods
        private void FillRowBooking(DataRow aRow,Booking anBooking)
        {

                    aRow["BookingID"] = anBooking.BookingId;
                    aRow["BookingDate"] = anBooking.BookingDate;
                    aRow["TotalAmount"] = anBooking.TotalAmount;
                    aRow["Confirmation"] = anBooking.IsConfirmed;
        }
        

        private void FillRowGuest(DataRow aRow,Guest anGuest)//i assume this will add each booking attribute to each field
            {
                    aRow["GuestID"]=anGuest.GuestId;
                    aRow["Name"] = anGuest.Name;
                    aRow["Date"] = anGuest.Date;
                    aRow["City"] = anGuest.City;
                    aRow["PostalCode"] = anGuest.PostalCode;
                    aRow["Address"] = anGuest.Address;
    }
        private void FillRowRoom(DataRow aRow, Rooms anRoom)//i assume this will add each booking attribute to each field
        {
                    aRow["RoomID"] = anGuest.GuestId;
                    aRow["RoomNumber"] = anGuest.Name;
                    aRow["RoomType"] = anGuest.Date;
                    aRow["Roo"] = anGuest.City;
                    aRow["PostalCode"] = anGuest.PostalCode;
                    aRow["Address"] = anGuest.Address;
        }
        #endregion


        #endregion

        #region Database Operations CRUD


        public void DatasetChange(Object o)
        {
            DataRow aRow = null;
            string dataTable = table1;

            if (o is Guest)
            {
                dataTable = table1;
                FillRowGuest(aRow, anGuest);//we need ti implemet FillRow method 
                                    //add to the dataset

                // Rest of your code for handling Guest objects
            }
            else if (o is Booking)
            {
                dataTable = table2;
                FillRowBooking(aRow, anBooking);

                // Rest of your code for handling Bookings objects
            }

            else if (o is Rooms)
            {
                dataTable = table3;
                FillRowBooking(aRow, anBooking);
            }
           
        
           aRow = dsMain.Tables[dataTable].NewRow();

        
            dsMain.Tables[dataTable].Rows.Add(aRow);

        }

        #endregion
        
        #region Build Parameters, Create Commands and Update database

        #region We will have INSERT_Parameters fr the both the Bookings and the Guest class
        private void Build_INSERT_Parameters(Object o)
        {
            SqlParameter param = default(SqlParameter);

            if (o is Guest)
            {

                param = new SqlParameter("@GuestId",SqlDbType.TinyInt, 15, "GuestId");
                daMain.InsertCommand.Parameters.Add(param);

                param = new SqlParameter("@Name",SqlDbType.NText,20,"Name");
                daMain.InsertCommand.Parameters.Add(param);

                param = new SqlParameter("@Date", SqlDbType.NChar, 10, "Date");
                daMain.InsertCommand.Parameters.Add(param);

                param = new SqlParameter("@BookingID",SqlDbType.NText,20 ,"BookingID");
                daMain.InsertCommand.Parameters.Add(param);

                param = new SqlParameter("@City",SqlDbType.NChar,10,"City");
                daMain.InsertCommand.Parameters.Add(param);

                param = new SqlParameter("@PostalCode",SqlDbType.NChar,10,"PostalCode");
                daMain.InsertCommand.Parameters.Add(param);

                param = new SqlParameter("@Address", SqlDbType.NChar, 10, "Address");
                daMain.InsertCommand.Parameters.Add(param);

                // Rest of your code for handling Guest objects
            }
            else if (o is Booking)
            {


                param = new SqlParameter("@BookingID", SqlDbType.NChar, 10, "BookingID");
                daMain.InsertCommand.Parameters.Add(param);

                param = new SqlParameter("@BookingDate", SqlDbType.NChar, 10, "BookingDate");
                daMain.InsertCommand.Parameters.Add(param);

                param = new SqlParameter("@TotalAmount", SqlDbType.NChar, 10, "TotalAmount");
                daMain.InsertCommand.Parameters.Add(param);

                param = new SqlParameter("@Confirmation", SqlDbType.NChar, 10, "Confirmation");
                daMain.InsertCommand.Parameters.Add(param);


                // Rest of your code for handling Bookings objects
            }

            else if (o is Rooms)
            {

                param = new SqlParameter("@RoomID", SqlDbType.TinyInt, 10, "RoomID");
                daMain.InsertCommand.Parameters.Add(param);

                param = new SqlParameter("@RoomNumber", SqlDbType.NChar, 10, "RoomNumber");
                daMain.InsertCommand.Parameters.Add(param);

                param = new SqlParameter("@RoomType", SqlDbType.NChar, 10, "RoomType");
                daMain.InsertCommand.Parameters.Add(param);

                param =new SqlParameter("RoomRate", SqlDbType.NChar, 10, "RoomRate");
                daMain.InsertCommand.Parameters.Add(param);

                param = new SqlParameter("@IsAvailable", SqlDbType.Bit, 10, "IsAvailable");
                daMain.InsertCommand.Parameters.Add(param);

                // Rest of your code for handling Bookings objects

            }
        }

        #endregion


        private void Create_INSERT_Command(Object o)
        {
            if (o is Guest)
            {

                daMain.InsertCommand = new SqlCommand("INSERT into GuestId (Name, Date, BookingID, City, PostalCode,Address) VALUES (@Name, @Date, @BookingID, @City, @PostalCode,@Address)", cnMain);
            }
            else if (o is Booking)
            {
                daMain.InsertCommand = new SqlCommand("INSERT into Bookings (BookingID, BookingDate, TotalAmount, Confirmation) VALUES(@BookingID,@BookingDate,@TotalAmount,@Confirmation)", cnMain);
            }

            else if (o is Rooms)
            {
                daMain.InsertCommand = new SqlCommand("INSERT into Bookings (RoomID, RoomNumber,RoomType,RoomRate,IsAvailable) VALUES (@RoomID, @RoomNumber, @RoomType, @RoomRate, @IsAvailable)", cnMain);
            }

                Build_INSERT_Parameters(o);   
        }

            public bool UpdateDataSource(Object o)
        {
            bool success = true;
            Create_INSERT_Command(o);
            if (o is Guest) {
                success = UpdateDataSource(sqlLocal1, table1);
            
            }

            else if (o is Booking) {
                success = UpdateDataSource(sqlLocal2, table2);
            }

            else if (o is Rooms)
            {
                success = UpdateDataSource(sqlLocal3, table3);
            }

            return success;

            }
        }

        #endregion


    }

