using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceDemo
{
    public class Sql : IDatabase
    {
        public void insert(){ Console.WriteLine("Data inserted");}
        public void update() { Console.WriteLine("Data updated");}
        public void delete() { Console.WriteLine("Data Deleted");}
       
        public void updateAll() { Console.WriteLine("updated all records"); }

        public void deleteAll() { Console.WriteLine("Deleted all records"); }
        
    }
}