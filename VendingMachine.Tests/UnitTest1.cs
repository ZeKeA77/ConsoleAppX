namespace VendingMachine
{

    public class UnitTest1
    {

        [Fact]
        public void DepositMoneyTest()
        {
            VendingMachine util = new VendingMachine();
            CoinBox coinbox = new CoinBox();
            // — Arrange
            int expValue = 150;

            // — Act
            coinbox.MoneyDeposited(100);
            coinbox.MoneyDeposited(50);

            // — Assert
            Assert.Equal(expValue, coinbox.AvailableFunds);
        }

        [Fact]
        public void ExtractMoneyTest()
        {
            VendingMachine util = new VendingMachine();
            CoinBox coinbox = new CoinBox();
            // — Arrange
            int expValue = 85;

            // — Act
            coinbox.MoneyDeposited(100);

            // Simulate buying Cola
            coinbox.AvailableFunds -= util.ProductList[0].Price;

            // — Assert
            Assert.Equal(expValue, coinbox.AvailableFunds);
        }

        [Fact]
        public void CreateRemoveProductsList()
        {
            VendingMachine util = new VendingMachine();
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
            VendingMachine util = new VendingMachine();
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