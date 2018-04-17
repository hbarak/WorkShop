using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkShop_github
{
    abstract class User
    {
        String name;
        String id;
        Permission permission;
        Cart cart;

        public abstract void addProductToCart(Product product);
        public abstract void removeProductFromCart(Product product);
        public abstract void viewCart();
        // voic editCart(details);          //is needed?
    }
}
