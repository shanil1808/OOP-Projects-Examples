using System;
using System.Reflection.Metadata;

namespace OOPClass2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //how to create object -> nameOfClass nameOfObject = new nameOfClass();
            Vehicle v1 = new Vehicle();
           //if you want to access to the method of class, ur obj should call the method
            v1.showInfo();

            Vehicle v2 = new Vehicle();

            //int nd = v1.numberOfDoors; //getters
            //int nd = v1.getNumberOfDoors();

            //modify
            Console.WriteLine("Please give me number of door you want?");
            int nd = int.Parse(Console.ReadLine());
            v2.numberOfDoors = nd;
            //v2.color = "Red";
            v2.setNumberOfDoors(nd);
            v2.setColor("Purple");
            v2.showInfo();
        }
    }

    public class Vehicle
    {
        //attributes -> visibility type name
        public int numberOfDoors = 2;
        public string color = "Blue";
        //give it to you methods to access and change it if you want
        //mutators and accesseors, getter and setter

        //method to return to me number of doors
        public int getNumberOfDoors()
        {
            return numberOfDoors;
        }

        //method to return to me color
        public string getColor()
        {
             return color;
        }
           
        //method for changing them ->setters
        public void setNumberOfDoors(int nd)
        { //put condition
            if (nd < 0 || nd > 7)
            {
                Console.WriteLine("Invalid number of doors");
                return;
            }
        
            numberOfDoors = nd;
        }
        public void setColor(string cl)
        {
            color = cl;
        }

        public void showInfo()
        {
            Console.WriteLine("This car has " + numberOfDoors + " number of the doors " + "it is " + color);
        }

    }

  //each class -> 1.attributes or propertises   2.Methods or functions
}


