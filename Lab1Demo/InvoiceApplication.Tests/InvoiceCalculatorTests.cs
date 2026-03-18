using FluentAssertions;
using InvoiceApplication.BusinessLogic;

namespace InvoiceApplication.Tests;

public class InvoiceCalculatorTests
{
    [Fact]
    public void GroupByCategory_should_work_fine() //I was lazy to invent better name now
    {
        var invoiceCalculator = new InvoiceCalculator();

        string[] invoicesLines =
        [
            "Product;Amount;Category;Date",
            "Tablet;100,01;Gaming;2024-04-23",
            "Smartwatch;200,02;Electronics;2024-12-18",
            "Mouse;300,03;Accessories;2024-05-08",
            "Keyboard;400,04;Accessories;2024-11-30"
        ];

        var result = invoiceCalculator.GroupByCategory(invoicesLines);

        result.Should().HaveCount(3);
        result.First().Key.Should().Be("Gaming");
        result.Skip(1).First().Key.Should().Be("Electronics");
        result.Skip(2).First().Key.Should().Be("Accessories");

        result.First().Value.Should().Be(100.01M);
        result.Skip(1).First().Value.Should().Be(200.02M);
        result.Skip(2).First().Value.Should().Be(700.07M);
    }
}