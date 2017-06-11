using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DFS
{
    class DepthFirstSearch
    {
        private HashSet<Node> visited;
        private LinkedList<Node> path;
        private Node goal;
        private bool limitWasReached;
        public int Sum = 0;

        public LinkedList<Node> Search(Node start, Node goal, int limit)
        {
            visited = new HashSet<Node>();
            path = new LinkedList<Node>();
            limitWasReached = true;
            this.goal = goal;
            Search(start, limit);
            if (path.Count > 0)
            {
                path.AddFirst(start);
            }
            return path;
        }

        private bool Search(Node node, int limit)
        {
            if (node == goal)
            {
                return true;
            }
            if (limit == 0)
            {
                limitWasReached = false;
                return false;
            }
            visited.Add(node);
            foreach (var child in node.Children.Where(x => !visited.Contains(x)))
            {
                Sum += child.Distance;
                if (Search(child, limit - 1))
                {
                    path.AddFirst(child);
                    return true;
                }
            }
            return false;
        }
        public void PrintSum()
        {
            Console.WriteLine(Sum);
        }
     }

        class Program
        {
            static void Main(string[] args)
            {
                var Kyiv = new Node("Kyiv");
                var Zhytomyr = new Node("Zhytomyr");
                var NovVolynsky = new Node("Novograd - Volynsky");
                var Rovno = new Node("Rovno");
                var Berdichev = new Node("Berdichev");
                var Vinnica = new Node("Vinnica");
                var Khmel = new Node("Khmelnycky");
                var Ternopil = new Node("Ternopil");
                var Shepetovka = new Node("Shepetopka");
                var Uman = new Node("Uman");
                var BCerkva = new Node("Bila Cerkva");
                var Chercassi = new Node("Cherkassi");
                var Kremen = new Node("Kremenchuk");
                var Poltava = new Node("Poltava");
                var Kharkov = new Node("Kharkov");
                var Priluki = new Node("Priluki");
                var Sumi = new Node("Sumi");
                var Mirgorod = new Node("Mirgorod");
                var Lutsk = new Node("Lutsk");

                Kyiv.AddChildren(Zhytomyr, 135).AddChildren(BCerkva, 78).AddChildren(Priluki, 128);
                Zhytomyr.AddChildren(NovVolynsky, 80).AddChildren(Berdichev, 38).AddChildren(Shepetovka, 115);
                BCerkva.AddChildren(Uman, 115).AddChildren(Chercassi, 146).AddChildren(Poltava, 181);
                Priluki.AddChildren(Sumi, 175).AddChildren(Mirgorod, 109);
                NovVolynsky.AddChildren(Rovno, 100);
                Rovno.AddChildren(Lutsk, 68);
                Berdichev.AddChildren(Vinnica, 73);
                Vinnica.AddChildren(Khmel, 110);
                Khmel.AddChildren(Ternopil, 104);
                Chercassi.AddChildren(Kremen, 105);
                Poltava.AddChildren(Kharkov, 130);


                var search = new DepthFirstSearch();
                var path = search.Search(Kyiv, Lutsk, 10);
                search.PrintSum();
                PrintPath(path);
            }

            private static void PrintPath(LinkedList<Node> path)
            {
                Console.WriteLine();
                if (path.Count == 0)
                {
                    Console.WriteLine("You shall not pass!");
                }
                else
                {
                    Console.WriteLine(string.Join(" -> ", path.Select(x => x.Name)));
                }
                Console.Read();
            }
        }

        class Node
        {
            public string Name { get; }
            public List<Node> Children { get; }
            public int Distance { get; set; }

            public Node(string name)
            {
                Name = name;
                Children = new List<Node>();
            }

            public Node AddChildren(Node node,int distance, bool bidirect = true)
            {
                Children.Add(node);
                Distance = distance;
                if (bidirect)
                {
                    node.Children.Add(this);
                }
                return this;
            }
        }
    }

