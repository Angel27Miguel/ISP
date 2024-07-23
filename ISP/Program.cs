using ISP.Documen;
using ISP.Impresoras;
using ISP.Interface;
class Program
    {
        static void Main(string[] args)
        {
            Document document = new Document { Name = "Documento1", Description = "Aplicando el Principio de segregación de interfaz (ISP)" };

            Iprint simplePrinter = new SimplerPrinter();
            simplePrinter.Print(document);

            Iprint multiFunctionPrinter = new MultiFunctionPrinter();
            multiFunctionPrinter.Print(document);

            IScan multiFunctionScanner = new MultiFunctionPrinter();
            multiFunctionScanner.Scan(document);
        }
    }

