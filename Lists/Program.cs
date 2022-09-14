using System;

namespace Lists //Esta forma de denominar un namespace no es correcta, debe ser pascal case: HelloUniverse
{
    class Program
    {



        static void Main(String[] args)
        {
            List<string> tacoShoppingList=new List<string>(); // Lists allows add and delete elements, Arrays doesn't allow
            tacoShoppingList.Add("5x Taco de suadero");
            tacoShoppingList.Add("4x Taco de tripa");
            tacoShoppingList.Add("5x Taco de pastor");
            tacoShoppingList.Add("10x Cola");

            for(int i=0;i<tacoShoppingList.Count;i++)
            {
                Console.WriteLine(tacoShoppingList[i]);
            }

            Console.WriteLine("------------------------------------------");

            tacoShoppingList.Remove("10x Cola"); ///The string to be deleted must be EXACTLY THE SAME in the list
            tacoShoppingList.RemoveAt(0);

            for(int i=0;i<tacoShoppingList.Count;i++)
            {
                Console.WriteLine(tacoShoppingList[i]);
            }

            Console.WriteLine("---------METHODS-------------");
            Random rnd=new Random(); //Random is a class belong to System library
            Console.WriteLine("A random number is: "+rnd.Next(1,20)); //Next is a method belong to Random class

            Console.WriteLine("---------STRING METHODS-------------");
            string cad= "Review to Split method";
            string[] cadSplit=cad.Split(new char[]{'e'});
            for (int i=0;i<cadSplit.Length;i++)
            {
                Console.WriteLine(cadSplit[i]);
            }

            string strCons=""; 
            char[] strChar=cad.ToCharArray();
            for (int i=0;i<strChar.Length;i++)
            {
                strCons+=strChar[i]+":-)";
            }
            Console.WriteLine(strCons);
        }
    }
}