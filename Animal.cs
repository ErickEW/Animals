using System;

namespace Animals{

    abstract class Animal
    {
    protected string name;

    protected string lastName;

    public string LastName {
        get => $"Sr.{lastName}";
        set => lastName = value;
        }

    public abstract void MakeSound();

    public string GetFullName() {
        return $"{this.name} {this.lastName}";
    }
    }
}