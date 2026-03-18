namespace StringCalculator;

public class Calculator
{
    public string Add(string first, string second)
    {
        return $"{first}{second}";
    }

    public string Subtract(string first, string second)
    {
        if (string.IsNullOrWhiteSpace(first))
            return string.Empty;

        if (string.IsNullOrWhiteSpace(second))
            return first;

        return new string(first.Where(x => !second.Contains(x)).ToArray());
    }

    public string Multiply(string first, int repetition)
    {
        return "";
    }
}