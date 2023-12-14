public class Outdoor : Event
{
    private int temperature;
    

    public Outdoor(string _title, string _description, string _date, string _time, Address _address, int _temperature) 
    : base (_title, _description, _date, _time, _address)
    {
        temperature = _temperature;
    }

    public override void FullDisplay()
    {
        BasicDisplay();
        Console.WriteLine($"The temperature will be F{temperature}.");
    }
}