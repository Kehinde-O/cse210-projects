class GoalManager{

    private List<Goal> _goals = new List<Goal>();
    private int _score;

    public GoalManager(){
        _score = 0;
    }

    public void Start(){
        Console.Clear();
        int choice = 0;
        while(choice != 6){
            DisplayFirstLevelMenu();
            choice = int.Parse(Console.ReadLine());
            switch(choice){
                case 1:
                    CreateGoal();
                    break;
                case 2:
                    ListGoalDetails();
                    break;
                case 3:
                    SaveGoals();
                    break;
                case 4:
                    LoadGoals();
                    break;
                case 5:
                    RecordEvent();
                    break;
                case 6:
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        }
    }

    private void DisplayFirstLevelMenu(){
        // Console.Clear();
        Console.WriteLine("");
        Console.WriteLine($"You have {_score} points.");
        Console.WriteLine("");
        Console.WriteLine("Menu Options:");
        Console.WriteLine(" 1. Create New Goal");
        Console.WriteLine(" 2. List Goals");
        Console.WriteLine(" 3. Save Goals");
        Console.WriteLine(" 4. Load Goals");
        Console.WriteLine(" 5. Record Event");
        Console.WriteLine(" 6. Quit");
        Console.Write("Select a choice from the menu: ");
    }

    private void DisplaySecondLevelMenu(){
        Console.WriteLine("The types of Goals are:");
        Console.WriteLine(" 1. Simple Goal");
        Console.WriteLine(" 2. Eternal Goal");
        Console.WriteLine(" 3. Checklist Goal");
    }

    private void DisplayPlayerInfo(){
        Console.WriteLine($"Score: {_score}");
    }

    private void ListGoalNames(){
        Console.WriteLine();
        Console.WriteLine("The goals are: ");
        for(int i = 0; i < _goals.Count; i++){
            Console.WriteLine($"{i+1}. {_goals[i].GetShortName()}");
        }
        Console.WriteLine();
    }

    private void ListGoalDetails(){
        Console.WriteLine();
        if(_goals.Count == 0){
            Console.WriteLine("You have no goals. Please create or load a goal.");
            return;
        }
        Console.WriteLine("The goals are: ");
        for(int i = 0; i < _goals.Count; i++){
            Console.WriteLine($"{i+1}. {_goals[i].GetDetailsString()}");
        }
        Console.WriteLine();
    }

    private void CreateGoal(){
        DisplaySecondLevelMenu();
        Console.Write("What type of goal would you like to create? ");
        string goalType = Console.ReadLine();
        Console.Write("What is the name of your goal? ");
        string goalName = Console.ReadLine();
        Console.Write("What is the description of your goal? ");
        string goalDescription = Console.ReadLine();
        Console.Write("What is the amount of points associated with this goal? ");
        int goalPoints = int.Parse(Console.ReadLine());
        if(goalType == "1"){
            _goals.Add(new SimpleGoal(goalName, goalDescription, goalPoints));
            Console.WriteLine($"The goal has been created. Its value is {_goals[_goals.Count - 1].GetPoints()} points.");
        }
        else if(goalType == "2"){
            _goals.Add(new EternalGoal(goalName, goalDescription, goalPoints));
        }
        else if(goalType == "3"){
            Console.Write("How many times does this goal need to be accomplished for a bonus? ");
            int goalTimes = int.Parse(Console.ReadLine());
            Console.Write("What is the bonus for accomplishing it that many times? ");
            int goalBonus = int.Parse(Console.ReadLine());
            _goals.Add(new ChecklistGoal(goalName, goalDescription, goalPoints, goalTimes, goalBonus));
        }
        else{
            Console.WriteLine("Error: Invalid goal type");
        }
    }

    private void RecordEvent(){
        ListGoalNames();
        if(_goals.Count == 0){
            Console.WriteLine("You have no goals. Please create or load a goal.");
            return;
        }
         Console.Write("Which goal did you accomplish? ");
        int goalIndex = int.Parse(Console.ReadLine()) - 1;
        _goals[goalIndex].RecordEvent();
        _score += _goals[goalIndex].GetPoints();
    }

    private void SaveGoals(){
        Console.Write("What would you like to name your file? ");
        string fileName = Console.ReadLine();
        using(StreamWriter outputFile = new StreamWriter(fileName)){
            outputFile.WriteLine(_score);
            for(int i = 0; i < _goals.Count; i++){
                outputFile.WriteLine(_goals[i].GetStringRepresentation());
            }
        }
    }

    private void LoadGoals(){
        Console.Write("What is the name of the file? ");
        string fileName = Console.ReadLine();
        string[] lines = System.IO.File.ReadAllLines(fileName);
        _score = int.Parse(lines[0]);
        for(int i = 1; i < lines.Length; i++){
            string[] parts = lines[i].Split("|");
            string goalType = parts[0];
            string goalName = parts[1];
            string goalDescription = parts[2];
            int goalPoints = int.Parse(parts[3]);
            bool isComplete = bool.Parse(parts[4]);
            if(goalType == "SimpleGoal"){
                _goals.Add(new SimpleGoal(goalName, goalDescription, goalPoints));
            }
            else if(goalType == "EternalGoal"){
                _goals.Add(new EternalGoal(goalName, goalDescription, goalPoints));
            }
            else if(goalType == "ChecklistGoal"){
                int amountCompleted = int.Parse(parts[5]);
                int goalTarget = int.Parse(parts[6]);
                int goalBonus = int.Parse(parts[7]);
                if(amountCompleted == 0){
                    _goals.Add(new ChecklistGoal(goalName, goalDescription, goalPoints, goalTarget, goalBonus));
                }else{
                    _goals.Add(new ChecklistGoal(goalName, goalDescription, goalPoints, goalTarget, goalBonus, amountCompleted));
                }
            }
        }
    }
}