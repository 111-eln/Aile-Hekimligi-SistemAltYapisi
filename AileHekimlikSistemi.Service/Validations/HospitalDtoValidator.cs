using AileHekimlikSistemi.Core.DTOs;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AileHekimlikSistemi.Service.Validations
{
    public class HospitalDtoValidator:AbstractValidator<HospitalDto>
    {
        public HospitalDtoValidator()
        {
            RuleFor(x => x.HospitalName).NotNull().WithMessage("{PropertyName} null geçilemez.").NotEmpty().WithMessage("{PropertyName} boş geçilemez");

        }
    }
}
