namespace challenge2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number1");
            int number1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter number2");
            int number2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter number3");
            int number3 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter number4");
            int number4 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter number5");
            int number5 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter number6");
            int number6 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter number7");
            int number7 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter number8");
            int number8 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter number9");
            int number9 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter number10");
            int number10 = Convert.ToInt32(Console.ReadLine());
            

            int maxnumber = number1;
            if (maxnumber < number2)
            {
                maxnumber = number2;
            }
            if (maxnumber < number3)
            {
                maxnumber = number3;
            }
            if (maxnumber < number4)
            {
                maxnumber = number4;
            }
            if (maxnumber < number5)
            {
                maxnumber = number5;
            }
            if (maxnumber < number6)
            {
                maxnumber = number6;
            }
            if (maxnumber < number7)
            {
                maxnumber = number7;
            }
            if (maxnumber < number8)
            {
                maxnumber = number8;
            }
            if (maxnumber < number9)
            {
                maxnumber = number9;
            }
            if (maxnumber < number10)
            {
                maxnumber = number10;
            }
            Console.WriteLine("The max number is " + maxnumber);
           
        }
    }
}
