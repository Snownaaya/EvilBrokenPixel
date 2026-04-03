using System;
using System.Collections.Generic;

namespace Assets._Project.Scripts.Utils
{
    public struct StructStack<T>
    {
        private T[] _array;
        private int _size;
        private readonly int _capacity;

        public StructStack(int capacity = 4)
        {
            if (capacity <= 0) 
                throw new ArgumentException("Capacity must be positive", nameof(capacity));
            
            _array = new T[capacity];
            _size = 0;
            _capacity = capacity;
        }

        public readonly int Count => _size;
        public readonly int Capacity => _capacity;

        public void Push(T item)
        {            
            _array[_size] = item;
            _size++;
        }

        public T Pop()
        {
            _size--;
            T item = _array[_size];
            _array[_size] = default!;
            return item;
        }

        public readonly T Peek()
        {            
            return _array[_size - 1];
        }

        public void Clear()
        {
            if (_size > 0)
            {
                Array.Clear(_array, 0, _size);
                _size = 0;
            }
        }

        public readonly bool Contains(T item)
        {
            if (_size == 0)
                return false;
            
            EqualityComparer<T> comparer = EqualityComparer<T>.Default;
            
            for (int i = 0; i < _size; i++)
                if (_array[i].Equals(item))
                    return true;
            
            return false;
        }

        public readonly T[] ToArray()
        {
            T[] result = new T[_size];
            Array.Copy(_array, 0, result, 0, _size);
            return result;
        }
    }
}