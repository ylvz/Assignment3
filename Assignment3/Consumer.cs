using Assignment3;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Assignment3
{
    /// <summary>
    /// Consumer class which handles removing items from the storage.
    /// </summary>
    public class Consumer
    {
        Product.CategoryType consumerType;
        Storage<Product> storage;
        LogisticManager logisticManager;
        public List<Product> loadedProducts = new List<Product>();
        bool isRunning = true;
        int capactity;
        public bool IsRunning { get { return isRunning; } set { isRunning = value; } }
        public int Capacity { get { return capactity; } set { capactity = value; } }

        public Consumer(Product.CategoryType consumerType, Storage<Product> storage, int capacity, LogisticManager logisticManager)
        {
            this.consumerType = consumerType;
            this.storage = storage;
            this.capactity = capacity;
            this.logisticManager = logisticManager;
        }
        public void Run()
        {
            while (isRunning)
            {
                Consuming();
                ResetCapacity();
                Thread.Sleep(1000);
            }
        }
        //Method to run the Consume method of the Storage class and add products to the Consumers list of products
        public void Consuming()
        {
            if (loadedProducts.Count < capactity)
            {
                Product product = storage.Consume();
                loadedProducts.Add(product);
            }
            else
            {
                switch (consumerType)
                {
                    case Product.CategoryType.Toys:
                        logisticManager.mainForm.UpdateTrixieStatus(false);
                        break;
                    case Product.CategoryType.Food:
                        logisticManager.mainForm.UpdateRoyalCaninStatus(false);
                        break;
                    case Product.CategoryType.Accessories:
                        logisticManager.mainForm.UpdateVetZooStatus(false);
                        break;
                }
            }
        }
        //Method to reset capacity of a consumer to let it start loading again
        public void ResetCapacity()
        {
            switch (consumerType)
            {
                case Product.CategoryType.Toys:
                    if (logisticManager.mainForm.TrixieCheckbox.Checked)
                    {
                        if (loadedProducts.Count >= capactity)
                        {
                            loadedProducts.Clear();
                        }
                        logisticManager.mainForm.UpdateTrixieStatus(true);
                    }
                    break;
                case Product.CategoryType.Food:
                    if (logisticManager.mainForm.RoyalCaninCheckbox.Checked)
                    {
                        if (loadedProducts.Count >= capactity)
                        {
                            loadedProducts.Clear();
                        }
                        logisticManager.mainForm.UpdateRoyalCaninStatus(true);
                    }
                    break;
                case Product.CategoryType.Accessories:
                    if (logisticManager.mainForm.VetZooCheckbox.Checked)
                    {
                        if (loadedProducts.Count >= capactity)
                        {
                            loadedProducts.Clear();
                        }
                        logisticManager.mainForm.UpdateVetZooStatus(true);
                    }
                    break;
            }

        }
    }
}
