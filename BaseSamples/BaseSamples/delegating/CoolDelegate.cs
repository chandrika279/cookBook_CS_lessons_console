using System;
using System.Threading;

namespace BaseSamples.delegating
{
    public delegate void CoolDel(String message);

    class CoolDelegate
    {
        public void Move(int distance, CoolDel method)
        {
            for (int i = 0; i < distance; i++)
            {
                Thread.Sleep(1000);
                method("Moving in progress.. : " + i);
            }
        }
    }
}
