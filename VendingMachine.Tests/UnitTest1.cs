namespace VendingMachine
{

    public class UnitTest1
    {

        CoinBox coinbox = new CoinBox();
        VendingMachine util = new VendingMachine();

        [Fact]
        public void DepositMoneyTest()
        {
            // — Arrange
            int expValue = 150;

            // — Act
            coinbox.MoneyDeposited(100);
            coinbox.MoneyDeposited(50);

            // — Assert
            Assert.Equal(expValue, coinbox.AvailableFunds);
        }

        [Fact]
        public void CreateRemoveProductsList()
        {
            // — Arrange
            int expValue = 7;

            // — Act
            util.RemoveFromProductList(4);
            util.RemoveFromProductList(2);


            // — Assert
            Assert.Equal(expValue, util.ProductList.Count);
        }

        [Fact]
        public void CreateProduct()
        {
            // — Arrange
            int expValue = 10;

            // — Act
            Drinks drink2 = new Drinks("Drink", "Fanta", "Smakar apelsin", 12);
            util.ProductList.Add(drink2);

            // — Assert
            Assert.Equal(expValue, util.ProductList.Count);
        }

    }
}