using System;
namespace UC2
{
    public class Class1
    {
        public int Length;
        public void CalculateLength()
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
            Console.WriteLine("Length of the Line is:"+Length);
        }
    }
}
