using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esercizio_6_ADVANCES_C__.NET
{
    public interface IQueue<T> 
    {
        void Enqueue(T item);
        T Dequeue();
        T Peek();
    }
}
