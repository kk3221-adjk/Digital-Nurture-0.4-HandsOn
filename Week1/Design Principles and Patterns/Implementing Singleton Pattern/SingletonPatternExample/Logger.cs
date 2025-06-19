using SingletonPatternExample;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonPatternExample
{
    public class Logger
    {
        private Logger() { }

        private static Logger instance = new Logger();

        public static Logger GetInstance()
        {
            return instance;
        }

        public void Log(string message)
        {
            Console.WriteLine(message);
        }
    }
}

//public static Logger GetInstance()
//{
//    if (instance == null)
//    {
//        lock (locker)
//        {
//            if (instance == null)
//                instance = new Logger();
//        }
//    }
//    return instance;
//}
