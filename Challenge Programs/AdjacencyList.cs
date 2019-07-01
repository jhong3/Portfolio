using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdjacencyList
{
    class Program
    {
        static void Main(string[] args)
        {
            Graph myGraph = new Graph();
            myGraph.AddVertex("CSC180");
            myGraph.AddVertex("CSC101");
            myGraph.AddVertex("MTA");
            myGraph.AddVertex("CSC200");
            myGraph.AddVertex("CSC395");
            myGraph.AddVertex("CSC300");
            myGraph.AddVertex("independent study");
            myGraph.AddVertex("independent study part 2");

            myGraph.AddEdge("MTA", "CSC101");
            myGraph.AddEdge("CSC180", "CSC200");
            myGraph.AddEdge("CSC180", "CSC395");
            myGraph.AddEdge("CSC200", "CSC300");
            myGraph.AddEdge("MTA", "CSC180");

            myGraph.AddEdge("independent study", "independent study part 2");
            

            //creating a cycle
            myGraph.AddEdge("CSC395", "CSC101");
            myGraph.AddEdge("CSC101", "MTA");

            //myGraph.RemoveEdge("MTA", "CSC180"); // remove edge
            //myGraph.RemoveVertex("MTA"); // remove vertex

            myGraph.printAdjacencyList();
            //myGraph.PrintVertices();

            //myGraph.PrintTopologicalSorting();

            //myGraph.BreadthFirstSearchAllComponents();
        }
    }

    // Adjacency List using a Linked List
    public class Graph
    {
        class VertexNode
        {
            public string Label { get; set; }
            public VertexNode nextVertex;
            public EdgeNode firstEdge;
            public VertexNode(string newLbl)
            {
                Label = newLbl;                
            }
        }

        // Node to use to connect edges
        class EdgeNode
        {
            public VertexNode endVertex;
            public EdgeNode nextEdge;

            public EdgeNode(VertexNode vertex)
            {
                endVertex = vertex;
            }
        }

        //data
        // Point the vertex node to start
        VertexNode start;

        //add vertex
        public void AddVertex(string newLabel)
        {
            // create temporary node with the input
            // newLabel value
            VertexNode temp = new VertexNode(newLabel);
            
            // If there are no vertices, reference start to temp
            if (start == null) 
                start = temp;

            // Reference current to the last node temp.
            else
            {
                VertexNode current = start;
                while(current.nextVertex != null)
                {
                    if (current.Label.Equals(newLabel))
                    {
                        Console.WriteLine("Already exists!");
                    }
                    // move current to next vertex while the value is not null
                    // and doesn't already exist
                    current = current.nextVertex;
                }
                if (current.Label.Equals(newLabel))
                {
                    Console.WriteLine("Already exists!");
                    return;
                }

                current.nextVertex = temp;
            }

        }
                
        private VertexNode FindVertex(string newLabel)
        {
            // point current node to start and move right
            VertexNode current = start;
            while (current != null)
            {
                // If found, return current
                if (current.Label.Equals(newLabel))
                {
                    return current;
                }
                // keep moving while the conditions are true
                current = current.nextVertex;
            }
            return null;
        }

        //add edge
        public void AddEdge(string A, string B) //adds an edge between A and B
        {
            // Cases where node is trying to connect to itself
            if (A.Equals(B))
            {
                Console.WriteLine("Can't connect to itself!");
                return;
            }

            // Create two nodes each holding the first and second
            // vertex labels
            VertexNode node1 = FindVertex(A);
            VertexNode node2 = FindVertex(B);

            if (node1 == null)
            {
                Console.WriteLine("First vertex doesn't exist!");
            }

            if (node2 == null)
            {
                Console.WriteLine("Second vertex doesn't exist!");
            }

            EdgeNode temp = new EdgeNode(node2);
            if (node1.firstEdge == null)
            {
                node1.firstEdge = temp;
  
            }
            else
            {
                EdgeNode current = node1.firstEdge;
                while (current.nextEdge != null)
                {
                    if (current.endVertex.Label.Equals(B))
                    {
                        Console.WriteLine("Edge exists!");
                    }
                    current = current.nextEdge;
                }
                if (current.endVertex.Label.Equals(B))
                {
                    Console.WriteLine("Edge exists!");
                    return;
                }
                current.nextEdge = temp;

            }

        }


        //print vertices
        public void PrintVertices()
        {
            Console.WriteLine("Printing the vertices ...");
            
            // Writes out every node that meets the condition statement
            for (VertexNode current = start; current != null; current = current.nextVertex)
            {
                Console.WriteLine(current.Label);
            }

        }

        //print adjacency list
        public void printAdjacencyList()
        {
            // Node pointer for nodes that are connected through edges
            EdgeNode node;
            Console.WriteLine("Printing adjacency list ...");

            // Print out every unique vertices/nodes
            for (VertexNode current = start; current != null; current = current.nextVertex)
            {
                Console.Write(current.Label + " ->");

                // Print nodes that are connected through edges
                for (node = current.firstEdge; node != null; node = node.nextEdge)
                    Console.Write(" " + node.endVertex.Label + "->");
                Console.WriteLine();
            }
        }

        //remove edge
        public void RemoveEdge(string A, string B)
        {
            // Assign node to current variable by using
            // the FindVertex method
            VertexNode current = FindVertex(A);

            // If there is no start vertex
            if (current == null)
            {
                Console.WriteLine("There is no starting vertex!");
                return;
            }

            // If the edge is empty...
            if (current.firstEdge == null)
            {
                Console.WriteLine("Edge doesn't exist!");
                return;
            }

            if (current.firstEdge.endVertex.Label.Equals(B))
            {
                // if the edge that's going to be deleted is pointing to
                // current, then delete
                current.firstEdge = current.firstEdge.nextEdge;
                return;
            }

            // Delete using edge node
            EdgeNode deleteMe = current.firstEdge;
            while (deleteMe.nextEdge != null)
            {
                if (deleteMe.nextEdge.endVertex.Label.Equals(B))
                {
                    deleteMe.nextEdge = deleteMe.nextEdge.nextEdge;
                    return;
                }
                deleteMe = deleteMe.nextEdge;
            }
            // When edge does not exist
            Console.WriteLine("No edges!");
        }

        // Remove vertex
        public void RemoveVertex(string labelA)
        {
            if (start == null)
            {
                Console.WriteLine("Nothing to delete!");
                return;
            }
            // Vertex that's going to be deleted is first
            if (start.Label.Equals(labelA))
            {
                start = start.nextVertex;
            }
            // If vertex that's going to be deleted is in between or
            // at the end of the list
            else
            {
                VertexNode current = start;
                while (current.nextVertex != null)
                {
                    if (current.nextVertex.Label.Equals(labelA))
                        break;
                    current = current.nextVertex;
                }

                if (current.nextVertex == null)
                {
                    Console.WriteLine("Can't find the vertex!");
                    return;
                }

                // Current is referencing the previous node that's going to be deleted
                else
                {
                    current.nextVertex = current.nextVertex.nextVertex;
                }
            }
            
        }


        public void PrintTopologicalSorting()
        {
            // Reverse the vertices printed using stacks
            Console.WriteLine();

            Stack<string> myStack = new Stack<string>();

            for (VertexNode current = start; current != null; current = current.nextVertex)
            {
                myStack.Push(current.Label);
            }

            while (myStack.Count > 0)
                Console.WriteLine(myStack.Pop());
        }


        //ctor
        public Graph()
        {
   
        }

    }
}
