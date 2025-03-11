namespace InvoiceApplication.BusinessLogic;

public class InvoiceProcessor
{
    public Dictionary<string, decimal> GroupByCategory(string[] lines) => lines
            .Skip(1)
            .Select(x => x.Split(";"))
            .GroupBy(x => x[2])
            .ToDictionary(x => x.Key, x => x.Sum(y => decimal.Parse(y[1])));
}