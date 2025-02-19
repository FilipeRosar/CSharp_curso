using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Secao10_Exercicio.Entities.Exception
{
    class DomainException(string message) : ApplicationException(message)
    {
    }
}
