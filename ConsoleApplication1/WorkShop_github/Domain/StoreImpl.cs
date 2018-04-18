using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace WorkShop_github.Domain
{
    class StoreImpl: Store
    {
        private static IdGenerator.IdGenerator Idgen;
        String name;
        Dictionary<Product, int> availableProducts;                        //all products for sale

        public StoreImpl(String name, String id, Dictionary<Product, int> availableProducts)
        {
            this.name = name;
            this.id = id;
            this.availableProducts = availableProducts;
        }

        public static StoreImpl newStore(String name)
        {
            return new StoreImpl(name, getId(), new Dictionary<Product, int>());
        }




        private static String getId()
        {
            return Idgen.get();
        }
    }
}
