using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AileHekimlikSistemi.Core.DTOs
{
    public class DoctorDto:BaseDto
    {
        public string Name { get; set; }
        public string Surname { get; set; }
    }
}
