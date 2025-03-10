namespace LinkedList
{
    class LinkedList<T>
    {
        class Node
        {
            public T Data;
            public Node? Next;

            public Node(T Element)
            {
                Data = Element;
                Next = null;
            }
        }
        private Node? Head;

        public LinkedList()
        {
            Head = null;
        }
        public void InsertFirst(T Element)
        {
            Node NewNode = new Node(Element);
            if (Head == null)
                Head = NewNode;
            else
            {
                NewNode.Next = Head;
                Head = NewNode;
            }
        }
        public void InsertLast(T Element)
        {
            Node NewNode = new Node(Element);
            if (Head == null)
                Head = NewNode;
            else 
            {
                Node Tail = Head;
                while (Tail.Next != null)
                {
                    Tail = Tail.Next;
                }
                Tail.Next = NewNode;
                Tail = NewNode;
            }
        }
        public void InsertAtPosition(T PositionValue, T Element)
        {
            Node NewNode = new Node(Element);
            if (Head == null)
            {
                Head = NewNode;
            }
            else if (Head.Data.Equals(PositionValue))
            {
                InsertFirst(Element);
            }
            else             {
                Node PreviousOfTargetPosition = Head;
                while (PreviousOfTargetPosition != null && PreviousOfTargetPosition.Next.Data!.Equals(PositionValue))
                {
                    PreviousOfTargetPosition = PreviousOfTargetPosition.Next;
                }
                NewNode.Next = PreviousOfTargetPosition.Next;
                PreviousOfTargetPosition.Next = NewNode;
            }
        }
        public void DeleteFirst()
        {
            if (Head == null)
                Console.WriteLine("Linked list is already empty");
            else
            {
                Node DeletedTemp = Head;
                Head = Head.Next;
                DeletedTemp.Next = null;
            }
        }
        public void DeleteLast() 
        {
            if (Head == null)
                Console.WriteLine("Linked list is already empty");
            else
            {
                Node PreviousOfTail = Head;
                while (PreviousOfTail.Next.Next != null)
                {
                    PreviousOfTail = PreviousOfTail.Next;
                }
                PreviousOfTail.Next = null;
            }
        }
        public void DeleteAtPosition(T WantedValue)
        {
            if (Head == null)
                Console.WriteLine("Linked list is already empty");
            else
            {
                if (Head.Next == null)
                    DeleteFirst();

                else if (Head.Data.Equals(WantedValue))
                    DeleteFirst();

                else
                {
                    Node PreviousOfDeleted = Head;
                    Node DeletedValue = Head.Next; 
                    while (DeletedValue != null && !DeletedValue.Data.Equals(WantedValue))
                    {
                        PreviousOfDeleted = DeletedValue;
                        DeletedValue = DeletedValue.Next;
                    }
                    PreviousOfDeleted.Next = DeletedValue.Next;
                    DeletedValue.Next = null;
                }
            }
        }
        public bool Search(T TargetElement)
        {
            if (Head == null)
                Console.WriteLine("Linked list is already empty");
            else
            {
                Node Current = Head;
                while (Current != null)
                {
                    if (Current.Data.Equals(TargetElement))
                        return true;
                    Current = Current.Next;
                }
            }
            return false;
        }
        public void Traverse()
        {
            if (Head == null)
                return;
            else
            {
                Node Current = Head;
                while (Current != null)
                {
                    Console.Write($"{Current.Data} ");
                    Current = Current.Next;
                }
            }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            LinkedList<int> ListOne = new LinkedList<int>();
            ListOne.InsertFirst(10);
            ListOne.InsertAtPosition(10, 50);
            ListOne.InsertLast(70);
            ListOne.DeleteLast();
            ListOne.DeleteAtPosition(10);
            Console.WriteLine(ListOne.Search(10));
            Console.WriteLine(ListOne.Search(50));
            ListOne.DeleteFirst();
            ListOne.Traverse();
        }
    }
}
