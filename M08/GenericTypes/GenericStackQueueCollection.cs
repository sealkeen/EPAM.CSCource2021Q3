using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

//TODO: Develop a generic class-collection Queue/Stack that implements basic operations. 
//Implement the capability to iterate by collection by design pattern Iterator.
namespace GenericTypes
{
    public class GenericStackQueueCollection<T> : IteratorAggregate
    {
        private int currentIndex = -1;
        private T[] collection;
        bool _direction = false;
        public override IEnumerator GetEnumerator()
        {
            return new GenericIterator<T>(this.collection, _direction);
        }
        public GenericStackQueueCollection(int size)
        {
            collection = new T[size];
            currentIndex = -1;
        }
        public void ReverseDirection()
        {
            _direction = !_direction;
        }
        public T Pop() {
            CheckIfStackIsEmpty();
            T toPop = collection[currentIndex];
            Array.Resize(ref collection, collection.Length - 1);
            return toPop;
        }
        public T Peek()
        {
            CheckIfStackIsEmpty();
            return collection[collection.Length - 1];
        }
        public void Push(T item) {
            if (currentIndex + 1 >= collection.Length) {
                Array.Resize(ref collection, collection.Length + 1);
            }
            collection[++currentIndex] = item;
        }
        private void CheckIfStackIsEmpty()
        {
            if (currentIndex < 0 || collection.Length <= 0)
            {
                throw new InvalidOperationException("Stack was empty.");
            }
        }
    }
}
