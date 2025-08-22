namespace Top_Interview_150.Array_String;

public class RemoveElement
{
    public int RemoveElements(int[] nums, int val) {
        int writeIndex = 0;

        for (int i = 0; i < nums.Length; i++) {
            if (nums[i] != val) {
                nums[writeIndex] = nums[i];
                writeIndex++;
            }
        }

        for (int i = writeIndex; i < nums.Length; i++) {
            nums[i] = -1;
        }

        return writeIndex;
    }
}