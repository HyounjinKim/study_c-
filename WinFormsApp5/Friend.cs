using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp5
{
    public class Friend
    {
        private string name;

        public Friend(string name)
        {
            this.name = name;
        }

        public string getName()
        {
            return name;
        }

        public override string? ToString()
        {
            //return "Friend { name = " + name + "}";
            return $"Friend name = {name}";
        }
    }
}
