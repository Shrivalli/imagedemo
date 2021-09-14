using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ImageDemo.Service
{
    public interface IProdServ<Product>
    {
        public void AddProduct(Product p);
        public List<Product> getAllProducts();
        public void UpdateProduct(int id, Product p);
        public void DeleteProduct(int id);
        public Product GetProductById(int id);

        public string msg(string note);
        public float calculateAmt(int qty, int price);
    }
}
