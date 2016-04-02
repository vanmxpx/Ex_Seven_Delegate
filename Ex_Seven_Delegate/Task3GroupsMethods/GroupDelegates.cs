using System;
using System.Collections.Generic;

namespace Ex_Seven_Delegate
{
    public delegate int RandomDels();
    public delegate double GrandDel(List<RandomDels> _list);
    public class GroupDelegates
    {
        private RandomDels rand;
        private List<RandomDels> _delList = new List<RandomDels>();

        private GrandDel myMainDelegate = delegate (List<RandomDels> _list)
        {
            double average = 0;
            foreach(var item in _list)
            {
                average += item();
            }
            return average / _list.Count;
        };

        public GroupDelegates()
        {
            rand = RandomCount;
            _delList.Add(rand);
            _delList.Add(rand);
            _delList.Add(rand);
        }
        private int RandomCount()
        {
            Random rnd = new Random();
            return rnd.Next(0, 1000);
        }
        public double GetNumber()
        {
            return myMainDelegate(_delList);
        }
    }


}
