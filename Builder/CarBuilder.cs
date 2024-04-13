namespace DesignPatterns.Builder;

public abstract class CarBuilder
{
    protected Car Car { get; set; }

    public void CreateCar(CarModels carModel)
    {
        Car = new Car(carModel);
    }

    public Car GetCar()
        => Car;

    public abstract void SetConfiguration();
    public abstract void SetEngine();
    public abstract void SetDisksDiameter();
    public abstract void SetHeatedSeats();
}