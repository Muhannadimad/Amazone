using System;
using MySql.Data.MySqlClient;
using System.Collections.Generic;
namespace Mercury
{
    class Program
    {


        static void Main(string[] args)
        {
            try
            {


                product p = new product();
                p.p_id = "11";
                p.p_price = "22000000";
                p.p_quantity = "90";
                p.p_description = "bmw x5";
                ProductRepo repo = new ProductRepo();
                repo.Delete(p);


            }
            catch (Exception e)
            {
                Console.WriteLine("Erorr " + e.Message);
            }

        }
    }
}
