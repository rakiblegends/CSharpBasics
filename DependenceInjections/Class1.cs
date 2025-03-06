using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Concept
{
    public interface IVehicleInterface
    {
        void Start();
    }
    public class Bike : IVehicleInterface
    {
        public void Start()
        {
            Console.WriteLine("Bike Started");
        }
    }

    public class Bus : IVehicleInterface
    {
        public void Start()
        {
            Console.WriteLine("Bus started");
        }
    }

    public class Driver
    {
        private readonly IVehicleInterface _vehicleInterface;
        public Driver(IVehicleInterface vehicleInterface)
        {
            _vehicleInterface = vehicleInterface;
        }
        public void Start()
        {
            _vehicleInterface.Start();
        }
    }
}
