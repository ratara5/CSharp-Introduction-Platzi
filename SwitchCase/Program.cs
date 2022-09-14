using System;

namespace switchCase //La forma de denominar un namespace debe ser pascal case: SwitchCase
//En este programa también hay una práctica de ciclo for
{
    class Program
    {
        static void Main(String[] args)
        {
            Console.WriteLine("Please, write a number between 1 and 4. You will be able to read in text");
            int number=Convert.ToInt32(Console.ReadLine());

            switch(number)
            {
                case 1:
                    string cad="One";
                    char[] cha = cad.ToCharArray();
                    for(int i=0; i<cha.Length; i++) //It means for i from 0 to the integer minor than 50, which is 49. But from 0 to 49 there is 50 numbers (one by one) //int i=0; i==cha.Lenght-1; i++ doesn't work
                    {
                        Console.WriteLine($"{cha[i]}");
                    }
                    break;
                case 2:
                    Console.WriteLine("Two");
                    for(int i=0; i<=50; i+=10) //It means for i from 0 to 50. But from 0 to 50 there is 6 numbers (ten by ten)
                    {
                        Console.WriteLine("{0}",i); //Other way to write with Console.WriteLine()
                    }
                    break;
                case 3:
                    Console.WriteLine("Three");
                    for(int i=-10, j=0; i<=0 && j<=10; i++, j++) 
                    {
                        Console.WriteLine($"i={i}, j={j}"); //
                    }
                    break;
                case 4:
                    Console.WriteLine("Four");
                    break;
                default:
                    Console.WriteLine("You didn't enter a valid number");
                    break;
            }

        }
    }
}