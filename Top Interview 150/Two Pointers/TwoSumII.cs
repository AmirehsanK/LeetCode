namespace Top_Interview_150.Two_Pointers;

public class TwoSumIi
{
    public int[] TwoSum(int[] numbers, int target)
    {
        int l = 0;
        int r= numbers.Length-1;

        while (l < r)
        {
            int sum = numbers[l] + numbers[r];
            if (sum == target)
                return [l + 1, r + 1];
            if (sum < target)
                l++;
            else if (sum > target)
                r--;
        }
        
        return [];
    }
}
