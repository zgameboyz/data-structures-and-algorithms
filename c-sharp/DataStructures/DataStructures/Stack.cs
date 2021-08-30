namespace DataStructures
{
  public class Stack<T>
    {
        public Node<T> Top { get; set; }

        //Pushes to the top of the stack
        public void Push(T value)
        {
            Node<T> node = new Node<T>(value);
            node.Next = Top;
            Top = node;
        }

        //removes the node from the top of the stack
        public Node<T> Pop()
        {
            Node<T> currentTop = Top;

            Top = currentTop.Next;

            return currentTop;
        }

        //Checks the top of the stack
        public bool Peek()
        {
            return Top != null;
        }

        //Checks is the stack is empty
        public bool IsEmpty()
        {
            if (Top == null)
            {
                return true;
            }
            return false;
        }

        public int openingCount1 = 0;
        public int openingCount2 = 0;
        public int openingCount3 = 0;

        public const string openingBrackets1 = "[";
        public const string openingBrackets2 = "{";
        public const string openingBrackets3 = "(";
        public const string closingBrackets1 = "]";
        public const string closingBrackets2 = "}";
        public const string closingBrackets3 = ")";

        public void IsBalanced(T f)
        {
            Node<T> node = new Node<T>(f);

            while (!Top.Equals(openingBrackets1) || !Top.Equals(openingBrackets2) || !Top.Equals(openingBrackets3))
            {
                Top = Top.Next;
            }
        }
    }
}
