using System;
using Xunit;

namespace StockAnalyzer
{
    public class StockAnalyzerTest
    {
        [Fact]
        public void TestStockAnalyzerReturnsStockPrice() {
            IStockFeed stubStockFeed = new StubStockFeed();
            StockAnalyzer itemUnderTest = new StockAnalyzer(stubStockFeed);

            Assert.Equal(100, itemUnderTest.GetMyobPrice());
        }
    }
}