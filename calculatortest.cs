using Xunit;

namespace Calculator
{
    public class CalculatorTest
    {
        [Fact]
        public void TestAdd()
        {
            // given
            Calculator calc = new Calculator();
            int a = 5;
            int b = 2;
            int expectedResult = 7;

            // when
            int result = calc.Add(a, b);

            // then
            Assert.Equal(expectedResult, result);
        }

        [Fact]
        public void TestSub()
        {
            // given
            Calculator calc = new Calculator();
            int a = 5;
            int b = 2;
            int expectedResult = 3;

            // when
            int result = calc.Sub(a, b);

            // then
            Assert.Equal(expectedResult, result);
        }

        [Fact]
        public void TestMulti()
        {
            // given
            Calculator calc = new Calculator();
            int a = 5;
            int b = 2;
            int expectedResult = 10;

            // when
            int result = calc.multi(a, b);

            // then
            Assert.Equal(expectedResult, result);
        }

        [Fact]
        public void TestDivi()
        {
            // given
            Calculator calc = new Calculator();
            int a = 6;
            int b = 2;
            int expectedResult = 3;

            // when
            int result = calc.divi(a, b);

            // then
            Assert.Equal(expectedResult, result);
        }
    }
}
