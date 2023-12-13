using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListNode
{
    class ListImp
    {

        static void Main(String[] args) {

            //create link list
            MlinkList list1 = new MlinkList();
            MlinkList list2 = new MlinkList();
            MlinkList list3 = new MlinkList();
            //create nodes in linked list
            
            Node key = new Node(0); //T(1)
            list1.next = key; //T(1)
            
            for (int i = 10; i <= 12 ; i++) { //T(1)
                
                key  = key.enterNode(i,key);
                
            }
            
            Node key2 = new Node(0); //T(1)
            list2.next = key2; //T(1)
            
            for (int i = 6; i <= 10; i++) //T(1)
            {
                key2 = key2.enterNode(i, key2);
                
            }
                 
            key = key.sortedMerge(list1.next,list2.next); //T(1)
            
            
            Node tra; //T(1)
            tra = key.next;
            
            while (tra.next != null) { //T(1)

                tra = tra.next;
                Console.WriteLine(tra.data);
            }
            Console.ReadLine();
            //time complexity = T(1) because we are not taking any input 
             //space complexity = O(m) where m is length of input
        }
    }

}
