using System;
namespace ExemploHerancaMultipla.Devices
{
    //implementa herança da classe abstrata Device
    //implementa as duas interfaces IScanner e IPrinter
    //desta forma é possível fazer "multiplas heranças"
    class ComboDevice : Device, IScanner, IPrinter
    {
        public void Print(string document)
        {
            Console.WriteLine("ComboDevice print " + document);
        }

        public override void ProcessDoc(string document)
        {
            Console.WriteLine("ComboDevice processing " + document);
        }

        public string Scan()
        {
            return "ComboDevice scan result";
        }
    }
}
