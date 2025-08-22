namespace Top_Interview_150.Array_String;

public class RomantoInteger
{
    //Dict Version (a Little bit slower)
    public int RomanToInt(string s)
    {
        var romanMap = new Dictionary<char, int>
        {
            {'I', 1},
            {'V', 5},
            {'X', 10},
            {'L', 50},
            {'C', 100},
            {'D', 500},
            {'M', 1000}
        };
        var total = 0;
        for (var i = 0; i < s.Length; i++)
        {
            var curr = romanMap[s[i]];

            if (i + 1 < s.Length && curr < romanMap[s[i + 1]])
                total -= curr;
            else
                total += curr;
        }

        return total;
    }
    //Switch Version
    private int ValueOf(char c) => c switch
    {
        'I' => 1,
        'V' => 5,
        'X' => 10,
        'L' => 50,
        'C' => 100,
        'D' => 500,
        'M' => 1000,
        _   => throw new ArgumentException("Invalid Roman numeral character")
    };

    public int RomanToIntSwitch(string s)
    {
        var total = 0;
        for (var i = 0; i < s.Length; i++)
        {
            var curr = ValueOf(s[i]);

            if (i + 1 < s.Length && curr < ValueOf(s[i + 1]))
                total -= curr;
            else
                total += curr;
        }

        return total;
    }
}