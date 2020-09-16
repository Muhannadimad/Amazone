using System;
using System.Linq;
using Mercury.Models;

namespace Mercury.repo
{
    public class OrderRepo
    {
        MercuryContext ctx;

        // Constructor : 
        public OrderRepo()
        {
            ctx = new MercuryContext();
        }

        // Create method :
        public void Create(Order o)
        {
            ctx.Orders.Add(o);
            ctx.SaveChanges();
        }

        // Read by ID :
        public IQueryable<Order> Read(int id)
        {
            var order = ctx.Orders.Where(o => o.Id == id);
            return order;
        }

         // read all data 
        public IQueryable<Order> Read()
        {
            var result = ctx.Orders.Where(o => true);
            return result;
        }

        // Update method :
        public void Update(Order order)
        {
            if (!order.ProductId.Equals(String.Empty))
            {
                var ord = ctx.Orders.First(o => o.Id == order.Id);
                ord.ProductId = order.ProductId;
            }

            if (!order.UserId.Equals(String.Empty))
            {
                var ord = ctx.Orders.First(o => o.Id == order.Id);
                ord.UserId = order.UserId;
            }

            if (!order.Quantity.Equals(String.Empty))
            {
                var ord = ctx.Orders.First(o => o.Id == order.Id);
                ord.Quantity = order.Quantity;
            }

            ctx.SaveChanges();
        }

        // Delete method :
        public void Delete(Order order)
        {
            var ord = ctx.Orders.First(o => o.Id == order.Id);
            ctx.Orders.Remove(ord);
            ctx.SaveChanges();
        }

        //  method to count raws in table : 
        public int Count()
        {
            return ctx.Orders.Count();
        }

        //Print Order table
        public void Print()
        {
            var temp = Read();
            Console.WriteLine("ID---UserId---ProductId---Quantity");
            foreach (var t in temp)
            {
                Console.WriteLine($"{t.Id}---{t.UserId}---{t.ProductId}---{t.Quantity}");
            }
        }
    }
}