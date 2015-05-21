using System;

namespace BaseSamples.interfaces
{
    class Program
    {
        public Program()
        {

            Student st1 = new Student() { Name = "Дмитрий",  Age = 100 };
            Student st2 = new Student() { Name = "Виктория", Age = 20 };

            Student[] sts = new Student[] { st1, st2 };

            Array.Sort(sts);

        }
    }

    class IProgram : IStudent
    {
        public String getNewStr (String incomeStr)
        {
            return "Вот это мы получили на входе: " + incomeStr;
        }
    }

    /*
        IProgram ip = new IProgram();
        String newStr = ip.getNewStr("Blah blah blah");
        Console.WriteLine(newStr); // вот тут будет принт строки "Вот это мы получили на входе: Blah blah blah"
     */
}
