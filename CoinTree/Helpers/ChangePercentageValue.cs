using System;

namespace CoinTree.Helpers
{
    public static class ChangePercentageValue
    {

        public static double GetValue(double oldPrice, double newPrice)
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