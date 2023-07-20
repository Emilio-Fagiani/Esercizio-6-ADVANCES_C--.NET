using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esercizio_6_ADVANCES_C__.NET
{
    public class Queue<T> : IQueue<T>
    {
        private Queue<T> queue;

        public Queue()
        {
            queue = new Queue<T>();
        }

        public void Enqueue(T item)
        {
            queue.Enqueue(item);
        }

        public T Dequeue()
        {
      
            return queue.Dequeue();
        }

        public T Peek()
        {
            throw new NotImplementedException();
        }
    }
}
