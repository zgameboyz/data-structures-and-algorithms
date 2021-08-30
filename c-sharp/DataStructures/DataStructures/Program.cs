

namespace DataStructures
{
  internal class Program : GraphMethods<string>
  {
    private static void Main(string[] args)
    {
      GraphCoolness();
    }

    private static void GraphCoolness()
    {
      Graph<string> graph = new Graph<string>();

      var aNode = graph.AddNode("A");
      var bNode = graph.AddNode("B");
      var cNode = graph.AddNode("C");
      var dNode = graph.AddNode("D");
      var eNode = graph.AddNode("E");
      

      graph.AddEdge(aNode, bNode, 2);
      graph.AddEdge(aNode, cNode, 4);
      graph.AddEdge(bNode, cNode, 5);
      graph.AddEdge(dNode, eNode, 8);
      graph.AddEdge(aNode, eNode, 3);

      graph.GetNodes();
    }
  }
}
