using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using Model.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class ParentConfiguration : IEntityTypeConfiguration<Parent>
{
    public void Configure(EntityTypeBuilder<Parent> builder)
    {
        builder.Property(p => p.Username)
            .HasColumnType("nvarchar(20)");

        builder.Property(p => p.Password)
            .HasColumnType("nvarchar(20)");

        builder.Property(p => p.FirstName)
            .HasColumnType("nvarchar(20)");

        builder.Property(p => p.LastName)
            .HasColumnType("nvarchar(20)");

        builder.Property(p => p.Phone)
            .HasColumnType("nvarchar(20)");

       
    }
}

