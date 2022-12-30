class Program
    {
        static void Main(string[] args)
        {


            double radius;
            double thickness = 0.4;

            Console.Write("Yarıçapını giriniz: ");
            if (!double.TryParse(Console.ReadLine(), out radius) || radius <= 0)
            {
                Console.WriteLine("eksi yarıçap olamaz");
                return;
            }

            while (radius <= 0) ;

            Console.WriteLine();
            double rin = radius - thickness, rOut = radius + thickness;

            for (double y = radius; y >= -radius; --y)
            {
                for (double x = -radius; x < rOut; x += 0.5)
                {
                    double value = x * x + y * y;
                    if (value >= rin * rin && value <= rOut * rOut)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }

        }
    }
