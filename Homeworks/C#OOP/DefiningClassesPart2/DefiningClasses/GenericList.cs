namespace DefiningClasses
{
    using System;
    using System.Collections.Generic;

    public class GenericList<T> where T : IComparable<T>
    {
        ////private const int DefaultCapacity = 4096;
        private T[] elements;
        private int capacity;
        private int count = 0;

        ////Ctor
        public GenericList(int capacity)
        {
            this.Capacity = capacity;
            this.Elements = new T[capacity];
        }

        ////public GenericList() : this(DefaultCapacity)
        ////{
        ////}

        //////Properties      
        public T[] Elements
        {
            get
            {
                return this.elements;
            }

            set
            {
                this.elements = value;
            }
        }

        public int Capacity
        {
            get
            {
                return this.capacity;
            }

            set
            {
                this.capacity = value;
            }
        }

        public T this[int index]
        {
            get
            {
                return this.elements[index];
            }

            set
            {
                if (index < 0 || index > this.capacity)
                {
                    throw new IndexOutOfRangeException();
                }
                else
                {
                    this.elements[index] = value;
                }
            }
        }
        ////Methods

        ////public void Add(T element)
        ////{

        ////    T[]
        ////}

        public void PrintAllElements()
        {
            foreach (var item in this.elements)
            {
                Console.WriteLine(item);
            }
        }

        public void Add(T element)
        {
            if (this.count > this.elements.Length - 1)
            {
                this.DoubleArray();
            }
            else
            {
                this.elements[this.count] = element;
                this.count++;
            }
        }

        public void GetElementInIndex(int index)
        {
            if (index < this.capacity)
            {
                Console.WriteLine(this.elements[index]);
            }
            else
            {
                throw new IndexOutOfRangeException();
            }
        }

        public void RemovingElementByIndex(int index)
        {
            T[] tempArray = new T[this.capacity];
            int tempIndex = 0;
            if (index < this.capacity)
            {
                for (int i = 0; i < this.capacity; i++)
                {
                    if (i != index)
                    {
                        tempArray[tempIndex] = this.elements[i];
                        tempIndex++;
                    }
                }

                this.Elements = tempArray;
            }
            else
            {
                throw new IndexOutOfRangeException();
            }
        }

        public void InsertElementAtPosition(int position, T element)
        {
            T[] tempArray = new T[this.Capacity];
            int tempIndex = 0;

            if (position > this.Capacity)
            {
                throw new IndexOutOfRangeException();
            }
            else
            {
                for (int i = 0; i < this.Capacity; i++)
                {
                    if (i == position)
                    {
                        tempArray[tempIndex] = element;
                        tempIndex++;
                    }
                    else
                    {
                        tempArray[tempIndex] = this.Elements[i];
                        tempIndex++;
                    }
                }

                this.Elements = tempArray;
            }
        }

        public void Clear()
        {
            this.Elements = new T[0];
        }

        public void FindElement(T element)
        {
            bool isFound = false;
            for (int i = 0; i < this.Capacity; i++)
            {
                if (this.Elements[i].CompareTo(element) == 0)
                {
                    Console.WriteLine("Postion: " + i);
                    isFound = true;
                    break;
                }
            }

            if (isFound == false)
            {
                throw new Exception("This element doesn't exist in current list");
            }
        }

        public void DoubleArray()
        {
            T[] tempArray = new T[this.Capacity * 2];
            for (int i = 0; i < this.capacity; i++)
            {
                tempArray[i] = this.elements[i];
            }

            this.elements = tempArray;
            this.capacity *= 2;
        }

        public T Min()
        {
            T currentMin = this.elements[0];
            T min = this.elements[0];
            for (int i = 0; i < this.capacity - 1; i++)
            {
                if (currentMin.CompareTo(this.elements[i + 1]) > 0)
                {
                    min = this.elements[i + 1];
                    currentMin = min;
                }
            }

            return min;
        }

        public T Max()
        {
            T currentMax = this.elements[0];
            T max = this.elements[0];
            for (int i = 0; i < this.capacity - 1; i++)
            {
                if (currentMax.CompareTo(this.elements[i + 1]) < 0)
                {
                    max = this.elements[i + 1];
                    currentMax = max;
                }
            }

            return max;
        }

        public override string ToString()
        {
            bool checkIsEmpty = false;

            for (int i = 0; i < this.Capacity; i++)
            {
                if (this.Elements[i] == null)
                {
                    checkIsEmpty = true;
                }
            }

            if (checkIsEmpty == true)
            {
                Console.WriteLine("This list is empty.");
            }
            else
            {
                for (int i = 0; i < this.Capacity; i++)
                {
                    Console.WriteLine(this.Elements[i]);
                }
            }

            return base.ToString();
        }
    }
}
