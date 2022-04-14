using System;
using Xunit;
using Stacks_and_Queues.Classes;

namespace TestStack
{
    public class UnitTest1
    {
        [Fact]
        public void TestPush() //Can successfully push onto a stack

        {
            Stack stack = new Stack();
            stack.Push(1);
            Assert.True(stack.IsEmpty == false);
        }
        [Fact]
        public void TestPushmultiple() //Can successfully push multiple values onto a stack

        {
            Stack stack = new Stack();
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);

            Assert.False(stack.IsEmpty);
        }
        [Fact]
        public void Pop() //Can successfully pop off the stack

        {
            Stack stack = new Stack();
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            stack.Pop();
            Assert.Equal("[ 2 ] -> [ 1 ] -> NULL", stack.Print());
        }
        [Fact]
        public void MultiplePop() //Can successfully empty a stack after multiple pops

        {
            Stack stack = new Stack();
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            stack.Pop();
            stack.Pop();
            stack.Pop();

            Assert.Equal("Stack is empty", stack.Print());
        }
        [Fact]
        public void peek() //Can successfully peek the next item on the stack

        {
            Stack stack = new Stack();
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            
            Assert.Equal(3 , stack.Peek());

        }
        [Fact]
        public void EmptyStack() //Can successfully instantiate an empty stack


        {
            Stack stack = new Stack();
            Assert.Equal("Stack is empty", stack.Print());

        }
        [Fact]
        public void PeekOnEmptyStack() //Calling pop or peek on empty stack raises exception


        {
            Stack stack = new Stack();
            Assert.Equal(-1, stack.Peek());

        }
        [Fact]
        public void TestEnqueue() //Can successfully enqueue into a queue


        {
            Queue queue = new Queue();
            queue.Enqeue(1);
            Assert.True(queue.IsEmpty == false);
         
        }
        [Fact]
        public void TestEnqueueMultiple() //Can successfully enqueue multiple values into a queue



        {
            Queue queue = new Queue();
            queue.Enqeue(1);
            queue.Enqeue(2);
            queue.Enqeue(3);
            Assert.Equal("[ 1 ] -> [ 2 ] -> [ 3 ] -> NULL", queue.Print());

        }
        [Fact]
        public void TestDequeue() //Can successfully dequeue out of a queue the expected value



        {
            Queue queue = new Queue();
            queue.Enqeue(1);
            queue.Enqeue(2);
            queue.Enqeue(3);
            queue.Denqeue();
            Assert.Equal("[ 2 ] -> [ 3 ] -> NULL", queue.Print());

        }
        [Fact]
        public void TestPeek() //Can successfully peek into a queue, seeing the expected value



        {
            Queue queue = new Queue();
            queue.Enqeue(1);
            queue.Enqeue(2);
            queue.Enqeue(3);
            Assert.Equal(1, queue.Peek());

        }
        [Fact]
        public void TestMultipleDequeue() //Can successfully empty a queue after multiple dequeues



        {
            Queue queue = new Queue();
            queue.Enqeue(1);
            queue.Enqeue(2);
            queue.Enqeue(3);
            queue.Denqeue();
            queue.Denqeue();
            queue.Denqeue();

            Assert.Equal("Queue is empty", queue.Print());

        }
        [Fact]
        public void InstantiateAnEmptyQueue() //Can successfully instantiate an empty queue
        {
            Queue queue = new Queue();
          

            Assert.Equal("Queue is empty", queue.Print());

        }
        [Fact]
        public void PeekOnEmptyQueue() //Can successfully instantiate an empty queue
        {
            Queue queue = new Queue();


            Assert.Equal(-1, queue.Peek());

        }
        [Fact]
        public void DequeueStackTest() // Test PesudoQueue 
        {

            PseudoQueue Stack1 = new PseudoQueue();




            Stack1.EnqueueStack(5);
            Stack1.EnqueueStack(15);
            Stack1.EnqueueStack(20);

            Assert.Equal(5, Stack1.DequeueStack());
        }
    }
}






//Calling dequeue or peek on empty queue raises exception