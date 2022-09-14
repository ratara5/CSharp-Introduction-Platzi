using System;

namespace MyMethods //Esta forma de denominar un namespace no es correcta, debe ser pascal case: HelloUniverse
{
    class Program
    {
        public float FloatSum(float a, float b)
        {
            float sum=a+b;
            return sum;
        }

        public float FloatSubs(float a, float b)
        {
            float subs=a-b;
            return subs;
        }

        public float FloatProd(float a, float b)
        {
            float prod=a*b;
            return prod;
        }

        public float FloatDiv(float a, float b)
        {
            float div=a/b;
            return div;
        }
        static void Main(String[] args)
        {
            Program program=new Program();
            Console.WriteLine("Enter the first float");
            float value1=float.Parse(Console.ReadLine());
            Console.WriteLine("Enter the second float");
            float value2=float.Parse(Console.ReadLine());

            float result=program.FloatSum(value1, value2);
            Console.WriteLine("The sum is: "+result);

            result=program.FloatSubs(value1, value2);
            Console.WriteLine("The subs is: "+result);

            result=program.FloatProd(value1, value2);
            Console.WriteLine("The prod is: "+result);

            result=program.FloatDiv(value1, value2);
            Console.WriteLine("The div is: "+result);
        }
    }
}