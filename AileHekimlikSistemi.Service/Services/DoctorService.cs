using AileHekimlikSistemi.Core.Models;
using AileHekimlikSistemi.Core.Repositories;
using AileHekimlikSistemi.Core.Services;
using AileHekimlikSistemi.Core.UnitOfWorks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AileHekimlikSistemi.Service.Services
{
    public class DoctorService : Service<Doctor>, IDoctorService
    {
        public DoctorService(IGenericRepository<Doctor> repository, IUnitOfWorks unitOfWork) : base(repository, unitOfWork)
        {
        }
    }
}
