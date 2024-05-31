class Goal
{
    protected string _shortName;
    protected string _description;
    protected int _points;
    protected bool _isCompleted;

    public Goal(string shortName, string description, int points)
    {
        _shortName = shortName;
        _description = description;
        _points = points;
        _isCompleted = false;
    }

    public virtual void RecordEvent()
    {
        _isCompleted = true;
        Console.WriteLine("Congratulations! You have earned " + _points + " points!");
    }

    public string GetShortName()
    {
        return _shortName;
    }

    public string GetDescription()
    {
        return _description;
    }

    public int GetPoints()
    {
        return _points;
    }

    public virtual bool IsCompleted()
    {
        return _isCompleted;
    }

    public virtual string GetDetailsString()
    {
        if (_isCompleted)
        {
            return $"[X] {_shortName} ({_description})";
        }
        else
        {
            return $"[ ] {_shortName} ({_description})";
        }
    }

    public virtual string GetStringRepresentation()
    {
        return $"{_shortName}|{_description}|{_points}|{_isCompleted}";
    }


}