namespace Top_Interview_150.Array_String;

public class MajorityElementO1
{
    public int MajorityElement(int[] nums)
    {
        int candidate = 0, count = 0;
        foreach (var num in nums)
        {
            if (count == 0)
            {
                candidate = num;
                count++;
            }
            else if(candidate==num)
            {
                count++;
            }
            else
            {
                count--;
            }
        }
        
        return candidate;
    }
}
/*Boyer–Moore implementation*/