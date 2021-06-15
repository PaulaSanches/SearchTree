using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using SFML.Window;
using SFML.Graphics;
using SFML.System;


namespace SearchTree
{
    class Program
    {

        static void Main(string[] args)
        {
            SearchTree tree = new SearchTree();
            Random rand = new Random();

            tree.Insert(30);
            tree.Insert(40);
            tree.Insert(20);
            tree.Insert(25);
            tree.Insert(22);
            tree.Insert(24);
            tree.Insert(45);
            tree.Insert(35);
            tree.Insert(90);
            tree.Insert(70);
            tree.Insert(7);
            tree.Insert(1);
            tree.Insert(0);
            tree.Insert(9);
            tree.Insert(2);
            tree.Insert(72);
            tree.Insert(67);
            tree.Insert(42);
            tree.Insert(12);
            tree.Insert(97);
            tree.Insert(99);
            tree.Insert(56);
            tree.Insert(23);
            tree.Insert(33);
            tree.Insert(44);
            tree.Insert(10);
            tree.Insert(6);
            tree.Insert(98);
            tree.Insert(17);
            tree.Insert(21);
            Console.WriteLine(tree.Quantity);
            //Console.ReadLine();
            Test();
            Initialize();


            static void Test()
            {
                SearchTree tree = new SearchTree();
                int opc = 0;

                do
                {
                    Console.WriteLine(" Menu \n");
                    Console.WriteLine("1- Insert a number in the Tree");
                    Console.WriteLine("2- Search value in the Tree");
                    Console.WriteLine("3- PreOrder Tree");
                    Console.WriteLine("4- InOrder Tree");
                    Console.WriteLine("5- PostOrder Tree");
                    Console.WriteLine("6- Height of the Tree");
                    Console.WriteLine("7- Print the Tree");
                    opc = Convert.ToInt32(Console.ReadLine());
                    Console.Clear();
                    switch (opc)
                    {
                        case 1:
                            Console.WriteLine("Insert as value");
                            int val = Convert.ToInt32(Console.ReadLine());
                            tree.Insert(val);
                            //Console.ReadKey();
                            Console.Clear();
                            break;

                        case 2:
                            Console.WriteLine("Which value to search:");
                            val = Convert.ToInt32(Console.ReadLine());
                            tree.Search(tree.Root, val);
                            Console.ReadKey();
                            Console.Clear();
                            break;

                        case 3:
                            Console.WriteLine("PreOrder Tree");
                            tree.preOrder(tree.Root);
                            Console.ReadKey();
                            Console.Clear();
                            break;

                        case 4:
                            Console.WriteLine("InOrder Tree");
                            tree.inOrder(tree.Root);
                            Console.ReadKey();
                            Console.Clear();
                            break;

                        case 5:
                            Console.WriteLine("PostOrder Tree");
                            tree.postOrder(tree.Root); 
                            Console.ReadKey();
                            Console.Clear();
                            break;

                        case 6:
                            Console.WriteLine("Height of the Tree:" + tree.Height(tree.Root));
                            Console.ReadKey();
                            Console.Clear();
                            break;

                        case 7:
                            tree.print(tree.Root, 0);
                            Console.ReadKey();
                            Console.Clear();
                            break;

                    }

                } while (opc != 7);

            }

        }

        static void Initialize()
            //in progress
        {
            RenderWindow window = new RenderWindow(new VideoMode(200, 200), "test");
            CircleShape cs = new CircleShape(100.0f);
             cs.FillColor = Color.Yellow;
             window.SetActive();
             while (window.IsOpen)
             {
                 window.Clear();
                 window.DispatchEvents();
                 window.Draw(cs);
                 window.Display();
             }
            
        }

    }

}
    

