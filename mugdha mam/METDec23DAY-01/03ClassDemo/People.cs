using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03ClassDemo
{
    public class People
    {
        string PName;
        string PAddress;
        public People()
        {
            PName = "Mugdha";
            PAddress = "Pune";
        }
        public People(string nm, string ad)
        {
            PName = nm;
            PAddress= ad;
        }
    }

    public class Custormer : People
    {
        int _id;
        public Custormer()
        {
            _id = 100;
        }
        public Custormer(int id,string nm, string add) :base(nm,add)
        {
            _id = id;
        }

    }

}
