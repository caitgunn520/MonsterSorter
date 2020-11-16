using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonsterSorter
{
    class Monster
    {
        public string name, type, role;

        public Monster(string _name, string _type, string _role)
        {
            name = _name;
            type = _type;
            role = _role;
        }
    }
}
