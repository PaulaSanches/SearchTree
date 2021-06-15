using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using SFML.Window;
using SFML.Graphics;
using SFML.System;

namespace SearchTree
{
    class SearchTree
    {
        Node root = new Node();
        int quantity = 0;

        public Node Root
        {
            get { return root; }
        }
        
        public void Insert(int value)
        {
            Node newNode = new Node();
            newNode.setValue(value);
            if (Root.getPrevious == null && root.getValue == null)
            {
                root.setValue(value);
                root.setRight(null);
                root.setLeft(null);

            }

            else
            {
                Node aux = InsertionSearch(value);
                if (aux == null)
                {
                    Console.WriteLine("Value - " + value);

                }
                else
                {
                    if (value > aux.getValue)
                    {
                        aux.setRight(newNode);
                        newNode.setPrevious(aux);

                    }
                    else
                    {
                        aux.setLeft(newNode);
                        newNode.setPrevious(aux);

                    }
                }
            }
            quantity++;
        }
        public string Quantity
        {
            get { return quantity.ToString(); }

        }

        public Node InsertionSearch(int value)
            {
            Node nod;
            nod = Root;
            bool x = true;
            do
            {
                if (value < nod.getValue)
                {
                    if (nod.getLeft == null)
                    {
                        x = false;
                        return nod;

                    }

                    if (nod.getLeft != null)
                    {
                        nod = nod.getLeft;

                    }
                }

                if (value > nod.getValue)
                {
                    if (nod.getRight == null)
                    {
                        x = false;
                        return nod;

                    }

                    if (nod.getRight != null)
                        nod = nod.getRight;

                }

                if (value == nod.getValue)
                {
                    return null;

                }

            }
            while (x);
            return null;
        }

        public Node Search(Node nod, int value)
        {
            if (nod == null)
            {
                Console.WriteLine("Did not find! " + value.ToString());
                return null;
            }
            else
            {
                if (value == nod.getValue)
                {
                    Console.WriteLine("Found it! " + value.ToString());
                    return nod;
                }
                else if (value < nod.getValue)
                {
                    Search(nod.getLeft, value);
                }
                else
                {
                    Search(nod.getRight, value);
                }
            }
            return null;
        }
        public int Greater(int a, int b)
        {
            if (a > b)
            {
                return a;
            }
            else
            {
                return b;
            }
        }

        public int Height(Node nod)
        {
            if ((nod == null) || (nod.getLeft == null && nod.getRight == null))
            {
                return 0;
            }
            else
            {
                return 1 + (Greater(Height(nod.getLeft), Height(nod.getRight)));
            }
        }
        public void preOrder(Node nod)
        {
            if (nod != null)
            {
                Console.Write(nod.getValue + " ");
                preOrder(nod.getLeft);
                preOrder(nod.getRight);
            }

        }

        public void inOrder(Node nod)
        {
            if (nod != null)
            {
                inOrder(nod.getLeft);
                Console.Write(nod.getValue + " ");
                inOrder(nod.getRight);

            }
        }

        public void postOrder(Node nod)
        {
            if ( nod != null)
            {
                inOrder(nod.getLeft);
                inOrder(nod.getRight);
                Console.Write(nod.getValue + " ");

            }
        }

        public void Padding(string pad, int times)
        {
            for (int i=0; i< times; i++)
            {
                Console.Write(pad);
            }
        }

        public void print(Node nod, int level)
        {
            int i;

            if (nod == null)
            {
                Padding(" ", level);
                Console.WriteLine(" ");

            }
            else
            {
                print(nod.getRight, level + 1);
                Padding(" ", level);
                Console.WriteLine(nod.getValue);
                print(nod.getLeft, level + 1);
            }
        }

    }
}
