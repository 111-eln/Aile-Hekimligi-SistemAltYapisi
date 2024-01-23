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
    public class HospitalService : Service<Hospital>, IHospitalService
    {
        public HospitalService(IGenericRepository<Hospital> repository, IUnitOfWorks unitOfWork) : base(repository, unitOfWork)
        {
        }
    }
}
