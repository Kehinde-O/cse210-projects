class SimpleGoal : Goal {

    public SimpleGoal(string shortName, string description, int points) : base(shortName, description, points) {
        if(_points > 0){
            _isCompleted = true;
        }
    }

    public override void RecordEvent() {
        if(!_isCompleted){
            _isCompleted = true;
            Console.WriteLine("Congratulations! You have earned " + _points + " points!");
        }else{
            _points = 0;
            Console.WriteLine("You have already completed this goal, No points awarded.");
        }
    }

    public override string GetStringRepresentation() {
        return $"SimpleGoal|{_shortName}|{_description}|{_points}|{_isCompleted}";
    }

    public override bool IsCompleted() {
        return _isCompleted;
    }
}