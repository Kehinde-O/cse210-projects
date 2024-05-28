using System;

class Program
{
    ////Added creativity
    ////Added a check to see if the input for ListingActivity is not empty and if it has not been already been entered, i.e making sure ListingActivity contains unique entry
    /////Added a check to make sure that random questions in ReflectingActivity never shows 2 times, i.e when a question is asked, it is not repeated
    static void Main(string[] args)
    {
        string menuChoice = "0";
        while (menuChoice != "4")
        {
            Console.Clear();
            DisplayMenu();
            menuChoice = Console.ReadLine();
            switch (menuChoice)
            {
                case "1":
                    BreathingActivity breathingActivity = new BreathingActivity("Breathing", "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.");
                    breathingActivity.Run();
                    break;
                case "2":
                    ReflectingActivity reflectingActivity = new ReflectingActivity("Reflecting","This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.");
                    reflectingActivity.Run();
                    break;
                case "3":
                    ListingActivity listingActivity = new ListingActivity("Listing", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.");
                    listingActivity.Run();
                    break;
                case "4":
                    break;
                default:
                    Console.WriteLine("Please enter a valid number between 1 and 4.");
                    break;
            }
        }

        void DisplayMenu(){
            Console.Clear();
            Console.WriteLine("Menu Options:");
            Console.WriteLine("  1. Start breathing activity");
            Console.WriteLine("  2. Start reflecting activity");
            Console.WriteLine("  3. Start listing activity");
            Console.WriteLine("  4. Quit");
            Console.Write("Select a choice from the menu: ");
        }
    }
}