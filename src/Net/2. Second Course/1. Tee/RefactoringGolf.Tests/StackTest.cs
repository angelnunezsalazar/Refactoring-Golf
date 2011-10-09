namespace RefactoringGolf.Stack.Tests
{
    using System;

    using Microsoft.VisualStudio.TestTools.UnitTesting;

    using RefactoringGolf.Stack;

    [TestClass]
    public class StackTest
    {
        private Stack stack;

        [TestInitialize]
        public void Setup()
        {
            stack = new Stack();
        }

        [TestMethod]
        public void IsEmptyWhenItIsCreated()
        {
            Assert.IsTrue(stack.IsEmpty);
        }

        [TestMethod]
        public void NotEmptyWhenInsertingOneItem()
        {
            stack.Push("1");
            Assert.IsFalse(stack.IsEmpty);
        }
        
        [TestMethod]
        public void IsEmptyWhenInsertingAndRemoving()
        {
            stack.Push("1");
            stack.Pop();
            Assert.IsTrue(stack.IsEmpty);
        }

        [TestMethod]
        public void InsertsAndReturnsOneItem()
        {
            stack.Push("1");
            Assert.AreEqual("1", stack.Pop());
        }

        [TestMethod]
        public void ReturnsTheMostRecentlyInsertedItem()
        {
            stack.Push("1");
            stack.Push("2");
            Assert.AreEqual("2", stack.Pop());
        }

        [TestMethod]
        public void InsertsAndReturnsTwoItems()
        {
            stack.Push("1");
            stack.Push("2");
            stack.Pop();
            Assert.AreEqual("1", stack.Pop());
        }

        [TestMethod]
        public void ReturnsTheNumberOfItems()
        {
            stack.Push("1");
            stack.Push("2");
            Assert.AreEqual(2, stack.Size);
        }

        [TestMethod]
        public void ReturnsOneItemWithoutRemovingIt()
        {
            stack.Push("1");
            stack.Peek();
            Assert.AreEqual("1", stack.Peek());

        }

        [TestMethod]
        public void ReturnsThePositionWhereAnItemExits()
        {
            stack.Push("1");
            stack.Push("2");
            stack.Push("3");
            stack.Push("4");
            Assert.AreEqual(3, stack.Search("2"));
        }

        [TestMethod]
        public void ReturnsMinusOneWhenItemDoesntExits()
        {
            Assert.AreEqual(-1, stack.Search("1"));
        }

        [TestMethod]
        public void DoesNotContainAnItemNotInserted()
        {
            Assert.IsFalse(stack.Contains("1"));
        }

        [TestMethod]
        public void ContainsAndItemAlreadyInserted()
        {
            stack.Push("1");
            Assert.IsTrue(stack.Contains("1"));
        }

        [TestMethod]
        public void ReplacesTheValueOfAnElement()
        {
            stack.Push("6");
            stack.Push("2");
            stack.Push("6");
            stack.ReplaceAll("6", "1");
            Assert.AreEqual("1", stack.Pop());
            stack.Pop();
            Assert.AreEqual("1", stack.Pop());
        }

        [TestMethod]
        public void ThrowsExceptionWhenIsEmptyAndRemovingAnItem()
        {
            try
            {
                stack.Pop();
                Assert.Fail();
            }
            catch (InvalidOperationException)
            {
            }
        }
    }
}
