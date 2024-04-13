namespace DesignPatterns.Builder;

public class BaseCarBuilder : CarBuilder
{
    public override void SetConfiguration()
    {
        Car.CarConfiguration = CarConfigurations.Base;
    }

    public override void SetEngine()
    {
        Car.Engine = 1.5;
    }

    public override void SetDisksDiameter()
    {
        Car.DisksDiameter = 15;
    }

    public override void SetHeatedSeats()
    {
        Car.HeatedSeats = false;
    }
}