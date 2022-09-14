
// Console.WriteLine("Hello, World!"); //En vstudio 2022 ya no se preescriben namespaces ni clases, ni son necesarias

using System;

namespace NumericCalculator //Esta forma de denominar un namespace no es correcta, debe ser pascal case: HelloUniverse
{
    class Calculator
    {
        static void Main(String[] args)
        {
            int numberOne;
            int numberTwo;
            Console.WriteLine("Input the first number");
            numberOne = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Input the second number");
            numberTwo = Convert.ToInt32(Console.ReadLine());

            int result=numberOne*numberTwo;
            Console.WriteLine("The result is: "+result);

        }
    }
}