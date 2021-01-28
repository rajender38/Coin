using System.Web.Http;
using CoinTree.Helpers;
using CoinTree.Interfaces;
using CoinTree.Models;

namespace CoinTree.Controllers
{
    public class PercentageChangeController : ApiController
    {
        ICoinTreeWebClient _coinTreeWebClient;
        ILoggerManager _loggerManager;
        public PercentageChangeController(ICoinTreeWebClient _coinTreeWebClient, ILoggerManager _loggerManager)
        {
            this._coinTreeWebClient = _coinTreeWebClient;
            this._loggerManager = _loggerManager;
        }

        public PriceDetails PostPercentageChange(ChangePercentageInput changePercentageInput)
        {
            try
            {
                CoinPriceDetails coinPriceDetails = _coinTreeWebClient.GetCoinDetails(changePercentageInput.CoinType);
                var changePercantage = ChangePercentageValue.GetValue(coinPriceDetails.Ask, changePercentageInput.OldPrice);
                return new PriceDetails()
                {
                    AskPrice = coinPriceDetails.Ask,
                    ChangePercentage = changePercantage,
                    Color = changePercantage < 0 ? "red" : "green"
                };
            }
            catch (System.Exception ex)
            {
                _loggerManager.LogError(ex.Message);
                throw;
            }
        }
    }
}
