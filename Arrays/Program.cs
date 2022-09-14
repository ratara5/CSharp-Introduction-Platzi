using System;

namespace Arrays //Esta forma de denominar un namespace no es correcta, debe ser pascal case: HelloUniverse
{
    class Program
    {



        static void Main(String[] args)
        {
            string[] coffeeTypes;
            float[] coffeePrices;
            coffeeTypes=new string[] {"Expresso","Latte","Capuccino","Mocca","Largo","Filtrado"};
            coffeePrices=new float[] {1.2f,5.0f,2.1f,2.2f,2.4f,1.7f};

            coffeeTypes[4]="Large";
            coffeeTypes[5]="Filtered";

            for (int i=0;i<coffeeTypes.Length;i++)
                Console.WriteLine(coffeeTypes[i]+": "+"$"+coffeePrices[i]);


            int[] integers = { 2, 4, 6, 8, 10, 12, 14, 16, 18, 20 };
            // Get the upper and lower bound of the array.
            int upper = integers.GetUpperBound(0); 
            int lower = integers.GetLowerBound(0);
            Console.WriteLine(upper); //9
            Console.WriteLine(lower); //0 Is posible this returns a number not equal to zero?

            int[,] integers2d= { {2, 4}, {3, 9}, {4, 16}, {5, 25}, {6, 36}, {7, 49}, {8, 64}, {9, 81} };
            upper = integers2d.GetUpperBound(1); //1
            lower = integers2d.GetLowerBound(0); //0 Is posible this returns a number not equal to zero?
            Console.WriteLine(upper);
            Console.WriteLine(lower);

            int[,,] integers3d= { {{2}, {4}, {8}}, {{3}, {9}, {27}}, {{4}, {16}, {64}}, {{5}, {25}, {126}}, {{6}, {36}, {216}}, {{7}, {49}, {483}}, {{8}, {64}, {512}}, {{9}, {81}, {729}} };
            // Get the number of dimensions.
            int rank = integers3d.Rank;
            Console.WriteLine($"Number of dimensions: {rank}"); //3
        }
    }
}