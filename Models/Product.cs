using System;
using System.Collections.Generic;
using System.Linq;

#nullable disable

namespace ImageDemo.Models
{
    public partial class Product:IProduct<Product>
    {
        public int Pid { get; set; }
        public string Pname { get; set; }
        public string Pimage { get; set; }

        //readonly variable of Context
        private readonly FISContext db = new FISContext();

        //default constructor
        public Product() { }

        //overloaded constructor
        //public Product(FISContext _db)
        //{
        //    db = _db;
        //}

        public void AddProduct(Product p)
        {
            db.Products.Add(p);
            db.SaveChanges();
        }

        public void DeleteProduct(int id)
        {
            Product p=GetProductById(id);
            db.Products.Remove(p);
            db.SaveChanges();
        }

        public List<Product> getAllProducts()
        {
            return db.Products.ToList();
        }

        public Product GetProductById(int id)
        {
            Product p = db.Products.Find(id);
            return p;
        }

        public void UpdateProduct(int id, Product p)
        {
           using(var db=new FISContext())
            {
                db.Entry(p).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                db.SaveChanges();
            }
        }
    }
}
