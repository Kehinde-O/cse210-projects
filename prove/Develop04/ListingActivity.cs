class ListingActivity : Activity{
    private int _count;
    private List<string> _prompts;

    public ListingActivity(string name, string description) : base(name, description){
        _count = 0;
        _prompts = new List<string>();
        _prompts.Add("Who are people that you appreciate?");
        _prompts.Add("What are personal strengths of yours?");
        _prompts.Add("Who are people that you have helped this week?");
        _prompts.Add("When have you felt the Holy Ghost this month?");
        _prompts.Add("Who are some of your personal heroes?");
    }

    public void StartListing(){
        Console.WriteLine("List as many responses as you can to the following prompt:");
        Console.WriteLine();
        GetRandomPrompt();
        Console.WriteLine();
        Console.Write("You may begin in: ");
        ShowCountdown(3);
        Console.WriteLine();
        List<string> responses = GetListFromUser();
        Console.WriteLine("You have listed " + responses.Count + " unique items!");
    }

    public void Run(){
        DisplayStartingMessage();
        Console.Write("How long, in seconds, would you like for your session? ");
        _duration = int.Parse(Console.ReadLine());
        Console.Clear();
        Console.WriteLine("Get ready...");
        ShowSpinner(3);
        StartListing();
        DisplayEndingMessage();
    }

    public void GetRandomPrompt(){
        Random random = new Random();
        int index = random.Next(_prompts.Count);
        Console.WriteLine($" --- {_prompts[index]} ---");
    }

    public List<string> GetListFromUser(){
        List<string> responses = new List<string>();
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration);
        while (DateTime.Now < endTime){
            Console.Write("> ");
            string word = Console.ReadLine();
            if(!responses.Contains(word) && word != ""){
                responses.Add(word);
                _count += 1;
            }
        }
        return responses;
    }

}