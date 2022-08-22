using System;
namespace UC3
{
    class Class1
    {
        public int i;
        public int Length;
        public int L1;
        public int L2;
        public void CalculateLength()
        {
            for (i = 0; i < 2; i++)
            {
                Console.Write("Enter FIRST point coordinates:\n");
                Console.Write("X Coordinate : ");
                int x1 = Convert.ToInt32(Console.ReadLine());
                Console.Write("Y Coordinate : ");
                int y1 = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter SECOND point coordinates:\n");
                Console.Write("X Coordinate : ");
                int x2 = Convert.ToInt32(Console.ReadLine());
                Console.Write("Y Coordinate : ");
                int y2 = Convert.ToInt32(Console.ReadLine());
                Console.Write("We can represent the line by its 2 Points as: (" + x1 + "," + y1 + ") and (" + x2 + "," + y2 + ")\n");
                Length = Convert.ToInt32(Math.Sqrt((Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2))));
                if (i == 0)
                {
                    L1 = Length;
                    Console.WriteLine("Length of the First Line is:" + L1 + "\n");
                    Console.WriteLine("\n");
                    Console.WriteLine("For Second Line:");
                }
                else
                {
                    L2 = Length;
                    Console.WriteLine("Length of the Second Line is:" + L2 + "\n");
                }
            }
        }
        public void CompareLines()
        {
            if (L1 == L2)
            {
                Console.WriteLine("Lines are Equal.");
            }
            else if (L1 > L2)
            {

                Console.WriteLine("Line1 is longer than Line2.");
            }
            else
            {
                Console.WriteLine("Line1 is shorter than Line2.");
            }
        }
    }
}
