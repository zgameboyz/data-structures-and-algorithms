using System;
using System.Collections.Generic;

namespace DataStructures
{
  public class GraphMethods<T>
  {

  
  public class Vertex<T>
  {
    public T Value { get; set; }

    public Vertex(T value)
    {
      Value = value;
    }
  }

  public class Edge<T>  // Directed Edge
  {
    public int Weight { get; set; }
    public Vertex<T> Vertex { get; set; }

    public Edge(Vertex<T> vertex, int weight)
    {
      Vertex = vertex;
      Weight = weight;
    }
  }

  public class Graph<T>
  {
    private int _size;

    public Dictionary<Vertex<T>, List<Edge<T>>> AdjacencyLists { get; set; }

    public Graph()
    {
      AdjacencyLists = new Dictionary<Vertex<T>, List<Edge<T>>>();
      _size = 0;
    }

    public Vertex<T> AddNode(T value)
    {
      Vertex<T> Vertex = new(value);
      AdjacencyLists.Add(Vertex, new List<Edge<T>>());
      _size++;

      return Vertex;
    }

    // Add bidirectional edge
    public void AddEdge(Vertex<T> sourceVertex, Vertex<T> destVertex, int weight)
    {
      AddDirectionalEdge(sourceVertex, destVertex, weight);
      AddDirectionalEdge(destVertex, sourceVertex, weight);
    }

    public void AddDirectionalEdge(Vertex<T> sourceVertex, Vertex<T> destVertex, int weight)
    {
      List<Edge<T>> edges = AdjacencyLists[sourceVertex];
      edges.Add(
        new Edge<T>(destVertex, weight)
      );
    }

    public List<Vertex<T>> GetNodes()
    {
      
      List<Vertex<T>> allNodes = new List<Vertex<T>>();
      int i = 1;
        

          foreach (var key in AdjacencyLists.Keys)
          {
            Console.WriteLine($"Node {i} is {key.Value}");
            i++;
            allNodes.Add(key);
          }
        if (allNodes.Count <= 0) { return null; }
        else
          return allNodes;
        }
     
      public List<Vertex<T>> GetNeighbors(Vertex<T> vertex)  // for a particular node/vertex
    {
      var neighborAdjacencyList = AdjacencyLists[vertex];
      List<Vertex<T>> neighborList = new List<Vertex<T>>();

      foreach (Edge<T> edge in neighborAdjacencyList)
      {
        neighborList.Add(edge.Vertex);
      }

      return neighborList;
    }

    public int GetSize()
    {
      return _size;
    }

    public void Print()
    {
      foreach (var key in AdjacencyLists)
      {
        Console.Out.Write($"{key.Key.Value} -> ");

        var adjacencyList = AdjacencyLists[key.Key];

        foreach (Edge<T> edge in adjacencyList)
        {
          Console.Out.Write($"{edge.Vertex.Value}, {edge.Weight} -> ");
        }
        Console.Out.WriteLine("null");
      }
    }
  }
}
}
