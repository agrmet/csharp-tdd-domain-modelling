using NUnit.Framework;
using tdd_domain_modelling.CSharp.Main;

namespace tdd_domain_modelling.CSharp.Test
{
    public class BasketTests
    {
        [Test]
        public void AddTest()
        {
            // arrange
            Basket basket = new();
            string product = "Pear";
            int price = 10;
            // act
            var result = basket.Add(product, price);
            // assert
            Assert.True(result);
        }
    }
}
