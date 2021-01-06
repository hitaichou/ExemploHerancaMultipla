using System;

namespace ExemploHerancaMultipla.Devices
{
    //Implementando herança de classe abstrata e interface 
    class Printer : Device, IPrinter
    {
        //implementa método da Device
        public override void ProcessDoc(string document)
        {
            Console.WriteLine("Printer processing: " + document);
        }
        //Implementa método da classe IPrinter
        public void Print(string document)
        {
            Console.WriteLine("Printer print result");
        }
    }
}
