using System;

namespace helloUniverse //Esta forma de denominar un namespace no es correcta, debe ser pascal case: HelloUniverse
{
    class Program
    {
        static void Main(String[] args)
        {
            Console.WriteLine("Hello Universe!");
            Console.WriteLine("This is my first App in C#!");
            Console.WriteLine("What's you name? Please write your full name");
            string fullUserName=Console.ReadLine(); //Se puede usar var, pues funciona como tipo de dato según sea detectado por C#

            Console.WriteLine("Hello, " + fullUserName + ". Welcome to the Universe");
        }
    }
}