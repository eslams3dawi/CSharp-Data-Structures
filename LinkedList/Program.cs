//tail != null // will exit from LinkedList _ used when traversing
//tail.Next != null // reach tail 
//PreviousOfTail.Next.Next != null

namespace LinkedList
{
    class LinkedList
    {
        class Node
        {
            public object Data;
            public Node? Next;

            public Node(object Element)
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

        public void InsertFirst(object Element)
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
        public void InsertLast(object Element)
        {
            Node NewNode = new Node(Element);
            if (Head == null)
                Head = NewNode;
            else 
            {
                Node Tail = Head;
                while(Tail.Next != null)
                {
                    Tail = Tail.Next;
                }
                Tail.Next = NewNode;
                Tail = NewNode;
            }
        }
        public void InsertAtPosition(object PositionValue, object Element)
        {
            Node NewNode = new Node(Element);
            if (Head == null)
            {
                Head = NewNode;
            }
            else if (PositionValue == Head.Data)
            {
                InsertFirst(Element);
            }
            else 
            {
                Node PreviousOfTargetPosition = Head;
                while(PreviousOfTargetPosition != null && PreviousOfTargetPosition.Next.Data != PositionValue)
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
                while(PreviousOfTail.Next.Next != null)
                {
                    PreviousOfTail = PreviousOfTail.Next;
                }
                PreviousOfTail.Next = null;
            }
        }
        public void DeleteAtPosition(object WantedValue)
        {
            if (Head == null)
                Console.WriteLine("Linked list is already empty");
            else
            {
                if (Head.Next == null)
                    DeleteFirst();

                else if(WantedValue == Head.Data)
                    DeleteFirst();

                else
                {
                    Node PreviousOfDeleted = Head;
                    Node DeletedValue = Head.Next;
                    while(DeletedValue.Data != WantedValue)
                    {
                        PreviousOfDeleted = DeletedValue;
                        DeletedValue = DeletedValue.Next;
                    }
                    PreviousOfDeleted.Next = DeletedValue.Next;
                    DeletedValue.Next = null;
                }
            }
        }
        public bool Search(object TargetElement)
        {
            if (Head == null)
                Console.WriteLine("Linked list is already empty");
            else
            {
                Node Current = Head;
                while (Current != null)
                {
                    if (Current.Data == TargetElement)
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
                while(Current != null)
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
            LinkedList ListOne = new LinkedList();
            ListOne.InsertFirst(10);
            ListOne.InsertFirst("Eslam");
            ListOne.InsertAtPosition(10, 50);
            ListOne.InsertLast(70);
            ListOne.DeleteLast();
            ListOne.DeleteAtPosition(10);
            Console.WriteLine(ListOne.Search(10));//false
            Console.WriteLine(ListOne.Search(50));//true
            ListOne.DeleteFirst();
            ListOne.Traverse();
        }
    }
}
