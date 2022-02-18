namespace Stopwatch
{
    class Stopwatch
    {
        static void Main(String[] args)
        {
            Menu();
        }

        static void Menu()
        {
            Console.Clear();

            Console.WriteLine("S = Segundo");
            Console.WriteLine("M = Minuto");
            Console.WriteLine("H = Hora");
            Console.WriteLine("Deseja cronometrar: ");
            string tpTime = Console.ReadLine();

            Console.WriteLine("Quanto tempo deseja contar?");
                int count = int.Parse(Console.ReadLine());

            switch (tpTime)
            {
                case "S":
                    CalcSeconds(count);
                    break;
                case "M":
                    CalcMinutes(count);
                    break;
                case "H":
                    CalcHours(count);
                    break;
                default:
                    break;
            }
        }

        static void CalcSeconds(int time)
        {
            int currentTime = 0;

            while (currentTime != time)
            {
                Console.Clear();
                currentTime++;
                Console.WriteLine(currentTime);
                Thread.Sleep(1000);
            }

            Console.Clear();
            Console.WriteLine("Stopwatch finalizado !!");
            Thread.Sleep(2500);

        }
        static void CalcMinutes(int time)
        {
            int currentTime = 0;

            while (currentTime != time)
            {
                Console.Clear();
                currentTime++;
                Console.WriteLine(currentTime);
                Thread.Sleep(60000);
            }

            Console.Clear();
            Console.WriteLine("Stopwatch finalizado !!");
            Thread.Sleep(2500);

        }
        static void CalcHours(int time)
        {
            int currentTime = 0;

            while (currentTime != time)
            {
                Console.Clear();
                currentTime++;
                Console.WriteLine(currentTime);
                Thread.Sleep(3600 * 1000);
            }

            Console.Clear();
            Console.WriteLine("Stopwatch finalizado !!");
            Thread.Sleep(2500);

        }
    }
}