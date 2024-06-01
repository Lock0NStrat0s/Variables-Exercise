using System.Diagnostics;

namespace VariablesExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            string stringVariable;
            int intVariable;
            char charVariable;
            bool boolVariable;
            double doubleVariable;
            decimal decimalVariable;

            Console.Write("What is your pet's name: ");
            stringVariable = Console.ReadLine();

            Console.Write("How old is your pet: ");
            intVariable = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"Your pet's name is {stringVariable} and it is {intVariable} years old.");
        }
    }
}
