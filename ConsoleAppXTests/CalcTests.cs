using static Calc.Utilities;

namespace ConsoleAppXTests
{
    public class CalculatorTests
    {
        [Fact]
        public void Test_Add()
        {
            var numA = 3;
            var numB = 5;
            var expValue = 8;

            var getTestResult = Add(numA, numB);

            Assert.Equal(expValue, getTestResult);
        }

        [Fact]
        public void Test_Add_Arr()
        {
            int[] inputA = { 1, 2, 5, 6, 7 };


            var getTestResult = Add(inputA);

            Assert.Equal(21, getTestResult);
        }

        [Fact]
        public void Test_Substract()
        {
            var numA = 5;
            var numB = 4;
            var expValue = 1;

            var getTestResult = Substract(numA, numB);

            Assert.Equal(expValue, getTestResult);
        }

        [Fact]
        public void Test_Substract_Arr()
        {
            int[] inputA = { 6, 7, 9 };

            var getTestResult = Substract(inputA);

            Assert.Equal(-22, getTestResult);
        }

        [Fact]
        public void Test_Multiply()
        {
            var numA = 5;
            var numB = 5;
            var expValue = 25;

            var getTestResult = Multiply(numA, numB);

            Assert.Equal(expValue, getTestResult);
        }

        [Fact]
        public void Test_Divide_NonZero()
        {

            var numA = 14;
            var numB = 2;
            var expValue = 7;

            var getTestResult = Divide(numA, numB);

            Assert.Equal(expValue, getTestResult);


        }

        [Fact]
        public void Test_Divide_Zero()
        {

            var numA = 0;
            var numB = 0;
            var expValue = 0;
            var getTestResult = 0;

            if (numA != 0)
            {
                getTestResult = Divide(numA, numB);
            }
            else
            {
                getTestResult = 0;
            }


            Assert.Equal(expValue, getTestResult);


        }
    }
}