using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DS_And_A
{
    class Node
    {
        private int _data;
        private Node _nextNode;

        public int Data { get => _data; set => _data = value; }
        public Node NextNode { get => _nextNode; set => _nextNode = value; }

        public Node(int Data)
        {
            this.Data = Data;
        }
        public override string ToString()
        {
            return "Data: " + this.Data;
        }
    }
}
