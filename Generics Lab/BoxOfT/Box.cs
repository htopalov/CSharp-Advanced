using System.Collections.Generic;

namespace BoxOfT
{
    public class Box<T>
    {
        private List<T> box;
        public Box()
        {
            box = new List<T>();
        }
        public void Add(T element)
        {
            box.Add(element);
        }
        public T Remove()
        {
            var current = box[box.Count-1];
            box.RemoveAt(box.Count-1);
            return current;
        }
        public int Count
        {
            get
            {
                return box.Count;
            }
        }
    }
}
