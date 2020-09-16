using System;
using System.Linq;
using Mercury.Models;

namespace Mercury.repo
{
    public class UserRepo
    {
        MercuryContext ctx;

        // Constructor : 
        public UserRepo()
        {
            ctx = new MercuryContext();
        }

        // Create method :
        public void Create(User user)
        {
            ctx.Users.Add(user);
            ctx.SaveChanges();
        }

        // Read by ID :
        public IQueryable<User> Read(int id)
        {
            var user = ctx.Users.Where(u => u.Id == id);
            return user;
        }
        
        // read all data 
        public IQueryable<User> Read()
        {
            var result = ctx.Users.Where(p => true);
            return result;
        }
        
        // Update method :
        public void Update(User user)
        {
            if (!user.firstname.Equals(String.Empty))
            {
                var us = ctx.Users.First(p => p.Id == user.Id);
                us.firstname = user.firstname;
            }
        
            if (!user.lastname.Equals(String.Empty))
            {
                var us = ctx.Users.First(u => u.Id == user.Id);
                us.lastname = user.lastname;
            }
        
            if (!user.password.Equals(String.Empty))
            {
                var us = ctx.Users.First(p => p.Id == user.Id);
                us.password = user.password;
            }
        
            if (!user.email.Equals(String.Empty))
            {
                var us = ctx.Users.First(p => p.Id == user.Id);
                us.email = user.email;
            }
        
            if (!user.phone.Equals(String.Empty))
            {
                var us = ctx.Users.First(p => p.Id == user.Id);
                us.phone = user.phone;
            }
        
            if (!user.address.Equals(String.Empty))
            {
                var us = ctx.Users.First(p => p.Id == user.Id);
                us.address = user.address;
            }
        
            ctx.SaveChanges();
        }
        
        // Delete method :
        public void Delete(User user)
        {
            var us = ctx.Users.First(u => u.Id == user.Id);
            ctx.Users.Remove(us);
            ctx.SaveChanges();
        }
        
        //  method to count raws in table : 
        public int Count()
        {
            return ctx.Users.Count();
        }
        
        //print product table
        public void Print()
        {
            var temp = Read();
            Console.WriteLine("ID---FirstName---LastName---Address---Email---Phone---password");
            foreach (var t in temp)
            {
                Console.WriteLine(
                    $"{t.Id}---{t.firstname}---{t.lastname}---{t.address}---{t.email}---{t.phone}---{t.password}");
            }
        }
    }
}