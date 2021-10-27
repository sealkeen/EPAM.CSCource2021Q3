using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace CountDown
{
    public delegate void CountdownEventHandler(CountdownEventArgs e);
    public class Countdown
    {
        public static int messageCounter = 0;
        public event CountdownEventHandler ThresholdReached;
        public List<object[]> CountdownEventArgsList;
        public Countdown()
        {
            CountdownEventArgsList = new List<object[]>();
        }

        public void Invoke()
        {
            var delegates = ThresholdReached.GetInvocationList();
            for(int i =0; i < delegates.Length; i++)
            {
                Thread.Sleep(((CountdownEventArgs)(CountdownEventArgsList[i][0])).SleepTimeMSec);
                delegates[i].Method.Invoke(delegates[i].Target, CountdownEventArgsList[i]);
            }
        }

        //public void Check(DateTime newTime, CountdownEventArgs e)
        //{
        //    if ((DateTime.Now.Millisecond + e.timeInMS) >= newTime.Millisecond)
        //    {
        //        ThresholdReached?.Invoke(this, new CountdownEventArgs(_WaitingMSec));
        //    }
        //}

        public void Subscribe(CountdownEventHandler countdownEventHandler, int waitTimeMSec = 0)
        {
            CountdownEventArgsList.Add(new object[] { new CountdownEventArgs(waitTimeMSec) });
            ThresholdReached += countdownEventHandler;
            CountdownEventArgs.messageCounter++;
        }

        public void Subscribe(ISubscriber subscriber)
        {
            Subscribe(subscriber.ReceiveMessage);
        }
        public void Unsubscribe(CountdownEventHandler countdownEventHandler)
        {
            ThresholdReached -= countdownEventHandler;
        }
    }
}
