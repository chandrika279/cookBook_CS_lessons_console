using System;

namespace BaseSamples.extends
{
    class SimpleExtending
    {
        protected String _lastname = "Ber";

        public SimpleExtending(string msg)
        {
            Console.WriteLine(msg);
        }

        public string Move(int param)
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
