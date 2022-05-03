using System;

namespace lklk
{
    class Program
    {
        static void Main(string[] args)
        {
            CardFile myDataHandler = new CardFile("card.txt"); 
            Card[] Cards = myDataHandler.GetAllCards();
            CardReporting reports = new CardReporting(Cards);
            System.Console.WriteLine(Card.GetCount());
           reports.PrintAllCards();
           reports.AverageReport();
           reports.CardSellReport();
           
           
           
           
           // System.Console.WriteLine($"Welcome to your card collection! /n Press 1 to view the average value of cards by manufacturer /n Press 2 to view combinations of cards that are $10 or more /n Press 3 to exit");
            // string userinput = Console.ReadLine();
            // if(int.Parse(userinput) == 1)
            // {
            //     Console.Clear();
            //     reports.AverageReport();
            // }
            // if (int.Parse(userinput) == 2)
            // {
            //     Console.Clear();
            //     reports.CardSellReport();
            // }
            // if(int.Parse(userinput) ==3)
            // {
            //     Console.Clear();
            //     System.Console.WriteLine("Bye!");
            // }
            // else
            // {
            //     System.Console.WriteLine($"Invalid input. /n Press any key to continue...");
            //     Console.ReadKey();
            //     Console.Clear();
            // }

        }
    }
}
