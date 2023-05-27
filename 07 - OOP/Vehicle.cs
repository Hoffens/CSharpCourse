namespace CSharpCourse._07___OOP.Inheritance
{
    // All classes inherited from Object
    // Base class. Is an abstract class, it means that cannot have instances
    // Limits of Inheritance!!
    /*
     * 1- A class can't be inherited by more than one class at the same time.
     * 2- Inheritance could make a software difficult to mantain.
    */
    // Access modifiers https://learn.microsoft.com/en-us/dotnet/csharp/programming-guide/classes-and-structs/access-modifiers
    internal abstract class Vehicle
    {
        public string? Brand { get; set; }
        public int CreationYear { get; set; }
        public int Speed { get; private set; }

        /*
         * Each MaxSpeed is different in the vehicles, so here we are
         * saying that each class must implement the property MaxSpeed
        */
    public abstract int MaxSpeed { get; }

        /*
         * All classes that inherited from Vehicle must use the constructor 
         * (if it has params) of the base class
        */
        public Vehicle(string brand)
        {
            Brand = brand;
        }

        /*
         *  Virtual keyword allow the inherited classes of vehicle to
         *  implement a custom functionality to Reverse() method
        */
        public virtual void Reverse()
        {
            Console.WriteLine("Reverse - Default implementation");
        }

        /*
         * Abstract method. All the classes that are vehicle (inherited) 
         * MUST implement this method
        */
        public abstract void HonkHorn();

        internal void SpeedUp(int increment = 1)
        {
            /* 
             * Here the MaxSpeed property is the implementation of each class.
             * It means that if this method is called by an instance of Car,
             * MaxSpeed will be the implementation of Car
            */
            if (Speed >= MaxSpeed)
            {
                Console.WriteLine("Reached max speed");
                return;
            }

            if (Speed + increment > MaxSpeed)
            {
                increment = MaxSpeed - Speed;
            }

            Speed += increment;
        }
    }

    // Class Car inherited the properties of Vehicle
    internal class Car : Vehicle
    {
        public Car(string brand) : base(brand)
        {
        }

        // Implementing MaxSpeed property of the Vehicle abstract class
        public override int MaxSpeed => 120;

        public override void HonkHorn()
        {
            Console.WriteLine("BIP BIP");
        }

        public void TurnOnRadio()
        {
            Brand = "";
            Console.WriteLine("Turning on radio...");
        }
    }

    // Class Truck inherited the properties of Vehicle
    internal class Truck : Vehicle
    {
        public Truck(string brand) : base(brand)
        {
        }

        // Implementing MaxSpeed property of the Vehicle abstract class
        public override int MaxSpeed => 80;

        public override void HonkHorn()
        {
            Console.WriteLine("PON POOOOOOON");
        }

        /*
        * Here we are extending the implementation of the base class
        */
        public override void Reverse()
        {
            base.Reverse();     // Invoking implementation of the base class
            Console.WriteLine("BEEP! BEEP! BEEP!");
        }
    }

    internal class Bicycle : Vehicle
    {
        public Bicycle(string brand) : base(brand)
        {
        }

        // Implementing MaxSpeed property of the Vehicle abstract class
        public override int MaxSpeed => 15;

        public override void HonkHorn()
        {
            Console.WriteLine("Tirin");
        }
    }

    /*
     * Sealed class. Can't be inherited
     * It improves performance a little bit, thanks to the way that .NET
     * organizes virtual methods
    */
    internal sealed class CantBeInherited
    {

    }
}
