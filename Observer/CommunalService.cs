namespace DesignPatterns.Observer;

public class CommunalService : IObserver
{
    public void Cry()
    {
        Console.WriteLine("I am communal service and i cry(");
    }
}