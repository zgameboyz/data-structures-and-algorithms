using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge08
{
  public class LinkedList
  {
    public Node Head { get; set; }

    public LinkedList()
    {
    }
    //This will print the node list
    public string Print()
    {
      Node current = Head;
      string nodeName = "";
      while (current != null)
      {
        nodeName = ($"({current.Value}) =>");
        Console.Write(nodeName);
        current = current.Next;

      }
      return nodeName;
    }
    //This will allow you to insert nodes 
    public void Insert(int value)
    {
      Node node = new Node(value);
      if (Head != null)
      {
        node.Next = Head;

      }
      Head = node;
    }
    public void Append(int value)
    {
      Node node = new Node(value);
      if (Head == null)
      {
        Head = node;
        return;
      }
      Node current = Head;
      while (current.Next != null)
      {
        current = current.Next;
      }
      current.Next = node;
    }

    public void InsertBefore(int value, int newValue)
    {
      Node node = new Node(newValue);
      Node current = Head;
      Node tempNode = current;
      while (current.Value != value)
      {
        if (current.Next.Value == value)
        {
          tempNode = current.Next;
          current.Next = node;
          node.Next = tempNode;
        }
        break;
      }
    }

    public void InsertAfter(int value, int newValue)
    {
      Node newNode = new Node(newValue);
      Node current = Head;
      Node tempNode = current;
      while (current != null)
      {
        if (current.Value == value)
        {

          tempNode = current.Next;
          current.Next = newNode;
          newNode.Next = tempNode;
          break;
        }
        current = current.Next;
      }
    }
    public int returnNodeValue(int k)
    {
      Node current = Head;
      int initialCount = 0;
      while (current != null)
      {
        current = current.Next;
        initialCount++;
      }
      int count = initialCount - k;
      Console.WriteLine(count);

      current = Head;
      Console.WriteLine(current.Value);
      if (k <= initialCount && k >= 0)
      {
        for (int i = 0; i < count - 1; i++)

        {
          current = current.Next;
        }
        Console.WriteLine(current.Value);
        return current.Value;
      }
      else
      {
        Console.WriteLine("that number is too big or less than zero");
        return 0;
      }
    }
    public LinkedList ZippedLinkedList(LinkedList LinkedList1, LinkedList LinkedList2)
    {

      LinkedList ZippedList = new LinkedList();
     
      Node newNode = LinkedList1.Head;
      Node newNode2 = LinkedList2.Head;
      

      //ZippedList.Head = newNode;
      //ZippedList.Head.Next = newNode2;
      //Node current = ZippedList.Head;


      while (newNode != null && newNode2 != null)
        {
        ZippedList.Append(newNode.Value);
        ZippedList.Append(newNode2.Value);

        newNode = newNode.Next;
        newNode2 = newNode2.Next;
        //current.Next = newNode.Next;
        //current = current.Next;
        //newNode = newNode.Next;
        //current.Next = newNode2.Next;
        //newNode = newNode2.Next;
        //current = current.Next;
      }
      Head = ZippedList.Head;


      return ZippedList;
    }

  }
}
