using System;
using MySql.Data.MySqlClient;
using System.Collections.Generic;
namespace Mercury
{
    class Program
    {


        static void Main(string[] args)
        {
            // try
            // {


                product p = new product();
                p.p_id = "7";
                //p.p_price = "66200";
                // p.p_quantity = "80";
                // p.p_description = "bmw x5 109";
                ProductRepo repo = new ProductRepo();
                repo.print();
                // product [] arr ;
                // arr = repo.Read_All();
                // for(int i=0; i<arr.Length;i++)
                // Console.WriteLine(arr[i].p_id+" "+arr[i].p_price+" "+arr[i].p_quantity+" "+arr[i].p_description+" "+arr[i].created_at+" "+arr[i].updated_at);


           // }
            // catch (Exception e)
            // {
            //     Console.WriteLine("Erorr " + e.Message);
            // }

        }
    }
}
