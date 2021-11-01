using System;
using Moq;
using Xunit;

namespace StockAnalyzer
{
    public class StockAnalyzerTest
    {
        [Fact]
        public void TestStockAnalyzerReturnsStockPrice() {
            // IStockFeed stubStockFeed = new StubStockFeed();
            Mock<IStockFeed> stubStockFeed = new Mock<IStockFeed>();
            stubStockFeed.Setup(x => x.GetSharePrice(It.IsAny<string>())).Returns(100);
            
            StockAnalyzer itemUnderTest = new StockAnalyzer(stubStockFeed.Object);
            // StockAnalyzer itemUnderTest = new StockAnalyzer(stubStockFeed);

            Assert.Equal(100, itemUnderTest.GetMyobPrice());
        }
    }
}