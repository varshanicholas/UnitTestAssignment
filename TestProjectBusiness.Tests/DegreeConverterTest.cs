using UnitTestAssignment;

namespace TestProjectBusiness.Tests
{
    [TestFixture]
    public class DegreeConverterTest
    {
        [Test]
        public void ToFahrenheit_ConvertZeroCelsius_Returns32Fahrenheit()
        {
            // Arrange
            double celsius = 0;

            // Act
            double result = DegreeConverter.ToFahrenheit(celsius);

            // Assert
            Assert.AreEqual(32, result, 0.001);
        }

        [Test]
        public void ToCelsius_Convert32Fahrenheit_ReturnsZeroCelsius()
        {
            // Arrange
            double fahrenheit = 32;

            // Act
            double result = DegreeConverter.ToCelsius(fahrenheit);

            // Assert
            Assert.AreEqual(0, result, 0.001);
        }

        [TestCase(100, 212)] // Boiling point of water
        [TestCase(-40, -40)] // Same temperature in Celsius and Fahrenheit
        [TestCase(37, 98.6)] // Normal body temperature
        public void ToFahrenheit_ConvertCelsius_ReturnsExpectedValue(double celsius, double expectedFahrenheit)
        {
            // Act
            double result = DegreeConverter.ToFahrenheit(celsius);

            // Assert
            Assert.AreEqual(expectedFahrenheit, result, 0.001);
        }

        [TestCase(212, 100)] // Boiling point of water
        [TestCase(-40, -40)] // Same temperature in Celsius and Fahrenheit
        [TestCase(98.6, 37)] // Normal body temperature
        public void ToCelsius_ConvertFahrenheit_ReturnsExpectedValue(double fahrenheit, double expectedCelsius)
        {
            // Act
            double result = DegreeConverter.ToCelsius(fahrenheit);

            // Assert
            Assert.AreEqual(expectedCelsius, result, 0.001);
        }
    }
}