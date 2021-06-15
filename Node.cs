using System;
using System.Collections.Generic;
using System.Linq;
using SFML.Window;
using SFML.Graphics;
using SFML.System;

namespace SearchTree
{
    class Node
    {
        int? value;
        Node previous, left, right;

        public int? getValue
        {
            get { return value; }
        }

        public Node getPrevious
        {
            get { return previous; }
        }

        public Node getRight
        {
            get { return right; }
        }

        public Node getLeft
        {
            get { return left; }
        }

        public void setValue(int? val)
        {
            value = val;
        }

        public void setPrevious(Node nod)
        {
            previous = nod;
        }

        public void setRight(Node nod)
        {
            right = nod;
        }

        public void setLeft(Node nod)
        {
            left = nod;
        }
    }
}
