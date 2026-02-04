using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Vehicle v1 = new Vehicle();
            //vehicle -> nd, price //wont have pc
            //bus -> nd, price, pc
            //Vehicle v2 = new Vehicle(4,30000);

            //Bus b1 = new Bus();
            //b1.setNumberOfDoors(2);
            //b1.setPrice(40000);
            //Console.WriteLine(b1);

            Bus b1 = new Bus(50);
            b1.setPrice(50000);

            Bus b2 = new Bus(b1);

            Console.WriteLine("======== Info for bus 1 ========");
            Console.WriteLine(b1);

            Console.WriteLine("======== Info for bus 2 ========");
            Console.WriteLine(b2);

        }
    }

    public class Vehicle
    {
        private int numberOfDoors;
        private double price;
        public Vehicle()
        {
            Console.WriteLine("creating Vehicle from default const of vehicle");
            numberOfDoors = 4;
            price = 10000;
        }

        public Vehicle(int nd, double pr)
        {
            Console.WriteLine("creating Vehicle from parameter const of vehicle");
            numberOfDoors = nd;
            price = pr;
        }

        public Vehicle(Vehicle v)
        {
            Console.WriteLine("creating Vehicle from copy const of vehicle");
            numberOfDoors = v.numberOfDoors;
        }

        public int getNumberOfDoors()
        {
            return numberOfDoors;
        }
        public double getPrice()
        {
            return price;
        }

        public void setNumberOfDoors(int nd)
        {
            numberOfDoors = nd;
        }
        public void setPrice(double pr)
        {
            price = pr;
        }

        public override string ToString()
        {
            return "This Vehicle has " + numberOfDoors + "doors and its price is " + price + "$.";
        }
    }


    public class Bus : Vehicle
    {
        private int passengerCapacity;

        public Bus()
        {
            Console.WriteLine("Creating Bus from default const of bus");
            passengerCapacity = 30;
        }

        public Bus(int pc)
        {
            Console.WriteLine("Creating Bus from parameter const of bus");
            passengerCapacity = pc;
        }

        //make the const for copy const
        public Bus(Bus b)
        {
            Console.WriteLine("Creating bus from copy const of bus");
            this.passengerCapacity = b.passengerCapacity;
            setPrice(b.getPrice());
            setNumberOfDoors(b.getNumberOfDoors());
        }


        public int GetPassengerCapacity()
        {
            return passengerCapacity;
        }

        public void SetPassengerCapacity(int pc)
        {
            passengerCapacity = pc;
        }

        public override string ToString()
        {
            return "This Vehicle has " + getNumberOfDoors() + " doors and its price is " + getPrice() + "$ and has " + passengerCapacity + " capacity ";
        }
    }
  
    }
