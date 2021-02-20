using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oef4
{
    public class ListManipulator
    {
        private int[] _items = new int[10];
        public int Count { get; private set; }
        public void Add(int number)
        {
            if (Count + 1 > GetArraySize())
            {
                int[] tempArr = new int[GetArraySize() * 2];
                for (int i = 0; i < GetArraySize(); i++)
                {
                    tempArr[i] = _items[i];
                }
                _items = tempArr;
            }
            _items[Count] = number;
            Count++;
            
        }
        public int GetArraySize()
        {
            return _items.Length;
        }
        public int this[int index]
        {
            get { return _items[index]; }
            set { _items[index] = value; }
        }
    }
}
