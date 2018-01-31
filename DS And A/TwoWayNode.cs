using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DS_And_A
{
    class TwoWayNode : Node 
    {
        private TwoWayNode _nextNode;
        private TwoWayNode __previousNode;

        public TwoWayNode PreviousNode { get => __previousNode; set => __previousNode = value; }
        public new TwoWayNode NextNode { get => _nextNode; set => _nextNode = value; }

        public TwoWayNode(int Data) : base(Data) { } //Constructor

        
    }
}
