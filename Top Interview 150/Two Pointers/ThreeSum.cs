namespace Top_Interview_150.Two_Pointers;

public class ThreeSum
{
    public IList<IList<int>> Three_Sum(int[] nums)
    {
        var result = new List<IList<int>>();
        if (nums == null || nums.Length < 3) return result;

        Array.Sort(nums);
        var n = nums.Length;

        for (var i = 0; i < n - 2; i++) {
            if (i > 0 && nums[i] == nums[i - 1]) continue;

            var left = i + 1;
            var right = n - 1;

            while (left < right)
            {
                var sum = nums[i] + nums[left] + nums[right];

                switch (sum)
                {
                    case < 0:
                        left++;
                        break;
                    case > 0:
                        right--;
                        break;
                    default:
                    {
                        result.Add(new List<int> { nums[i], nums[left], nums[right] });

                        left++;
                        right--;

                        while (left < right && nums[left] == nums[left - 1]) left++;
                        while (left < right && nums[right] == nums[right + 1]) right--;
                        break;
                    }
                }
            }
        }

        return result;
    }
}