using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinnessLayer.FluentValidation
{
    public class CustomerValidator : AbstractValidator<Customer>
    {
        public CustomerValidator()
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage("Müşteri ismi boş geçilemez");
            RuleFor(x => x.Name).MinimumLength(3).WithMessage("Müşteri ismi en az 3 karakter olmalı");
            RuleFor(x => x.City).NotEmpty().WithMessage("Şehir boş geçilemez");
            RuleFor(x => x.City).MinimumLength(2).WithMessage("Şehir ismi en az 2 karakter olmalı");
          
        }
    }
}
