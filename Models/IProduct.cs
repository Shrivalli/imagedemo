using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ImageDemo.Models
{
   public interface IProduct<Product>
    {
        public void AddProduct(Product p);
        public List<Product> getAllProducts();
        public void UpdateProduct(int id, Product p);
        public void DeleteProduct(int id);
        public Product GetProductById(int id);
    }
}
