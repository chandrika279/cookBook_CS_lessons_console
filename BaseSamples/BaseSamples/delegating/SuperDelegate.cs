using System;
using System.Threading;

namespace BaseSamples.delegating
{
    public delegate void SuperDel(String message);

    class SuperDelegate
    {
        public void Move(int distance, Action<String> method)
        {
            for (int i = 0; i < distance; i++)
            {
                Thread.Sleep(1000);
                method("Moving in progress.. : " + i);
            }
        }
    }
}
