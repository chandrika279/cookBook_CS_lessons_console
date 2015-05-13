using System;

namespace BaseSamples.delegating
{
    class Caller
    {
        /* ---------------------------------- for a SuperDelegate class ----------------------------------- */

        public void CallSuperDel()
        {
            SuperDelegate sd = new SuperDelegate();
            Action<String> sdlgt = Show;
            sd.Move(5, sdlgt);
        }

        /* ----------------------------------- for a CoolDelegate class ----------------------------------- */

        public void CallCoolDel()
        {
            CoolDelegate cd = new CoolDelegate();
            CoolDel cdlgt = Show;
            cd.Move(7, cdlgt);
        }

        static void Show(String message)
        {
            Console.WriteLine(message);
        }

        /* ----------------------------------- for a SimpleDelegate class ----------------------------------- */

        public void CallSimpleDel()
        {
            SimpleDelegate sd = new SimpleDelegate();

            SimpleDel sdlgt1 = sd.GetCountSymbols;
            SimpleDel sdlgt2 = sd.GetCountSymbol;

            String message = "Dmitry Ber";

            Console.Write("Symbol count: " + sdlgt1(message) + "\n");
            Console.Write("Symbol count 'r': " + TestSimpleDel(sdlgt2, message));
        }

        private int TestSimpleDel(SimpleDel method, String msg)
        {
            return method(msg);
        }
    }
}
