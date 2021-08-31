using Entities.Concreate;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.ValidationRules.FluentValidation
{
    public class CustomerValidator:AbstractValidator<Customer>
    {
        public CustomerValidator()
        {
            RuleFor(cst => cst.CompanyName).Must(StartWithA).WithMessage("Kampanya ismi A harfi ile başlamalı");
            RuleFor(cst => cst.CompanyName).MaximumLength(2);
        }

        private bool StartWithA(string arg)
        {
            return arg.StartsWith("A");
        }
    }
}
