using Microsoft.Data.SqlClient;
using System.Data;
using System.Diagnostics.Metrics;

namespace MyAdoNet
{
    internal class Program
    {
        static string connStr = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\байбатыровм\\Documents\\MyDB.mdf;Integrated Security=True;Connect Timeout=30";
        static void GetData()
        {
            using (SqlConnection db = new SqlConnection(connStr))
            {
                db.Open();
                using (SqlCommand cmd = new SqlCommand("select id, name from country", db))
                {
                    DataTable dt = new DataTable();
                    dt.Load(cmd.ExecuteReader());
                    foreach (DataRow row in dt.Rows)
                    {
                        Console.WriteLine($"{row[0].ToString()} - {row["name"].ToString()}");
                    }
                }
                db.Close();
            }
        }

        static void AddCountry(string cou)
        {
            using (SqlConnection db = new SqlConnection(connStr))
            {
                db.Open();
                using (SqlCommand cmd = new SqlCommand($"insert into country (name) values ('{cou}')", db))
                {
                    cmd.ExecuteNonQuery();
                }
                db.Close();
            }
        }

        static void pGetCitiesByCountryName(string country)
        {
            using (SqlConnection db = new SqlConnection(connStr))
            {
                db.Open();
                using (SqlCommand cmd = new SqlCommand("pGetCitiesByCountryName @country_name", db))
                {
                    cmd.Parameters.AddWithValue("country_name", country);
                    DataTable dt = new DataTable();
                    dt.Load(cmd.ExecuteReader());
                    foreach (DataRow row in dt.Rows)
                    {
                        Console.WriteLine($"{row[0].ToString()}");
                    }
                }
                db.Close();
            }
        }
        static void Main(string[] args)
        {
            //AddCountry("UZ");
            //GetData();
            pGetCitiesByCountryName("RU");
        }
    }
}
