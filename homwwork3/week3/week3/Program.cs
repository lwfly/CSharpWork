using System;


namespace week3
{

    class Program
    {
        static void Main(string[] args)
        {
            double areaSum=0;
            for (int i=1;i<=10;i++)
            {
                Graphical a = SimpleFactory.NewShape(SimpleFactory.GetResult());
                while (!a.isLegal())
                {
                    a = SimpleFactory.NewShape(SimpleFactory.GetResult());
                }
                areaSum += a.Area;

            }
            Console.WriteLine("These shapes' area is "+areaSum.ToString());
        }
    }


}
