using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicle_Bus
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //SportCar spcar = new SportCar(2, 100000, 2, 5);
            //create 2v , 2b , 2c, 2sc

            //------Vehicle-----
            Vehicle v1 = new Vehicle();
            Vehicle v2 = new Vehicle(2, 20000);

            //----Bus-----
            Bus b1 = new Bus();
            Bus b2 = new Bus(2, 52000, 60);

            //------Car-----
            Car c1 = new Car();
            Car c2 = new Car(4, 30000, 5);

            //----Sport Car------
            SportCar sc1 = new SportCar();
            SportCar sc2 = new SportCar(2, 100000, 2, 5);

            //----Copy Constructor----
            Vehicle v3 = new Vehicle(v2);
            Bus b3 = new Bus(b2);
            Car c3 = new Car(c2);
            SportCar sc3 = new SportCar(sc2);

            //----Display----
            //Console.WriteLine(v1);
            //Console.WriteLine(v2);
            //Console.WriteLine(b1);
            //Console.WriteLine(b2);
            //Console.WriteLine(c1);
            //Console.WriteLine(c2);
            //Console.WriteLine(sc1);
            //Console.WriteLine(sc2);

            //all of this in one array
            Object[]inventory = {v1, v2, b1, b2, c1, c2, sc1, sc2,};

            for (int i = 0; i < inventory.Length; i++)
            {
                Console.WriteLine(inventory[i]);
                Console.WriteLine("=================");
            }
        }
    }

    public class Vehicle
    {

        private int numberOFDoor;
        private double price;

        public Vehicle()
        {
            Console.WriteLine("creating vehicle from deafult const");
            numberOFDoor = 4;
            price = 10000;
        }

        public Vehicle(int nd, double pr)
        {
            Console.WriteLine("creating vehicle from parameter const");
            numberOFDoor = nd;
            price = pr;
        }

        public Vehicle(Vehicle v)
        {
            Console.WriteLine("creating vehicle from COPY const");
            numberOFDoor = v.numberOFDoor;
            price = v.price;
        }

        public int GetNumberOfDoors() { return numberOFDoor; }
        public double GetPrice() { return price; }
        public virtual void SetNumOfDoors(int nd) { numberOFDoor = nd; }
        public virtual void SetPrice(double price) { this.price = price; }

        public override string ToString()
        {
            return "This vehicle has " + numberOFDoor + " doors and the price is " + price + "$";
        }
    }


    public class Bus : Vehicle
    {
        private int passangerCapacity;

        public Bus()
        {
            Console.WriteLine("creating Bus from deafult const");
            passangerCapacity = 50;
        }

        public Bus(int pc)
        {
            Console.WriteLine("creating Bus from parameter const");
            this.passangerCapacity = pc;
        }

        // constructor base
        //public Bus(int nd, double pr, int pc) : base(nd, pr)
        //{
        //    Console.WriteLine("creating Bus from base const of bus ");
        //    passangerCapacity = pc;
        //}


        //this constructon
        public Bus(int nd, double pr, int pc) : this(pc)
        {
            Console.WriteLine("creating Bus from THIS const of bus ");
            SetNumOfDoors(nd);
            SetPrice(pr);
        }

        public Bus(Bus b)
        {
            Console.WriteLine("creating Bus from COPY const of bus ");
            SetNumOfDoors(b.GetNumberOfDoors());
            SetPrice(b.GetPrice());
            passangerCapacity = b.GetPassangerCapacity();
        }

        public override void SetPrice(double pr)
        {
            if (pr < 0 || pr > 100000)
            {
                Console.WriteLine("Not valid price");
                return;
            }
            base.SetPrice(pr);
        }

        public int GetPassangerCapacity() { return passangerCapacity; }
        public void SetPassangerCapacity(int pc) { passangerCapacity = pc; }

        public override string ToString()
        {
            return "This Bus has " + GetNumberOfDoors() + "doors and  the price is " + GetPrice()
                + "$ and passenger capacity is "
                + passangerCapacity;
        }

    }

    //Car :Vehicle   => numberofSeats

    public class Car : Vehicle
    {
        private int numberOfSeats;

        public Car()
        {
            Console.WriteLine("Creating Car from default constructor");
            numberOfSeats = 5;
        }
        public Car(int ns)
        {
            Console.WriteLine("Creating Car from parameterized constructor");
            numberOfSeats = ns;
        }
        public Car(int nd, double pr, int ns) : base(nd, pr)
        {
            Console.WriteLine("Creating Car from base constructor of car");
            numberOfSeats = ns;
        }
        public Car(Car c)
        {
            Console.WriteLine("Creating Car from copy constructor");
            SetNumOfDoors(c.GetNumberOfDoors());
            SetPrice(c.GetPrice());
            numberOfSeats = c.numberOfSeats;
        }


        public int GetNumberOfSeats() { return numberOfSeats; }
        public void SetNumberOfSeats(int ns) { numberOfSeats = ns; }

        public override string ToString()
        {
            return $"This Car has {GetNumberOfDoors()} doors and the price is {GetPrice()}$ and it has {numberOfSeats} seats.";
        }
    }


    //SportCar = > : Car   ->  double gasconsuption

    public class SportCar : Car
    {

        private double gassConsumption;

        public SportCar()
        {
            Console.WriteLine("Creating Sport Car from default constructor");
            gassConsumption = 4;
        }

        public SportCar(int nd, int pr, int ns, double gc) : base(nd, pr, ns)
        {
            Console.WriteLine("Creating Sport Car from BASE constructor");
            gassConsumption = gc;
        }

        public SportCar(SportCar sc)
        {
            Console.WriteLine("Creating Sport Car from COPY constructor");
            SetNumOfDoors(sc.GetNumberOfDoors());
            SetPrice(sc.GetPrice());
            SetNumberOfSeats(sc.GetNumberOfSeats());
            gassConsumption = sc.gassConsumption;
        }

        public double GetGassCons() { return gassConsumption; }
        public void SetGassCons(double gc) { gassConsumption = gc; }

        public override void SetNumOfDoors(int nd)
        {
            if (nd > 2 || nd > 4)
            {
                Console.WriteLine("the number is not valid ");
                return;
            }
            base.SetNumOfDoors(nd);
        }

        public override string ToString()
        {
            return $"This Car has {GetNumberOfDoors()} doors and the price is {GetPrice()}$ and it has" +
                $" {GetNumberOfSeats()} seats." +
                $"This car gasconsumtion is " + gassConsumption;
        }


    }
}
