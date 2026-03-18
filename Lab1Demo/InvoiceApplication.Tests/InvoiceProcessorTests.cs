using FluentAssertions;
using InvoiceApplication.BusinessLogic;

namespace InvoiceApplication.Tests;

public class InvoiceProcessorTests
{
    [Fact]
    public void GroupByCategory_should_return_proper_result_for_a_given_input()
    {
        // Arrange
        string[] lines =
        [
            "Product;Amount;Category;Date",
            "Tablet;100;Gaming;2024-04-23",
            "Smartwatch;200,50;Electronics;2024-12-18",
            "Mouse;50,50;Accessories;2024-05-08",
            "Keyboard;49,50;Accessories;2024-11-30"
        ];

        var processor = new InvoiceProcessor();

        // Act
        var result = processor.GroupByCategory(lines);

        // Assert
        result.Should().HaveCount(3);
        result.First().Key.Should().Be("Gaming");
        result.Skip(1).First().Key.Should().Be("Electronics");
        result.Skip(2).First().Key.Should().Be("Accessories");

        result.First().Value.Should().Be(100);
        result.Skip(1).First().Value.Should().Be(200.5M);
        result.Skip(2).First().Value.Should().Be(100);
    }
}