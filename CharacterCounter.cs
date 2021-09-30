using System;

namespace CharacterCounter
{
    class Program
    {
        /* 
         Prompts the user for a strings.
        Prints the number of characters in that string to the console.
         */
        static void RetrieveAndCountCharacters()
        {
            Console.WriteLine("Please type or paste the string you want to count below:");
            string stringOfCharactersToCount = Console.ReadLine();
            Console.WriteLine("There are " + stringOfCharactersToCount.Length + " characters in that string.");
        }

        static void Main(string[] args)
        {
            // The app introduces itself
            Console.WriteLine("Hello I am a character counter.");
            Console.WriteLine("Some software will give you errors if you pass in strings with too many characters.");
            Console.WriteLine("That is where I come in. I can help you count the number of characters in a string.");

            // Initialize a boolean to track if the user wants to keep running the application
            bool ApplicationRunning = true;
            // Initialize a variable to keep track of the user input
            string UserInput;
            // While the application is running...
            while(ApplicationRunning)
            {
                // Call the RetrieveAndCountCharacters method
                RetrieveAndCountCharacters();

                // Ask the user if they would like to count another string or close the application
                Console.WriteLine("Would you like to count another string?");
                Console.WriteLine("Type Y to count another string or N to close the application.");
                UserInput = Console.ReadLine();

                // If the user typed n, turn off the application
                if (UserInput == "N" || UserInput == "n")
                {
                    ApplicationRunning = false;
                }


            }

        }

    }
}
