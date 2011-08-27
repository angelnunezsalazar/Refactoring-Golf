package refactoringgolf.stack;

import java.util.ArrayList;
import java.util.List;

public class Stack {
	
    private List<Object> elements = new ArrayList<Object>();

    public boolean isEmpty()
    {
        return size() == 0;
    }

    public int size()
    {
        return elements.size();
    }

    public void push(Object element)
    {
        elements.add(element);
    }

    public Object pop()
    {
        if (isEmpty())
            throw new IllegalStateException();
        Object element = elements.get(size() - 1);
        elements.remove(size()-1);
        return element;
    }

    public Object peek()
    {
        return elements.get(size() - 1);
    }

    public boolean contains(Object elementToFind)
    {
        int indexOf = search(elementToFind);
        if (indexOf != -1)
        {
            return true;
        }
        return false;
    }

    public int search(Object elementToFind)
    {
        for (int i = 1; i <= size(); i++)
        {
            if (elementToFind == elements.get(size()-i))
            {
                return i;
            }
        }
        return -1;
    }

    public void replaceAll(Object elementToFind, Object newElement)
    {
        for (int i = size() - 1; i >= 0; i--)
        {
            if (elementToFind == elements.get(i))
            {
                elements.set(i,newElement);
            }
        }
    }
}
