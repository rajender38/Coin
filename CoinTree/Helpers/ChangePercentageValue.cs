using System;

namespace CoinTree.Helpers
{
    public static class ChangePercentageValue
    {

        public static decimal GetValue(decimal oldPrice, decimal newPrice)
        {
            try
            {
                return ((newPrice - oldPrice) / oldPrice) * 100;
            }
            catch (Exception ex)
            {

                throw;
            }
           
        }

    }
}