using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace ListyIterator
{
    public class ListyIterator<T> : IEnumerable<T>
    {
        private List<T> list;
        public ListyIterator(List<T> list)
        {
            this.list = new List<T>(list);
        }

        public bool Move()
        {
            return true;
        }

        public bool HasNext()
        {
            return true;
        }
        public void Print()
        {

        }

        public void Create()
        {

        }

        public IEnumerator<T> GetEnumerator()
        {
            throw new NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
