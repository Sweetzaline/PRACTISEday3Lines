using System;

namespace UC2
{
    class Program
    {
        public int L1;
        public int L2;
        static void Main(string[] args)
        {

            Console.WriteLine("Hello! I am a big fan of Geometry :)");
            Console.WriteLine("Let's play with Lines.");
            Console.WriteLine("_---___------_____--------_______-----------_________--------------______________\n");
            Console.WriteLine("Let us find length of any 2 lines.\n");
            Console.WriteLine("For First Line:");
            Class1 obj = new Class1();
            obj.CalculateLength();
            obj.CheckEquality();
        }
    }
}










