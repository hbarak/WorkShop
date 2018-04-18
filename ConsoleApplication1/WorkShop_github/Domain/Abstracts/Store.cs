using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WorkShop_github.Domain;
using WorkShop_github.Domain.IdGenerator;

namespace WorkShop_github
{
    abstract class Store
    {
        private IdGenerator Idgen;
        String id;
        String name;
        Dictionary<Product, int> availableProducts;                        //all products for sale

        public abstract int addNewProduct(Product product, int quantity);
        public abstract int decreaseProduceQuantity(Product product, int quantity);
        public abstract int increaseProduceQuantity(Product product, int quantity);
        public abstract int editProduct(Product product, int quantity);
        public abstract bool addManager(User user);
        public abstract bool removeManager(User user);
        public abstract void viewHistory();

        protected String getId()
        {
            return Idgen.get();
        }
    }
}
