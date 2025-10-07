using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinnessLayer.FluentValidation
{

    public class ProductValidator : AbstractValidator<Product>
    {
        public ProductValidator()
        {
            RuleFor(x=>x.Name).NotEmpty().WithMessage("Ürün ismi boş geçilemez");
            RuleFor(x => x.Name).MinimumLength(3).WithMessage("Ürün ismi en az 3 karakter olmalı");
            RuleFor(RuleFor => RuleFor.Price).NotEmpty().WithMessage("Fiyat boş geçilemez");
            RuleFor(RuleFor => RuleFor.Price).GreaterThan(0).WithMessage("Fiyat 0'dan büyük olmalı");
            RuleFor(RuleFor => RuleFor.Stock).NotEmpty().WithMessage("Stok boş geçilemez");
            RuleFor(RuleFor => RuleFor.Stock).GreaterThan(0).WithMessage("Stok 0'dan büyük olmalı");

        }
    }
}
