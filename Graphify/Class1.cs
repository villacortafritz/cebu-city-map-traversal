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
    

   
}
