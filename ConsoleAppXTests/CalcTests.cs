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
            var numA = 0;
            var expValue = 0;
            var numB = 5;

            foreach (int i in inputA)
            {
                numA = i;
                expValue = i + numB;
            }


            var getTestResult = Add(numA, numB);

            Assert.Equal(expValue, getTestResult);
        }

        [Fact]
        public void Test_Subtract()
        {
            var numA = 5;
            var numB = 4;
            var expValue = 1;

            var getTestResult = Subtract(numA, numB);

            Assert.Equal(expValue, getTestResult);
        }

        [Fact]
        public void Test_Subtract_Arr()
        {
            int[] inputA = { 6, 7, 9 };
            var numA = 0;
            var expValue = 2;
            var numB = 5;

            foreach (int i in inputA)
            {
                numA = i;
                expValue = i - numB;
            }


            var getTestResult = Subtract(numA, numB);

            Assert.Equal(expValue, getTestResult);
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