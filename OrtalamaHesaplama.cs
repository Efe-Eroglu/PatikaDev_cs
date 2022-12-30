class Program
    {
        static void Main(string[] args)
        {

            int length = Convert.ToInt32(Console.ReadLine());

            int n1 = 0;
            int n2= 1;
            int n3=n1+n2;

            int toplam=n3;

            for (int i= 2; i < length; i++)
            {
                
                n1= n2;
                n2= n3;
                n3= n2+ n1;
                toplam += n3;
                Console.WriteLine(n3);
            }
            
            double ortalama= (double)toplam /length;
            Console.WriteLine(ortalama);
        }
    }
