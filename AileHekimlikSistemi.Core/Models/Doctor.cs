using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AileHekimlikSistemi.Core.Models
{
    public class Doctor:BaseEntity
    {
        public string Name { get; set; }
        public string Surname { get; set; }

        public Hospital Hospital { get; set; }

       
        public int HospitalId { get; set; }
    }
}
