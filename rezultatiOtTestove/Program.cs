namespace rezultatiOtTestove
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your grades(1-100):");
            int[] grades = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int sum = 0; int highest = 0; int lowest = 100;
            for (int i = 0; i < grades.Length; i++)
            {
                sum += grades[i];
                if (grades[i] > highest)
                {
                    highest = grades[i];
                }
                if (grades[i] < lowest)
                {
                    lowest = grades[i];
                }
            }
            double avg = (double)sum / grades.Length;
            int nadAvg = 0;
            for (int i = 0; i < grades.Length; i++)
            {
                if (grades[i] > avg)
                {
                    nadAvg++;
                }
            }
            Console.WriteLine($"Highest grade: {highest}");
            Console.WriteLine($"Lowest grade: {lowest}");
            Console.WriteLine($"Avarege score: {avg:f1}");
            Console.WriteLine($"Number of people with bigger score than the avg: {nadAvg}");
            Array.Sort(grades);
            Console.Write("All grades from smallest to biggest: ");
            Console.WriteLine(String.Join(", ", grades));
        }
    }
}