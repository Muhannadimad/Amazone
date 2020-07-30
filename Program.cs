using System;
using MySql.Data.MySqlClient;
using System.Collections.Generic;
namespace Mercury
{
    class Program
    {

    
        static void Main(string[] args)
        {
            ProductRepo repo = new ProductRepo();

            repo.data["p_id"] = "2";
            repo.data["p_price"] = "3000";
            repo.data["p_quantity"] = "7";
            repo.data["p_description"] = "iphone 11";

            repo.Read();


        }
    }
}
