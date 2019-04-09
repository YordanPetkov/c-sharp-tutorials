using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    class GenericList<T>
        where T : IComparable<T>
    {
        private const int InitialCopacity = 4;

        private T[] elements;

        public int Count { get; private set; }

        public int Capacity
        {
            get { return elements.Length; }
        }

        public T this[int index]
        {
            get
            {
                return this.elements[index];
            }

            set
            {
                this.elements[index] = value;
            }
        }

        public static int Compare(GenericList<T> first, GenericList<T> second)
        {
            var lenght = Math.Min(first.Count, second.Count);

            for (int i = 0; i < lenght; i++)
            {
                if (first[i].CompareTo(second[i]) != 0)
                {
                    return first[i].CompareTo(second[i]);
                }
            }

            if (first.Count > second.Count)
            {
                return 1;
            }

            if (second.Count > first.Count)
            {
                return -1;
            }

            return 0;
        }

        public GenericList()
        {
            this.elements = new T[InitialCopacity];
            this.Count = 0;
        }

        public GenericList(int capacity)
        {
            this.Count = 0;
            var powerOfTwo = this.NearestPowerOf2(capacity);
            this.elements = new T[powerOfTwo];
        }

        public void Add(T item)
        {
            if (this.Count == this.Capacity) Expand();
            elements[this.Count++] = item;
        }

        public void RemoveFirst(T item)
        {
            //var itemIndex = Array.IndexOf(this.elements, item);
            int index = -1;
            for (int i = 0; i < this.Count; i++)
            {
                if(this.elements[i].Equals(item))
                {
                    index = i;
                    break;
                }
            }

            RemoveAt(index);
        }

        public void RemoveAll(T item)
        {
            int index = -1;
            for (int i = 0; i < this.Count; i++)
            {
                if (this.elements[i].Equals(item))
                {
                    index = i;
                    RemoveAt(index);
                    i--;
                }
            }
        }

        public void RemoveAt(int index)
        {
            if (this.Count <= index || index <= -1) return;
            for (int i = index; i < this.Count - 1; i++)
            {
                this.elements[i] = this.elements[i + 1];
            }

            this.elements[this.Count - 1] = default(T);

            this.Count--;
        }

        public static GenericList<T> operator+(GenericList<T> list, T[] items)
        {
            foreach (var itemToAdd in items)
            {
                list.Add(itemToAdd);
            }
            return list;
        }

        public static GenericList<T> operator+(GenericList<T> list, T item)
        {
            list.Add(item);
            return list;
        }

        public static GenericList<T> operator-(GenericList<T> list, T item)
        {
            list.RemoveFirst(item);
            return list;
        }

        public static GenericList<T> operator--(GenericList<T> list)
        {
            list.RemoveAt(list.Count - 1);
            return list;
        }

        public static implicit operator bool(GenericList<T> list)
        {
            return list != null && list.Count > 0;
        }

        public override string ToString()
        {
            var result = new StringBuilder();

            for (int i = 0; i < this.Count; i++)
            {
                result.Append(this.elements[i]);
                if(i != this.Count - 1)
                {
                    result.Append(" -> ");
                }
            }

            return result.ToString(); 
        }

        public void Print()
        {
            Console.WriteLine(string.Join(", ", this.elements));
        }

        private void Expand()
        {
            var newElements = new T[2 * this.Capacity];

            for (int i = 0; i < this.Count; i++)
            {
                newElements[i] = this.elements[i];
            }

            this.elements = newElements;
        }

        private int NearestPowerOf2(int n)
        {
            var pow = 0;
            while (n > 0)
            {
                n >>= 1;
                pow++;
            }
            return 1 << pow;
        }
    }
}
