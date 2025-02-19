using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Secao12_Exercicio.Entities
{
    class Installment
    {
        public Installment()
        {
        }

        public DateTime DueDate{ get; set; }
        public double Amount { get; set; }

        public Installment(DateTime dueDate, double amount)
        {
            DueDate = dueDate;
            Amount = amount;
        }
        public override string ToString()
        {
            return $"{DueDate:dd/MM/yyyy} - {Amount.ToString("F2",CultureInfo.InvariantCulture)}";
        }
    }
}
