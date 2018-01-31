using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DS_And_A
{
    class LinkedList
    {
        private Node _head;

        public Node Head { get => _head; set => _head = value; }

        public virtual void InsertAtHead(int Data) //Marked virtual so that it can be overridden
        {
            Node NewNode = new Node(Data);
            NewNode.NextNode = this.Head; //On the first addition, this.head will be null, and this is how the last element's NextNode value ends up being null
            this.Head = NewNode;
        }
        public Node InsertByValue(int Data)
        {
            Node current = this.Head;
            Node NewNode = new Node(Data);

            while(current.NextNode != null)
            {

                if (Data < current.NextNode.Data)
                {
                    NewNode.NextNode = current.NextNode;
                    current.NextNode = NewNode;
                    return NewNode;
                }
                current = current.NextNode;
            }
            current.NextNode = NewNode;
            return NewNode;
        }
        public void DeleteFromHead()
        {
            Head = this.Head.NextNode;
        }
        public Node SearchList(String Query)
        {
            Node current = this.Head;

            while(current != null)
            {
                if(current.Data.ToString() == Query)
                {
                    return current;
                }
                current = current.NextNode;
            }
            return null;

        }
        public override string ToString()
        {
            String Result = "{";
            Node current = this.Head;

            while (current != null)
            {
                Result += current.ToString() + ",";
                current = current.NextNode;
            }
            Result += "}";
            return Result;
        }
        public int Length()
        {
            int length = 0;
            Node Current = this.Head;

            while(Current != null)
            {
                length++;
                Current = Current.NextNode;
            }
            return length;
        }
    }
}
