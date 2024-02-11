using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Model.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Configuration
{
    internal class DriverConfiguration : IEntityTypeConfiguration<Driver>
    {
        public void Configure(EntityTypeBuilder<Driver> builder)
        {
            builder.Property(d => d.FirstName).IsRequired().HasColumnType("nvarchar(20)");
            builder.Property(d => d.LastName).IsRequired().HasColumnType("nvarchar(20)");
            builder.Property(d => d.Username).IsRequired().HasColumnType("nvarchar(20)");
            builder.Property(d => d.Password).IsRequired().HasColumnType("nvarchar(20)");
            builder.Property(d => d.Phone).IsRequired().HasColumnType("nvarchar(20)");
            builder.Property(d => d.License).IsRequired(false).HasColumnType("nvarchar(20)");
        }
    }
}
