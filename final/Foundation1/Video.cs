using System.Diagnostics.CodeAnalysis;
using System.Security.Cryptography.X509Certificates;
using System.Transactions;

public class Video
{
    public string title;
    public string author;
    public int seconds;

    List<Comment> comments = new List<Comment>{};

    public Video(string _title, string _author, int _seconds)
    {
        title = _title;
        author = _author;
        seconds = _seconds;
    }

    public void AddComment(Comment comment)
    {
        comments.Add(comment);
    }

    public void Display()
    {
        Console.WriteLine($"\nTitle: {title}, Author: {author}, Length: {seconds} seconds.");
        Console.WriteLine($"Number of Comments on this video is: {CommentCount()}");
        foreach (Comment com in comments)
        {
            Console.WriteLine($"User {com.name} commented: {com.text} ");
        }
    }


    public int CommentCount()
    {
        int sum = 0;
        foreach (Comment comment in comments)
        {
            sum++;
        }
        return sum;
    }
}

public class Comment
{
    public string name;
    public string text;

    public Comment(string _name, string _text)
    {
        name = _name;
        text = _text;
    }

}