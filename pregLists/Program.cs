namespace pregLists
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1
            List<int> numbers = new List<int>();
            //2
            List<string> names = new List<string>();
            //3
            Console.WriteLine("Enter nums separated with space:");
            numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            Console.WriteLine("Enter names separated by space:");
            names = Console.ReadLine().Split().ToList();
            //4
            Console.WriteLine($"All numbers: {string.Join(' ',numbers)}");
            Console.WriteLine($"All names: {string.Join(' ', names)}");


        }
    }
}
