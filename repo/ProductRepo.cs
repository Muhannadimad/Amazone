using System;
using System.Linq;
using Mercury.Models;

namespace Mercury.repo
{
    public class ProductRepo
    {
        MercuryContext ctx;

        // Constructor : 
        public ProductRepo()
        {
            ctx = new MercuryContext();
        }

        // Create method :
        public void Create(Product P)
        {
            ctx.Products.Add(P);
            ctx.SaveChanges();
        }

        // Read by ID :
        public IQueryable<Product> Read(int id)
        {
            var p = ctx.Products.Where(p => p.Id == id);
            return p;
        }

//         // read all data 
        public IQueryable<Product> Read()
        {
            var result = ctx.Products.Where(p => true);
            return result;
        }

        // Update method :
        public void Update(Product P)
        {
            if (!P.Price.Equals(String.Empty))
            {
                var prd = ctx.Products.First(p => p.Id == P.Id);
                prd.Price = P.Price;
            }

            if (!P.Description.Equals(String.Empty))
            {
                var prd = ctx.Products.First(p => p.Id == P.Id);
                prd.Description = P.Description;
            }

            if (!P.Quantity.Equals(String.Empty))
            {
                var prd = ctx.Products.First(p => p.Id == P.Id);
                prd.Quantity = P.Quantity;
            }

            ctx.SaveChanges();
        }

        // Delete method :
        public void Delete(Product P)
        {
            var prd = ctx.Products.First(p => p.Id == P.Id);
            ctx.Products.Remove(prd);
            ctx.SaveChanges();
        }

        //  method to count raws in table : 
        public int Count()
        {
            return ctx.Products.Count();
        }

        //print product table
        public void Print()
        {
            var temp = Read();
            Console.WriteLine("ID---Description---Price---Quantity");
            foreach (var t in temp)
            {
                Console.WriteLine($"{t.Id}---{t.Description}---{t.Price}---{t.Quantity}");
            }
        }
    }
}