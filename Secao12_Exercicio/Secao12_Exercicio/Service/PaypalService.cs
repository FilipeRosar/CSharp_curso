using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Secao12_Exercicio.Service
{
    class PaypalService : IOnlinePaymentService
    {
        private const double mouthlyInterest = 0.01;
        private const double feePaymant = 0.02;
        public double Interest(double amount, int mounths)
        {
            return amount * mouthlyInterest * mounths;
        }

        public double PaymentFee(double amount)
        {
            return amount * feePaymant;
        }
    }
}
