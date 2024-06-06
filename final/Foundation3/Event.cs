class Event{
    private string _title;
    private string _description;
    private DateOnly _date;
    private string _time;
    private Address _address;
    public Event(string title, string description, DateOnly date, string time, Address address){
        _title = title;
        _description = description;
        _date = date;
        _time = time;
        _address = address;
    }

    public string GetStandardDetails(){
        return $"Title: {_title}\nDescription: {_description}\nDate: {_date}\nTime: {_time}";
    }
    public virtual string GetFullDetails(){
        return $"Title: {_title}\nDescription: {_description}\nDate: {_date}\nTime: {_time}\nAddress: {_address.ToString()}\n";
    }
    public string GetShortDescription(){
        return $"{_date.ToShortDateString()} - {_title}";
    }
}