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
        public void Create(product p)
        {
            string query = $"INSERT INTO product (p_price, p_quantity, p_description) VALUES (@p_price, @p_quantity,@p_description)";
            MySqlCommand com = c.CreateCommand();
            com.CommandText = query;
            com.Parameters.Add("@p_price", MySqlDbType.VarString);
            com.Parameters.Add("@p_quantity", MySqlDbType.VarString);
            com.Parameters.Add("@p_description", MySqlDbType.VarString);
            com.Parameters["@p_price"].Value = p.p_price;
            com.Parameters["@p_quantity"].Value = p.p_quantity;
            com.Parameters["@p_description"].Value = p.p_description;
            com.ExecuteNonQuery();

        }
        // Read method :
        public void Read_Id(product p)
        {
            string query = "SELECT * FROM product WHERE p_id = @p_id";
            MySqlCommand com = c.CreateCommand();
            com.CommandText = query;
            com.Parameters.Add("@p_id", MySqlDbType.VarString);
            com.Parameters["@p_id"].Value = p.p_id;

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
        // read all data 
        public void Read_All()
        {
            string query = "SELECT * FROM product";
            MySqlCommand com = new MySqlCommand(query, c);

            MySqlDataReader myreader = com.ExecuteReader();
            int count = 0;
            if (myreader.HasRows)
            {
                while (myreader.Read())
                {

                    Console.WriteLine(++count);
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
        // Update method :
        public void Update(product p)
        {
            MySqlCommand com = c.CreateCommand();
            string query = "UPDATE product SET ";

            if (!p.p_price.Equals(string.Empty))
            {
                query += $"  p_price = @p_price  ";
                com.Parameters.Add("@p_price", MySqlDbType.VarString);
                com.Parameters["@p_price"].Value = p.p_price;
            }
            if (!p.p_quantity.Equals(String.Empty))
            {
                query += $" , p_quantity= @p_quantity ";
                com.Parameters.Add("@p_quantity", MySqlDbType.VarString);
                com.Parameters["@p_quantity"].Value = p.p_quantity;
            }
            if (!p.p_description.Equals(string.Empty))
            {
                query += " , p_description =@p_description ";
                com.Parameters.Add("@p_description", MySqlDbType.VarString);
                com.Parameters["@p_description"].Value = p.p_description;
            }
            query += " WHERE p_id = @p_id";
            com.Parameters.Add("@p_id", MySqlDbType.VarString);
            com.Parameters["@p_id"].Value = p.p_id;

            com.CommandText = query;
            com.ExecuteNonQuery();

        }
        // Delete method :
        public void Delete(product p)
        {
            string query = $"DELETE FROM product WHERE p_id = @p_id";
            MySqlCommand com = new MySqlCommand(query, c);
            com.Parameters.Add("@p_id", MySqlDbType.VarString);
            com.Parameters["@p_id"].Value = p.p_id;
            com.ExecuteNonQuery();
        }
        // method to run any query : 
        public void runQuery(string query)
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
                            + " - " + myreader.GetString(3) + " - " + myreader.GetString(4) + " - " + myreader.GetString(5) + " - " + myreader.GetString(6));
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
