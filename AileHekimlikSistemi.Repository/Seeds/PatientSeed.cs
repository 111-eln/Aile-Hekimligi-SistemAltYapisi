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
    public class PatientSeed : IEntityTypeConfiguration<Patient>
    {
        public void Configure(EntityTypeBuilder<Patient> builder)
        {
            builder.HasData(
                new Patient { Id = 1, Name = "hasta1",Surname="sou1",Age=35,DoctorId=1, createdDate = DateTime.Now },
                new Patient { Id = 2, Name = "hasta2", Surname = "soy2", Age = 15, DoctorId = 2, createdDate = DateTime.Now },
                 new Patient { Id = 3, Name = "hasta3", Surname = "soy3", Age = 45, DoctorId = 3, createdDate = DateTime.Now },
                  new Patient { Id = 4, Name = "hasta4", Surname = "soy4", Age = 65, DoctorId = 4, createdDate = DateTime.Now }
                );
        }
    }
}
