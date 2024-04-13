namespace DesignPatterns.Builder;

public class PremiumCarBuilder : CarBuilder
{
    public override void SetConfiguration()
    {
        Car.CarConfiguration = CarConfigurations.Premium;
    }

    public override void SetEngine()
    {
        Car.Engine = 1.8;
    }

    public override void SetDisksDiameter()
    {
        Car.DisksDiameter = 16;
    }

    public override void SetHeatedSeats()
    {
        Car.HeatedSeats = false;
    }
}