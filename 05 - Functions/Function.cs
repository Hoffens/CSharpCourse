namespace CSharpCourse.Functions
{
    public class Function
    {
        public Function() 
        {
            int myNum = 2;
            // Named parameters. It's a best practice because it improves code redeability of code
            MyFunction(param1: "Hello", param2: "World");
            MyFunctionWithOptionalParams(param1: "Hello");

            // Params avoid the manual initialization of an array of strings
            MyFunctionWithParams("Word1", "Word2", "Word3");
            MyFunctionWithRefParams(ref myNum);

            // Lambda function
            int Sum(int a, int b) => a + b;     // its returning the sum of a + b
            myNum = Sum(1, 2);
        }

        /*
         * Static methods can be invoked without creating a instance of the class,
         * because they don't access properties of the class
        */
        static void MyFunction (string param1, string param2) 
        {
            Console.WriteLine($"{param1} {param2}");
        }

        /*
         * OPTIONAL PARAMETERS
         * We can provide a default value to define an optional parameter. 
         * They must be in the final of the function definition.
         * Default means the default value of the data type (for param3 the default value is false).
        */
        static void MyFunctionWithOptionalParams(string param1, string param2 = "Default value", bool param3 = default)
        {
            Console.WriteLine($"{param1} {param2} {param3}");
        }

        /*
         * Params
         * Simplifies the invocation of the function if it contains an array
         * It must be the last parameter in the function definition
        */
        static void MyFunctionWithParams(params string[] param)
        {
            foreach (var word in param)
            {
                Console.WriteLine(word);
            }
        }

        /*
         * param is passed as reference, its means that it will change
         * outside the function
        */
        static void MyFunctionWithRefParams(ref int param)
        {
            param *= 2;
        }
    }
}