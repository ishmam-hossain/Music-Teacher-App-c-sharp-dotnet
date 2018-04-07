using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlServerCe;
using System.Windows.Forms;
using System.Data;

namespace MusicTeacher
{
    class DatabaseManager
    {
        public static void processQuery(string qryString) {
            // open a connection
            SqlCeConnection conn = new SqlCeConnection(@"Data Source=|DataDirectory|\QuizDB.sdf");
            conn.Open();

            // execute query
            try
            {
                new SqlCeCommand(qryString, conn).ExecuteNonQuery();
            }
            catch (Exception exep)
            {
                MessageBox.Show(exep.Message);
            }

            // closing connection
            conn.Close();
            conn = null;
        }

        public static DataSet resultQuery(string qryStr)
        {
            // open a connection
            SqlCeConnection conn = new SqlCeConnection(@"Data Source=|DataDirectory|\QuizDB.sdf");
            conn.Open();

            // prepare command
            SqlCeCommand command = new SqlCeCommand(qryStr, conn);

            // run command and get dataset
            DataSet dataSet = new DataSet();
            try
            {
                SqlCeDataAdapter adapter = new SqlCeDataAdapter(command);
                adapter.Fill(dataSet);
            }
            catch (Exception exep)
            {
                MessageBox.Show(exep.Message);
            }

            // closing connection
            conn.Close();
            conn = null;

            // return the dataset
            return dataSet;
        }
    }
}
