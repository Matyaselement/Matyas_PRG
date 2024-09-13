using System;

namespace GraphPlayground
{
    internal class Program
    {
        public static void DFS(Graph graph, Node startNode, Node targetNode = null)
        {
            Node currentNode = startNode;
            startNode.visited = true;
            Console.WriteLine("Začínám v uzlu " + startNode.index);
            while (true)
            {
                Console.WriteLine("Aktuálně jsem v uzlu " + currentNode.index);
                //pokud current Node - cíl
                //NEBO
                //Pokud je current Node start a všichni neighbours jsou visited
                bool haveNeiToVisit = false;
                foreach (Node neighbour in currentNode.neighbors)
                {
                    if (!neighbour.visited)
                    {
                        haveNeiToVisit = true;
                        break;
                    }
                }

                if (!haveNeiToVisit)
                {
                    //pokud current Node - cíl
                    //NEBO
                    //Pokud je current Node start a všichni neighbours jsou visited
                    if (currentNode == startNode)
                    {
                        Console.WriteLine("Jsem ve startovní uzlu a nemám kam jít, ukončuji DFS");
                        return;
                    }
                    //jsem někde v grafu ve slepé uličce
                    else
                    {
                        Console.WriteLine("Jsem ve slepé uličce, vracím se do uzlu " + currentNode.cameFrom.index);
                        currentNode = currentNode.cameFrom;
                        continue;
                    }
                }
                else
                {

                }
            }
        }

        public static void BFS(Graph graph, Node startNode, Node targetNode = null) 
        {
            
        }

        static void Main(string[] args)
        {
            //Create and print the graph
            Graph graph = new Graph();
            graph.PrintGraph();
            graph.PrintGraphForVisualization();

            //Call both algorithms with a random starting node
            Random rng = new Random();
            DFS(graph, graph.nodes[rng.Next(0, graph.nodes.Count)]);
            BFS(graph, graph.nodes[rng.Next(0, graph.nodes.Count)]);

            Console.ReadKey();
        }
    }
}
