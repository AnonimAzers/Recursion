using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack
{
    //LIFO. Стек
    internal class MyStack<T>
    {
        int MaxSize;
        int Size;
        T[] mas;

        public MyStack(int maxSize)
        {
            MaxSize = maxSize;
            Size = 0;
            this.mas = new T[maxSize];
        }

        public bool isEmpty() => Size == 0;

        public bool Pop([MaybeNullWhen(false)] out T result) {
            if (Size != 0)
            {
                Size -= 1;
                result = this.mas[Size];
                this.mas[Size] = default(T);
                return true;
            } else
            {
                result = default(T);
                return false;
            }
        }

        public bool Push(T value)
        {
            if (Size != MaxSize)
            {
                mas[Size] = value;
                Size += 1;
                return true;
            }
            return false;
        }
    }
}
