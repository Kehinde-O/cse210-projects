using System;

class Program
{
    static List<Scripture> _scriptures = new List<Scripture>();
    static void Main(string[] args)
    {
        ///////Added Challenge to exceed requirement, Added a feature to hide only visible words

        

        PopulateScriptures();
        Scripture scripture = GetRandomScripture();
        string user_input = "";
        do{
            Console.Clear();
            scripture.GetDisplayText();
            Console.WriteLine();
            Console.Write("Press enter to continue, or type quit to exit: ");
            user_input = Console.ReadLine();
            scripture.HideRandomWord(3);
            Console.Clear();
            if(user_input == "quit"){
                break;
            }
        }while(user_input != "quit" && !scripture.isCompletelyHidden());

        void PopulateScriptures(){
            Reference reference = new Reference("John", "3", "16");
            string text = "For God so loved the world that he gave his one and only Son, that whoever believes in him should not perish but have eternal life.";
            _scriptures.Add(new Scripture(reference, text));

            /////Create another reference and scripture
            reference = new Reference("1 Nephi", "3","7","8");
            text = "I will go and do the things which the Lord hath commanded, for I know that the Lord giveth no commandments unto the children of men, save he shall prepare a way for them that they may accomplish the thing which he commandeth them. And it came to pass that when my father had heard these words he was exceedingly glad, for he knew that I had been blessed of the Lord.";
            _scriptures.Add(new Scripture(reference, text));

            reference = new Reference("Proverbs", "3", "5");
            text = "Trust in the Lord with all your heart; and lean not on your own understanding. In all your ways submit to the Lord, and he will make your paths straight.";
            _scriptures.Add(new Scripture(reference, text));
        }

        Scripture GetRandomScripture(){
            Random random = new Random();
            int index = random.Next(_scriptures.Count);
            return _scriptures[index];
        }
    }
}