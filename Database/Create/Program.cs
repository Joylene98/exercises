using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Create
{
    class Program
    {
        static void Main(string[] args)
        {
            SqlConnection cnn;
            SqlCommand command;
           // SqlDataReader dataReader;
            //String output;
            int rowsAffected = 0;

            String connString = "Data Source =.\\sqlexpress; Initial Catalog=Northwind;User ID=Thomas;Password=Thomas";
            String query = "SET IDENTITY_INSERT Student ON INSERT INTO Student (StudentID, Name, Age) VALUES('6', 'Lilly', '28') SET IDENTITY_INSERT Student OFF";
            cnn = new SqlConnection(connString);
            cnn.Open();
            Console.WriteLine("Connection is Open");
            command = new SqlCommand(query, cnn);

            if(command.ExecuteNonQuery() == 1)
            {
                rowsAffected++;
                Console.WriteLine("Insertion sucessful");
                Console.WriteLine("Row(s) Affected : {0} ", rowsAffected);
            }
            Console.ReadLine();
            command.Dispose();
            cnn.Close();
        }
    }
}
