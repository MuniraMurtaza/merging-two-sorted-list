using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListNode
{
    public class Node
    {
        public int data;
        public Node next;
        public Node head;
        //create a link list empty
        public Node(int data)
        {
            this.data = data; //O(1)
            this.next = null;  //O(1)      
        }
        public Node enterNode( int data, Node start)
        { 
        Node node = new Node(data); //O(1)
        start.next = node;   // O(1) Node is created and data is stored in it
                                // now the start node points to the node 
                                //it will act as a next node
        return node;
        }
       public  Node sortedMerge(Node key, Node key2)
        {
            Node result = null ;
            /* Base cases */
            if (key == null)
                return key2;
            if (key2 == null)
                return key;
            
        /* Pick either key or key2, and recur */
            if (key.data <= key2.data)
            {
                result =key;
                result.next = sortedMerge(key.next, key2);
            }
            else
            {
                result = key2;
                result.next = sortedMerge(key, key2.next);
            }
            return result;
        }
    }
}
