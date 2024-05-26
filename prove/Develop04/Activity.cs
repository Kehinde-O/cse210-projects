class Activity{
    protected string _name;
    protected string _description;
    protected int _duration;
    public Activity(string name, string description){
        _name = name;
        _description = description;
    }
    public void DisplayStartingMessage(){
        Console.Clear();
        Console.WriteLine($"Welcome to the {_name}!");
        Console.WriteLine(_description);
        Console.WriteLine();
    }
   
    public void DisplayEndingMessage(){
        Console.WriteLine();
        Console.WriteLine("Well Done!");
        Console.WriteLine($"You have completed another {_duration} seconds of the {_name} Activity.");
        ShowSpinner(5);
    }

    public void ShowSpinner(int seconds){
        string[] animation = new string[] {"/", "-", "\\", "|"};
        int index = 0;
        while (seconds > 0){
            Console.Write(animation[index]);
            index = (index + 1) % animation.Length;
            Thread.Sleep(1000);
            Console.Write("\b \b");
            seconds -= 1;
        }
        Console.WriteLine();
    }

    public void ShowCountdown(int seconds){
        int time = seconds;
        while(time > 0){
            Console.Write(time);
            Thread.Sleep(1000);
            Console.Write("\b \b");
            time -= 1;
        }
    }
}