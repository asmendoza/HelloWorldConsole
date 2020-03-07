using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorldConsole
{
    class Program
    {
        string MyName = "";

        int squareMe(int theNumber)
        {
            int theRet;

            theRet = theNumber * theNumber;

            return theRet;
        }

        void HelloWorld()
        {
            string hello = "Hello ";
            MyName = Console.ReadLine();
            Console.Write("Output of global MyName: ");
            Console.WriteLine(hello + MyName + "!");
        }
        static void Main(string[] args)
        {
            string MyName = "Haha!";
            Console.Write("Enter your name: ");

            Program p = new Program();
            p.HelloWorld();
            Console.Write("Output of local MyName: ");
            Console.WriteLine(MyName 
                + p.squareMe(5).ToString() + "x");
            Console.WriteLine("Hahaha!");
            Console.ReadLine();
            
        }
    }
}
