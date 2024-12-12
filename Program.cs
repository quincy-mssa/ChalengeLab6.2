namespace ChalengeLab6._2
{//Given an array nums containing n distinct numbers in the range [0, n], return the only number in the range that is missing from the array.
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { 3, 0, 1 };

            int missingNumber = FindMissingNumber(nums);

            Console.WriteLine($"The missing number is:  {missingNumber}");
        }

        static int FindMissingNumber(int[] nums)
        {
            //array length
            int n = nums.Length;

            //calculate the sum of all numbers from 0 to n
            int totalSum = 0;
            for (int i = 0; i <= n; i++) // Add all numbers from 0 to n
            {
                totalSum += i;
            }

            //calculate the sum of the numbers in the array
            int actualSum = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                actualSum += nums[i];
            }

            //the missing number is the difference between the totalSum and actualSum
            return totalSum - actualSum;
        }

    }
}
