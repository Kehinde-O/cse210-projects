class EternalGoal : Goal{
    public EternalGoal(string shortName, string description, int points) : base(shortName, description, points){
    }
    public override void RecordEvent(){
        Console.WriteLine("Congratulations! You have earned " + _points + " points!");
    }

    public override bool IsCompleted(){
        return _isCompleted;
    }

    public override string GetStringRepresentation(){
        return $"EternalGoal|{_shortName}|{_description}|{_points}|{_isCompleted}";
    }
}