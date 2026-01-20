namespace ChooseCar
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Vehicle v1 = new Vehicle();
            Vehicle v2 = new Vehicle();
            Vehicle v3 = new Vehicle();

            Console.WriteLine("==========Info for v1==============");
            v1.setGetNumOfDoors(5);
            v1.setPrice(25000);
            v1.setMaxSpeed(260);

            v1.showInfo();

            Console.WriteLine("==========Info for v2==============");
            v2.setGetNumOfDoors(3);
            v2.setPrice(10000);
            v2.setMaxSpeed(220);

            v2.showInfo();

            Console.WriteLine("==========Info for v3==============");
            v3.setGetNumOfDoors(4);
            v3.setPrice(20000);
            v3.setMaxSpeed(300);

            v3.showInfo();


            double pr;
            int nd, ms;
            bool found = false;
            Console.WriteLine("Please give me maximum price:");
            pr = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Please give me minimum number of doors:");
            nd = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please give me minimum speed : ");
            ms = Convert.ToInt32(Console.ReadLine());

            //cond for v1
            if (v1.getPrice() <= pr && v1.getNumOfDoors() >= nd && v1.getMaxSpeed() >= ms)
            {
                found = true;
                Console.WriteLine("I found a car with this info : ");
                v1.showInfo();
            }
            //cond for v2

            if (v2.getPrice() <= pr && v2.getNumOfDoors() >= nd && v2.getMaxSpeed() >= ms)
            {
                found = true;
                Console.WriteLine("I found a car with this info : ");
                v2.showInfo();
            }
            //cond for v3
            if (v3.getPrice() <= pr && v3.getNumOfDoors() >= nd && v3.getMaxSpeed() >= ms)
            {
                found = true;
                Console.WriteLine("I found a car with this info : ");
                v3.showInfo();
            }

            if (!found)
            {
                Console.WriteLine("Sorry no car found");
            }


        }
    }

    public class Vehicle
    {

        private int numOfdoors;
        private double price;
        private int maxSpeed;


        public int getNumOfDoors()
        {
            return numOfdoors;
        }

        public double getPrice()
        {
            return price;
        }

        public int getMaxSpeed()
        {
            return maxSpeed;
        }

        public void setGetNumOfDoors(int nd)
        {
            if (nd < 0 || nd > 7)
            {
                Console.WriteLine("Input is wrong input");
                return;
            }
            numOfdoors = nd;
        }

        public void setPrice(double pr)
        {
            if (pr < 0 || pr > 300000)
            {
                Console.WriteLine("Input is wrong input");
                return;
            }
            price = pr;
        }

        public void setMaxSpeed(int ms)
        {
            if ((ms < 0) || (ms > 400))
            {
                Console.WriteLine("Input is wrong input");
                return;
            }
            maxSpeed = ms;
        }


        public void showInfo()
        {
            Console.WriteLine("This car has " + numOfdoors
                + "  number of the doors and the price  is " + price
                + " and the maximum speed is " + maxSpeed);
        }

    }


    //each class -> 1. attirbutes or properties 2.Methods or functions

}
