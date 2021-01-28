using System;
using System.Net;
using Newtonsoft.Json;
using CoinTree.Interfaces;
using CoinTree.Models;

namespace CoinTree.Helpers
{
    public class CoinTreeWebClient : ICoinTreeWebClient
    {
        public CoinPriceDetails GetCoinDetails(string coinsymbol)
        {
            try
            {
                //string url = string.Format(Convert.ToString(ConfigurationManager.AppSettings["CoinTreeWebApi"]), coinsymbol);
                using (var client = new WebClient())
                {
                    client.Headers.Add("content-type", "application/json");
                    //string response = client.DownloadString(url);
                    string response = "{\"sell\": \"AUD\",     \"buy\": \"BTC\",     \"ask\": 41787.6087,     \"bid\": 40656.4389,     \"rate\": 0.00002393,     \"spotRate\": 41222.0238,     \"market\": \"AUD\",     \"timestamp\": \"2021-01-27T05:09:12.6288209+00:00\",     \"rateType\": \"Ask\",    \"rateSteps\": null}";
                    CoinPriceDetails deserializedProduct = JsonConvert.DeserializeObject<CoinPriceDetails>(response);
                    return deserializedProduct;
                }
            }
            catch (Exception ex)
            {

                throw;
            }
        }
    }
}