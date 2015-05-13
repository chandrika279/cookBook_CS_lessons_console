using System;
using System.Linq;

namespace BaseSamples.delegating
{
    public delegate int SimpleDel(String message);

    class SimpleDelegate
    {
        public int GetCountSymbols(String msg)
        {
            return msg.Length;
        }

        public int GetCountSymbol(String msg)
        {
            return msg.Count(c => c == 'r');
        }
    }
}
