using System;
using System.Collections.Generic;


namespace Open_Lab_04._06
{
    public class Numbers
    {
        public int[] NoOdds(int[] numbers)
        {

            List<int> even = new List<int>();
            foreach (int i in numbers)
            {
                if (i % 2 == 0)
                    even.Add(i);
            }
            return even.ToArray();
        }
    }
}
