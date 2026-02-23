namespace povtarqneNaVsekiEl
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter numbers separated with a space:");
            int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            byte count = 1;
            byte maxCount = 0;
            int maxEl = 0;
            for (int i = 0;  i < numbers.Length - 1; i++)
            {
                for (int j = i + 1; j < numbers.Length; j++)
                {
                    if (numbers[i] == numbers[j])
                    {
                        count++;
                    }
                }
                if (count > maxCount)
                {
                    maxCount = count;
                    maxEl = numbers[i];
                }
                count = 1;
            }
            Console.WriteLine($"{maxEl} was repeated {maxCount} time(s)");
        }
    }
}