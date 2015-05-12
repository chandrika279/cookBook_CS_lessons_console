using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseSamples.getSet
{
    class CoolGetSet
    {
        private String _lastName;

        public String LastName {
            get { return _lastName; }
            set { _lastName = value; }
        }

        /*
         * Call getter / setter example:
         * 
         * CoolGetSet cgs = new CoolGetSet();
         * cgs.LastName = "Бер";
         * Console.WriteLine(cgs.LastName); => this print "Бер"
         * 
         */
    }
}