using System;

namespace CountDown
{
    public class Program
    {
        [MTAThread]
        static void Main(string[] args)
        {
            Console.WriteLine("Creating Countdown class");
            var countdown = new Countdown();
            var program = new Program();

            Console.WriteLine("Subscribing to the event.");
            countdown.Subscribe(program.Countdown_TimeExceeded, 750);

            Console.WriteLine("Invoking the event.");

            countdown?.Invoke();
        }
        public void Countdown_TimeExceeded(CountdownEventArgs e)
        {
            Console.WriteLine($"{e.Message} in class: {this.GetType()}");
        }
    }
}
