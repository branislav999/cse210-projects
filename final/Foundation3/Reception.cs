public class Reception : Event
{
    private string link;

    public Reception(string _title, string _description, string _date, string _time, Address _address, string _email  ) 
    : base (_title, _description, _date, _time, _address)
    {
        link = _email;
    }

    public override void FullDisplay()
    {
        BasicDisplay();
        Console.WriteLine($"Please enter the link to the registration page: {link}");
    }

}