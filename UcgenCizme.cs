class Program
    {
        static void Main(string[] args)
        {

			Console.Write("Kenar Uzunluğu: ");
			int length = Convert.ToInt32(Console.ReadLine());


            for (int i = 1; i <= length; i++)
            {
                for (int j = 1; j <=i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine("");
            }

        }
