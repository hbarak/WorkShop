using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WorkShop_github.Domain;
using WorkShop_github.Domain.Enums;

namespace WorkShop_github
{
    abstract class Product
    {
        String name;
        Depertment deprtment;
        Policy policy;
        public abstract Discount getAvailableDiscount();
        public abstract void viewItem();
        public abstract void buyItem();
        public abstract bool purchasePolicycheak();
        public abstract void productPolicy(int min, int max);
        public abstract void productDiscount(details);          // TODO: decide what are 'detalis'
    }
}
