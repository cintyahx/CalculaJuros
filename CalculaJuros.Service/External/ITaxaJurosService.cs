using System.Threading.Tasks;

namespace CalculaJuros.Service.External
{
    public interface ITaxaJurosService
    {
        Task<decimal> GetLastInterestAsync();
    }
}
