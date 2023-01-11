namespace StackandQueue
{
    class Program
    {
        public class StackNode
        {
            public int data;
            public StackNode next;
            public StackNode(int data)
            {
                this.data = data;
            }
        }

        StackNode root;

        public void push(int data)
        {
            StackNode newNode = new StackNode(data);
            if (root == null)
            {
                root = newNode;
            }
            else
            {
                StackNode temp = root;
                root = newNode;
                newNode.next = temp;
            }
            Console.WriteLine("Item pushed into stack : " + data);
        }

        public int pop()
        {
            int popped;
            if (root == null)
            {
                Console.WriteLine("Stack is Empty");
                return 0;
            }
            else
            {
                popped = root.data;
                root = root.next;
                return popped;
            }
        }

        public int peek()
        {
            if (root == null)
            {
                Console.WriteLine("Stack is empty");
                return 0;
            }
            else
            {
                return root.data;
            }
        }

        public static void Main(String[] args)
        {
            Program p = new Program();
            p.push(56);
            p.push(30);
            p.push(70);
            Console.WriteLine("Item popped from stack : " + p.pop());
            Console.WriteLine(p.peek() + " Returned by Peek operation");
        }
    }
}