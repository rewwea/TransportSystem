namespace TransportSystem 
{
    class Program
    {
        static void Main()
        {
            Car car1 = new Car("Toyota", "Corolla", 2022, 4);
            Car car2 = new Car("BMW", "X5", 2023, 5);
            Motorcycle moto1 = new Motorcycle("Harley-Davidson", "Sportster", 2021, false);
            Motorcycle moto2 = new Motorcycle("Ducati", "Monster", 2022, false);

            Garage<Car> carGarage = new Garage<Car>();
            Garage<Motorcycle> motoGarage = new Garage<Motorcycle>();

            carGarage.AddVehicle(car1);
            carGarage.AddVehicle(car2);
            motoGarage.AddVehicle(moto1);
            motoGarage.AddVehicle(moto2);

            Console.WriteLine();
            carGarage.ShowVehicles();
            Console.WriteLine();
            motoGarage.ShowVehicles();
        }
    }
}