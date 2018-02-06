using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DS_And_A
{
    class DoublyLinkedList : LinkedList
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
        public void InsertNodeAtHead(TwoWayNode NewNode)
        {
            NewNode.NextNode = this.Head;
            this.Head.PreviousNode = NewNode;
        }
        public void InsertionSortDList()

        {

            TwoWayNode current = this.Head.NextNode;
            
            TwoWayNode searchPointer = current.PreviousNode;

            for (int i = 0; i < this.Length() - 1; i++)
            {
                try
                {
                    while (current.Data < searchPointer.Data)
                    {
                        searchPointer = searchPointer.PreviousNode;
                    }
                } catch (NullReferenceException e)
                {
                    this.InsertNodeAtHead(current);
                    current = current.NextNode;
                    

                }
                
                //Before we move the node, we need to store our position
                TwoWayNode nodeToMove = current;
                //Move the current pointer to the next node to pick up on it on the next iteration
                current = current.NextNode;
                //this removes the current element from its unsorted place in the list by linking its previous and next elements together
                nodeToMove.PreviousNode.NextNode = nodeToMove.NextNode;
                nodeToMove.NextNode.PreviousNode = nodeToMove.PreviousNode;

                //This places the element in its sorted position
                nodeToMove.NextNode = searchPointer;
                nodeToMove.PreviousNode = searchPointer.PreviousNode;
                searchPointer.PreviousNode = nodeToMove;


                


            }
        }

    }
}
