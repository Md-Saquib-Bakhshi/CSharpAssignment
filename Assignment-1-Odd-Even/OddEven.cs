using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1_Odd_Even
{
    internal class OddEven
    {
        public int TargetValue { get; set; }
        private List<int> oddList;
        private List<int> evenList;

        public OddEven()
        {
            oddList = new List<int>();
            evenList = new List<int>();
        }

        public void OddEvenIdentifier()
        {
            for (int i = 0; i <= TargetValue; i++)
            {
                if (i % 2 == 0)
                {
                    evenList.Add(i);
                }
                else
                {
                    oddList.Add(i);
                }
            }
        }

        public void GetOddList()
        {
            foreach (int i in oddList)
            {
                Console.Write(i+"   ");
            }
        }

        public void GetEvenList()
        {
            foreach(int i in evenList)
            {
                Console.Write(i + "   ");
            }
        }
    }
}
