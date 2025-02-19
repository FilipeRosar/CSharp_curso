
using Secao12_Exercicio.Entities;

namespace Secao12_Exercicio.Service
{
    class ContractService
    {
        private IOnlinePaymentService _onlinePaymentService;

        public ContractService(IOnlinePaymentService onlinePaymentService)
        {
            _onlinePaymentService = onlinePaymentService;
        }

        public void ProcessContract(Contract contract, int mounths)
        {
            double basicAliquota = contract.TotalValue / mounths;

            for (int i = 1; i <= mounths; i++)
            {
                DateTime date = contract.Date.AddMonths(i);
                double updatedAliquota = basicAliquota + _onlinePaymentService.Interest(basicAliquota, i);
                double totalAliquota = updatedAliquota + _onlinePaymentService.PaymentFee(updatedAliquota);
                contract.AddInstallment(new Installment(date, totalAliquota));
            }
        }
    }
}
