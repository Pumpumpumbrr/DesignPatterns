namespace DesignPatterns.Adapter;

public class MessageService
{
    public void SendMessage(IMessage message)
    {
        message.Send();
    }
}
