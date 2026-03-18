using FluentAssertions;
using StringCalculator;

namespace StringCalculatorTests;

public class CalculatorTests   //DRY does not apply for unit tests.
{
    [Fact]
    public void Add_properly_adds_two_strings()
    {
        // Arrange 
        var calculator = new Calculator();

        // Act
        var result = calculator.Add("Marcin", "Jagieła");

        // Assert
        result.Should().Be("MarcinJagieła");
    }

    [Fact]
    public void Add_properly_adds_two_strings_when_first_of_them_is_null()
    {
        // Arrange 
        var calculator = new Calculator();

        // Act
        var result = calculator.Add(null, "Jagieła");

        // Assert
        result.Should().Be("Jagieła");
    }

    [Fact]
    public void Add_properly_adds_two_strings_when_second_of_them_is_null()
    {
        // Arrange 
        var calculator = new Calculator();

        // Act
        var result = calculator.Add("Marcin", null);

        // Assert
        result.Should().Be("Marcin");
    }

    [Fact]
    public void Subtract_properly_subtracts_two_strings()
    {
        // Arrange 
        var calculator = new Calculator();

        // Act
        var result = calculator.Subtract("Marcin", "Mariusz");

        // Assert
        result.Should().Be("cn");
    }

    [Fact]
    public void Subtract_does_nothing_if_second_string_is_null()
    {
        // Arrange 
        var calculator = new Calculator();

        // Act
        var result = calculator.Subtract("Marcin", null);

        // Assert
        result.Should().Be("Marcin");
    }

    [Fact]
    public void Subtract_returns_empty_string_if_the_first_string_is_null()
    {
        // Arrange 
        var calculator = new Calculator();

        // Act
        var result = calculator.Subtract(null, "SomeString");

        // Assert
        result.Should().Be(string.Empty);
    }
}