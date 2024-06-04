namespace multilevel
{
    internal class Program
    {
        static void Main(string[] args)

        {
            Console.WriteLine("Please enter user age");
            sbyte userage=Convert.ToSByte(Console.ReadLine());
            Console.WriteLine("Please enter user gender ");
            string usergender=Convert.ToString(Console.ReadLine()).ToLower();
            Console.WriteLine("Please enter true if user student and false otherwise");
            bool userstudent=Convert.ToBoolean(Console.ReadLine());
            Console.WriteLine("Please enter true if user works and false otherwise");
            bool userworks = Convert.ToBoolean(Console.ReadLine());
            if (userage < 18)
            {
                if (usergender == "male")
                {
                    if (userstudent) 
                    {
                        Console.WriteLine("You  are a young male student");
                        if (userworks)
                        {
                            Console.WriteLine("You are a young male  student who also works");

                        }
                        if (!userworks)
                        {
                            Console.WriteLine("You are a young male  student who  dose not work");

                        }

                    }
                    if(!userstudent)
                    {
                        if (userworks)
                        {
                            Console.WriteLine("You are a young male non student who works");

                        }
                        if (!userworks)
                        {
                            Console.WriteLine("You are a young male non student who  dose not work");

                        }


                    }
                }
                if (usergender == "female")
                {
                    if (userstudent)
                    {
                        Console.WriteLine("You  are a young female student");
                        if (userworks)
                        {
                            Console.WriteLine("You are a young female  student who also works");

                        }
                        if (!userworks)
                        {
                            Console.WriteLine("You are a young female  student who  dose not work");

                        }

                    }
                    if (!userstudent)
                    {
                        if (userworks)
                        {
                            Console.WriteLine("You are a young female non student who works");

                        }
                        if (!userworks)
                        {
                            Console.WriteLine("You are a young female non student who  dose not work");

                        }


                    }
                }

            }
           
            if (userage > 18)
            {
                if (usergender == "male")
                {
                    if (userstudent)
                    {
                        Console.WriteLine("You  are a adult male student");
                        if (userworks)
                        {
                            Console.WriteLine("You are a adult male  student who also works");

                        }
                        if (!userworks)
                        {
                            Console.WriteLine("You are a adult male  student who  dose not work");

                        }

                    }
                    if (!userstudent)
                    {
                        if (userworks)
                        {
                            Console.WriteLine("You are a adult male non student who works");

                        }
                        if (!userworks)
                        {
                            Console.WriteLine("You are a adult male non student who  dose not work");

                        }


                    }
                }


                if (usergender == "female")
                {
                    if (userstudent)
                    {
                        Console.WriteLine("You  are a adult female student");
                        if (userworks)
                        {
                            Console.WriteLine("You are a adult female  student who also works");

                        }
                        if (!userworks)
                        {
                            Console.WriteLine("You are a adult female  student who  dose not work");

                        }

                    }
                    if (!userstudent)
                    {
                        if (userworks)
                        {
                            Console.WriteLine("You are a adult female non student who works");

                        }
                        if (!userworks)
                        {
                            Console.WriteLine("You are a adult female non student who  dose not work");

                        }


                    }
                }

            }


        }
    }
}
