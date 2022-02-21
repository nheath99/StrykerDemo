using Xunit;

namespace StrykerDemo.Tests
{
    public class TestClass
    {
        [Fact]
        public void CalculateValue_1()
        {
            // Arrange
            var a = true;
            var b = 69M;
            var c = 420M;

            // Act
            var result = ClassToBeTested.CalculateValue(a, b, c);

            // Assert
            Assert.Equal(b, result);
        }

        [Fact]
        public void CalculateValue_2()
        {
            // Arrange
            var a = false;
            var b = 69M;
            var c = 420M;

            // Act
            var result = ClassToBeTested.CalculateValue(a, b, c);

            // Assert
            Assert.Equal(c, result);
        }
    }
}