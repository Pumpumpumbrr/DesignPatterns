namespace DesignPatterns.Adapter;

public class Email : IMessage
{
    private readonly string _text;

    public Email(string text)
    {
        _text = text;
    }

    public void Send()
    {
        Console.WriteLine($"Message: {_text}");
        Console.WriteLine("Message sent by email");
    }
}