using System;
using MySql.Data.MySqlClient;
using System.Collections.Generic;
namespace Mercury
{
    class ProductRepo
    {
        public MySqlConnection c;
        public Dictionary<string, string> data;
        // Consructer : 
        public ProductRepo()
        {
            data = new Dictionary<string, string>();
            try
            {
                string con = "datasource = 127.0.0.1;port = 3306 ; username=root;password=;database=mercury";
                c = new MySqlConnection(con);
                c.Open();

            }
            catch (Exception e)
            {
                Console.WriteLine("Error in connction :" + e.Message);
            }
        }
        // Create method :
        public void Create()
        {
            string query = $"INSERT INTO product (p_price, p_quantity, p_description) VALUES ('{data["p_price"]}', '{data["p_quantity"]}','{data["p_description"]}')";

            try
            {
                MySqlCommand com = new MySqlCommand(query, c);

                MySqlDataReader myreader = com.ExecuteReader();
            }
            catch (Exception e)
            {
                Console.WriteLine("Erorr :" + e.Message);
            }

            data.Clear();
        }
        // Read method :
        public void Read()
        {
            string query = $"SELECT * FROM product WHERE p_id = {data["p_id"]}";
            Console.WriteLine(query);
            try
            {
                MySqlCommand com = new MySqlCommand(query, c);
                MySqlDataReader myreader = com.ExecuteReader();

                if (myreader.HasRows)
                {
                    while (myreader.Read())
                    {
                        Console.WriteLine(myreader.GetString(0) + " - " + myreader.GetString(1) + " - " + myreader.GetString(2)
                        + " - " + myreader.GetString(3) + " - " + myreader.GetString(4) + " - " + myreader.GetString(5) + " - " + myreader.GetString(6));
                    }
                }
                else
                {
                    Console.WriteLine("Nothing to return check id !");
                }
                myreader.Close();

            }
            catch (Exception e)
            {
                Console.WriteLine("query error :" + e.Message);
            }
            data.Clear();
        }
        // Update method :
        public void Update()
        {
            string query;

            if (!data.ContainsKey("p_id"))
            {
                Console.WriteLine("Determine product id (p_id) to update");
            }
            else
            {
                if (data.ContainsKey("p_price"))
                {
                    query = $"UPDATE product SET p_price={data["p_price"]} WHERE p_id={data["p_id"]}";
                    try
                    {
                        MySqlCommand com = new MySqlCommand(query, c);

                        MySqlDataReader myreader = com.ExecuteReader();
                        myreader.Close();
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine("Erorr :" + e.Message);
                    }

                }
                if (data.ContainsKey("p_quantity"))
                {
                    query = $"UPDATE product SET p_quantity={data["p_quantity"]} WHERE p_id={data["p_id"]}";
                    try
                    {
                        MySqlCommand com = new MySqlCommand(query, c);

                        MySqlDataReader myreader = com.ExecuteReader();
                        myreader.Close();
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine("Erorr :" + e.Message);
                    }
                }
                if (data.ContainsKey("p_description"))
                {
                    query = $"UPDATE product SET p_description ='{data["p_description"]}' WHERE p_id={data["p_id"]}";

                    try
                    {
                        MySqlCommand com = new MySqlCommand(query, c);

                        MySqlDataReader myreader = com.ExecuteReader();
                        myreader.Close();
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine("Erorr :" + e.Message);
                    }
                }
            }
            data.Clear();
        }
        // Delete method :
        public void Delete()
        {
            if (data.ContainsKey("p_id"))
            {
                string query = $"DELETE FROM product WHERE p_id = {data["p_id"]}";

                try
                {
                    MySqlCommand com = new MySqlCommand(query, c);

                    MySqlDataReader myreader = com.ExecuteReader();
                    myreader.Close();
                }
                catch (Exception e)
                {
                    Console.WriteLine("Erorr :" + e.Message);
                }
            }
            else
            {
                Console.WriteLine("Determine id to delete");
            }
            data.Clear();
        }
        // method to run any query : 
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


    }
}
