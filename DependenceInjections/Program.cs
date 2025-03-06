namespace OOP_Concept
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Bus bus = new Bus();
            Bike bike = new Bike();
            Driver driver = new Driver(bike);
            //driver.Start();
            driver.Start();
        }
    }
}

