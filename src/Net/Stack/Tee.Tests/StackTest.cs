namespace Tee.Tests
{
    using System;

    using Microsoft.VisualStudio.TestTools.UnitTesting;

    using Tee;

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
        public void EmptyWhenCreated()
        {
            Assert.IsTrue(stack.IsEmpty);
        }

        [TestMethod]
        public void ReturnTheNumberOfItems()
        {
            stack.Push("1");
            stack.Push("2");
            Assert.AreEqual(2, stack.Size);
        }

        [TestMethod]
        public void EmptyWhenPushAndPopOneItem()
        {
            stack.Push("1");
            stack.Pop();
            Assert.IsTrue(stack.IsEmpty);
        }

        [TestMethod]
        public void NotEmptyWhenPush()
        {
            stack.Push("1");
            Assert.IsFalse(stack.IsEmpty);
        }

        [TestMethod]
        public void PushAndPopOneItem()
        {
            stack.Push("1");
            Assert.AreEqual("1", stack.Pop());
        }

        [TestMethod]
        public void PopTheLastWhenTwoItems()
        {
            stack.Push("1");
            stack.Push("2");
            Assert.AreEqual("2", stack.Pop());
        }

        [TestMethod]
        public void PushAndPopTwoItems()
        {
            stack.Push("1");
            stack.Push("2");
            stack.Pop();
            Assert.AreEqual("1", stack.Pop());
        }

        [TestMethod]
        public void ReturnOneItemWithoutRemovingIt()
        {
            stack.Push("1");
            stack.Peek();
            Assert.AreEqual("1", stack.Peek());

        }

        [TestMethod]
        public void ReturnThePositionWhereAnItemExits()
        {
            stack.Push("1");
            stack.Push("2");
            stack.Push("3");
            stack.Push("4");
            Assert.AreEqual(3, stack.Search("2"));
        }

        [TestMethod]
        public void ReturnMinusOneWhenItemDoesntExits()
        {
            Assert.AreEqual(-1, stack.Search("1"));
        }

        [TestMethod]
        public void ContainAndItemAlreadyPushed()
        {
            stack.Push("1");
            Assert.IsTrue(stack.Contains("1"));
        }

        [TestMethod]
        public void NotContainAnItemNotPushed()
        {
            Assert.IsFalse(stack.Contains("1"));
        }

        [TestMethod]
        public void ReplaceTheValueOfAnElement()
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
        public void ThrowExceptionWhenEmptyAndPop()
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
