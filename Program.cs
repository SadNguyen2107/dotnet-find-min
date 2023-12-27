namespace MyProgram
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int[] arr = { -99, 12, 7, 8, 1, 6, 9 };
            int index = FindMinIndex(arr);
            Console.WriteLine("The smallest element in the array is: " + arr[index]);
        }

        public static Int32 FindMinIndex(Int32[] nums)
        {
            Int32 min_value = nums[0];
            Int32 min_index = 0;

            for (int index = 1; index < nums.Length; index++)
            {
                if (nums[index] < min_value)
                {
                    min_value = nums[index];
                    min_index = index;
                }
            }

            return min_index;
        }
    }
}