using System;
using System.Collections.Generic;
using System.Linq;
using Mercury.Models;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Mercury
{
    class Program
    {


        static void Main(string[] args)
        {

           


             // return raw by id : 
        //    MercuryContext m =new MercuryContext();
        //    var mp = m.Product.Single(b => b.Id.Equals(2));
        //    Console.WriteLine(mp.Quantity);
    


          // add new entity :
        // var p = new Product(){
        //  Description = "bmw x5",
        //  Price = 200000,
        //  Quantity = 5
        // };
        // var m= new MercuryContext();
        // m.Add(p);
        // m.SaveChanges();



     

      var context = new MercuryContext();
      
      var x =   context.Product.Where(s => s.Id ==3).ToList();
    foreach (var z in x)
    {
        Console.WriteLine(z.Description);
    }
         }
    
    }
}
