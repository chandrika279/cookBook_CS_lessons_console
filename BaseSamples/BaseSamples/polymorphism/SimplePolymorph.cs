using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseSamples.polymorphism
{
    class SimplePolymorph
    {
        public virtual String Move(int param)
        {
            return "This is parent method param: " + param + "\n";
        }
    }

    class Child : SimplePolymorph
    {
        public override string Move(int param)
        {
            String resp = base.Move(param + 500); // вот так можно колить переопределяемый метод из родительского класса
            resp += "This is child method param: " + param;
            return resp;
        }
    }

    /*
     * Call child class example
     * 
     * Child sec = new Child();
     * Console.WriteLine(sec.Move(500)); // print "This is parent method param: 1000"
     *                                   //       "This is child method param: 500"
     * 
     */
}
