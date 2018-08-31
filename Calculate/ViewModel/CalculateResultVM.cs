using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Calculate.ViewModel
{
    public class CalculateResultVM
    {
        [Required]
        public string Operator { get; set; }

        [Required]
        public double Result { get; set; }

    }
}
