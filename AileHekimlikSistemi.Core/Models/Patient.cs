using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AileHekimlikSistemi.Core.Models
{
    public class Patient:BaseEntity
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Age { get; set; }
       
        public Doctor Doctor { get; set; }
        public int DoctorId { get; set; }
    }
}
