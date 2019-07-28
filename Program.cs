using System;


namespace NumberGuesser
{
    //Main Class
    class Program
    {
        // Entry Point Method
        static void Main(string[] args)

        {
            GetAppInfo(); // run GetAppinfo function

            GreetUser(); // Ask for user name and greet
            

            while (true)
            {
                // Set correct number

                // Init correct number 
                //int correctNumber = 7;

                //Create a new Random object
                Random random = new Random();

                //int correct number
                int correctNumber = random.Next(1, 10);

                // Init guess var
                int guess = 0;

                // Ask user for number
                Console.WriteLine("Guess a number between 1 and 10");

                // While guess is not correct
                while (guess != correctNumber)
                {
                    // Get users input
                    string input = Console.ReadLine();

                    //Make sure its a number
                    if (!int.TryParse(input, out guess))
                    {
                        //Print error message
                        PrintColorMessage(ConsoleColor.DarkRed, "Please use an actual number");
                
                        //keep going

                        continue;


                    }
                    {

                    }

                    // Cast to int and put in guess
                    guess = Int32.Parse(input);

                    // Match guess to correct number 
                    if (guess != correctNumber)
                    {
                      // Print Error Message 

                        PrintColorMessage(ConsoleColor.DarkRed, "Wrong number, please try again!");
                    }

                }

                PrintColorMessage(ConsoleColor.Green, "CORRECT!! You gessed it!");

                // ask to play again
                Console.WriteLine("Play Again? [Y or N]");

                //Get answer
                string answer = Console.ReadLine().ToUpper();

                if (answer == "Y")
                {
                    continue;

                }
                else if (answer == "N")
                {
                    return;
                }
                else
                {
                    return;

                }
            }

        }
        static void GetAppInfo() //Get and display user info
        {
            // Set app Vars
            string appName = "Number Guesser";
            string appVersion = "1.0.0";
            string appAuthor = "Jamel Davis";

            // Change text color

            Console.ForegroundColor = ConsoleColor.Blue;

            // Wrote out app info

            Console.WriteLine("{0}; Version {1} by {2}", appName, appVersion, appAuthor);

            //Reset text color 

            Console.ResetColor();
        }
        static void GreetUser ()
        {
            // Ask user name
            Console.WriteLine("What is your name?");

            // Get user input
            string inputName = Console.ReadLine();

            //lets play a game
            Console.WriteLine("Hello {0}, let's play a game!", inputName);
        }
        
        //Print color messasge
        static void PrintColorMessage(ConsoleColor color, string message) {
            // Change text color

            Console.ForegroundColor = color;

            // Tell user its not a number

            Console.WriteLine(message);

            //Reset text color 

            Console.ResetColor();
        }

    }
}
