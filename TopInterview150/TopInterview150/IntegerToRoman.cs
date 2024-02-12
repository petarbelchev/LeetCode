using System.Text;

namespace TopInterview150;

internal class IntegerToRoman
{
    readonly IEnumerable<(int Value, string Number)> _romanNumbers = new[]
    {
        (1000, "M"),
        (900, "CM"),
        (500, "D"),
        (400, "CD"),
        (100, "C"),
        (90, "XC"),
        (50, "L"),
        (40, "XL"),
        (10, "X"),
        (9, "IX"),
        (5, "V"),
        (4, "IV"),
        (1, "I")
    };

    public string IntToRoman(int num)
    {
        var sb = new StringBuilder();

        while (num > 0)
        {
            var (Value, Number) = _romanNumbers.First(n => n.Value <= num);
            num -= Value;
            sb.Append(Number);
        }

        return sb.ToString();
    }
}
