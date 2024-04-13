namespace DesignPatterns.Builder;

public class CarDiller
{
    private CarBuilder _carBuilder;

    private void SetCarBuilder(CarBuilder carBuilder)
    {
        _carBuilder = carBuilder;
    }

    private void BuildCar(CarModels carModel)
    {
        _carBuilder.CreateCar(carModel);
        _carBuilder.SetConfiguration();
        _carBuilder.SetEngine();
        _carBuilder.SetDisksDiameter();
        _carBuilder.SetDisksDiameter();
    }

    public Car BuyCar(CarBuilder carBuilder, CarModels carModel)
    {
        SetCarBuilder(carBuilder);
        BuildCar(carModel);

        return _carBuilder.GetCar();
    }
}