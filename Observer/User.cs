namespace DesignPatterns.Observer;

public class User : IObserver
{
    public void Cry()
    {
        Console.WriteLine("I am user and i cry(");
    }
}