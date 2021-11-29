using System.Threading.Tasks;

namespace CalculaJuros.Service
{
    public interface ICalculaJurosService
    {
        Task<decimal> CalculateInterest(decimal startValue, int months);
    }
}
