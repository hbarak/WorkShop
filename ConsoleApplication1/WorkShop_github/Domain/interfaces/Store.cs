using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkShop_github
{
    abstract class Store
    {
        String id;
        String name;
        List<Product> availableProducts;                        //all products for sale
        public abstract int addProduct(Product product, int quantity);
        public abstract int removeProduct(Product product, int quantity);
        public abstract int editProduct(Product product, int quantity);
        public abstract bool addManager(User user);
        public abstract bool removeManager(User user);
        public abstract void viewHistory();
    }
}
