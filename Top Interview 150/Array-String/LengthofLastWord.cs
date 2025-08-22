namespace Top_Interview_150.Array_String;

public class LengthofLastWord
{
    public int LengthOfLastWord(string s)
    {
        var i = s.Length - 1;
        var count = 0;

        while (i >= 0)
        {
            if (s[i] != ' ')
            {
                count++;
            }
            else if (count > 0)
            {
                break; 
            }
            i--;
        }
        return count;
    }
}
//Reverse looping