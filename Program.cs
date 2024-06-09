using System.ComponentModel;
using System.Security.Cryptography;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Guess the number between 1 and 100 \nYou get 3 guesses");
        int RandInt = RandomNumber();
        int Guess1 = Guess();
        GuessesCheck(Guess1, RandInt);
        int Guess2 = Guess();
        GuessesCheck(Guess2, RandInt);
        int Guess3 = Guess();
        GuessesCheck(Guess3 , RandInt);
        if (Guess3 != RandInt) 
        {
            Console.WriteLine("\n \n");
            Console.WriteLine($"The number you were looking for was {RandInt}");
              
        }
        Again();


    }

    public static int RandomNumber() 
    {
        Random random = new Random();
        int RandomNumber = random.Next(1, 100);
        return RandomNumber;

    }
    public static int Guess() 
    {

        Console.WriteLine("Enter your Guess");
        int Guess = Convert.ToInt32(Console.ReadLine());
        return Guess;

    }
    public static void WonMessage(int RandInt) 
    {

        Console.WriteLine($"You guessed the number {RandInt}, Congrats ");
                
    }
    public static void GuessesCheck(int Guess, int RandInt) 
    {
        if (Guess == RandInt) 
        {
            WonMessage(RandInt);
            
        }
        
        if (Guess >= RandInt) 
        {

            Console.WriteLine("The Number you input is larger \nthan the Number you are looking for");

        }
        if (Guess <= RandInt)
        {

            Console.WriteLine("The Number you input is smaller \nthan the Number you are looking for");

        } 
    }
    public static void Again() 
    {
        Console.WriteLine("Enter Again to play once again");
        string? Again = Console.ReadLine();
        while (Again == "Again")
        {
            Console.WriteLine("Guess the number between 1 and 100 \nYou get 3 guesses");
            int RandInt = RandomNumber();
            int Guess1 = Guess();
            GuessesCheck(Guess1, RandInt);
            int Guess2 = Guess();
            GuessesCheck(Guess2, RandInt);
            int Guess3 = Guess();
            GuessesCheck(Guess3, RandInt);
            if (Guess3 != RandInt)
            {
                Console.WriteLine("\n \n");
                Console.WriteLine($"The number you were looking for was {RandInt}");
                Console.WriteLine("Enter Again to play once again");
                Again = Console.ReadLine();
            }
            

        }
        

    }
}
