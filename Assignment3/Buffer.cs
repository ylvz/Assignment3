using System.Threading;

namespace Assignment3
{
    /// <summary>
    /// Class representing the shared buffer in the management system. Includes methods to add products
    /// and also remove them. Synchronisation for the system occurs in the methods of this class.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class Buffer<T>
    {
        private T[] buffer;
        private int producerIndex; //position in the buffer where the producer produces a product
        private int consumeIndex; //position in the buffer where the consumer consumes a product
        private int productsCount; //the amount of products currently in the buffer
        public int ProductsCount { get { return productsCount; } }
        private const int bufferSize = 20; //the constant size of the buffer
        Semaphore filledSlots = new Semaphore(0, bufferSize);
        Semaphore emptySlots = new Semaphore(bufferSize, bufferSize);
        Mutex mutex = new Mutex();
        public Buffer()
        {
            producerIndex = -1;
            consumeIndex = -1;
            productsCount = 0;
            buffer = new T[bufferSize];
        }
        public void AddProduct(T product)
        {
            try
            {
                emptySlots.WaitOne();
                mutex.WaitOne();
                producerIndex = (producerIndex + 1) % bufferSize;
                buffer[producerIndex] = product;
                productsCount++;
            }
            finally
            {
                mutex.ReleaseMutex();
                filledSlots.Release();
            }
        }
        public T RemoveProduct()
        {
            try
            {
                filledSlots.WaitOne();
                mutex.WaitOne();
                consumeIndex = (consumeIndex + 1) % bufferSize;              
                productsCount--;
                return buffer[consumeIndex];
            }
            finally
            {
                mutex.ReleaseMutex();
                emptySlots.Release();
            }                   
        }    
    }
}
