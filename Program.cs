using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace EXE5_038_KELOMPOK5
{
    class Node
    {
        string element;
        Node devina;
        Node fitria;
        Node next;
        int data;
        private int item;

        public Node(int item)
        {
            this.item = item;
        }

        public Node()
        {
        }
        bool empty()
        {
            if (devina == null)
                return (true);
            else
                return (false);
        }
        public void LinkListQueue()
        {
            this.devina = this.fitria = null;
        }
        public void Enqueue(int item)
        {
            Node newNode = GetNewNode(item);

            // If queue is empty, then new node is front and rear both 
            if (this.fitria == null)
            {
                this.devina = this.fitria = newNode;
            }
            else
            {
                // Add the new node at the end of queue and change rear 
                this.fitria.next = newNode;
                this.fitria = newNode;
            }
            Console.WriteLine("{0} inserted into Queue", item);
        }

        public static Node GetNewNode(int item)
        {
            return new Node(item);
        }

        internal void Dequeue()
        {
            // If queue is empty, return NULL. 
            if (this.devina == null)
            {
                Console.WriteLine("The Queue is empty");
                return;
            }

            // Store previous front and move front one node ahead 
            Node temp = this.devina;
            this.devina = this.devina.next;

            // If front becomes NULL, then change rear also as NULL 
            if (this.devina == null)
            {
                this.fitria = null;
            }

            Console.WriteLine("Item deleted is {0}", temp.data);
        }

        public void display()
        {
            Node tmp;
            if (empty())
                Console.WriteLine("\n Antrean kosong");
            else
            {
                for (tmp = devina; tmp != null; tmp = tmp.next)
                {
                    Console.WriteLine(tmp.data);
                }
                Console.WriteLine();
            }
        }
        static void Main(string[] args)
        {
            Node q = new Node();
            char ch;
            while (true)
            {
                try
                {
                    Console.WriteLine("Menu");
                    Console.WriteLine("1. Implement insert operation");
                    Console.WriteLine("2. Implement delete operation");
                    Console.WriteLine("3. Display values");
                    Console.WriteLine("4. Exit");
                    Console.Write("\nEnter your choice (1-4): ");
                    ch = Convert.ToChar(Console.ReadLine());
                    Console.WriteLine();
                    