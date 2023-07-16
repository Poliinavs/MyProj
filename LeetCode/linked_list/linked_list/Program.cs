using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
  public class ListNode
    {
     public int val;
      public ListNode next;
      public  ListNode head; // головной/первый элемент
        ListNode? tail; // последний/хвостовой элемент
       public static int count;  // количество элементов в списке
                    // добавление элемента
        public void Add(int val)
        {
            ListNode node = new ListNode(val);

            if (head == null)
                head = node;
            else
                tail.next = node;
            tail = node;

            count++;
        }
        public void Remove()
        {

        }


        public ListNode(int val = 0, ListNode next = null)
        {
           this.val = val;
           this.next = next;
                 }
 }

    class Program
    {
        public ListNode RemoveNthFromEnd(ListNode head, int n)
        {


            ListNode? current = head;
            ListNode? previous = null;
            int a = 0;

            while (current != null && a != ListNode.count-n)
            {
                a++;
                previous= current;
                current = current.next;
            }
            previous.next = current.next;


            return head;
                    
            

            /*   var elem = head;
               int amount = 1;
              for(int i=0; i< ListNode.count - n; i++)
               {
                   elem = elem.next;
               }
               Console.WriteLine("numer del" + elem.val);





               return elem;*/
        }
        static void Main(string[] args)
        {

            int[] head = { 1, 2, 3, 4, 5 };
            int n = 2;
          ListNode list = new ListNode();
            list.Add(1);
            list.Add(2);
            list.Add(3);
            list.Add(4);
            list.Add(5);
            var elem = list.head;
            while (elem != null)
            {
                Console.WriteLine(elem.val);
                elem = elem.next;
            }
            Program pr = new Program();
           ListNode lst= pr.RemoveNthFromEnd(list.head, n);
            elem = list.head;
            while (elem != null)
            {
                Console.WriteLine(elem.val);
                elem = elem.next;
            }





        }
    }
}