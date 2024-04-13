namespace DesignPatterns.Builder;

public class Car
{
    public CarModels CarModel { get; set; }
    public CarConfigurations CarConfiguration { get; set; }
    public double Engine { get; set; }
    public int DisksDiameter { get; set; }
    public bool HeatedSeats { get; set; }

    public Car(CarModels carModel)
    {
        CarModel = carModel;
    }

    public override string ToString()
    {
        return $"Model: {CarModel}, Configuration: {CarConfiguration}";
    }
}