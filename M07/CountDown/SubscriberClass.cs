using System;
using System.Collections.Generic;
using System.Text;

namespace CountDown
{
    public class SubscriberClass : ISubscriber
    {
        public void SubscribeToCountdown(Countdown cd, int waitTimeMS)
        {
            cd.Subscribe(ReceiveMessage, 400);
        }

        public void ReceiveMessage(CountdownEventArgs e)
        {
            Console.WriteLine($"{e.Message} in class: {this.GetType()}");
        }

        public void Unsubscribe(Countdown cd)
        {
            cd.Unsubscribe(ReceiveMessage);
        }
    }
}
