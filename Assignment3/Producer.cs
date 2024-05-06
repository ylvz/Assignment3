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

        public Producer(SharedBuffer buffer, Label statuslabel)
        {
            this.buffer = buffer;
            this.statuslabel = statuslabel;
        }

        public void CreateTestProduct()
        {
            const int max = 50;
            itemArray=new Product[max];

            for(int i = 0; i < 5; i++)
            {
                int j = i * 10;
            }
        }

        public void StopProducing()
        {
            isProducing = false;
        }

        private void Produce()
        {

        }
    }
}
