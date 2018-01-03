using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Graphify
{
    partial class Node
    {
        private int data;
        private Node next;

        public Node(int data)
        {
            this.data = data;
            next = null;
        }

        public void setData(int data)
        {
            this.data = data;
        }

        public void setNext(Node next)
        {
            this.next = next;
        }

        public int getData()
        {
            return data;
        }

        public Node getNext()
        {
            return next;
        }
    }

    partial class GreedyNode
    {
        private int data;
        private double function;
        private GreedyNode next;

        public GreedyNode(int data, double function)
        {
            this.data = data;
            this.function = function;
            next = null;
        }

        public void setData(int data)
        {
            this.data = data;
        }

        public void setNext(GreedyNode next)
        {
            this.next = next;
        }

        public void setFunction(double function)
        {
            this.function = function;
        }

        public int getData()
        {
            return data;
        }

        public GreedyNode getNext()
        {
            return next;
        }

        public double getFunction()
        {
            return function;
        }
    }

    partial class AStarNode
    {
        private int data;
        private double heuristic;
        private double function;
        private AStarNode next;

        public AStarNode(int data, double heuristic, double function)
        {
            this.data = data;
            this.heuristic = heuristic;
            this.function = function;
            next = null;
        }

        public void setData(int data)
        {
            this.data = data;
        }

        public void setNext(AStarNode next)
        {
            this.next = next;
        }

        public void setFunction(double function)
        {
            this.function = function;
        }

        public int getData()
        {
            return data;
        }

        public AStarNode getNext()
        {
            return next;
        }

        public double getFunction()
        {
            return function;
        }

        public double getHeuristic()
        {
            return heuristic;
        }
    }

    partial class Queue
    {
        private Node front;
        private Node rear;
        private int count = 0;
        public Queue()
        {
            front = rear = null;
        }

        public void enqueue(int data)
        {
            Node node = new Node(data);

            if (front == null)
                front = node;

            else
                rear.setNext(node);

            rear = node;
            count++;
        }

        public void dequeue()
        {

            if (front != null)
                front = front.getNext();

            else
                rear = null;

            count--;
        }

        public bool isEmpty()
        {
            bool flag = false;

            if (count == 0)
                flag = true;

            return flag;
        }

        public int peek()
        {
            int temp = 0;
            if (front != null)
                temp = front.getData();

            return temp;
        }

        public String display()
        {
            String nodes = "";
            Node temp = front;
            while (temp != null)
            {
                nodes += temp.getData() + " ";
                temp = temp.getNext();
            }

            return nodes;
        }

        public bool isVisited(int data)
        {
            bool flag = false;
            Node temp = front;

            while (temp != null)
            {
                if (data == temp.getData())
                {
                    flag = true;
                    break;
                }
                else
                    temp = temp.getNext();
            }

            return flag;
        }

        public int getCount()
        {
            int count = 0;
            Node temp = front;

            while (temp != null)
            {
                count++;
                temp = temp.getNext();
            }
            return count;
        }
    }

    partial class Stack
    {
        private Node head;
        private Node feet;
        private int count = 0;
        public Stack()
        {
            head = feet = null;
        }

        public void push(int data)
        {
            Node node = new Node(data);

            if (head == null)
                head = node;
            else
                feet.setNext(node);

            feet = node;
            count++;
        }

        public void pop()
        {
            Node temp = head;
            Node p = head.getNext();

            if (temp != null)
            {
                while (p != feet)
                {
                    if (p != null)
                    {
                        p = p.getNext();
                        temp = temp.getNext();
                    }
                    else
                        break;
                }

                feet = null;
                feet = temp;
                count--;
            }
        }

        public int peek()
        {
            int temp = 0;

            if (head != null)
            {
                Node p = feet;
                temp = p.getData();
            }

            return temp;
        }

        public bool isEmpty()
        {
            bool flag = false;

            if (count == 0)
                flag = true;

            return flag;
        }

        public String display()
        {
            String nodes = "";
            Node p = head;
            while (p != null)
            {
                nodes += p.getData() + " ";
                p = p.getNext();
            }

            return nodes;
        }

        public bool isVisited(int data)
        {
            bool flag = false;
            Node temp = head;

            while (temp != null)
            {
                if (data == temp.getData())
                {
                    flag = true;
                    break;
                }
                else
                    temp = temp.getNext();
            }

            return flag;
        }

        public int getCount()
        {
            int count = 0;
            Node temp = head;

            while (temp != null)
            {
                count++;
                temp = temp.getNext();
            }
            return count;
        }
    }

    partial class GreedyQueue
    {
        private GreedyNode front;
        private GreedyNode rear;
        public GreedyQueue()
        {
            front = rear = null;
        }

        public void enqueue(int data, double function)
        {
            GreedyNode node = new GreedyNode(data, function);

            if (front == null)
                front = node;

            else
                rear.setNext(node);

            rear = node;
        }

        public void dequeue()
        {

            if (front != null)
                front = front.getNext();

            else
                rear = null;
        }

        public int peek()
        {
            int temp = 0;
            if (front != null)
                temp = front.getData();

            return temp;
        }

        public String display()
        {
            String nodes = "";
            GreedyNode temp = front;
            while (temp != null)
            {
                nodes += temp.getData() + " ";
                temp = temp.getNext();
            }

            return nodes;
        }

        public bool isVisited(int data)
        {
            bool flag = false;
            GreedyNode temp = front;

            while (temp != null)
            {
                if (data == temp.getData())
                {
                    flag = true;
                    break;
                }
                else
                    temp = temp.getNext();
            }

            return flag;
        }

        public bool isEmpty()
        {
            return (front == null) ? true : false;
        }

        public int compare()
        {
            int node = 0;
            double heuristic = 0;
            if (front != null)
            {
                GreedyNode temp = front.getNext();

                heuristic = front.getFunction();
                node = front.getData();
                while (temp != null)
                {
                    if (temp.getFunction() < heuristic)
                    {
                        heuristic = temp.getFunction();
                        node = temp.getData();
                    }

                    temp = temp.getNext();
                }
            }
            return node;
        }
    }

    partial class AStarQueue
    {
        private AStarNode front;
        private AStarNode rear;
        public AStarQueue()
        {
            front = rear = null;
        }

        public void enqueue(int data, double heuristic, double function)
        {
            AStarNode node = new AStarNode(data, heuristic, function);

            if (front == null)
                front = node;

            else
                rear.setNext(node);

            rear = node;
        }

        public void dequeue()
        {

            if (front != null)
                front = front.getNext();

            else
                rear = null;
        }

        public int peek()
        {
            int temp = 0;
            if (front != null)
                temp = front.getData();

            return temp;
        }

        public String display()
        {
            String nodes = "";
            AStarNode temp = front;
            while (temp != null)
            {
                nodes += temp.getData() + " ";
                temp = temp.getNext();
            }

            return nodes;
        }

        public bool isVisited(int data)
        {
            bool flag = false;
            AStarNode temp = front;

            while (temp != null)
            {
                if (data == temp.getData())
                {
                    flag = true;
                    break;
                }
                else
                    temp = temp.getNext();
            }

            return flag;
        }

        public bool isEmpty()
        {
            return (front == null) ? true : false;
        }

        public int compare()
        {
            int node = 0;
            double function = 0;
            if (front != null)
            {
                AStarNode temp = front.getNext();

                function = front.getFunction();
                node = front.getData();
                while (temp != null)
                {
                    if (temp.getFunction() < function)
                    {
                        function = temp.getFunction();
                        node = temp.getData();
                    }

                    temp = temp.getNext();
                }
            }
            return node;
        }

        public double getHeuristic(int data)
        {
            double heuristic = 0;
            AStarNode temp = front;

            while (temp != null)
            {
                if (data == temp.getData())
                {
                    heuristic = temp.getHeuristic();
                    break;
                }
                else
                    temp = temp.getNext();
            }

            return heuristic;
        }
    }
}
