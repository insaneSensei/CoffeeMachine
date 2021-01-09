using System.IO;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Windows.Forms;
using System;

namespace Coffee
{
    class Water
    {

      
        public static void Change(float amount)
        {
            StreamReader reader;
            StreamWriter writer;
            string path = @"water.txt";
            float waterAmount;
            using (reader = new StreamReader(path))
            {
                waterAmount = float.Parse(reader.ReadLine());

            }
            using (writer = new StreamWriter(path))
            {
                writer.Write((waterAmount - amount).ToString());
            }
        }
        public static void UpdateDB(SqlDecimal amount)
       
        {
            DirectoryInfo databasePath = new DirectoryInfo("db.mdf");

            string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename='"+databasePath.FullName+"';Integrated Security=True";
            SqlConnection connection;
            SqlCommand command;
            
            
            using (connection = new SqlConnection(connectionString))
            {
                try
                {
                connection.Open();
                string query = @"Update [Table] Set Water=Water+'" + amount + "'";
                command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("Amount", amount);
                command.ExecuteNonQuery();

                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
        }
    }
}
