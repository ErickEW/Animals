using System;

namespace Animals{

    class Pato : Animal 
    {
        public Pato(string lastName) {
            this.name = "Pato";
            this.lastName = lastName;
        }
    
     public override void MakeSound(){
        Console.WriteLine($"{this.name} goes Cuack!");
     }
    }
}