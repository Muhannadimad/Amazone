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
                p.p_id = "7";
                p.p_price = "66200";
                // p.p_quantity = "80";
                p.p_description = "bmw x5 109";
                ProductRepo repo = new ProductRepo();
                repo.Update(p);


            }
            catch (Exception e)
            {
                Console.WriteLine("Erorr " + e.Message);
            }

        }
    }
}
