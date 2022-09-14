using System;

namespace Operators //Esta forma de denominar un namespace no es correcta, debe ser pascal case: HelloUniverse
{
    class Program
    {
        static void Main(String[] args)
        {
            int value1;
            int value2=2;
            float value3;
            int value4=4;
            Console.WriteLine("Enter value1");
            value1=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter value3");
            value3=float.Parse(Console.ReadLine());
            bool result=(value1<value2) && (value4>value3);
            Console.WriteLine("The antiresult is " + !result);

        }
    }
}