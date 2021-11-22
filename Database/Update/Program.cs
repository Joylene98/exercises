using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Update
{
    class Program
    {
        static void Main(string[] args)
        {
            SqlConnection cnn;
            SqlCommand command;
            int rowsModified = 0;
            String connString = "Data Source=.\\sqlexpress; Initial Catalog=Northwind; User ID=Thomas;Password=Thomas";
            String query = "UPDATE Student SET Age = '21' WHERE StudentID = '3'";
            cnn = new SqlConnection(connString);
            cnn.Open();
            Console.WriteLine("Connection is Open");
            command = new SqlCommand(query, cnn);

            if (command.ExecuteNonQuery() == 1)
            {
                rowsModified++;
                Console.WriteLine("Row(s) Updated Sucessfully!");
                Console.WriteLine("Row(s) Modified : {0}", rowsModified);
            }
            Console.ReadLine();
            command.Dispose();
            cnn.Close();
            

        }
    }
}
