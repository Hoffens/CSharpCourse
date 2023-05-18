namespace CSharpCourse.Functions
{
    public class Delegates
    {
        public Delegates() 
        {
            // Delegates allow us to save references of functions

            /* 
             * Action
             * ONLY for void functions
             */
            Action myFunction; // Stores a reference to a void function without parameters
            myFunction = MyFunctionWithoutParams;
            myFunction();   // Invokes the function, will print Hello! in Console

            MyFunctionWithFuncAsParam(myFunction);  // will print Hello! in Console

            Action<string> myNewFunction;   // Stores a reference to a void function with a single parameter
            myNewFunction = MyName;
            myNewFunction("Nicolas");   // Invokes the function, will print Nicolas in Console

            Action<string, string> myNewFunction2;   // Stores a reference to a void function with a two parameteres
            myNewFunction2 = MyFullName;
            myNewFunction2("Nicolas", "Fernandez");   // Invokes the function, will print Nicolas Fernandez in Console

            /* Action<string, string, string, ...> for n parameters. They can be of different types */

            /* 
             * Func
             * For functions that return a value
             */
            Func<string> myNewFunction3;   // Stores a reference to a function without parameters that returns a string
            myNewFunction3 = CurrentDate;
            string actualDate = myNewFunction3();   // Invokes the function, now actualDate has a value.

            Func<int, string> myNewFunction4;   // the last data type is the type that returns the function
            myNewFunction4 = ReceiveIntReturnString;
            string newValue = myNewFunction4(23);   // Invokes the function, receive an int and returns a string

            /*
             * Predicate
             * It's a Func that always return a bool
            */
            Predicate<int> myPredicate;     // Stores a reference to a function with an int parameter that returns a bool
            myPredicate = IsEven;
            bool isEven = myPredicate(2);

            // Anonymous function: Functions without name
            Action anonFunc = () =>
            {
                Console.WriteLine("Anon. Func!");
            };
            anonFunc(); // executes the anon func

            Func<int, int> anonFunc2 = a => 2 * a;
            int result = anonFunc2(5);  // returns 2 * a
        }

        void MyFunctionWithoutParams()
        {
            Console.WriteLine("Hello!");
        }

        static void MyFunctionWithFuncAsParam(Action func)
        {
            func();
        }

        static void MyName(string name)
        {
            Console.WriteLine($"{name}");
        }

        static void MyFullName(string name, string lastname = "noLastName")
        {
            Console.WriteLine($"{name} {lastname}");
        }

        static string CurrentDate()
        {
            return DateTime.Now.ToString();
        }
        
        static string ReceiveIntReturnString(int value)
        {
            return value.ToString();
        }

        bool IsEven(int value)
        {
            return value % 2 == 0;
        }
    }
}
