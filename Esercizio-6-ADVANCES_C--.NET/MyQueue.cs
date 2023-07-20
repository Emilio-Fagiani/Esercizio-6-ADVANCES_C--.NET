using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esercizio_6_ADVANCES_C__.NET
{
    public class MyQueue<T>
    {
        public IQueue<T> _queue;

        public MyQueue()
        { 
        }

      

        public void Enqueue(T item)
        {
            if(_queue == null)
            {
                throw new Exception();
            }else 

                _queue.Enqueue(item);
        }

        public T Dequeue()
        {
            return _queue.Dequeue();
        }

        public T Peek()
        {
            return _queue.Peek();
        }

    }
}
