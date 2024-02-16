namespace MethodsExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            
            {
                Console.WriteLine("Hello - What is your first name?");
                var userName = Console.ReadLine();
                
                Console.WriteLine($"Hi, {userName} what is your favorite color?");
                var color = Console.ReadLine();

                Console.WriteLine($"{color} is a sweet color! What is your favorite Animal?");
                var animal = Console.ReadLine();

                Console.WriteLine($"{animal} is a great animal, What is your favorite band?");
                var band = Console.ReadLine();

            }
        }
    }
}
