using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using Model.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Configuration
{
    
        internal class CarConfiguration : IEntityTypeConfiguration<Car>
        {
            public void Configure(EntityTypeBuilder<Car> builder)
            {
                builder.Property(c => c.Name)
                    .HasColumnType("nvarchar(20)");

                builder.Property(c => c.Number)
                    .HasColumnType("nvarchar(20)");

                builder.HasMany(c => c.Rides)
                    .WithOne(r => r.Car)
                    .HasForeignKey(c => c.CarId);
            }
        }
    
}
