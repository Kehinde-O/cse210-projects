class BreathingActivity : Activity{
    public BreathingActivity(string name, string description) : base(name, description){

    }

    public void Run(){
        DisplayStartingMessage();
        Console.Write("How long, in seconds, would you like for your session? ");
        _duration = int.Parse(Console.ReadLine());
        StartBreathing();
        DisplayEndingMessage();
    }

    private void StartBreathing(){
        Console.Clear();
        Console.WriteLine("Get ready...");
        ShowSpinner(3);
        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(_duration);
        while (DateTime.Now < futureTime){
            Console.WriteLine();
            Console.Write("Breathe in... ");
            ShowCountdown(4);
            Console.WriteLine();
            Console.Write("Now breathe out... ");
            ShowCountdown(6);
            Console.WriteLine();
        }
    }
}