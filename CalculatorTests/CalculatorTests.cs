using TestProject;

namespace CalculatorTests
{
    public class CalculatorTests
    {
        //comment added for testing
        private readonly Calculator _calculator;

        // Constructor to initialize the Calculator class
        public CalculatorTests()
        {
            _calculator = new Calculator();
        }

        [Fact]
        public void Add_ShouldReturnCorrectSum()
        {
            // Arrange
            double num1 = 10;
            double num2 = 5;

            // Act
            double result = _calculator.Add(num1, num2);

            // Assert
            Assert.Equal(15, result);
        }

        [Fact]
        public void Subtract_ShouldReturnCorrectDifference()
        {
            // Arrange
            double num1 = 4;
            double num2 = 5;

            // Act
            double result = _calculator.Subtract(num1, num2);

            // Assert
            Assert.Equal(5, result);
        }

        [Fact]
        public void Multiply_ShouldReturnCorrectProduct()
        {
            // Arrange
            double num1 = 10;
            double num2 = 5;

            // Act
            double result = _calculator.Multiply(num1, num2);

            // Assert
            Assert.Equal(50, result);
        }

        [Fact]
        public void Divide_ShouldReturnCorrectQuotient()
        {
            // Arrange
            double num1 = 10;
            double num2 = 5;

            // Act
            double result = _calculator.Divide(num1, num2);

            // Assert
            Assert.Equal(2, result);
        }

        [Fact]
        public void Divide_ByZero_ShouldReturnNaN()
        {
            // Arrange
            double num1 = 10;
            double num2 = 0;

            // Act
            double result = _calculator.Divide(num1, num2);

            // Assert
            Assert.True(double.IsNaN(result));
        }
    }
}
