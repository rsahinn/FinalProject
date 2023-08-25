using Business.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using System;
using System.Net.Http.Headers;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            //ProductTest();
            //CategoryTest();
            ProductManager productManager = new ProductManager(new EfProductDal());
            foreach (var item in productManager.getAll().Data)
            {
                Console.WriteLine(item);
            }
        }

        private static void CategoryTest()
        {
            CategoryManager categoryManager = new CategoryManager(new EfCategoryDal());
            foreach (var item in categoryManager.getAll().Data)
            {
                Console.WriteLine(item.CategoryName);
            }
        }

        private static void ProductTest()
        {
            ProductManager productManager = new ProductManager(new EfProductDal());

            var result = productManager.GetProductDetail();
            if (result.Success)
            {
                foreach (var item in result.Data)
                {
                    Console.WriteLine(item.ProductName + " - " + item.CategoryName);
                }
            }
            else
            {
                Console.WriteLine(result.Message);
            }
            
        }
    }


}