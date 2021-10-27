using NUnit.Framework;
using CountDown;
using System.Diagnostics;

namespace CountDownTester
{
    public class CountDownTests
    {
        [Test]
        public void CountdownTest()
        {
            Debug.WriteLine("Creating Countdown class");
            var countdown = new Countdown(); var program = new Program();
            var sub = new SubscriberClass();
            var aSub = new AnotherSubscriberClass();

            Debug.WriteLine("Subscribing to the event.");
            countdown.Subscribe(program.Countdown_TimeExceeded, 550);
            countdown.Subscribe(ReceiveMessage, 650);
            sub.SubscribeToCountdown(countdown, 400);
            countdown.Subscribe(aSub);

            Debug.WriteLine("Invoking the event.");
            countdown?.Invoke();
            Debug.WriteLine("Unsubscribing.");
            sub.Unsubscribe(countdown); countdown.Unsubscribe(ReceiveMessage);
            Debug.WriteLine("Invoking.");
            countdown?.Invoke();
        }

        public void ReceiveMessage(CountdownEventArgs e)
        {
            System.Console.WriteLine($"{e.Message} in class: {this.GetType()}");
        }

        [SetUpFixture]
        public class SetupTrace
        {
            [OneTimeSetUp]
            public void StartTest()
            {
                Trace.Listeners.Add(new ConsoleTraceListener());
            }

            [OneTimeTearDown]
            public void EndTest()
            {
                Trace.Flush();
            }
        }
    }
}