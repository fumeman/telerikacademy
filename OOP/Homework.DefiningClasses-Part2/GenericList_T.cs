namespace Homework.DefiningClasses_Part2
{
    using System;

    public class GenericList<T>
    {
        private const int InitialCapacity = 4;

        private T[] elements;

        public GenericList()
        {
            this.Count = 0;
            this.elements = new T[InitialCapacity];
        }

        public int Count { get; private set; }

        public int Capacity
        {
            get
            {
                return this.elements.Length;
            }
        }

        public void Add(T item)
        {
            if (this.Count >= this.Capacity)
            {
                this.DoubleSize();
            }

            this.elements[this.Count] = item;
            this.Count++;
        }

        public T GetByIndex(int index)
        {
            this.CheckIndex(index);
            return this.elements[index];
        }

        public void RemoveByIndex(int index)
        {
            this.CheckIndex(index);

            for (int i = index; i < this.Count - 1; i++)
            {
                this.elements[i] = this.elements[i + 1];
            }

            this.elements[this.Count - 1] = default(T);
            this.Count--;
        }

        public void InsertAtPosition(int index, T item)
        {
            this.CheckIndex(index == 0 ? index : index - 1); ////because of CheckIndex()

            T tmp = this.elements[index];
            this.elements[index] = item;
            if (this.Count == this.Capacity)
            {
                this.DoubleSize();
            }

            for (int i = this.Count; i > index + 1; i--)
            {
                this.elements[i] = this.elements[i - 1];
            }

            this.elements[index + 1] = tmp;
            this.Count++;
        }

        public void Clear()
        {
            int count = this.Count;
            for (int i = 0; i < count; i++)
            {
                this.RemoveByIndex(0);
            }
        }

        public int FindFirst(T item)
        {
            int result = -1;

            for (int i = 0; i < this.Count; i++)
            {
                if (this.elements[i].Equals(item))
                {
                    result = i;
                    break;
                }
            }

            return result;
        }

        public override string ToString()
        {
            string result = string.Empty;

            for (int i = 0; i < this.Count; i++)
            {
                if (i < this.Count - 1)
                {
                    result += this.elements[i] + ", ";
                }
                else
                {
                    result += this.elements[i];
                }
            }

            return result;
        }

        private void DoubleSize()
        {
            var newElements = new T[this.Capacity * 2];

            for (int i = 0; i < this.Count; i++)
            {
                newElements[i] = this.elements[i];
            }

            this.elements = newElements;
        }

        private void CheckIndex(int index)
        {
            if (index >= this.Count)
            {
                throw new Exception("Index out of range!");
            }
        }
    }
}
