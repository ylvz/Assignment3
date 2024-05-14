using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3
{
    internal class SharedBuffer
    {
        ProgressBar progressBar;
        private Label lblBufferItems;
        private Product[] buffer;
        private int inPos;
        private int outPos;
        private int bufferCount;

        Semaphore producerSem, consumerSem;
        Mutex mutex;

        public SharedBuffer(ProgressBar progressBar,Label lblItems,int storageSize)
        {
            this.progressBar = progressBar;
            buffer = new Product[storageSize];

            progressBar.Maximum = storageSize;
            this.lblBufferItems = lblItems;

            producerSem = new Semaphore(storageSize, storageSize);
            consumerSem = new Semaphore(0, storageSize);
            mutex = new Mutex();
        }

        public void Produce(Product product)
        {
            progressBar.Invoke((MethodInvoker)(()=>progressBar.Value=bufferCount));
            lblBufferItems.Invoke((MethodInvoker)(()=>lblBufferItems.Text=bufferCount.ToString()));
        }

    }
}
