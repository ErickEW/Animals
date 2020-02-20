using System;

namespace Animals
{
    class Program
    {
        static void Main(string[] args)
        {
         
            Pato pato= new Pato("Zapata");

            pato.MakeSound();
            pato.GetFullName();
            Console.WriteLine(pato.GetFullName());
            Console.WriteLine(pato.LastName);
            pato.LastName = "De la Suela";
            Console.WriteLine(pato.LastName);
            Console.WriteLine(pato.GetFullName());

            Animal perro = new Perro("Odin");
            Animal pato2 = new Pato("McDonald");

            Animal[] pets = new Animal[2];
            pets[0] = perro;
            pets[1] = pato2;
        }
    }
}
