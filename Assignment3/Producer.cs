using Assignment3;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Globalization;
using System.Threading;

namespace Assignment3
{
    /// <summary>
    /// Producer class which handles adding products from the create Products list to the Storage
    /// </summary>
    public class Producer
    {
        Product.CategoryType producerType;
        Buffer<Product> storage;
        Manager manager;
        bool isRunning = true;
        public bool IsRunning { get { return isRunning; } set { isRunning = value; } }

        public Producer(Product.CategoryType producerType, Buffer<Product> storage, Manager logisticManager)
        {
            this.producerType = producerType;
            this.storage = storage;
            this.manager = logisticManager;
        }

        public void Run()
        {
            while (isRunning)
            {
                if (!isRunning)
                {
                    continue;
                }
                if (manager.products.Count != 0)
                {
                    Product randomProduct = GetRandomProduct();
                    storage.AddProduct(randomProduct); //Runs the produce method of the Storage class to add products to the Storage
                    Thread.Sleep(1000);
                }
            }

        }
        //Method to get a random product from the list of generated products
        public Product GetRandomProduct()
        {
            Random random = new Random();
            List<Product> matchProducts =
            manager.products.Where(product => product.Type == this.producerType).ToList();
            int index = random.Next(0, matchProducts.Count);
            Product rightProduct = matchProducts[index];
            return rightProduct;
        }


    }
}