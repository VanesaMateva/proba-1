namespace rabotenList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> nums = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> evenNums = new List<int>();
            List<int> negNums = new List<int>();
            for (int i = 0; i < nums.Count; i++)
            {
                if (nums[i] % 2 == 0)
                {
                    evenNums.Add(nums[i]);
                }
                else if (nums[i] < 0)
                {
                    negNums.Add(nums[i]);
                }
            }
            Console.WriteLine(string.Join(", ", nums));
            Console.WriteLine($"All even nums: {string.Join(", ", evenNums)}");
            Console.WriteLine($"All negative nums: {string.Join(", ", negNums)}");
        }
    }
}
