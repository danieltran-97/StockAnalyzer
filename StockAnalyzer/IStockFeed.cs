namespace StockAnalyzer
{
    public interface IStockFeed
    {
        int GetSharePrice(string company);
    }
}