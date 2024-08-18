namespace CSC205Final
{
    public class Program
    {
        public static void Main()
        {
            // Testing
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
