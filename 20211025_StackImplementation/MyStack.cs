using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20211025_StackImplementation
{
    class MyStack<T>
    {
        Entry _top;

        public void Push(T data)
        {
            _top = new Entry(_top, data);
        }

        public T Pop()
        {
            if (_top == null)
            {
                throw new InvalidOperationException();
            }

            T result = _top.data;
            _top = _top.next;

            return result;
        }

        public bool IsEmpty
        {
            get
            {
                return _top == null;
            }
        }

        class Entry
        {
            public Entry next;
            public T data;    

            public Entry(Entry next, T data)
            {
                this.next = next;
                this.data = data;
            }
        }
    }
}
