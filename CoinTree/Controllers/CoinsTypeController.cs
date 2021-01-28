using System.Collections.Generic;
using System.Web.Http;
using CoinTree.Models;

namespace CoinTree.Controllers
{
    public class CoinsTypeController : ApiController
    {
        CoinType[] coinTypes = new CoinType[]
            {
                new CoinType{CoinSymbol="BTC"},
                new CoinType{CoinSymbol="ETH"},
                new CoinType{CoinSymbol="XRP"},

            };

        public IEnumerable<CoinType> GetAllCoinType()
        {
            return coinTypes;
        }


    }
}
