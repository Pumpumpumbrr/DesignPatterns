namespace DesignPatterns.Builder;

public class ComfortPlusCarBuilder : CarBuilder
{
    public override void SetConfiguration()
    {
        Car.CarConfiguration = CarConfigurations.ComfortPlus;
    }

    public override void SetEngine()
    {
        Car.Engine = 1.81;
    }

    public override void SetDisksDiameter()
    {
        Car.DisksDiameter = 16;
    }

    public override void SetHeatedSeats()
    {
        Car.HeatedSeats = true;
    }
}