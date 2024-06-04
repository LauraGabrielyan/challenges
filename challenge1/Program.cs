namespace challenge1
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
           
            
            int maxnumber = number1;
            if (maxnumber < number2)
            {
                maxnumber = number2;
            }
            if (maxnumber < number3)
            {
                maxnumber = number3;
            }
            
            Console.WriteLine("The max number is " + maxnumber);
        }
    }
}
