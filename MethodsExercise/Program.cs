using System.ComponentModel;

namespace MethodsExercise
{
    public class Program
    {
        public static int Sum(int num1, int num2)
        {
            var answer = num1 + num2;
            return answer;
        }
        public static int Multiply(int num1, int num2, int num3)
        {
            return num1 * num2 * num3;

        }
        public static int Minus(int num1, int num2)
        {  
            return num1 - num2; 
        
        } 

        public static int Divide(int num1, int num2)

        { 
            return num1 / num2; 
        }
  
      

        static void Main(string[] args)
        {
            
            {
                //Exercise 1

                Console.WriteLine("Hello - What is your first name?");
                var userName = Console.ReadLine();
                
                Console.WriteLine($"Hi, {userName} what is your favorite color?");
                var color = Console.ReadLine();

                Console.WriteLine($"{color} is a sweet color! What is your favorite Animal?");
                var animal = Console.ReadLine();

                Console.WriteLine($"{animal} is a great animal, What is your favorite band?");
                var band = Console.ReadLine();

                Console.WriteLine($"Thanks, {userName}! Here is your Profile!");

                Console.WriteLine($"Name:{userName}");
                Console.WriteLine($"Favorite Band: {band}");
                Console.WriteLine($"Favorite Animal: {animal}");
                Console.WriteLine($"Favorite Color: {color}");

                //Exercise 2

                var amountOfCars = Sum(2, 6);

                var amountOfDrivers = Multiply(60, 2, 4);

                var costOfCarInsurance = Minus(100, 50);

                var avgCost = Divide(100, 50);


                Console.WriteLine();

                Console.WriteLine($"The Amount of cars and drivers on the road is: {amountOfCars + amountOfDrivers} The cost of car insurance is: {costOfCarInsurance}. The average cost is: {avgCost} ").;

                
                

            }
        }
    }
}
