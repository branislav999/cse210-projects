public class Event 
{
    private string title;
    private string description;
    private string date;
    private string time;
    private Address address;
    

    public Event(string _title, string _description, string _date, string _time, Address _address)
    {
        title = _title;
        description = _description;
        date = _date;
        time = _time;
        address = _address;
    }
    
    public void BasicDisplay()
    {
        Console.WriteLine("Event Details");
        Console.WriteLine($"Title: {title} ({description}). On {date} at {time}");
        Console.WriteLine($"The address of the event is: {address.GetAddress()}");
    }

    public virtual void FullDisplay()
    {

    }

    public void ShortDisplay()
    {
        Console.WriteLine("Event Details");
        Console.WriteLine($"Title: {title} on {date}");
    }
    
}