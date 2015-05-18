using System;

namespace BaseSamples.extends
{
    private class SimpleExtending // если стоит пометка sealed, то мы не можем наследоваться от этого класса
    {
        protected String _lastname = "Ber";

        public SimpleExtending(string msg)
        {
            Console.WriteLine(msg);
        }

        public string Move(int param) // если стоит пометка sealed, то мы не можем переопределять этот метод в дочернем классе
        {
            return "This is method param: " + param;
        }
    }

    class SEChild : SimpleExtending
    {
        public SEChild() : base("Mother fucker") // Это нужно дописывать в случае, если конструктор родительского класса требует параметры
        {

        }

        public String LastName
        {
            get { return _lastname;  }
            set { _lastname = value; }
        }
    }

    /*
     * Call child class example
     * 
     * SEChild sec = new SEChild(); // print "Mother fucker"
     * Console.WriteLine(sec.LastName); // print "Ber"
     * sec.LastName = "Knyazkova";
     * Console.WriteLine(sec.LastName); // print "Knyazkova"
     * Console.WriteLine(sec.Move(500)); // print "This is method param: 500"
     * 
     */
}
