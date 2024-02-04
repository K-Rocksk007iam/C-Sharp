using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceDemo
{
    public interface IDatabase
    {
        public void insert();
        public void delete();   
        public void update();
        public void deleteAll();
        public void updateAll();
    }
}
