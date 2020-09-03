
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using System.ComponentModel.DataAnnotations.Schema;
using Mercury.Models;
namespace Mercury
{

    public class MercuryContext : DbContext
    {
        public DbSet<product> products { get; set; }
        public DbSet<User> users { get; set; }
        public DbSet<Order> orders { get; set; }
        // public MercuryContext(): base(){
        //     Database.SetInitializer(new SchoolDBInitializer());
        // }
        //public DbSet<Student> Students { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {

                optionsBuilder.UseMySql("server=localhost; database=Mercury; user=root; pwd=123123;");
            }
        }

    }
}
//     protected override void OnModelCreating(ModelBuilder modelBuilder)
//     {
//     //     modelBuilder.Entity<Student>()
//     //    .HasKey(s => s.StudentId);
//     //     modelBuilder.Entity<Grade>()
//     //     .HasKey(s => s.Id);

//     //     modelBuilder.Entity<Student>().HasKey(s => new { s.StudentId, s.FirstName });      

//     //     //   modelBuilder.Entity<Student>()
//     //     //         .Property(p => p.DateOfBirth)
//     //     //         .HasColumnName("DoB")
//     //     //         .HasColumnOrder(3)
//     //     //         .HasColumnType("datetime2");
//     }
// }

// public class Student
// {
//     [Key]
//     public int StudentId { get; set; }

//     public string FirstName { get; set; }

//     public string LastName { get; set; }

//     public DateTime DateOfBirth { get; set; }

//     public byte[] Photo { get; set; }

//     public decimal Height { get; set; }

//     public float Weight { get; set; }

//     public int GradeID {get; set;}


// }

// public class Grade
// {
//     [Column(Order = 0)]
//     public int Id { get; set; }
//      [Column(Order = 2)]
//     public string GradeName { get; set; }
//      [Column(Order = 1)]
//     public string Section { get; set; }
// }

