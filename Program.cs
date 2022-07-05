namespace SyntaxExercise2._0
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var userGuess = int.Parse(Console.ReadLine());
            var answer = 9;

            var repsonse = (userGuess <answer) ? $"{userGuess} is less than mine" : $"{userGuess} is greater than or equal to mine";

            Console.WriteLine(repsonse);

        
        
        
        }
    }
}