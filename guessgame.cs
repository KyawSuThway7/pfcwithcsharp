using System;
namespace JumpStatmentTest2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Program start");
            bool value = true;
            if (value)//if(value==true)
            {
                Console.WriteLine("I am coming from brfore return statment");
                Console.WriteLine("press any key to close the window");
                Console.ReadKey();
                return;
            }
            Console.WriteLine("Hello, I am form after return statment");
            Console.WriteLine("program 2");
            bool values = true;
            if (values)
            {
                Console.WriteLine("Hello, Hi");
                Console.WriteLine("press any key to close the window");
                Console.ReadKey();
                return;
            }
            Console.WriteLine("hi Are you?");
            Console.WriteLine("Press any key to close the window");
            Console.ReadKey();

            Console.WriteLine("Press any key to close the window");
            Console.ReadKey();
        }
    }
}
