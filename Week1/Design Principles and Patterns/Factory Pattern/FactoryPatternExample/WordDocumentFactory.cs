using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodPatternExample
{
    public class WordDocumentFactory : DocumentFactory
    {
        public override Document createDocument()
        {
            return new WordDocument();
        }
    }
}
