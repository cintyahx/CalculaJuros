using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace CalculaJuros.Service.External
{
    public class TaxaJurosService : ITaxaJurosService
    {
        private readonly string _urlJuros;
        private const string _endpointTaxaJuros = "taxaJuros";

        public TaxaJurosService(IConfiguration config)
        {
            _urlJuros = config.GetSection("UrlJuros").Value;
        }

        public async Task<decimal> GetLastInterestAsync()
        {
            using var httpClient = new HttpClient();
            var response = await httpClient.GetStringAsync(new Uri(_urlJuros + _endpointTaxaJuros));

            var lastInterest = JsonConvert.DeserializeObject<decimal>(response);

            return lastInterest;
        }
    }
}
