namespace Assignmnet1
{
    internal class Program
    {
        const string PASSWORD = "password";
        static void Main(string[] args)
        {
            Console.WriteLine("WElcome to my computer store: ");
            Console.WriteLine("Enter maximum number of computers :");
            int maxComputers = int.Parse(Console.ReadLine());

            Computer[] inventory = new Computer[maxComputers];//{}
            //Computer[] in1 = new Computer[2] //{null,null}

            int choice;
            int count = 0;


            do
            {
                DisplayMenu();
                choice = GetMenuChoice();

                switch (choice)
                {
                    //check password
                    //getnb of howmany  check the inventory size 
                    //create my object 
                    //added to  my inventory 

                    //count++   vs ++count

                    case 1:
                        if (CheckPass())
                        {
                            Console.WriteLine("how many computers you wants to enter");
                            int num = int.Parse(Console.ReadLine());
                            if (count + num > maxComputers || num < 0)
                            {
                                Console.WriteLine(" you dont have that much space in your inventory or the value is wrong");
                                break;
                            }
                            for (int i = 0; i < num; i++)
                            {
                                Console.WriteLine("For Computer " + (i + 1) + ": ");
                                Console.WriteLine("Brand:");
                                string brand = Console.ReadLine();
                                Console.WriteLine("Model:");
                                string model = Console.ReadLine();
                                Console.WriteLine("SN:");
                                long serialnum = long.Parse(Console.ReadLine());
                                Console.WriteLine("Price:");
                                double price = double.Parse(Console.ReadLine());
                                Computer c = new Computer(brand, model, serialnum, price);
                                inventory[count++] = c;
                            }
                        }
                        break;

                    //int[] arr1 = new arr[4] -> {0,0,0,0}
                    //string[] arr2 = new arr[4] -> {null,null,null, null}
                    //check password
                    //sze = 5
                    //[c1,c2,-,-,-]
                    case 2:
                        if (CheckPass())
                        {
                            Console.WriteLine("which computer number you wishes to update");
                            int index = int.Parse(Console.ReadLine());

                            if (index < 0 || index > inventory.Length || inventory[index] == null)
                            {
                                Console.WriteLine("No computer in this index");
                            }
                            else
                            {
                                //first display and then modify it 
                                Console.WriteLine("Computer " + index + ":");
                                Console.WriteLine(inventory[index]);

                                //modify it by method 
                                UpdateComp(inventory[index], index);
                            }
                        }
                        break;

                    case 3:
                        Console.WriteLine("Enter the brand you are looking for: ");
                        string br = Console.ReadLine();
                        FindComputersByBrand(inventory, br);
                        break;

                    case 4:
                        Console.WriteLine("Enter the price you are looking for: ");
                        double pr = double.Parse(Console.ReadLine());
                        FindComputersBy(inventory, pr);
                        break;
                    case 5:
                        Console.WriteLine("bye");
                        break;

                }


            } while (choice != 5);
        }

        public static void DisplayMenu()
        {
            Console.WriteLine("Main Menu : ");
            Console.WriteLine("1. Enter new Computer");
            Console.WriteLine("2. Update Computer ");
            Console.WriteLine("3. Find computer by brand");
            Console.WriteLine("4. Find Computer cheaper than a price");
            Console.WriteLine("5. Exit");
        }

        public static int GetMenuChoice()
        {
            int choice;
            do
            {
                Console.WriteLine("Enter your Choice[1-5] :");
                choice = int.Parse(Console.ReadLine());
            } while (choice < 1 || choice > 5);

            return choice;
        }

        public static bool CheckPass()
        {
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("Please Give me Password : ");
                if (Console.ReadLine() == PASSWORD)
                {
                    return true;
                }
            }
            Console.WriteLine("Incorret pass , return to Menue");
            return false;
        }

        //updating computer

        public static void UpdateComp(Computer c, int index)
        {

            int option;

            do
            {
                Console.WriteLine("what information you want to change : ");
                Console.WriteLine("1. Change Brand");
                Console.WriteLine("2. Change Model ");
                Console.WriteLine("3. Change Serial number");
                Console.WriteLine("4. Change Price");
                Console.WriteLine("5. Quit");
                Console.WriteLine("Choice : ");
                option = int.Parse(Console.ReadLine());

                switch (option)
                {
                    case 1:
                        Console.WriteLine("New Brand");
                        c.SetBrand(Console.ReadLine());
                        break;
                    case 2:
                        Console.WriteLine("New Model");
                        c.SetModel(Console.ReadLine());
                        break;
                    case 3:
                        Console.WriteLine("New SN");
                        c.SetSerialNumber(long.Parse(Console.ReadLine()));
                        break;
                    case 4:
                        Console.WriteLine("New Price");
                        c.SetPrice(double.Parse(Console.ReadLine()));
                        break;

                }

            } while (option != 5);

        }


        public static void FindComputersByBrand(Computer[] comps, string brand)
        {
            for (int i = 0; i < comps.Length; i++) {
                if (comps[i]!=null && comps[i].GetBrand() == brand) {
                    Console.WriteLine(comps[i]);
                }
            }

        }

        public static void FindComputersBy(Computer[] comps, double pr)
        {

            foreach (Computer c in comps)
            {
                if (c != null && c.GetPrice() < pr)
                {
                    Console.WriteLine(c);
                }
            }
        
        }

    }


    }

    public class Computer
    {
        private string brand;
        private string model;
        private long serialnumber;
        private double price;

        private static int numberOFCreatedComputer = 0; 

        public Computer(string brand, string model, long serialnumber, double price)
        {
            this.brand = brand;
            this.model = model;
            this.serialnumber = serialnumber;
            this.price = price;
            numberOFCreatedComputer++;
        }
        public string GetBrand() { 
            return brand;
        }
        public string GetModel() { 
            return model;
        }
        public long GetSerialNumber()
        {
            return serialnumber;
        }
        public double GetPrice() { 
            return price;
        }

        public void SetBrand(string brand) { 
            this.brand = brand;
        }

        public void SetModel(string model) { 
            this .model = model;
        }

        public void SetSerialNumber(long serialnumber) { 
            this.serialnumber = serialnumber;
        }

        public void SetPrice(double price) { 
            this.price = price;
        }

        public override string ToString()
        {
            return $"Brand: {brand}  \nModel: {model} \nSN: {serialnumber} \nPrice: {price}";
        }


        public static int findNumberOfCreatedComputers() { 
            return numberOFCreatedComputer;
        }

    }

