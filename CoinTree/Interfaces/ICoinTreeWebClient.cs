
using CoinTree.Models;

namespace CoinTree.Interfaces
{
    public interface ICoinTreeWebClient
    {
        CoinPriceDetails GetCoinDetails(string coinType);
    }
}
