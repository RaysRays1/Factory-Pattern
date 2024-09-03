namespace FactoryPattern
{
    public class Program
    {
        static void Main(string[] args)
        {
            var car = new Car();
            
            var motorcycle = new Motorcycle();
            
            Console.WriteLine("How many tires do you choose to have!");
            var numberOfTires = int.Parse(Console.ReadLine());
            var vehicle = VehicleFactory.GetVehicle(numberOfTires);
            vehicle.Drive();





        }
    }
}
