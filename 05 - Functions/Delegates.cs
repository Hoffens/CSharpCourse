namespace CSharpCourse.Functions
{
    public class Delegates
    {
        public Delegates() 
        {
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
            Func<string> myNewFunction3;   // Stores a reference to a string function without parameters
            myNewFunction3 = CurrentDate;
            string actualDate = myNewFunction3();   // Invokes the function, now actualDate has a value.

            /* TODO */
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

        static void MyFullName(string name, string lastname)
        {
            Console.WriteLine($"{name} {lastname}");
        }

        static string CurrentDate()
        {
            return DateTime.Now.ToString();
        }
    }
}
