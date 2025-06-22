using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodPatternExample
{
    public class WordDocument : Document
    {
        public void open()
        {
            Console.WriteLine("Opening Word Document!");
        }
    }
}
