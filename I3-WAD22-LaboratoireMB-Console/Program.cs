using System;
using System.Data.SqlClient;

namespace I3_WAD22_LaboratoireMB_Console
{
    class Program
    {

        static string ConnectionString = @"Data Source=(localDB)\MSSQLlocalDB;Initial Catalog=AdopteUnDev;Integrated Security=True";
            static void Main(string[] args)
        {
                
                SqlConnection connection = new SqlConnection();
                connection.ConnectionString = ConnectionString;
                Console.WriteLine(connection.State);
                connection.Open();
                Console.WriteLine(connection.State);
                connection.Close();
                Console.WriteLine(connection.State);
        }
    }
}
