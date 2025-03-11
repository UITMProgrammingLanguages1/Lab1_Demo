namespace InvoiceApplication.BusinessLogic;

public class InvoiceProcessor
{
    public Dictionary<string, decimal> GroupByCategory(string[] lines)
    {
        var entries = new Dictionary<string, decimal>();

        for (int i = 1; i < lines.Length; i++)
        {
            var line = lines[i];

            var split = line.Split(";");

            var category = split[2];
            var price = decimal.Parse(split[1]);

            if (entries.ContainsKey(category))
            {
                entries[category] += price;
            }
            else
            {
                entries[category] = price;
            }
        }

        return entries;
    }
}