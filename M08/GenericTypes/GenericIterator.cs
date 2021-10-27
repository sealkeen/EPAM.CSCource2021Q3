using System;
using System.Collections.Generic;
using System.Text;

namespace GenericTypes
{
    public class GenericIterator<T> : Iterator
    {
        private T[] _collection;
        private int _position = -1;
        private bool _reverse = false;
        public GenericIterator(T[] collection, bool reverse = false)
        {
            this._collection = collection;
            this._reverse = reverse;

            if (reverse)
            {
                this._position = collection.Length;
            }
        }
        public override object Current()
        {
            return this._collection[_position];
        }
        public override int Key()
        {
            return this._position;
        }
        public override bool MoveNext()
        {
            int updatedPosition = this._position + (this._reverse ? -1 : 1);

            if (updatedPosition >= 0 && updatedPosition < this._collection.Length)
            {
                this._position = updatedPosition;
                return true;
            }
            else
            {
                return false;
            }
        }
        public override void Reset()
        {
            this._position = this._reverse ? this._collection.Length - 1 : 0;
        }
    }
}
