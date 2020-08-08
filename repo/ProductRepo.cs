using System;
using MySql.Data.MySqlClient;
using System.Collections.Generic;
using System.Collections;
namespace Mercury
{
    class ProductRepo
    {
        public MySqlConnection c;

        // Consructer : 
        public ProductRepo()
        {
            string con = "datasource = 127.0.0.1;port = 3306 ; username=root;password=;database=mercury";
            c = new MySqlConnection(con);
            c.Open();
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
        public product Read_Id(product p)
        {
            product newp = new product();
            string query = "SELECT * FROM product WHERE p_id = @p_id";
            MySqlCommand com = c.CreateCommand();
            com.CommandText = query;
            com.Parameters.Add("@p_id", MySqlDbType.VarString);
            com.Parameters["@p_id"].Value = p.p_id;

            MySqlDataReader myreader = com.ExecuteReader();
            while (myreader.Read())
            {
                newp.p_id = myreader.GetString(0);
                newp.p_price = myreader.GetString(1);
                newp.p_quantity = myreader.GetString(2);
                newp.p_description = myreader.GetString(3);
                newp.p_image = myreader.GetString(4);
                newp.created_at = myreader.GetString(5);
                newp.updated_at = myreader.GetString(6);

            }

            myreader.Close();
            return newp;

        }
        // read all data 
        public product[] Read_All()
        {
            string query = "SELECT * FROM product";
            MySqlCommand com = new MySqlCommand(query, c);
            product[] arr = new product[count()];
            for (int j = 0; j < arr.Length; j++)
            {
                arr[j] = new product();
            }
            int i = 0;
            MySqlDataReader myreader = com.ExecuteReader();

            while (myreader.Read())
            {

                arr[i].p_id = myreader.GetString(0);
                arr[i].p_price = myreader.GetString(1);
                arr[i].p_quantity = myreader.GetString(2);
                arr[i].p_description = myreader.GetString(3);
                arr[i].p_image = myreader.GetString(4);
                arr[i].created_at = myreader.GetString(5);
                arr[i].updated_at = myreader.GetString(6);
                i++;
            }
            myreader.Close();
            return arr;
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
        // method to count raws in table : 
        public int count()
        {
            string query = "SELECT COUNT(*) FROM product";
            MySqlCommand com = new MySqlCommand(query, c);
            Int32 count = Convert.ToInt32(com.ExecuteScalar());

            return count;

        }
        //print product table
        public void print()
        {
            product[] arr;
            arr = Read_All();
            for (int i = 0; i < arr.Length; i++)
                Console.WriteLine(arr[i].p_id + " -- " + arr[i].p_price + " -- " + arr[i].p_quantity + " -- " + arr[i].p_description + " -- " + arr[i].created_at + " -- " + arr[i].updated_at);

        }
    }


}

