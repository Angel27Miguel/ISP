﻿using ISP.Documen;
using ISP.Interface;

namespace ISP.Impresoras
{
    public class SimplerPrinter : Iprint
    {
        public void Print(Document document)
        {
            Console.WriteLine($"Impresora simple");
            Console.WriteLine($"Imprimir documento: {document.Name}\n");
        }
    }
}