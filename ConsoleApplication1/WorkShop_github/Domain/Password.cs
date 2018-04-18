using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkShop_github.domain
{
    class Password
    {
        private string pass;
        public bool equals(Password other)
        {
            if (other.pass.Equals(pass))
                return true;
            return false;
        }

        public String get()
        {
            return pass;
        }
    }
}
