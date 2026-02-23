namespace pregMasiv
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1
            int[] numbers = new int[5];
            //2
            string[] names = new string[13];
            //3
            Console.WriteLine("Enter 5 nums separated with a space:");
            numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            //4
            Console.WriteLine("Enter 13 names separated with a space");
            int max = 0; int inde = 0; string maxName = "";
            for (int i = 0; i < names.Length; i++)
            {
                Console.Write($"names[{i}] = ");
                names[i] = Console.ReadLine();
                if (names[i].Length > max)
                {
                    max = names[i].Length;
                    maxName = names[i];
                    inde = i;
                }
            }
            Console.WriteLine($"The longest name is {maxName} and it's in index {inde}");
            //5
            Console.WriteLine(string.Join(' ', numbers));
            Console.WriteLine(string.Join(' ', names));
            foreach (int item in numbers)
            {
                Console.WriteLine(item);
            }
            max = -327582356; int min = 238754623; int sum = 0;
            for (int j = 0; j < numbers.Length; j++)
            {
                if (numbers[j] < min)
                {
                    min = numbers[j];
                }
                if (numbers[j] > max)
                {
                    max = numbers[j];
                }
                sum += numbers[j];
            }
            Console.WriteLine($"min = {min}, max = {max}, avarage = {(double)sum/numbers.Length:f2}");
        }
    }
}
