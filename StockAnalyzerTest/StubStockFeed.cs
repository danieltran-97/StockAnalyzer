namespace StockAnalyzer
{
    public class StubStockFeed: IStockFeed
    {
        public int GetSharePrice(string company) {
            return 100;
        }
    }
}