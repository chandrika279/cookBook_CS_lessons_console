using System;

namespace BaseSamples.interfaces
{
    public interface IStudent // Все классы, реализовывающие этот интерфейс, должны имплементировать приведенные в нем методы 
    {
        String getNewStr(String incomeStr);
    }

    public struct Student : IComparable
    {
        public String Name { get; set; }

        public int Age { get; set; }

        public int CompareTo(Object obj)
        {
            Student st = (Student) obj;

            if (this.Age > st.Age) return 1;
            if (this.Age < st.Age) return -1;

            return 0;
        }
    }
}
