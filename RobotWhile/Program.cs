using System;

namespace RobotWhile //Mientras no haya peligros el Robot seguirá inspeccionando
{
    class Program
    {
        static void Main(String[] args)
        {
            Random rnd=new Random();
            int ale;
            int rem;
            
            do{
                ale=rnd.Next(1,100);
                Console.WriteLine("Inspecting...");
            }while(ale%2!=0);
            Console.WriteLine($"Alert: Danger detected!! Code {ale}");
            rem=ale-10;
            do{
                ale--;
                Console.WriteLine("Removing Danger...");
            }while(ale>rem);
            Console.WriteLine($"Advice: Danger removed. Success code {rem}");

        }
    }
}