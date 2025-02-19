using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Secao12_01.Entities
{
    class Vehicle
    {
        [Required(ErrorMessage = "O modelo é obrigatorio.")]
        public string Model { get; set; }

        public Vehicle(string model)
        {
            Model = model;
        }
    }
}
