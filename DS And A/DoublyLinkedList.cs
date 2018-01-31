using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DS_And_A
{
    class DoublyLinkedList: LinkedList
    {
        private TwoWayNode _head;

        public new TwoWayNode Head { get => _head; set => _head = value; }

        public override void InsertAtHead(int Data)
        {
            TwoWayNode NewNode = new TwoWayNode(Data);
            NewNode.NextNode = this.Head; //On the first addition, this.head will be null, and this is how the last element's NextNode value ends up being null
            // NewNode.PreviousNode = this.Head; I think this is supposed to remain unassigned because it should point to null

            if (Head != null) //Must do null check because of list is empty head will be null
            {
                this.Head.PreviousNode = NewNode; //And then this won't execute (Nullpointer exception)
            }
            this.Head = NewNode;
        }
    }
}
