using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqTask
{
    class User
    {
        public int ID { get; set; }
        public String Name { get; set; }
        public String Surname { get; set; }
        public User(int id, String name, String surname) { this.ID = id; this.Name = name; this.Surname = surname; }
        public override string ToString() { return string.Format("ID={0}: {1} {2}", ID, Name, Surname); }
    }
}
