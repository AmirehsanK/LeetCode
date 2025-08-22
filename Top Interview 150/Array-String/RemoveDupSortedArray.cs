namespace Top_Interview_150.Array_String;

public class RemoveDupSortedArray
{
    public static int RemoveDuplicates(int[] nums)
    {
        var writer = 0;
        if(nums.Length == 0)
            return writer;
        for (int reader = 1; reader < nums.Length; reader++)
        {
            if (nums[reader] != nums[writer])
            {
                writer++;
                nums[writer] = nums[reader];

            }
        }
        return writer+1;
    }
}
/*Two Pointers used to solve this problem*/