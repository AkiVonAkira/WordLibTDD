using WordLib;

namespace WordLibTests
{
    public class MyMathTests
    {
        [Theory]
        [InlineData(2)]
        [InlineData(4)]
        [InlineData(6)]
        public void IsEven_EvenNumbers_ReturnsTrue(int number)
        {
            // Act
            var result = MyMath.IsEven(number);

            // Assert
            Assert.True(result);
        }

        [Theory]
        [InlineData(1)]
        [InlineData(3)]
        [InlineData(5)]
        public void IsOdd_OddNumbers_ReturnsTrue(int number)
        {
            // Act
            var result = MyMath.IsOdd(number);

            // Assert
            Assert.True(result);
        }
    }
}
