using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ArnaudWeil2022.ViewModels.Home
{
    public class ComputeProductViewModel
    {
        public ComputeProductViewModel(decimal? number1, decimal? number2)
        {
            Number1 = number1 ?? 0;
            Number2 = number2 ?? 0;
            Result = Number1 * Number2;
        }

        public decimal Number1 { get; private set; }
        public decimal Number2 { get; private set; }
        public decimal Result { get; set; }
    }
}