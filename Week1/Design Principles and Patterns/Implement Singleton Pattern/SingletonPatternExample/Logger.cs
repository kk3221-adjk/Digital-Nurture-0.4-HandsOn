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

        private static Logger instance = null;

        public static Logger GetInstance()
        {
            if (instance == null)
                instance = new Logger();
            return instance;
        }

        public void Log(string message)
        {
            Console.WriteLine(message);
        }
    }
}
