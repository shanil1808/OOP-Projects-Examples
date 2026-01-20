namespace SimpleAddition
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(add(3, 5));
            Console.WriteLine(add(3.6, 5));
            Console.WriteLine(add(3, 8.6));
            Console.WriteLine(add(3.9, 5.7));
            Console.WriteLine(add(3, 5, 9));
        }

        //the overlapping methods

        public static int add(int x, int y)
        {
            return x + y;
        }

        public static double add(double a, int b)
        {
            return a + b;
        }

        public static double add(int a, double b)
        {
            return a + b;
        }

        public static double add(double a, double b)
        {
            return a + b;
        }

        public static int add(int x, int y, int z)
        {
            return x + y + z;
        }
    }
}
