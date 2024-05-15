using System;
using System.Collections.Generic;
using System.Threading;
using System.IO;
using System.Globalization;
using System.Diagnostics;
using Assignment3;

namespace Assignment3
{
    /// <summary>
    /// Manager class which handles the creation of the product list, the consumer threads and producer threads. It also
    /// includes methods to update listboxes and the progressbar of the Windows Form, as well as get product information as 
    /// strings to send into the listboxes.
    /// </summary>
    public class LogisticManager
    {
        public Storage<Product> Storage { get; set; } = new Storage<Product>();
        public List<Product> products = new List<Product>();
        private Dictionary<Product.CategoryType, Producer> producers = new Dictionary<Product.CategoryType, Producer>();
        private Dictionary<Product.CategoryType, Consumer> consumers = new Dictionary<Product.CategoryType, Consumer>();
        public Form1 mainForm;
        bool isRunning = true;
        public bool IsRunning { get { return isRunning; } }

        public Thread managerThread;
        private string[] testProducts;

        public LogisticManager(Form1 mainForm)
        {
            this.mainForm = mainForm;
        }
        //Method to parse information from the text file and call CreateProducts to create a product
        void AddTestProducts()
        {
            var path = Environment.CurrentDirectory;
            string newPath = Path.GetFullPath(Path.Combine(path, @"..\..\"));
            testProducts = File.ReadAllLines
                (newPath + "\\Product.txt");

            foreach (string line in testProducts)
            {
                string[] parts = line.Split(',');
                try
                {
                    if (parts.Length == 3)
                    {
                        string name = parts[0];
                        double.TryParse(parts[1], NumberStyles.Any, CultureInfo.InvariantCulture, out double price);
                        Enum.TryParse(parts[2], out Product.CategoryType type);
                        CreateProduct(name, price, type);
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }

        //Method to create products and add them to the products list for producers to produce from
        public Product CreateProduct(string name, double price, Product.CategoryType type)
        {
            Product product = new Product(name, price, type);
            product.Name = name;
            product.Price = price;
            product.Type = type;
            products.Add(product);
            return product;
        }

        public void Run()
        {
            AddTestProducts();
            while (isRunning)
            {
                UpdateTrixieListBox();
                UpdateRoyalCaninListBox();
                UpdateVetZooListBox();
                UpdateProgressBar(Storage.ElementsInBuffer);
                Thread.Sleep(1000);
            }
        }

        public void Start()
        {
            CreateProducers();
            CreateConsumers();
            managerThread = new Thread(Run);
        }

        public void CreateProducers()
        {
            producers[Product.CategoryType.Food] = new Producer(Product.CategoryType.Food, Storage, this);
            producers[Product.CategoryType.Toys] = new Producer(Product.CategoryType.Toys, Storage, this);
            producers[Product.CategoryType.Accessories] = new Producer(Product.CategoryType.Accessories, Storage, this);
        }

        public void CreateConsumers()
        {
            consumers[Product.CategoryType.Food] = new Consumer(Product.CategoryType.Food, Storage, 15, this);
            consumers[Product.CategoryType.Toys] = new Consumer(Product.CategoryType.Toys, Storage, 10, this);
            consumers[Product.CategoryType.Accessories] = new Consumer(Product.CategoryType.Accessories, Storage, 8, this);
        }

        #region Methods to start and stop consumers and producers
        public void StartProducer(Product.CategoryType category)
        {
            if (producers.TryGetValue(category, out var producer))
            {
                producer.IsRunning = true;
                Thread producerThread = new Thread(producer.Run);
                producerThread.Start();
            }
        }
        public void StopProducer(Product.CategoryType category)
        {
            if (producers.TryGetValue(category, out var producer))
            {
                producer.IsRunning = false;
            }
        }
        public void StartConsumer(Product.CategoryType category)
        {
            if (consumers.TryGetValue(category, out var consumer))
            {
                consumer.IsRunning = true;
                Thread consumerThread = new Thread(consumer.Run);
                consumerThread.Start();
            }
        }

        public void StopConsumer(Product.CategoryType category)
        {
            if (consumers.TryGetValue(category, out var consumer))
            {
                consumer.IsRunning = false;
            }
        }
        #endregion

        //Method to update the progressbar in the Windows Form
        public void UpdateProgressBar(int value)
        {
            mainForm.UpdateProgressBar(value);
        }

        #region Methods to Update ListBoxes
        public void UpdateTrixieListBox()
        {
            string[] infoStrings = GetTrixieInfoStrings();
            if (mainForm.TrixieListBox.InvokeRequired)
            {
                mainForm.TrixieListBox.Invoke(new Action(UpdateTrixieListBox));
            }
            else
            {
                ClearTrixieListBox();
                foreach (string infoString in infoStrings)
                {
                    mainForm.UpdateTrixieProducts(infoString);
                }
            }
        }
        public void UpdateRoyalCaninListBox()
        {
            string[] infoStrings = GetRoyalCaninInfoStrings();
            if (mainForm.RoyalCaninListBox.InvokeRequired)
            {
                mainForm.RoyalCaninListBox.Invoke(new Action(UpdateRoyalCaninListBox));
            }
            else
            {
                ClearRoyalCaninListBox();
                foreach (string infoString in infoStrings)
                {
                    mainForm.UpdateRoyalCaninProducts(infoString);
                }
            }
        }
        public void UpdateVetZooListBox()
        {
            string[] infoStrings = GetVetZooInfoStrings();
            if (mainForm.VetZooListbox.InvokeRequired)
            {
                mainForm.VetZooListbox.Invoke(new Action(UpdateVetZooListBox));
            }
            else
            {
                ClearVetZooListBox();
                foreach (string infoString in infoStrings)
                {
                    mainForm.UpdateVetZooProducts(infoString);
                }
            }
        }
        #endregion

        #region Methods to clear ListBoxes
        private void ClearTrixieListBox()
        {
            mainForm.TrixieListBox.Items.Clear();
        }
        private void ClearRoyalCaninListBox()
        {
            mainForm.RoyalCaninListBox.Items.Clear();
        }
        private void ClearVetZooListBox()
        {
            mainForm.VetZooListbox.Items.Clear();
        }
        #endregion

        #region Methods to get product information as strings
        private string[] GetTrixieInfoStrings()
        {
            if (consumers[Product.CategoryType.Toys].loadedProducts.Count == 0)
            {
                return new string[] { ConstStrings.EMPTY };
            }
            string[] infoStrings = new string[consumers[Product.CategoryType.Toys].loadedProducts.Count + 1];

            infoStrings[0] = ConstStrings.PRODUCTS_LOADED +
                $"{consumers[Product.CategoryType.Toys].loadedProducts.Count}";

            for (int i = 0; i < consumers[Product.CategoryType.Toys].loadedProducts.Count; i++)
            {
                infoStrings[i + 1] = consumers[Product.CategoryType.Toys].loadedProducts[i].ToString();
            }
            return infoStrings;
        }

        private string[] GetRoyalCaninInfoStrings()
        {
            if (consumers[Product.CategoryType.Food].loadedProducts.Count == 0)
            {
                return new string[] { ConstStrings.EMPTY };
            }
            string[] infoStrings = new string[consumers[Product.CategoryType.Food].loadedProducts.Count + 1];

            infoStrings[0] = ConstStrings.PRODUCTS_LOADED +
                $"{consumers[Product.CategoryType.Food].loadedProducts.Count}";

            for (int i = 0; i < consumers[Product.CategoryType.Food].loadedProducts.Count; i++)
            {
                infoStrings[i + 1] = consumers[Product.CategoryType.Food].loadedProducts[i].ToString();
            }
            return infoStrings;
        }

        private string[] GetVetZooInfoStrings()
        {
            if (consumers[Product.CategoryType.Accessories].loadedProducts.Count == 0)
            {
                return new string[] { ConstStrings.EMPTY };
            }
            string[] infoStrings = new string[consumers[Product.CategoryType.Accessories].loadedProducts.Count + 1];

            infoStrings[0] = ConstStrings.PRODUCTS_LOADED +
                $"{consumers[Product.CategoryType.Accessories].loadedProducts.Count}";

            for (int i = 0; i < consumers[Product.CategoryType.Accessories].loadedProducts.Count; i++)
            {
                infoStrings[i + 1] = consumers[Product.CategoryType.Accessories].loadedProducts[i].ToString();
            }
            return infoStrings;
        }
        #endregion
    }
}