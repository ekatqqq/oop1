using FirstOOP;
using System.Transactions;

//6 задание

namespace FirstOOP
{
    class Ticks
    {
        private double time;

        public double TimeOnTicks { get; set; }

        public double NumberOfMinutes
        {
            get { return time / (60 * 18.2); }
            set { time = value * (60 * 18.2); }
        }

        public double NumberOfSeconds
        {
            get { return time / 18.2; }
            set { time = value * 18.2; }
        }

        private Ticks(double time)
        {
            this.time = time;
        }
        public static Ticks FromTimeOnTicks(double time)
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
            Ticks t1 = Ticks.FromTimeOnTicks(36.4);
            Ticks t2 = Ticks.FromTimeOnTicks(163.8);

            Console.WriteLine("t1: " + t1);
            Console.WriteLine("t2: " + t2);

            Ticks sum = t1 + t2;
            Ticks difference = t1 - t2;

            Console.WriteLine("сумма: " + sum);
            Console.WriteLine("разница: " + difference);

            Console.WriteLine("Количество секунд t1: " + t1.NumberOfSeconds);
            Console.WriteLine("Количество минут t1: " + t1.NumberOfMinutes);
            Console.WriteLine("Количество секунд t2: " + t2.NumberOfSeconds);
            Console.WriteLine("Количество минут t2: " + t2.NumberOfMinutes);
        }
    }
}
