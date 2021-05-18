using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySqlConnector;


namespace IntegrationsSystem_labolatory2
{
    public static class Helper
    {

        public static bool AddRecordToDatabse(Product product)
        {
            string connStr = "server=localhost;user=root;database=integrationsystems;port=3306;password=;Allow User Variables=true";

            MySqlConnection conn = new MySqlConnection(connStr);

                
            try
            {
                MySqlCommand comm = new MySqlCommand();
                conn.Open();
                comm.Parameters.AddWithValue("@manufacture", "");
                comm.Parameters.AddWithValue("@screen_size", "");
                comm.Parameters.AddWithValue("@screen_resolution", "");
                comm.Parameters.AddWithValue("@screen_type", "");
                comm.Parameters.AddWithValue("@screen_touch", "");
                comm.Parameters.AddWithValue("@processor_name", "");
                comm.Parameters.AddWithValue("@cpu_speed", "");
                comm.Parameters.AddWithValue("@cpu_thread", "");
                comm.Parameters.AddWithValue("ram_size", "");
                comm.Parameters.AddWithValue("ssd_size", "");
                comm.Parameters.AddWithValue("ssd_type", "");
                comm.Parameters.AddWithValue("gpu_name", "");
                comm.Parameters.AddWithValue("gpu_ram", "");
                comm.Parameters.AddWithValue("os_name", "");
                comm.Parameters.AddWithValue("disc_reader", "");
                comm.CommandText = "INSERT INTO integrationsystems (manufacture,screen_size,screen_resolution,screen_type,screen_touch,processor_name,cpu_speed,cpu_thread,ram_size,ssd_size,ssd_type,gpu_name,gpu_ram,os_name,disc_reader) VALUES (@manufacture,@screen_size,@screen_resolution,@screen_type,@screen_touch,@processor_name,@cpu_speed,@cpu_thread,@ram_size,@ssd_size,@ssd_type,@gpu_name,@gpu_ram,@os_name,@disc_reader)";
                comm.Connection = conn;

                comm.Parameters["@manufacture"].Value = product.Manufacture;
                comm.Parameters["@screen_size"].Value = product.ScreenSize;
                comm.Parameters["@screen_resolution"].Value = product.ScreenResolution;
                comm.Parameters["@screen_type"].Value = product.ScreenType;
                comm.Parameters["@screen_touch"].Value = product.ScreenTouch;
                comm.Parameters["@processor_name"].Value = product.ProcessorName;
                comm.Parameters["@cpu_speed"].Value = product.CpuSpeed;
                comm.Parameters["@cpu_thread"].Value = product.CpuThread;
                comm.Parameters["@ram_size"].Value = product.CpuThread;
                comm.Parameters["@ssd_size"].Value = product.SsdSize;
                comm.Parameters["@ssd_type"].Value = product.SsdType;
                comm.Parameters["@gpu_name"].Value = product.GpuName;
                comm.Parameters["@gpu_ram"].Value = product.GpuRam;
                comm.Parameters["@os_name"].Value = product.OsName;
                comm.Parameters["@disc_reader"].Value = product.DiscReader;
             
                comm.ExecuteNonQuery();
                conn.Close();
                return true;
            }
            catch (MySqlException mysql)
            {
                Console.Error.WriteLine(mysql.Message);
                return false;
            }
            //string sql = "INSERT INTO [dbo].[cloudbi]([IDUser],[manufacture],[screen_size],[screen_resolution],[screen_type],[screen_touch],[processor_name],[cpu_speed],[cpu_thread],[ram_size],[ssd_size],[ssd_type])) VALUES ('"
            //        + product.Id + "','" 
            //        + product.Manufacture + "','" 
            //        + product.ScreenSize + "','" 
            //        + product.ScreenResolution + "','" 
            //        + product.ScreenType + "','" 
            //        + product.ScreenTouch + "','" 
            //        + product.ProcessorName + "','" 
            //        + product.CpuThread + "','" 
            //        + product.RamSize + "','" 
            //        + product.SsdSize + "','" 
            //        + product.SsdType
            //        +"')";
            return true;

        }
        public static void GetDataFromDatabase(DataGridView data)
        {
            string connStr = "server=localhost;user=root;database=integrationsystems;port=3306;password=;Allow User Variables=true";
            MySqlConnection conn = new MySqlConnection(connStr);
            try
            {
                Console.WriteLine("Connecting to MySQL...");
                conn.Open();

                MySqlCommand comm = new MySqlCommand();
                comm.Connection = conn;
                comm.CommandText = "select * from integrationsystems";
                data.Rows.Clear();
                data.Rows.Add();
                MySqlDataReader rdr = comm.ExecuteReader();
                int row = 0;

                if (rdr.HasRows)
                {
                    while (rdr.Read())
                    {

                        for (int i = 0; i < rdr.FieldCount; i++)
                        {
                            for (int j = 0; j < data.Rows[row].Cells.Count; j++)
                            {
                                int cells = data.Rows[row].Cells.Count;
                                Console.WriteLine("Index: " + j + " " + rdr[j]);
                                data.Rows[row].Cells[j].Value = rdr[j + 1];


                            }

                        }
                        row++;
                        data.Rows.Add();
                    }

                }

                conn.Close();
            }
            catch (MySqlException mysql)
            {
                Console.Error.WriteLine(mysql.Message);
            }

            Console.WriteLine("Done.");

        }
        public static int ShowCountProducentItems(string producentName)
        {
            string connStr = "server=localhost;user=root;database=integrationsystems;port=3306;password=;Allow User Variables=true";
            MySqlConnection conn = new MySqlConnection(connStr);
            int count = 0;
            try
            {
                Console.WriteLine("Connecting to MySQL...");
                conn.Open();

                MySqlCommand comm = new MySqlCommand();
                comm.Connection = conn;
                comm.CommandText = "select count(*) from integrationsystems where manufacture = '" + producentName + "'";

                count = int.Parse(comm.ExecuteScalar().ToString());
                conn.Close();
            }
            catch (MySqlException mysql)
            {
                Console.Error.WriteLine(mysql.Message);
            }

            return count;
        }

        public static void ShowItemsMatrix(DataGridView dataView, string matrixType)
        {
            string connStr = "server=localhost;user=root;database=integrationsystems;port=3306;password=;Allow User Variables=true";
            MySqlConnection conn = new MySqlConnection(connStr);
            try
            {
                Console.WriteLine("Connecting to MySQL...");
                conn.Open();

                MySqlCommand comm = new MySqlCommand();
                comm.Connection = conn;
                comm.CommandText = "select * from integrationsystems where screen_type = '" + matrixType + "'";
                dataView.Rows.Clear();
                dataView.Rows.Add();
                MySqlDataReader rdr = comm.ExecuteReader();
                int row = 0;

                if (rdr.HasRows)
                {
                    while (rdr.Read())
                    {
                        for (int i = 0; i < rdr.FieldCount; i++)
                        {
                            for (int j = 0; j < dataView.Rows[row].Cells.Count; j++)
                            {
                                int cells = dataView.Rows[row].Cells.Count;
                                Console.WriteLine("Index: " + j + " " + rdr[j]);
                                dataView.Rows[row].Cells[j].Value = rdr[j + 1];                               
                            }
                        }
                        row++;
                        dataView.Rows.Add();
                    }
                }

                conn.Close();
            }
            catch (MySqlException mysql)
            {
                Console.Error.WriteLine(mysql.Message);
            }
        }
        public static int ScreenResolutionCount(string ScreenResolution)
        {
            string connStr = "server=localhost;user=root;database=integrationsystems;port=3306;password=;Allow User Variables=true";
            int countItems = 0;
            MySqlConnection conn = new MySqlConnection(connStr);
            try
            {
                Console.WriteLine("Connecting to MySQL...");
                conn.Open();

                MySqlCommand comm = new MySqlCommand();
                comm.Connection = conn;
                comm.CommandText = "select count(*) from integrationsystems where screen_resolution = '" + ScreenResolution + "'";
                countItems = int.Parse(comm.ExecuteScalar().ToString());
                conn.Close();
            }
            catch (MySqlException mysql)
            {
                Console.Error.WriteLine(mysql.Message);
            }
            return countItems;
        }

    }
}
