using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();

        Address address1 = new Address("123 Main Street", "Anytown", "CA", "USA");
        Address address2 = new Address("12 Broad Street", "Lagos Island", "Lagos", "NIG");
        Address address3 = new Address("456 Elm St", "Shelbyville", "IN", "USA");

        Lecture lecture = new Lecture("Introduction to C#", "Introduction to C# Programming", new DateOnly(2022, 12, 25), "10:00 AM", address1,"John Omotoso", 100);
        Reception reception = new Reception("Birthday Party", "Birthday Party for John", new DateOnly(2022, 12, 25), "07:00 AM", address2, "johndoe@me.com");
        OutdoorGathering outdoorGathering = new OutdoorGathering("Tennis Tournament", "1st Quarter Tennis Tournament", new DateOnly(2023, 10, 15), "09:00 AM", address3, "Sunny");

        List<Event> events = new List<Event>{lecture, reception, outdoorGathering};
        foreach(Event e in events){
            Console.WriteLine(e.GetFullDetails());
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
        }
    }
}