class Activity{
    protected DateOnly _date;
    protected int _length;

    public Activity(DateOnly date, int length){
        _date = date;
        _length = length;
    }

    public virtual double GetSpeed(){
        return 0;
    }

    public virtual double GetPace(){
        return 0;
    }

    public virtual double GetDistance(){
        return 0;
    }

    public virtual string GetSummary(){
        return $"{_date} ({_length} min)";
    }
}