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
    
        internal class AdminConfiguration : IEntityTypeConfiguration<Admin>
        {
            public void Configure(EntityTypeBuilder<Admin> builder)
            {
                builder.Property(a => a.Username)
                    .HasColumnType("nvarchar(20)");

                builder.Property(a => a.Password)
                    .HasColumnType("nvarchar(20)");
            }
        }

}

