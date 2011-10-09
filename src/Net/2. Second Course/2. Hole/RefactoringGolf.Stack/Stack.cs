namespace RefactoringGolf.Stack
{
    using System;
    using System.Collections.Generic;

    public class Stack
    {
        private List<object> elements = new List<object>();

        public bool IsEmpty
        {
            get { return Size == 0; }
        }

        public int Size
        {
            get { return elements.Count; }
        }

        public void Push(object element)
        {
            elements.Add(element);
        }

        public object Pop()
        {
            if (IsEmpty)
                throw new InvalidOperationException();
            object element = elements[Size - 1];
            elements.RemoveAt(Size-1);
            return element;
        }

        public object Peek()
        {
            return elements[Size - 1];
        }

        public bool Contains(object elementToFind)
        {
            int indexOf = Search(elementToFind);
            if (indexOf != -1)
            {
                return true;
            }
            return false;
        }

        public int Search(object elementToFind)
        {
            for (int i = 1; i <= Size; i++)
            {
                if (elementToFind == elements[Size-i])
                {
                    return i;
                }
            }
            return -1;
        }

        public void ReplaceAll(object elementToFind, object newElement)
        {
            for (int i = Size - 1; i >= 0; i--)
            {
                if (elementToFind == elements[i])
                {
                    elements[i] = newElement;
                }
            }
        }
    }
}