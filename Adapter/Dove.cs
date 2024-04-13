namespace DesignPatterns.Adapter;

public class Dove : IOldFashionMessage
{
    private readonly string _text;

    public Dove(string text)
    {
        _text = text;
    }

    public void KickTheBird()
    {
        Console.WriteLine($"Message: {_text}");
        Console.WriteLine("Message sent by dove");
    }
}