package refactoringgolf.stack;

public class Stack {

	private final int INITIAL_CAPACITY = 5;
	private Object[] elements = new Object[INITIAL_CAPACITY];
	private int count;

	public boolean isEmpty() {
		return count == 0;
	}

	public int size() {
		return count;
	}

	public void push(Object element) {
		if (count + 1 > elements.length) {
			Object[] temp = new Object[2 * elements.length];
			System.arraycopy(elements, 0, temp, 0, elements.length);
			elements = temp;
		}
		elements[count] = element;
		count++;
	}

	public Object pop() {
		if (isEmpty())
			throw new IllegalStateException();
		Object element = elements[count - 1];
		count--;
		return element;
	}

	public Object peek() {
		return elements[count - 1];
	}

	public boolean contains(Object elementToFind) {
		for (int i = 0; i < count; i++) {
			if (elementToFind == elements[i]) {
				return true;
			}
		}
		return false;
	}

	public int search(Object elementToFind) {
		for (int i = 1; i <= count; i++) {
			if (elementToFind == elements[count - i]) {
				return i;
			}
		}
		return -1;
	}

	public void replaceAll(Object elementToFind, Object newElement) {
		for (int i = count - 1; i >= 0; i--) {
			if (elementToFind == elements[i]) {
				elements[i] = newElement;
			}
		}
	}
}
