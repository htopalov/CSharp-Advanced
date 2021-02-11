using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace ListyIterator
{
    public class ListyIterator<T> : IEnumerable<T>
    {
        private List<T> list;
        private int index = 0;
        public ListyIterator()
        {
            this.list = new List<T>();
        }
        public ListyIterator(IEnumerable<T> array)
        {
            this.list = new List<T>(array);
        }

        public bool Move()
        {
            if (index < list.Count -1)
            {
                index++;
                return true;
            }
        
            return false;
        }

        public bool HasNext()
        {
            if (index == list.Count -1)
            {
                return false;
            }
            return true;
        }
        public void Print()
        {
            if (list.Count == 0)
            {
                Console.WriteLine("Invalid Operation!");
            }
            else
            {
                Console.WriteLine(list[index]);
            }
        }
        public IEnumerator<T> GetEnumerator()
        {
            foreach (var item in list)
            {
                yield return item;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
