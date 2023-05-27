namespace CSharpCourse._07___OOP.Inheritance
{
    // Base class. Is an abstract class, it means that cannot have instances
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
        // Implementing MaxSpeed property of the Vehicle abstract class
        public override int MaxSpeed => 15;

        public override void HonkHorn()
        {
            Console.WriteLine("Tirin");
        }
    }
}
