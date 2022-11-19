namespace LiniaŁamana
{
    struct Punkt
    {
        public double X;
        public double Y;
    }

    internal class Program
    {
        static Punkt CzytajPunkt()
        {
            Punkt p;
            Console.Write("x=");
            p.X = double.Parse(Console.ReadLine());
            Console.Write("y=");
            p.Y = double.Parse(Console.ReadLine());
            return p;
        }

        static double OdległośćAB(Punkt a, Punkt b)
        {
            return Math.Sqrt( (b.X-a.X)* (b.X - a.X) + (b.Y - a.Y) * (b.Y - a.Y));
        }

        static double DługośćLiniŁamanej(Punkt[] punkty )
        {
            double długość = 0.0;
            for (int i = 0; i < punkty.Length -1; i++)
            {
                długość += OdległośćAB(punkty[i], punkty[i + 1]);
            }
            return długość;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Ile punktów ma linia łamana?");
            
            int n = int.Parse(Console.ReadLine() ?? "");
            
            Punkt [] punkty = new Punkt[n];
            for (int i = 0; i < punkty.Length; i++)
            {
                Console.WriteLine("Podaj współżędne punktu {0}", i + 1);
                punkty[i] = CzytajPunkt();
            }

            double długość = DługośćLiniŁamanej(punkty);
            Console.WriteLine("Długość = {0}", długość);
        }
    }
}