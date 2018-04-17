using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkShop_github
{
    abstract class Product
    {
        String name;
        public abstract Discount getAvailableDiscount();
        public abstract void viewItem();
        public abstract void buyItem();
        public abstract bool purchasePolicycheak();
        public abstract void productPolicy(int min, int max);
        public abstract void productDiscount(details);          // TODO: decide what are 'detalis'
    }
}
