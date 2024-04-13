namespace DesignPatterns.Observer;

public class Wodocanal
{
    public List<IObserver> Observers { get; set; }

    public Wodocanal()
    {
        Observers = new();
    }

    public void AttachObserver(IObserver observer)
        => Observers.Add(observer);

    public void DetachObserver(IObserver observer)
        => Observers.Remove(observer);

    public void Notify()
    {
        Console.WriteLine("Say bye to water");
        Observers.ForEach(o => o.Cry());
        Console.WriteLine();
    }
}