using AileHekimlikSistemi.Core.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AileHekimlikSistemi.Repository.Seeds
{
    public class HospitalSeed : IEntityTypeConfiguration<Hospital>
    {
        public void Configure(EntityTypeBuilder<Hospital> builder)
        {
            builder.HasData(
                new Hospital { Id = 1, HospitalName = "ist. hastanesi", createdDate = DateTime.Now },
                new Hospital { Id = 2, HospitalName = "ankara. hastanesi", createdDate = DateTime.Now },
                new Hospital { Id = 3, HospitalName = "İzmir. hastanesi", createdDate = DateTime.Now },
                new Hospital { Id = 4, HospitalName = "Bursa. hastanesi", createdDate = DateTime.Now }
                );
        }
    }
}
