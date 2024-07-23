using ISP.Documen;
using ISP.Impresoras;
using ISP.Interface;
class Program
    {
        static void Main(string[] args)
        {
            Document document = new Document { Name = "Documento1", Description = "Aplicando el Principio de segregación de interfaz (ISP)" };

            IPrint simplePrinter = new SimplerPrinter();
            simplePrinter.Print(document);

            IPrint multiFunctionPrinter = new MultiFunctionPrinter();
            multiFunctionPrinter.Print(document);

            IScan multiFunctionScanner = new MultiFunctionPrinter();
            multiFunctionScanner.Scan(document);
        }
    }

