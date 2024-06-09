class Running : Activity{
    private double _distance = 0.0;

    public Running(DateOnly date, int length, double distance) : base(date, length){
        _distance = distance;
    }

    public override double GetDistance(){
        return _distance;
    }

    public override double GetSpeed(){
        return (_distance / _length) * 60;
    }

    public override double GetPace(){
        return _length / _distance;
    }

    public override string GetSummary(){
        return $"{_date} ({_length} min) - Distance: {GetDistance()} miles, Speed: {GetSpeed()} mph, Pace: {GetPace()} min per mile";
    }


}