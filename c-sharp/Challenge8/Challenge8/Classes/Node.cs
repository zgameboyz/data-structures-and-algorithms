using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge08
{
  public class Node
  {
    public int Value { get; set; }

    public Node Next { get; set; }
    public object Head { get; internal set; }

    public Node(int value)
    {
      Value = value;
    }
  }
}
