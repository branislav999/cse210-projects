using System;

class Program
{
    static void Main()
    {
        Address eventAddress = new Address("General Draza Mihailovic Street", 42, "Belgrade", "Vojvodina", "Serbia");

        Event standardEvent = new Event("Standard Event", "A generic event", "2023-01-01", "12:00 PM", eventAddress);
        Lecture lectureEvent = new Lecture("Tech Talk", "Learn about new technologies", "2023-02-15", "3:00 PM", eventAddress, "Matija Pavlovic", 100);
        Reception receptionEvent = new Reception("Networking Mixer", "Socialize and network", "2023-03-20", "6:00 PM", eventAddress, "register.com");
        Outdoor outdoorEvent = new Outdoor("Summer Picnic", "Enjoy outdoor activities", "2023-06-10", "1:00 PM", eventAddress, 75);

        standardEvent.BasicDisplay();
        lectureEvent.FullDisplay();
        receptionEvent.FullDisplay();
        outdoorEvent.FullDisplay();
    }
}
