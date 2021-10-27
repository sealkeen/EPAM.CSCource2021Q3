using System;
using System.Collections.Generic;
using System.Text;

namespace CountDown
{
    public interface ISubscriber
    {
        void ReceiveMessage(CountdownEventArgs e);
    }
}
