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
    public class DoctorSeed : IEntityTypeConfiguration<Doctor>
    {
        public void Configure(EntityTypeBuilder<Doctor> builder)
        {
            builder.HasData(
                 new Doctor { Id = 1,Name = "eln1",Surname="akk1", HospitalId = 1, createdDate = DateTime.Now },
                 new Doctor { Id = 2, Name = "eln2", Surname = "akk2", HospitalId = 2, createdDate = DateTime.Now },
                 new Doctor { Id = 3, Name = "eln3", Surname = "akk3", HospitalId = 3, createdDate = DateTime.Now },
                  new Doctor { Id = 4, Name = "eln4", Surname = "akk4", HospitalId = 4, createdDate = DateTime.Now }
                 );
        }
    }
}
