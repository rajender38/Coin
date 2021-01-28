using CoinTree.Interfaces;
using CoinTree.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;


namespace webApi.Controllers
{
    [RoutePrefix("api/CoinDetails")]
    public class CoinDetailsController : ApiController
    {
        ICoinTreeWebClient _coinTreeWebClient;
        ILoggerManager _loggerManager;
        public CoinDetailsController(ICoinTreeWebClient _coinTreeWebClient, ILoggerManager _loggerManager)
        {
            this._coinTreeWebClient = _coinTreeWebClient;
            this._loggerManager = _loggerManager;
        }

        [Route("{coinType}")]
        public CoinPriceDetails GetCoinDetails(string coinType)
        {
            try
            {
                var coinPriceDetails = _coinTreeWebClient.GetCoinDetails(coinType);
                return coinPriceDetails;
            }
            catch (Exception ex)
            {
                _loggerManager.LogError(ex.Message);
                throw;
            }
            
        }
    }
}
