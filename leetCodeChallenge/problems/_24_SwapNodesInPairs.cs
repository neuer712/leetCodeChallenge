using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCodeChallenge.problems
{
    public class _24_SwapNodesInPairs
    {
        public ListNode SwapPairs(ListNode head)
        {
            ListNode before = new ListNode(val: 0, head);
            ListNode result = (head!=null && head.next!=null ? head.next : head);
            while(before != null && before.next!= null && before.next.next !=null) 
            {
                var pos1 = before.next;
                var pos2 = before.next.next;
                var tail = before.next.next.next;
                before.next = pos2;
                pos2.next = pos1;
                pos1.next = tail ;
                before = pos1;
            }

            return result;
        }
    }

    public class ListNode
    {
        public int val;
        public ListNode next;

        public ListNode(int val = 0, ListNode next = null)
        {
            this.val = val;
            this.next = next;
        }
    }
}
