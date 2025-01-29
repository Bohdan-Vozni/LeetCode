using System.Runtime.CompilerServices;

namespace Implement_Stack_using_Queues
{
    public class MyStack
    {

        public MyStack()
        {

        }
        private Queue<int> queue = new Queue<int>();


        public void Push(int x)
        {

            queue.Enqueue(x);

            if ( queue.Count() < 2 ) return;
            
            for ( int i = 0; i < queue.Count() - 1 ; i++ )
            {
                int element = queue.Dequeue();
                queue.Enqueue(element);

            }         

        }

        public int Pop()
        {
            return queue.Dequeue();
        }

        public int Top()
        {
            return queue.Peek();
        }

        public bool Empty()
        {
            if (queue.Count() == 0) return true;
            else return false;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            MyStack obj = new MyStack();
            
            obj.Push(1);
            obj.Push(2);
            obj.Push(3);
            obj.Push(4);
        }
    }
}
