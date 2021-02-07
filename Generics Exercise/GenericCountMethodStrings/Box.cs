using System;
using System.Collections.Generic;

namespace GenericCountMethodStrings
{
    public class Box<T>
        where T : IComparable
    {
        private List<T> list;
        public Box(List<T> list)
        {
            this.List = list;
        }
        public List<T> List
        {
            get
            {
                return list;
            }
            set
            {
                this.list = value;
            }
        }
        public int Comparator(T value)
        {
            int count = 0;
            for (int i = 0; i < List.Count; i++)
            {
                if (value.CompareTo(List[i]) < 0)
                {
                    count++;
                }
            }
            return count;
        }

    }
}
