using CalculaJuros.Service.External;
using System;
using System.Threading.Tasks;

namespace CalculaJuros.Service
{
    public class CalculaJurosService : ICalculaJurosService
    {
        private ITaxaJurosService _taxaJurosService;

        public CalculaJurosService(ITaxaJurosService taxaJurosService)
        {
            _taxaJurosService = taxaJurosService;
        }

        public async Task<decimal> CalculateInterest(decimal startValue, int months)
        {
            var interest = await _taxaJurosService.GetLastInterestAsync();

            var finalValue = Math.Pow(Convert.ToDouble(startValue * (1M + interest)), months);

            return Decimal.Round(Convert.ToDecimal(finalValue), 2);        
        }
    }
}
