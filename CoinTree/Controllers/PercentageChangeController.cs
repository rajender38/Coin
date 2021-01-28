using System.Web.Http;
using CoinTree.Helpers;
using CoinTree.Interfaces;
using CoinTree.Models;

namespace CoinTree.Controllers
{
    public class PercentageChangeController : ApiController
    {
        ILoggerManager _loggerManager;
        public PercentageChangeController( ILoggerManager _loggerManager)
        {
            this._loggerManager = _loggerManager;
        }

        public PriceDetails PostPercentageChange(ChangePercentageInput changePercentageInput)
        {
            try
            {
               
                var changePercantage = ChangePercentageValue.GetValue(changePercentageInput.AskPrice, changePercentageInput.PreviousAskPrice);
                return new PriceDetails()
                {
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
