namespace Top_Interview_150.Array_String;

public class ValidPalindrome
{
    public bool IsPalindrome(string s)
    {
        var newStr = new string(
            s.Where(char.IsLetterOrDigit)
                .Select(char.ToLowerInvariant)
                .ToArray()
        );
        
        var l = 0;
        var r = newStr.Length-1;
        
        while (l < r)
        {
            if (newStr[l] == newStr[r])
            {
                l++;
                r--;
            }
            else
            {
                return false;
            }
        }
        
        return true;
    }
}