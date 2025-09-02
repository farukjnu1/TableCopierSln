using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TableCopier
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            bool isComplete = false;
            string dataSourceFrom = "Data Source=" + tbServerFrom.Text.Trim() + ";";
            string initialCatalogFrom = "Initial Catalog=" + tbDatabaseFrom.Text.Trim() + ";";
            string userIdFrom = "User ID=" + tbUserIdFrom.Text.Trim() + ";";
            string passwordFrom = "Password=" + tbPasswordFrom.Text.Trim() + ";";
            string connStrFrom = @"" + dataSourceFrom + "" + initialCatalogFrom + "" + userIdFrom + ";" + passwordFrom + "";

            // check Track_Tables where IsComplete = 0
            // insert into select
            //Create a connection
            SqlConnection conFrom1 = new SqlConnection(connStrFrom);
            conFrom1.Open();

            string sql1 = "SELECT [Track_Table],[IsComplete] FROM [GPSDB_OLD].[dbo].[Track_Tables]  WHERE Track_Table = '"+tbTableFrom.Text.Trim()+"' AND IsComplete = 1";
            try
            {
                //Create the SqlCommand object, specifying the transaction through
                //the constructor (along with the SQL string and SqlConnection)
                SqlCommand myCommand1 = new SqlCommand(sql1, conFrom1);
                SqlDataReader rd = myCommand1.ExecuteReader();
                rd.Read();
                if (rd.HasRows)
                {
                    isComplete = true;
                }
            }
            catch (Exception ex)
            {
                //Something went wrong, so rollback the transaction
                isComplete = true;
                MessageBox.Show(ex.Message);
                //throw 		//Bubble up the exception
            }
            finally
            {
                conFrom1.Close();	//Finally, close the connection
            }

            // insert into select
            //Create a connection
            if (!isComplete)
            {
                SqlConnection conFrom = new SqlConnection(connStrFrom);
                conFrom.Open();

                //Start the transaction
                SqlTransaction myTrans;
                myTrans = conFrom.BeginTransaction();
                string fromDate = Convert.ToDateTime(dtPickerFrom.Text.Trim()).ToString("yyyy-MM-dd");
                fromDate = fromDate + " 00:00:01";
                string sql = "INSERT INTO [GPSDB].[dbo].[" + tbTableFrom.Text.Trim() + "] ([strTEID]"
          + ",[nTime]"
          + ",[dbLon]"
          + ",[dbLat]"
          + ",[nDirection]"
          + ",[nSpeed]"
          + ",[nGSMSignal]"
          + ",[nGPSSignal]"
          + ",[nFuel]"
          + ",[nMileage]"
          + ",[nTemp]"
          + ",[nCarState]"
          + ",[nTEState]"
          + ",[nAlarmState]) "
                + "SELECT [strTEID]"
          + ",[nTime]"
          + ",[dbLon]"
          + ",[dbLat]"
          + ",[nDirection]"
          + ",[nSpeed]"
          + ",[nGSMSignal]"
          + ",[nGPSSignal]"
          + ",[nFuel]"
          + ",[nMileage]"
          + ",[nTemp]"
          + ",[nCarState]"
          + ",[nTEState]"
          + ",[nAlarmState] FROM [GPSDB_OLD].[dbo].[" + tbTableFrom.Text.Trim() + "]"
          + " WHERE nTime BETWEEN DATEDIFF (SECOND, '1970-01-01 06:00:00', '" + fromDate + "') AND DATEDIFF(SECOND, '1970-01-01 06:00:00', GETDATE());";
                try
                {
                    //Create the SqlCommand object, specifying the transaction through
                    //the constructor (along with the SQL string and SqlConnection)
                    SqlCommand myCommand = new SqlCommand(sql, conFrom);
                    myCommand.Transaction = myTrans;
                    myCommand.ExecuteNonQuery();

                    myCommand = new SqlCommand("UPDATE [dbo].[Track_Tables] SET [IsComplete] = '1' WHERE [Track_Table] = '" + tbTableFrom.Text.Trim() + "'", conFrom);
                    myCommand.Transaction = myTrans;
                    myCommand.ExecuteNonQuery();

                    //If we reach here, all command succeeded, so commit the transaction
                    myTrans.Commit();
                    MessageBox.Show("Mission completed successfully!");
                }
                catch (Exception ex)
                {
                    //Something went wrong, so rollback the transaction
                    myTrans.Rollback();
                    MessageBox.Show(ex.Message);
                    //throw 		//Bubble up the exception
                }
                finally
                {
                    conFrom.Close();	//Finally, close the connection
                }
            }
            else
            {
                MessageBox.Show("Already saved in this table!");
            }
        }
    }
}
