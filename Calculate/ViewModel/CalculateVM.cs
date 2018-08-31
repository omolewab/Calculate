using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Calculate.ViewModel
{
    public class CalculateVM
    {
        [Required]
        public double FirstNumber { get; set; }

        [Required]
        public double SecondNumber { get; set; }

        [Required]
        public string Operator { get; set; }

        public List<SelectListItem> OperatorsList { get; set; }

    }
}
