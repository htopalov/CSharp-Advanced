using System;
using System.Collections;
using System.Collections.Generic;

namespace Froggy
{
    public class Lake : IEnumerable<int>
    {
        private List<int> stones;

        public Lake(List<int> stones)
        {
            this.stones = new List<int>(stones);
          
        }
        public IEnumerator<int> GetEnumerator()
        {
            List<int> oddStones = new List<int>();
            List<int> evenStones = new List<int>();
            for (int i = 0; i < stones.Count; i++)
            {
                if (i % 2 == 0)
                {
                    evenStones.Add(stones[i]);
                }
                else
                {
                    oddStones.Add(stones[i]);
                }
            }
            oddStones.Reverse();
            foreach (var stone in evenStones)
            {
                yield return stone;
            }
            foreach (var stone in oddStones)
            {
                yield return stone;
            }

        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
