using FirstOOP;
using System.Transactions;

//5 задание

namespace FirstOOP
{
    class Ticks
    {
        private double time;

        public double TimeOnSeconds { get; set; }

        public double NumberOfMinutes
        {
            get { return time / 60; }
            set { time = value * 60; }
        }

        public double NumberOfTicks
        {
            get { return time * 18.2; }
            set { time = value / 18.2; }
        }

        private Ticks(double time)
        {
            this.time = time;
        }
        public static Ticks FromTimeOnSeconds(double time)
        {
            return new Ticks(time);
        }

        public static Ticks operator +(Ticks t1, Ticks t2)
        {
            return new Ticks(t1.time + t2.time);
        }

        public static Ticks operator -(Ticks t1, Ticks t2)
        {
            return new Ticks(t1.time - t2.time);
        }

        public override string ToString()
        {
            return time.ToString();
        }
    }
    class Program
        {
        static void Main(string[] args)
        {
            Ticks t1 = Ticks.FromTimeOnSeconds(60);
            Ticks t2 = Ticks.FromTimeOnSeconds(240);

            Console.WriteLine("t1: " + t1);
            Console.WriteLine("t2: " + t2);

            Ticks sum = t1 + t2;
            Ticks difference = t1 - t2;

            Console.WriteLine("сумма: " + sum);
            Console.WriteLine("разница: " + difference);

            Console.WriteLine("Количество тиков t1: " + t1.NumberOfTicks);
            Console.WriteLine("Количество минут t1: " + t1.NumberOfMinutes);
            Console.WriteLine("Количество тиков t2: " + t2.NumberOfTicks);
            Console.WriteLine("Количество минут t2: " + t2.NumberOfMinutes);
        }
    }
}