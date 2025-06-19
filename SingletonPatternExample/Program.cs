using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace SingletonPatternExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Logger logger1 = Logger.GetInstance();
            logger1.Log("First Logger!");

            Logger logger2 = Logger.GetInstance();
            logger2.Log("Second Logger!");

            if(logger1 == logger2)
            {
                Console.WriteLine("Both are same instance!");
            }
            else
            {
                Console.WriteLine("Both are different instance!");
            }
        }
    }
}
