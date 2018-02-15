using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DS_And_A
{
    class Stack
    {
        private LinkedList List;


        public Stack()
        {
            this.List = new LinkedList();
        }

        public int Pop()
        {
            int value = this.List.Head.Data;
            this.List.DeleteFromHead();
            return value;
        }

        public void Push(int value)
        {            
            this.List.InsertAtHead(value);
        }
        public int Peek()
        {
            return this.List.Head.Data;
        }


    }
}
