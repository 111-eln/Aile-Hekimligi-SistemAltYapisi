using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AileHekimlikSistemi.Core.Models
{
    public class Hospital:BaseEntity
    {
        public string HospitalName { get; set; }
        public ICollection<Doctor> Doctors { get; set; }
    }
}
