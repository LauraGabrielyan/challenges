namespace challangee1
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

            if (number1 > number2)
            {
                Console.WriteLine("Number1>Number2");
            } 
            if (number1 < number2)
            {
                Console.WriteLine("Number1<Number2");
            }
             if(number1>number3)
            {
                Console.WriteLine("Number1>Number3");
            }
             if (number1 < number3)
            {
                Console.WriteLine("Number1<Number3");
            } 
           if (number2 > number3)
            {
                Console.WriteLine("Number2>Number3");
            }
            else
            {
                Console.WriteLine("Number2<Number3");
            }
        }
    }
}
