namespace Top_Interview_150.Array_String;

public class FindIndexFirstOccur
{
   public int StrStr(string haystack, string needle) 
   {
      int m = haystack.Length, n = needle.Length;
      if (n > m)
         return -1;

      for (int i = 0; i <= m - n; i++)
      {
         int j = 0;
         while (j < n && haystack[i + j] == needle[j])
            j++;
         if (j == n) return i;
      }

      return -1;
   }
}