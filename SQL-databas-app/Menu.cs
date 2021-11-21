using System;

namespace SQL_databas_app
{
    public class Menu
    {
        public void runMenu()
        {
            Console.WriteLine("Hej! Vilken fråga vill du ha svar på? Välj med en siffra nedan.");
            Console.WriteLine("1.Hur många länder finns representerade i databasen?");
            Console.WriteLine("2.Är alla användarnamn och lösenord unika? ");
            Console.WriteLine("3.Hur många användare är från Norden respektive Skandinavien?");
            Console.WriteLine("4.Vilket är det vanligaste namnet?");
            Console.WriteLine("5.Lista 10 första användarna vars efternamn börjar på bokstaven L.");
            Console.WriteLine("6.Lista alla användare vars för och efternamn har samma begynnelsebokstav.");


            char userInput = Console.ReadKey();

            switch (userInput)
            {
                case 1
                    break;
                case 2
                     break;
                    case 3
                    break;
                    case 4
                    break;
                    case 5
                    break;
                    case 6
                    break;
                    default: Console.WriteLine("");
                    break;
-                    
                    


            }

        }
        
    


    }
}
