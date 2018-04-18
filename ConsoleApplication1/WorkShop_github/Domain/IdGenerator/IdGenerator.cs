using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkShop_github.Domain.IdGenerator
{
    class IdGenerator
    {
        private int nextId;

        public IdGenerator()
        {
            nextId = 0;
        }

        public IdGenerator(int init)
        {
            nextId = init;
        }

        public String get()
        {
            return nextId++.ToString();
        }
    }
}
