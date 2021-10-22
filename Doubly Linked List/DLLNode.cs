using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Doubly_Linked_List
{
    public class DLLNode
    {
        public int num;
        public DLLNode prev;
        public DLLNode next;

        public DLLNode(int num)
        {
            next = null;
            prev = null;
            this.num = num;
        }
    }
}
