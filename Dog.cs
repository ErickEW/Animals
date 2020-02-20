using System;

namespace Animals{

    class Perro : Animal 
    {
        public Perro(string lastName) {
            this.name = "Perro";
            this.lastName = lastName;
        }
    
     public override void MakeSound(){
        Console.WriteLine($"{this.name} goes Guau!");
     }
    }
}