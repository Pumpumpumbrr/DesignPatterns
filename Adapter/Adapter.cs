namespace DesignPatterns.Adapter;

public class Adapter : IMessage
{
    private readonly IOldFashionMessage _message;

    public Adapter(IOldFashionMessage message)
    {
        _message = message;
    }

    public void Send()
    {
        _message.KickTheBird();
    }
}
    