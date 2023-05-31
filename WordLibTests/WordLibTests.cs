namespace WordLibTests
{
    public class WordLibTests
    {
        [Fact]
        public void IsPalindrome_ValidPalindrome_ReturnsTrue()
        {
            // Arrange
            var word = "radar";

            // Act
            var result = WordLib.WordLib.IsPalindrome(word);

            // Assert
            Assert.True(result);
        }

        [Fact]
        public void IsPalindrome_EmptyString_ThrowsArgumentException()
        {
            // Arrange
            var word = "";

            // Act & Assert
            Assert.Throws<ArgumentException>(() => WordLib.WordLib.IsPalindrome(word));
        }

        [Fact]
        public void IsPalindrome_SingleCharacter_ReturnsTrue()
        {
            // Arrange
            var word = "a";

            // Act
            var result = WordLib.WordLib.IsPalindrome(word);

            // Assert
            Assert.True(result);
        }

        [Fact]
        public void IsPalindrome_NonPalindrome_ReturnsFalse()
        {
            // Arrange
            var word = "hello";

            // Act
            var result = WordLib.WordLib.IsPalindrome(word);

            // Assert
            Assert.False(result);
        }

        [Fact]
        public void IsPalindrome_CaseInsensitivePalindrome_ReturnsTrue()
        {
            // Arrange
            var word = "RaceCar";

            // Act
            var result = WordLib.WordLib.IsPalindrome(word);

            // Assert
            Assert.True(result);
        }

        [Fact]
        public void IsPalindrome_LongPalindrome_ReturnsTrue()
        {
            // Arrange
            var word = "deified";

            // Act
            var result = WordLib.WordLib.IsPalindrome(word);

            // Assert
            Assert.True(result);
        }
    }
}