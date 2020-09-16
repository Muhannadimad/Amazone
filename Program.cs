using System;
using Mercury.Models;
using Mercury.repo;
using Microsoft.Extensions.Configuration;

namespace Mercury
{
    // class LoggingConfig
    // {
    //     public string LogPath {get;set;}
    //     public LogLevel Level {get;set;}
    // }
    class Program
    {
        static void Main(string[] args)
        {
            // ProductRepo pr = new ProductRepo();
            // Product p = new Product()
            // {
            //     Description = "hats",
            //     Quantity = 200,
            //     Price = 50
            // };
            // pr.Create(p);

            // var t = pr.Read();
            //  foreach (var item in t)
            //  {
            //      Console.WriteLine(item.Description);
            //  }


            // OrderRepo ordrepo = new OrderRepo();
            // Order o = new Order()
            // {
            //    
            //     ProductId = 2,
            //     UserId = 1,
            //     Quantity = 33
            // };
            // ordrepo.Create(o);


            // UserRepo userrepo = new UserRepo();
            // var u = new User()
            // {
            //     Id = 4
            //     // firstname = "ali",
            //     // lastname = "mohammad",
            //     // address = "nablus",
            //     // email = "ali@muhannad.com",
            //     // phone = "0599958574",
            //     // password = "1223"
            // };
            // userrepo.Count();
            //    try
            //    {
            //        userrepo.Create(u);
            //    }
            //    catch (Exception ex)
            //    {
            //        String innerMessage = (ex.InnerException != null) 
            //            ? ex.InnerException.Message
            //            : "";
            //        Console.WriteLine(innerMessage);
            //    }
            // }

            // configuration
            // IConfiguration configuration = new ConfigurationBuilder()
            //     .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true)
            //     .AddEnvironmentVariables()
            //     .AddCommandLine(args)
            //     .Build();
          
        }
    }
}