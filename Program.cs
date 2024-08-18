namespace CSC205Final
{
    public class Program
    {
        public static void Main()
        {

            // List to store the numbers
            List<int> numbers = new List<int>();

            // Read 10 numbers from the user
            Console.WriteLine("Please enter 10 numbers:");

            for (int i = 0; i < 10; i++)
            {
                Console.Write($"Enter number {i + 1}: ");
                int number = int.Parse(Console.ReadLine());
                numbers.Add(number);
            }

            // Calculate minimum, maximum, and average
            int min = numbers.Min();
            int max = numbers.Max();
            double average = numbers.Average();

            // Display the results
            Console.WriteLine($"Minimum: {min}");
            Console.WriteLine($"Maximum: {max}");
            Console.WriteLine($"Average: {average}");
            // Testing For IsDoubloon...
            Console.WriteLine("--------------------");
            Console.WriteLine("Testing For IsDoubloon...");
            Console.WriteLine(IsDoubloon("Noon"));       // True
            Console.WriteLine(IsDoubloon("Civic"));      // False
            Console.WriteLine(IsDoubloon("Moon"));       // False
            Console.WriteLine(IsDoubloon("Rotor"));      // False
            Console.WriteLine(IsDoubloon("Deeded"));     // True
            Console.WriteLine(IsDoubloon("Totem"));      // False
            Console.WriteLine(IsDoubloon("Night"));      // False
        }

        public static bool IsDoubloon(string word)
        {
            
            word = word.ToLower();

            
            foreach (char c in word)
            {
                if (word.Count(ch => ch == c) != 2)
                {
                    return false;
                }
            }

            return true;
        }
    }
}
