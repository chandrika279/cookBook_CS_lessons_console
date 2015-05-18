using System;

namespace BaseSamples.statics
{
    class Variables
    {
        public static int _staticField;
        public int _instanceField;

        /*
         * Variables vb1 = new Variables();
         * Variables vb2 = new Variables();
         * 
         * vb1._instanceField = 10;
         * vb2._instanceField = 20;
         * 
         * Variables._staticField = 30;
         * 
         * Console.WriteLine(vb1._instanceField + " -- " + vb2._instanceField + " -- " + Variables._staticField); // print "10 -- 20 -- 30"
         * 
         */

        /*
         * Ключевая суть в том, что статические переменные / методы
         * не привязаны к какому-либо экземпляру класса.
         * В первую очередь - это означает, что статический метод не может обращаться к нестатическим переменным.
         * А все НЕ статические методы, могут обращаться к статическому контенту.
         */
    }
}
