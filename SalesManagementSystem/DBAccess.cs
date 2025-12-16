using System;
using System.Data;
using System.Data.SQLite;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesManagementSystem
{
    public static class DBAccess
    {
        private static string connectionString = "Data Source=SalesDB.db;Version=3;";

        public static DataTable GetTable(string sql)
        {   
            try
            {
                using(SQLiteConnection conn = new SQLiteConnection(connectionString))
                {
                    conn.Open();
                    DataTable dt = new DataTable();
                    SQLiteDataAdapter da = new SQLiteDataAdapter(sql, conn);
                    da.Fill(dt);
                    return dt;
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Məlumat oxunarkən xəta: " + ex.Message);
                return null;
            }
        }

        public static void Execute(string sql)
        {
            try
            {
                using(SQLiteConnection conn = new SQLiteConnection(connectionString))
                {
                    conn.Open();
                    SQLiteCommand cmd = new SQLiteCommand(sql, conn);
                    cmd.ExecuteNonQuery();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Əməliyyat zamanı xəta: " + ex.Message);
            }
        }

        public static int ExecuteReturnId(string sql)
        {
            try
            {
                using(SQLiteConnection conn = new SQLiteConnection(connectionString))
                {
                    conn.Open();
                    SQLiteCommand cmd = new SQLiteCommand(sql, conn);
                    cmd.ExecuteNonQuery();

                    cmd.CommandText = "Select last_insert_rowid();";
                    return Convert.ToInt32(cmd.ExecuteScalar());
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("ID alınarkən xəta: " + ex.Message);
                return -1;
            }
        }
    }

}
