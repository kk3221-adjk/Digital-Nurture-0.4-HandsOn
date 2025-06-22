using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodPatternExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DocumentFactory wordFactory = new WordDocumentFactory();
            Document wordDoc = wordFactory.createDocument();
            wordDoc.open();

            DocumentFactory pdfFactory = new PDFDocumentFactory();
            Document pdfDoc = pdfFactory.createDocument();
            pdfDoc.open();

            DocumentFactory excelFactory = new ExcelDocumentFactory();
            Document excelDoc = excelFactory.createDocument();
            excelDoc.open();

            Console.ReadLine();

        }
    }
}
