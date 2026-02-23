namespace find
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter names(END za krai):");
            List<string> names = new List<string>();
            string i = Console.ReadLine();
            while (i != "END")
            { 
                names.Add(i);
                i = Console.ReadLine();           
            }
            Console.WriteLine(string.Join(" ", names));
            if (names.Contains("Vanessa"))
            {
                Console.WriteLine("Vanessa is in the list");
            }
            else
            {
                Console.WriteLine("No Vanessa");
            }
        }
    }
}