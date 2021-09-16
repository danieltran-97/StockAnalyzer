using System;

namespace StockAnalyzer
{
    public class StockAnalyzer
    {
        private IStockFeed _stockFeed;

        public StockAnalyzer(IStockFeed feed) {
            _stockFeed = feed;
        }

        public int GetMyobPrice() {
            return _stockFeed.GetSharePrice("MYOB");
        }
    }
}