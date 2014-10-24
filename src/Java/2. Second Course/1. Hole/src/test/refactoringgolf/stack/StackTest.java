package refactoringgolf.stack;

import static org.junit.Assert.*;

import org.junit.Before;
import org.junit.Test;


public class StackTest {
    private Stack stack;

    @Before
    public void setup()
    {
        stack = new Stack();
    }

    @Test
    public void emptyWhenCreated()
    {
        assertTrue(stack.isEmpty());
    }

    @Test
    public void returnTheNumberOfItems()
    {
        stack.push("1");
        stack.push("2");
        assertEquals(2, stack.size());
    }

    @Test
    public void emptyWhenPushAndPopOneItem()
    {
        stack.push("1");
        stack.pop();
        assertTrue(stack.isEmpty());
    }

    @Test
    public void notEmptyWhenPush()
    {
        stack.push("1");
        assertFalse(stack.isEmpty());
    }

    @Test
    public void pushAndPopOneItem()
    {
        stack.push("1");
        assertEquals("1", stack.pop());
    }

    @Test
    public void popTheLastWhenTwoItems()
    {
        stack.push("1");
        stack.push("2");
        assertEquals("2", stack.pop());
    }

    @Test
    public void pushAndPopTwoItems()
    {
        stack.push("1");
        stack.push("2");
        stack.pop();
        assertEquals("1", stack.pop());
    }

    @Test
    public void returnOneItemWithoutRemovingIt()
    {
        stack.push("1");
        stack.peek();
        assertEquals("1", stack.peek());

    }

    @Test
    public void returnThePositionWhereAnItemExits() {
        stack.push("1");
        stack.push("2");
        stack.push("3");
        stack.push("4");
        assertEquals(3, stack.search("2"));
    }

    @Test
    public void returnMinusOneWhenItemDoesntExits()
    {
        assertEquals(-1, stack.search("1"));
    }

    @Test
    public void containAndItemAlreadyPushed()
    {
        stack.push("1");
        assertTrue(stack.contains("1"));
    }

    @Test
    public void notContainAnItemNotPushed()
    {
        assertFalse(stack.contains("1"));
    }

    @Test
    public void replaceTheValueOfAnElement()
    {
        stack.push("6");
        stack.push("2");
        stack.push("6");
        stack.replaceAll("6", "1");
        assertEquals("1", stack.pop());
        stack.pop();
        assertEquals("1", stack.pop());
    }

    @Test
    public void throwExceptionWhenEmptyAndPop()
    {
        try
        {
            stack.pop();
            fail();
        }
        catch (IllegalStateException e)
        {
        }
    }
}
