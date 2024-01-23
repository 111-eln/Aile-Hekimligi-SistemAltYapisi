using AileHekimlikSistemi.Core.DTOs;
using AileHekimlikSistemi.Core.Models;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AileHekimlikSistemi.Service.Mapping
{
    public class MapProfile:Profile
    {
        public MapProfile()
        {
            CreateMap<Hospital, HospitalDto>().ReverseMap();
            CreateMap<Doctor, DoctorDto>().ReverseMap();
            CreateMap<Patient, PatientDto>().ReverseMap();

            //dto'dan entity'e çevirmek istersem;
            CreateMap<PatientDto, Patient>();
        }
    }
}
