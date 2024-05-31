class ChecklistGoal : Goal{
    private int _amountCompleted;
    private int _target;
    private int _bonus;

    public ChecklistGoal(string name, string description, int points, int target, int bonus) : base(name, description, points){
        _target = target;
        _bonus = bonus;
        _amountCompleted = 0;
        _isCompleted = false;
    }

    public ChecklistGoal(string name, string description, int points, int target, int bonus, int amountCompleted) : base(name, description, points){
        _target = target;
        _bonus = bonus;
        _amountCompleted = amountCompleted;
        if(_amountCompleted >= _target){
            _isCompleted = true;
        }
    }

    public override void RecordEvent(){
        if(!_isCompleted){
            _amountCompleted++;
            if(_amountCompleted >= _target){
                _isCompleted = true;
                _points += _bonus;
            }
            Console.WriteLine("Congratulations! You have earned " + _points + " points!");
        }else{
            _points = 0;
            Console.WriteLine("You have already completed this goal, No points awarded.");
        }
    }

    public override bool IsCompleted(){
        return _amountCompleted == _target;
    }

    public override string GetDetailsString(){
        if(_isCompleted){
            return $"[X] {_shortName} ({_description}) -- Currently completed: {_amountCompleted}/{_target}";
        }
        else{
            return $"[ ] {_shortName} ({_description}) -- Currently completed: {_amountCompleted}/{_target}";
        }
    }

    public override string GetStringRepresentation(){
        return $"ChecklistGoal|{_shortName}|{_description}|{_points}|{_isCompleted}|{_amountCompleted}|{_target}|{_bonus}";
    }
}