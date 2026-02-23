namespace masiv
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a niz of strings:");
            int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Console.Write("Enter the number reds: ");
            int n = int.Parse(Console.ReadLine());
            for (int k = 0;k < n; k++)
            {
                Console.Write("Enter the command you want(Reverse/Distinct/Replace): ");
                string kmd = Console.ReadLine();
                if (kmd == "Reverse")
                {
                    Array.Reverse(arr);
                    Console.WriteLine(string.Join(", ", arr));
                }
                else if (kmd == "Distinct")
                {
                    List<int> dist = arr.Distinct().ToList();
                    Console.WriteLine(string.Join(", ", dist));
                }
                else if (kmd == "Replace")
                {                    
                    Console.Write("Enter index: ");
                    int index = int.Parse(Console.ReadLine());
                    Console.Write("You wanna replace it with? - ");
                    arr[index] = int.Parse(Console.ReadLine());
                    Console.WriteLine(string.Join(", ", arr));
                }
            }
        }
    }
}
