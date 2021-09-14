using ImageDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ImageDemo.Repository
{
    public class ProdRepo : IProdRepo<Product>
    {
        private readonly IProduct<Product> obj;

        //dependency injection
        public ProdRepo(IProduct<Product> _obj)
        {
            obj = _obj;
        }
        public void AddProduct(Product p)
        {
            obj.AddProduct(p);
        }

        public void DeleteProduct(int id)
        {
            obj.DeleteProduct(id);
        }

        public List<Product> getAllProducts()
        {
            return obj.getAllProducts();
        }

        public Product GetProductById(int id)
        {
            return obj.GetProductById(id);
        }

        public void UpdateProduct(int id, Product p)
        {
            obj.UpdateProduct(id, p);
        }
    }
}
