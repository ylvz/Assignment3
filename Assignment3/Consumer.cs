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
        Buffer<Product> buffer;
        Manager manager;
        public List<Product> loadedProducts = new List<Product>();
        bool isRunning = true;
        int maxCapacity;
        public bool IsRunning { get { return isRunning; } set { isRunning = value; } }
        public int MaxCapacity { get { return maxCapacity; } set { maxCapacity = value; } }

        public Consumer(Product.CategoryType consumerType, Buffer<Product> buffer, int maxCapacity, Manager logisticManager)
        {
            this.consumerType = consumerType;
            this.buffer = buffer;
            this.maxCapacity = maxCapacity;
            this.manager = logisticManager;
        }
        public void Run()
        {
            while (isRunning)
            {
                Consume();
                ResetMaxCapacity();
                Thread.Sleep(1000);
            }
        }
        //Method to run the Consume method of the Storage class and add products to the Consumers list of products
        public void Consume()
        {
            if (loadedProducts.Count < maxCapacity)
            {
                Product product = buffer.RemoveProduct();
                loadedProducts.Add(product);
            }
            else
            {
                if (consumerType == Product.CategoryType.Toys)
                {
                    manager.mainForm.UpdateBitibaStatus(false);
                }
                else if (consumerType == Product.CategoryType.Food)
                {
                    manager.mainForm.UpdateArkenZooStatus(false);
                }
                else if (consumerType == Product.CategoryType.Accessories)
                {
                    manager.mainForm.UpdateVetZooStatus(false);
                }
            }
        }

        //Method to reset capacity of a consumer to let it start loading again
        public void ResetMaxCapacity()
        {
            if (consumerType == Product.CategoryType.Toys && manager.mainForm.BitibaCheckbox.Checked)
            {
                if (loadedProducts.Count >= maxCapacity)
                {
                    loadedProducts.Clear();
                }
                manager.mainForm.UpdateBitibaStatus(true);
            }
            else if (consumerType == Product.CategoryType.Food && manager.mainForm.ArkenZooCheckbox.Checked)
            {
                if (loadedProducts.Count >= maxCapacity)
                {
                    loadedProducts.Clear();
                }
                manager.mainForm.UpdateArkenZooStatus(true);
            }
            else if (consumerType == Product.CategoryType.Accessories && manager.mainForm.VetZooCheckbox.Checked)
            {
                if (loadedProducts.Count >= maxCapacity)
                {
                    loadedProducts.Clear();
                }
                manager.mainForm.UpdateVetZooStatus(true);
            }
        }

    }
}
