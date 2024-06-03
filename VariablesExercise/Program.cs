using System.Diagnostics;

namespace VariablesExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            string stringVariable = "";
            int intVariable = 0;
            char charVariable = 'C';
            bool boolVariable = true;
            double doubleVariable = 32.2;
            decimal decimalVariable = 9.81m;

            do
            {
                Console.Write("What is your pet's name: ");
                stringVariable = Console.ReadLine();
            } while (String.IsNullOrEmpty(stringVariable));

            Console.Write("How old is your pet: ");
            intVariable = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"Your pet's name is {stringVariable} and it is {intVariable} years old.");
        }
    }
}
