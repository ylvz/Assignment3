using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3
{
    internal class Producer
    {
        private volatile bool isProducing;
        private SharedBuffer buffer;
        private Label statuslabel;
        private Random random=new Random();
        private Product[] itemArray;

        public CategoryType Category { get; set; }

        public Producer(SharedBuffer buffer, Label statuslabel,CategoryType category)
        {
            CreateTestProduct();
            this.buffer = buffer;
            this.statuslabel = statuslabel;
            this.Category = category;

            statuslabel.Invoke((MethodInvoker)(() => statuslabel.Text = "NOT PRODUCING"));
        }

        public void CreateTestProduct()
        {
            const int max = 50;
            itemArray=new Product[max];

            for(int i = 0; i < 5; i++)
            {
                int j = i * 10;
                itemArray[0 + j] = new Product("Milk, Gen Food" + (i + 1).ToString(), 1.0, 19.95, 6, CategoryType.Food);
                itemArray[1 + j] = new Product("Egg, organic" + (i + 1).ToString(), 5.0, 60.55, 20, CategoryType.Food);
                itemArray[2 + j] = new Product("Dish Washer" + (i + 1).ToString(), 15, 5990, 1, CategoryType.Electrics);
                itemArray[3 + j] = new Product("Shaving machine" + (i + 1).ToString(), 200, 750, 2, CategoryType.Electrics);
                itemArray[4 + j] = new Product("Tigersaw" + (i + 1).ToString(), 450, 2000, 3, CategoryType.Tools);
                itemArray[5 + j] = new Product("Milk, Gen Food" + (i + 1).ToString(), 1.0, 19.95, 6, CategoryType.Food);
                itemArray[6 + j] = new Product("Egg, Gen Food" + (i + 1).ToString(), 5.0,60.55, 20, CategoryType.Food);
                itemArray[7 + j] = new Product("Dish Washer, Globel El" + (i + 1).ToString(), 15, 5990, 1, CategoryType.Electrics);
                itemArray[8 + j] = new Product("Shaving machine, Home Tools" + (i + 1).ToString(), 200, 750, 2, CategoryType.Electrics);
                itemArray[9 + j] = new Product("Electric screwdriver, Home Tools" + (i + 1).ToString(), 780, 459, 3, CategoryType.Tools);

            }
        }

        public void StartProducing()
        {
            isProducing = true;
            statuslabel.Invoke((MethodInvoker)(() => statuslabel.Text = "PRODUCING"));
            Produce();
        }

        public void StopProducing()
        {
            isProducing = false;
            statuslabel.Invoke((MethodInvoker)(() => statuslabel.Text = "NOT PRODUCING"));
        }

        private void Produce()
        {
            while (isProducing)
            {
                buffer.Produce(ChooseRandomItem());
                Thread.Sleep(300);
            }
        }

        public Product ChooseRandomItem()
        {
            bool done = false;
            Product product;
            do
            {
                product = itemArray[random.Next(itemArray.Length)];
                done = (product.Category == this.Category);
            } while (!done);

            return product;
        }
    }
}
