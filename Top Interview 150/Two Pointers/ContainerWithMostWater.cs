namespace Top_Interview_150.Two_Pointers;

public class ContainerWithMostWater
{
    //O(n²)
    public int MaxArea(int[] height)
    {
        int maxArea = 0;

        for (var i = 0; i < height.Length-1; i++)
        {
            for (var j = i+1; j < height.Length; j++)
            {
                var currentArea = Math.Min(height[i], height[j])*(j-i);
                if(currentArea>maxArea)
                    maxArea = currentArea;
            }
        }

        return maxArea;
    }
    //O(n)
    public int MaxArea2(int[] height)
    {
        int left = 0, right = height.Length - 1;
        var maxArea = 0;

        while (left < right)
        {
            var h = Math.Min(height[left], height[right]);
            var w = right - left;
            var area = h * w;
            if (area > maxArea) maxArea = area;

            if (height[left] < height[right]) left++;
            else right--;
        }

        return maxArea;
    }

}