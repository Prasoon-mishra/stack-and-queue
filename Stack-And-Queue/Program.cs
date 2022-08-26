namespace Stack_And_Queue
{
    public class Node //    CREATING THE NODE
    {
        public int element;
        public Node next;

        public Node(int a, Node n) // INITIALIZING THE VARIABLES USING COSTRUCTOR
        {
            this.element = a;
            this.next = n;
        }
    }
    internal class Queue
    {
        public Node head;
        public Node top;
        public int size;

        public Queue()
        {
            head = null;
            top = null;
            size = 0;
        }

        public int Length()  //CALCULATING THE LENGTH OF LINKED LIST
        {
            return size;
        }

        public bool isEmpty() // TO CHECK WHETHER THE LIST IS EMPTY OR NOT
        {
            return size == 0;
        }
        public void push(int e) // ADDING THE NODES FROM THE LAST 
        {
            Node newest = new Node(e, null);
            if (isEmpty())
            {
                head = newest;
            }
            else
            {
                top.next = newest;
            }
            top = newest;
            size++;
        }
        public void display()
        {
            Node runner = head;
            while (runner.next != null)
            {
                Console.Write(runner.element + " --> ");
                runner = runner.next;
            }
            Console.WriteLine(runner.element);
            Console.WriteLine();
        }
    }
    
    internal class Program
        {

        static void Main(string[] args)
        {
            Console.WriteLine("-----------------------QUEUE-------------------");
            Queue queue = new Queue();
            queue.push(56);
            queue.push(30);
            queue.push(70);
            queue.display();

        }
    }
}