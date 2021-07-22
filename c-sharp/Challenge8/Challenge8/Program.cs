using System;

namespace Challenge08
{
  class Program
  {
    static void Main(string[] args)
    {
     

      LinkedList OurList1 = new LinkedList { };
      OurList1.Append(2);
      OurList1.Append(7);
      OurList1.Append(9);
      OurList1.Append(3);



      LinkedList OurList2 = new LinkedList { };
      OurList2.Append(1);
      OurList2.Append(6);
      OurList2.Append(7);
      OurList2.Append(5);

      LinkedList TheZippedOne = new LinkedList { };
      TheZippedOne.ZippedLinkedList(OurList1, OurList2);
      TheZippedOne.Print();

      }
    }
  }


