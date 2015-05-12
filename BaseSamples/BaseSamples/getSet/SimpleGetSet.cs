using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseSamples.getSet
{
    class SimpleGetSet
    {
        private String _lastName = "Бер";

        public SimpleGetSet()
        {
            String ln = GetLastName();

            Console.WriteLine("Lastname: " + ln + "\n");

            // call setters 
            SetLastName("Князькова");

            // rewrite variable
            ln = GetLastName();

            Console.WriteLine("Lastname: " + ln);
        }

        // SETTER

        public void SetLastName(String newLastName) {
            _lastName = newLastName;
        }

        // GETTER

        public String GetLastName() {
            return _lastName;
        }
    }
}
