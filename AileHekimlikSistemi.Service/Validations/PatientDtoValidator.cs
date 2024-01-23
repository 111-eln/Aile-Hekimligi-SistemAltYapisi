using AileHekimlikSistemi.Core.DTOs;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AileHekimlikSistemi.Service.Validations
{
    public class PatientDtoValidator:AbstractValidator<PatientDto>
    {
        public PatientDtoValidator()
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage("Kullanıcı adı boş olamaz.")
           .NotNull().WithMessage("Kullanıcı adı null olamaz!")
           .MaximumLength(50).WithMessage("Kullanıcı adı en fazla 50 karakter olabilir. ");

            RuleFor(x => x.Surname)
                .NotEmpty().WithMessage("soyad boş geçilemez.")
                .NotNull().WithMessage("soyad null olamaz.");
                
        }
    }
}
