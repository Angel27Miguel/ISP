using ISP.Documen;
using ISP.Interface;

namespace ISP.Impresoras
{
    public class MultiFunctionPrinter : Iprint, IScan
    {
        public void Print(Document document)
        {
            Console.WriteLine($"Impresora multifuncional");
            Console.WriteLine($"Imprimir documento: {document.Name}\n");
        }

        public void Scan(Document document)
        {
            Console.WriteLine($"Impresora multifuncional");
            Console.WriteLine($"Escanear documento: {document.Name}\n");
        }
    }
}
