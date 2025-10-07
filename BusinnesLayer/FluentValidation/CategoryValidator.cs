using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinnessLayer.FluentValidation
{
    public class CategoryValidator : AbstractValidator<Category>
    {
        public CategoryValidator()
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage("Kategori ismi boş geçilemez");
            RuleFor(x => x.Name).MinimumLength(3).WithMessage("Kategori ismi en az 3 karakter olmalı");
        }
    }
}
