class Cycling : Activity{
    public double _speed;
    public Cycling(DateOnly date, int length, double speed) : base(date, length){
        _speed = speed;
    }

    public override double GetSpeed(){
        return _speed;
    }

    public override double GetPace(){
        return 60 / _speed;
    }

    public override string GetSummary(){
        return $"{_date} ({_length} min) - Distance: {GetDistance()} miles, Speed: {GetSpeed()} mph, Pace: {GetPace()} min per mile";
    }

}