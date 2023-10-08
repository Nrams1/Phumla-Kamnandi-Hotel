using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;


namespace Phumla_Kamnandi_Hotel.Data
{
    public class PhumlaDB
    {

        #region Variable declaration
        // The connection string from Settings
        private string strConn = Settings.Default.OrderingDBConnectionString; 
        SqlDataAdapter cnMain = new SqlDataAdapter;
         DataSet dsMain;
        SqlDataAdapter daMain;
        #endregion

        #region Constructor
        public PhumlaDB()
        {
            try
            {
                //Open a connection & create a new dataset object
                cnMain = new SqlConnection(strConn);
                dsMain = new DataSet();
            }
            catch (SystemException e)
            {
                System.Windows.Forms.MessageBox.Show(e.Message, "Error");
                return;
            }
        }

        #endregion



        #region Update the DataSet
        public void FillDataSet(string aSQLstring, string aTable)
        {
            // Fills dataset fresh from the db for a specific table and with a specific Query
            try
            {
                daMain = new SqlDataAdapter(aSQLstring, cnMain);
                cnMain.Open();
                dsMain.Clear();
                daMain.Fill(dsMain, aTable);
                cnMain.Close();
            }
            catch (Exception errObj)
            {
                System.Windows.Forms.MessageBox.Show(errObj.Message + "  " + errObj.StackTrace);
            }
        }
        #endregion

        #region Update the data source
        protected bool UpdateDataSource(string sqlLocal, string table)
        {
            bool success;
            try
            {
                // Open the connection
                cnMain.Open();
                // Update the database table via the data adapter
                daMain.Update(dsMain, table);
                // Close the connection
                cnMain.Close();
                // Refresh the dataset
                FillDataSet(sqlLocal, table);
                success = true;
            }
            catch (Exception errObj)
            {
                System.Windows.Forms.MessageBox.Show(errObj.Message + "  " + errObj.StackTrace);
                success = false;
            }
            finally
            {
                // Optionally, you can include any cleanup code here
            }
            return success;
        }
    }
}
