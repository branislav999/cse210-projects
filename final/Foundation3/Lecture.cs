public class Lecture : Event
{

    private string speaker;
    private int capacity;

    public Lecture(string _title, string _description, string _date, string _time, Address _address, string _speaker, int _capacity  ) 
    : base (_title, _description, _date, _time, _address)
    {
        speaker = _speaker;
        capacity = _capacity;
    }

    public override void FullDisplay()
    {
        BasicDisplay();
        Console.WriteLine($"Speaker: {speaker}. The capacity is {capacity}.");
    }
}