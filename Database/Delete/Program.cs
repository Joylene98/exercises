using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delete
{
    class Program
    {
        static void Main(string[] args)
        {
            SqlConnection cnn;
            SqlCommand command;
            int rowsDeleted = 0;

            String connString = "Data Source=.\\sqlexpress; Initial Catalog=Northwind;User ID=Thomas;Password=Thomas";
            String query = "DELETE FROM Student WHERE StudentID = '1'";
            cnn = new SqlConnection(connString);
            cnn.Open();
            Console.WriteLine("Connection is Open");
            command = new SqlCommand(query, cnn);
            
            if(command.ExecuteNonQuery() == 1) // checks if one record is deleted
            {
                rowsDeleted++;
                Console.WriteLine("Row(s) deleted successfully");
                Console.WriteLine("Rows Deleted : {0}", rowsDeleted);
            }
            Console.ReadLine();
            command.Dispose();
            cnn.Close();
        }
    }
}
