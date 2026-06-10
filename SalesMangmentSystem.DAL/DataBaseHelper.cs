using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesMangmentSystem.DAL
{
    public static class DataBaseHelper
    {
        // تعريف الـ Connection String فقط كـ string ثابت
        private const string ConnectionString = "Data Source=.;Initial Catalog=SSTOREONLINE;Integrated Security=True;TrustServerCertificate=True;Encrypt=False";

        // 1- Get Data (Disconnected Mode)
        public static DataTable ExcuteSelect(string query)
        {
            // إنشاء Connection جديد لكل عملية يضمن إنه يتقفل تلقائياً بعد الـ using
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                using (SqlCommand sqlCommand = new SqlCommand(query, connection))
                {
                    using (SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand))
                    {
                        DataTable dataTable = new DataTable();
                        sqlDataAdapter.Fill(dataTable); // الـ Fill بيفتح ويقفل الـ connection لوحده
                        return dataTable;
                    }
                }
            }
        }

        // 2- Execute DML (Connected Mode)
        public static bool ExcuteDML(string command)
        {
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                using (SqlCommand sqlCommand = new SqlCommand(command, connection))
                {
                    connection.Open(); // كدة هيفتح Connection جديد خاص بالعملية دي بس
                    int rowsAffected = sqlCommand.ExecuteNonQuery();
                    return rowsAffected > 0;
                } // هنا الـ Connection بيتقفل أوتوماتيكياً بفضل الـ using
            }
        }

        public static bool ExcuteTransaction(List<string> commands)
        {
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                connection.Open();
                SqlTransaction transaction = connection.BeginTransaction();
                try
                {
                    // اجمع كل الأوامر في batch واحد بدل تنفيذ كل أمر لوحده
                    string batch = string.Join(Environment.NewLine, commands);

                    using (SqlCommand cmd = new SqlCommand(batch, connection, transaction))
                    {
                        cmd.ExecuteNonQuery();
                    }

                    transaction.Commit();
                    return true;
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    System.Diagnostics.Debug.WriteLine(ex.Message); 
                    return false;
                }
            }
        }
    }
}
