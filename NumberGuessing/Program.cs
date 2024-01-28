internal class Program
{
    private static void Main(string[] args)
    {
        Random random = new Random();
        int guesses;
        bool playAgain = true;
        int computerRandom;
        int playerGuess;
        int min = 1;
        int max = 100;
        String response;
        while(playAgain)
        {
            response = "";
            playerGuess = 0;
            guesses = 0;
            computerRandom = random.Next(min,max + 1);

            while ( playerGuess != computerRandom) { 
            Console.WriteLine("Please select any number between " + min + "and" + max);
            playerGuess = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Your Guess is : " + playerGuess);


            if (playerGuess > computerRandom)
                {

                    Console.WriteLine("Your Guess is too high");
                }
            else if ( playerGuess < computerRandom)
                {
                    Console.WriteLine("Your Guess is too low");
                }
                guesses++; 
                }
            Console.WriteLine("Player Guess: " + playerGuess);
            Console.WriteLine("Your Guess matched Congratulations");
            Console.WriteLine("Attempts :" + guesses);
            Console.WriteLine("Do you want to Play Again ? Y//N");
            response = Console.ReadLine();
            response = response.ToUpper();


            if (response == "Y")
            {
                playAgain = true;
            }
            else
            {
                playAgain = false;
            }
            
        }

        Console.WriteLine("Thank you for Playing");

    }
    }
