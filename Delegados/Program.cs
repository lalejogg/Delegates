using System;
using static Delegados.SamplesDelegate;

namespace Delegados
{

    public class SamplesDelegate
    {
        public delegate String myMethodDelegate(int myInt);

        public class mySampleClass
        {

            public String myStringMethod(int myInt)
            {
                if (myInt > 0)
                    return ("positive");
                if (myInt < 0)
                    return ("negative");
                return ("zero");
            }

            public static String mySignMethod(int myInt)
            {
                if (myInt > 0)
                    return ("+");
                if (myInt < 0)
                    return ("-");
                return ("");
            }
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            mySampleClass mySC = new mySampleClass();

            myMethodDelegate myD1 = new myMethodDelegate(mySC.myStringMethod);
            myMethodDelegate myD2 = new myMethodDelegate(mySampleClass.mySignMethod);

            //FORMA CLASICA
            Console.WriteLine(mySC.myStringMethod(1));
            Console.WriteLine(mySampleClass.mySignMethod(1));

            //CON DELEGADOS
            Console.WriteLine("{0} is {1}; use the sign \"{2}\".", 5, myD1(5), myD2(5));
            Console.WriteLine("{0} is {1}; use the sign \"{2}\".", -3, myD1(-3), myD2(-3));
            Console.WriteLine("{0} is {1}; use the sign \"{2}\".", 0, myD1(0), myD2(0));

            Console.Read();
        }






    }

}