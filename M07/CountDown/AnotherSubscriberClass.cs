using System;
using System.Collections.Generic;
using System.Text;

namespace CountDown
{
    public class AnotherSubscriberClass : ISubscriber
    {
        string messageFromCountDown = "";
        public void ReceiveMessage(CountdownEventArgs e)
        {
            Console.WriteLine($"Message received from countdown: {e.Message}");
        }
    }
}
