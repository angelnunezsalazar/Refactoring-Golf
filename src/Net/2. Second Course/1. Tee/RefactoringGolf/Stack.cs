namespace RefactoringGolf.Stack
{
    using System;

    public class Stack
    {
        private const int INITIAL_CAPACITY = 5;
        private object[] elements = new object[INITIAL_CAPACITY];
        private int count;

        public bool IsEmpty
        {
            get { return count == 0; }
        }

        public int Size
        {
            get { return count; }
        }

        public void Push(object element)
        {
            if (count + 1 > this.elements.Length)
            {
                object[] temp = new object[2 * this.elements.Length];
                Array.Copy(elements, temp, count);
                elements = temp;
            }
            elements[count] = element;
            count++;
        }

        public object Pop()
        {
            if (IsEmpty)
                throw new InvalidOperationException();
            object element = elements[count - 1];
            count--;
            return element;
        }

        public object Peek()
        {
            return elements[count - 1];
        }

        public bool Contains(object elementToFind)
        {
            for (int i = 0; i < count; i++)
            {
                if (elementToFind == elements[i])
                {
                    return true;
                }
            }
            return false;
        }

        public int Search(object elementToFind)
        {
            for (int i = 1; i <= count; i++)
            {
                if (elementToFind == elements[count - i])
                {
                    return i;
                }
            }
            return -1;
        }

        public void ReplaceAll(object elementToFind, object newElement)
        {
            for (int i = count - 1; i >= 0; i--)
            {
                if (elementToFind == elements[i])
                {
                    elements[i] = newElement;
                }
            }
        }
    }
}