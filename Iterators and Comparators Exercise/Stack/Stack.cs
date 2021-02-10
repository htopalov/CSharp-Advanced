using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Stack
{
    public class Stack<T> : IEnumerable<T>
    {

        private List<T> list;

        public Stack()
        {
            this.list = new List<T>();
        }
        public void Push(T item)
        {
            list.Add(item);
        }
        public void Pop()
        {
            if (list.Count>0)
            {
                list.RemoveAt(list.Count - 1);
            }
            else
            {
                Console.WriteLine("No elements");
            }
 
        }

        public IEnumerator<T> GetEnumerator()
        {
            for (int i = list.Count-1; i >= 0; i--)
            {
                yield return list[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
