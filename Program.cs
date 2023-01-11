using System.Threading.Tasks;

namespace StackandQueue
{ 
public class QNode
{
    public int data;
    public QNode next;
    public QNode(int value)
    {
        this.data = value;
        this.next = null;
    }
}
    public class MyQueue
    {
        public QNode head;
        public QNode tail;
        public int count;
        public MyQueue()
        {
            this.head = null;
            this.tail = null;
            this.count = 0;
        }
        public int size()
        {
            return this.count;
        }
        public bool isEmpty()
        {
            return this.count == 0;
        }
        
        public void enqueue(int value)
        {
            
            var node = new QNode(value);
            if (this.head == null)
            { 
                this.head = node;
            }
            else
            {
                this.tail.next = node;
            }
            Console.WriteLine("The data is: " + node.data);
            this.count++;
            this.tail = node;
        }
        
        public int dequeue()
        {
            if (this.head == null)
            {
                Console.WriteLine("Empty Queue");
                return -1;
            }
            
            var temp = this.head;
            
            this.head = this.head.next;
            this.count--;
            if (this.head == null)
            {
                this.tail = null;
            }
            return temp.data;
        }
        
        public int peek()
        {
            if (this.head == null)
            {
                Console.WriteLine("Empty Queue");
                return -1;
            }
            return this.head.data;
        }
        public static void Main(String[] args)
        {
            var queue = new MyQueue();
            
            queue.enqueue(56);
            queue.enqueue(30);
            queue.enqueue(70);

            while (queue.size() > 0)
            {
                Console.WriteLine();
                Console.WriteLine("size is : " + queue.size());
                Console.WriteLine("peek is : " + queue.peek());
                Console.WriteLine("dequeue : " + queue.dequeue());
                Console.WriteLine("size is : " + queue.size());
                Console.WriteLine("peek is : " + queue.peek());
                Console.WriteLine("IsEmpty : " + queue.isEmpty());
            }

        }
    }
}