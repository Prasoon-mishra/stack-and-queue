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
    internal class Stack
    {
        public Node head;
        public Node top;
        public int size;

        public Stack()
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
        public int Pop()
        {
            if (isEmpty())
            {
                Console.WriteLine("List is empty");
                return -1;
            }
            Node runner = head;
            int i = 1;
            while (i < size - 1)
            {
                runner = runner.next;
                i++;
            }
            top = runner;
            runner = runner.next;
            int e = runner.element;
            top.next = null;
            size--;
            return e;
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
            Stack stack = new Stack();
            stack.push(56);
            stack.push(30);
            stack.push(70);
            stack.display();
            stack.Pop();
            stack.display();
            stack.Pop();
            stack.display();


        }
    }
}