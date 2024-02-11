using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.SqlServer;
using Model.Concretes;

namespace DataAccess.Context
{
    internal class SchoolBusDB:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string constr = "Data Source=LAPTOP-JLBUNNBV\\SQLEXPRESS;Initial Catalog=SchoolDB;Integrated Security=True;Connect Timeout=30;Encrypt=True;Trust Server Certificate=True;Application Intent=ReadWrite;Multi Subnet Failover=False";
            optionsBuilder.UseLazyLoadingProxies();
            optionsBuilder.UseSqlServer(constr);
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
           
            modelBuilder.Entity<ParentStudent>()
                .HasKey(p => new { p.StudentId, p.ParentId });

            modelBuilder.Entity<ParentStudent>()
                .HasOne(ps => ps.Student)
                .WithMany(p => p.ParentStudents)
                .HasForeignKey(pt => pt.StudentId);

            modelBuilder.Entity<ParentStudent>()
                .HasOne(pt => pt.Parent)
                .WithMany(t => t.ParentStudents)
                .HasForeignKey(pt => pt.ParentId);

            modelBuilder.Entity<StudentRide>()
                .HasKey(t => new { t.StudentId, t.RideId });

            modelBuilder.Entity<StudentRide>()
                .HasOne(pt => pt.Student)
                .WithMany(p => p.StudentRides)
                .HasForeignKey(pt => pt.StudentId);

            modelBuilder.Entity<StudentRide>()
                .HasOne(pt => pt.Ride)
                .WithMany(t => t.StudentRides)
                .HasForeignKey(pt => pt.RideId);

            modelBuilder.ApplyConfigurationsFromAssembly(GetType().Assembly);
        
            base.OnModelCreating(modelBuilder);
        }


        public virtual DbSet<Car>? Cars { get; set; }
        public virtual DbSet<Driver>? Drivers { get; set; }
        public virtual DbSet<Class>? Classes { get; set; }
        public virtual DbSet<Parent>? Parents { get; set; }
        public virtual DbSet<Ride>? Rides { get; set; }
        public virtual DbSet<Student>? Students { get; set; }
        public virtual DbSet<ParentStudent> ParentStudent { get; set; }
        public virtual DbSet<StudentRide> StudentRide { get; set; }
        public virtual DbSet<Admin>? Admins { get; set; }
   
    }
}
