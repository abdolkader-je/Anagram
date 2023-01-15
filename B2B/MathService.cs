namespace B2B
{
    public sealed class MathService
    {
        public static bool IsFactorial(int userInput, HashSet<long> listOfTheFileNumbers) => listOfTheFileNumbers.Contains(userInput);

        public static long GetFactorial(int number)
        {
            long factorial = 1;
           
            for (int i = 1; i <= number; i++)
            {
                factorial *= i;
            }
            return factorial;
        }
    }
}
