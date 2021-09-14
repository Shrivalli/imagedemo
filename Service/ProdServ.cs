using ImageDemo.Models;
using ImageDemo.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ImageDemo.Service
{
    public class ProdServ : IProdServ<Product>
    {
        private readonly IProdRepo<Product> repo;
        public ProdServ(IProdRepo<Product> _repo)
        {
            repo = _repo;
        }
        public void AddProduct(Product p)
        {
            repo.AddProduct(p);
        }

        public float calculateAmt(int qty, int price)
        {
            return qty * price;
        }

        public void DeleteProduct(int id)
        {
            repo.DeleteProduct(id);
        }

        public List<Product> getAllProducts()
        {
            return repo.getAllProducts();
        }

        public Product GetProductById(int id)
        {
            return repo.GetProductById(id);
        }

        public string msg(string note)
        {
            return "Hello " + note;
        }

        public void UpdateProduct(int id, Product p)
        {
            repo.UpdateProduct(id, p);
        }
    }
}
