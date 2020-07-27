using System;
using MySql.Data.MySqlClient;

namespace Mercury
{
    class Program
    {

        public static void runQuery(string query)
        {

            if (query == "")
            {
                Console.WriteLine("please enter a query");
                return;
            }
            else
            {
                string con = "datasource = 127.0.0.1;port = 3306 ; username=root;password=;database=mercury";
                MySqlConnection c = new MySqlConnection(con);
                MySqlCommand com = new MySqlCommand(query, c);
                try
                {
                    c.Open();
                    MySqlDataReader myreader = com.ExecuteReader();
                    if (myreader.HasRows)
                    {
                        while (myreader.Read())
                        {
                            Console.WriteLine(myreader.GetString(0) + " - " + myreader.GetString(1) + " - " + myreader.GetString(2)
                            + " - " + myreader.GetString(3) + " - " + myreader.GetString(4) + " - " + myreader.GetString(5));
                        }
                    }
                    else
                    {
                        Console.WriteLine("query successfully excuated");
                    }


                }
                catch (Exception e)
                {
                    Console.WriteLine("query error :" + e.Message);
                }
            }
        }

        static void Main(string[] args)
        {
            string myquery1 = "INSERT INTO USER VALUES (NULL , 'muhannad' ,'imad' , '123123' ,'moh@gmail.com','qalqilia' ,'0599123123') ";
            string myquery2 = "SELECT * FROM USER";
            runQuery(myquery2);


        }
    }
}
