﻿namespace CSharpCourse._06___Classes__structs_and_records
{
    public class Module6
    {
        //  Properties
        //  Allow us to encapsulate the attributes of a class

        private int _id;
        public int Id
        { 
            get { return _id + 1; }     // this get the value of _id + 1
            set { _id = value; }    // this set the value of id
        }
        
        // If we are going to only read and set the value of an attribute, its not necessary to
        // add that property
        public string Name { get; set; }    // this get and set the value of name

        // We can also set default values to properties
        public string LastName { get; set; } = "I'm a default value!";

        // Read only property
        public string AccountId { get; } = "No account";

        // Read only property with lambda expression
        public string FullName => $"{Name} {LastName}";

        // Private set, only can be modified inside the class
        public string Email { get; private set; } = "No email";

        /*
         * Constructor
         * The first method that executes when an instance of the class is created
        */
        public Module6(string name, string lastName)
        {
            Console.WriteLine("Creating Module6...");
            Name = name;
            LastName = lastName;
        }

        /*
         * Methods
         * Are functions that we can use inside a class
        */
        public void ChangeEmail(string email)
        {
            Email = email;
        }

        // One line method with lambda expression
        public void ChangeName(string name) => Name = name;

        /*
         * Method overloading
         * We can have methods with the same name but different parameters
         * Changing the orders of parameters too
        */
        public void ChangeName() => Name = "Overloading";
    }
}
