using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AileHekimlikSistemi.Core.Models
{
    public abstract class BaseEntity
    {
        public int Id { get; set; }
        public DateTime updatedDate { get; set; }
        public DateTime createdDate { get; set; }
    }
}
