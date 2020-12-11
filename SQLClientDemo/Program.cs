using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace SQLClientDemo
{
    class Program
    {
        static string connectionString = "Server=localhost;Database=everyloop;User Id=airport;Password=airport;";

        static void Main(string[] args)
        {
            string searchString;

            do
            {
                Console.Write("Enter search string: ");
                searchString = Console.ReadLine();
                if (searchString != "") RunQuery(searchString);
                Console.WriteLine();

            } while (searchString != "");
        }

        static void RunQuery(string searchString)
        {
            string query = "Select top 10 [Airport name], IATA, isnull(ICAO, '-') from airports where [Airport name] like '%' + @UserInput + '%';";

            Console.WriteLine(query);

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@UserInput", searchString);

                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    Console.WriteLine($"{reader.GetValue(0),-50}{reader.GetValue(1),-10}{reader.GetValue(2),-10}");
                }

                connection.Close();
            }
        }
    }
}
