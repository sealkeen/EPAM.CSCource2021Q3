using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace CountDown
{
    public class CountdownEventArgs : EventArgs
    {
        public static int messageCounter = 0;
        public int SleepTimeMSec;
        public CountdownEventArgs(int waitTimeMSec = 0)
        {
            SleepTimeMSec = waitTimeMSec;
        }
        public string Message
        { 
            get
            { 
                return $"Here is a message sent after {SleepTimeMSec}ms "; 
            }
        }
    }
}
