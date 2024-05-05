using System;

class Program
{
    /////////To Exceed requirement, I added a check to prevent user from
    ///////// loading journal entry when there are unsaved entries so that
    ///////// unsaved entries would not be lost without saving
    static void Main(string[] args)
    {
        PromptGenerator promptGenerator = new PromptGenerator();
        Journal journal = new Journal();

        string entered_command = "";
        Console.WriteLine("Welcome to the Journal Program!");
        do{
            ShowMenu();
            Console.Write("What would you like to do? ");
            entered_command = Console.ReadLine();
            HandleCommand(entered_command);
        }while(entered_command != "5");



        ///////////HANDLE COMMAND HERE
        void HandleCommand(string command){
            if(command == "1"){
                //////Do write here
                string promp_text = promptGenerator.GetRandomPrompt();
                Console.WriteLine($"{promp_text}");
                Console.Write(">");
                string entry_text = Console.ReadLine();
                Entry entry = new Entry();
                entry._promptText = promp_text;
                entry._entryText = entry_text;
                DateTime theCurrentTime = DateTime.Now;
                string dateText = theCurrentTime.ToShortDateString();
                entry._date = dateText;
                journal.AddEntry(entry);
            }else if(command == "2"){
                //////Do display here
                journal.DisplayAll();
            } else if(command == "3"){
                //////Do load here
                Console.Write("Enter filename: ");
                string filename = Console.ReadLine();
                ///////BEYOND REQUIREMENT
                if(journal._entries.Count > 0){
                    Console.WriteLine("You have to save current entries first before you can load entries.");
                }else{
                    journal.LoadFromFile(filename);
                    journal.DisplayAll();
                }
            } else if(command == "4"){
                //////Do save here
                Console.Write("Enter filename: ");
                string filename = Console.ReadLine();
                journal.SaveToFile(filename);
            }
        }
    }

    static void ShowMenu(){
        Console.WriteLine("Please select one of the following choices:");
        Console.WriteLine("1. Write");
        Console.WriteLine("2. Display");
        Console.WriteLine("3. Load");
        Console.WriteLine("4. Save");
        Console.WriteLine("5. Quit");
    }
}