using System;

namespace GenericScale
{
    public class EqualityScale<T> 
        where T : IComparable
    {
        private T left;
        private T right;
        public EqualityScale(T left, T right)
        {
            this.Left = left;
            this.Right = right;
        }
        public T Left
        { 
            get
            {
                return left;
            }
            set
            {
                this.left = value;
            }
        }

        public T Right
        { 
            get
            {
                return right;
            }
            set
            {
                this.right = value;
            }
        }
        public bool AreEqual()
        {
           int result = Left.CompareTo(Right);
            if (result == 0)
            {
                return true;
            }
            return false;
        }
    }
}
