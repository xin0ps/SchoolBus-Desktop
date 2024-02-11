using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using Model.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

internal class RideConfiguration : IEntityTypeConfiguration<Ride>
{
    public void Configure(EntityTypeBuilder<Ride> builder)
    {
        builder.Property(r => r.Rotate)
            .HasColumnType("bit");

        builder.HasOne(r => r.Driver)
            .WithMany(d => d.Rides)
            .HasForeignKey(r => r.DriverId);

        builder.HasOne<Car>(r => r.Car)
            .WithMany(c => c.Rides)
            .HasForeignKey(r => r.CarId);

   
    }
}