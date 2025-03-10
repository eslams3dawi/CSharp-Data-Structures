namespace Stack_LinkedList
{
    class Stack
    {
        class Node
        {
            public int Data;
            public Node Next;

            public Node(int Element)
            {
                Data = Element;
                Next = null;
            }
        }
        Node Top;
        public Stack()
        {
            Top = null;
        }
        public bool IsEmpty()
        {
            return Top == null;
        }
        public void Push(int Element)// 1 ← 2 ← 3(top) 
        {
            Node NewNode = new Node(Element);
            if (IsEmpty())
                Top = NewNode;
            else
            {
                NewNode.Next = Top;
                Top = NewNode;
            }
        }
        public void Pop()
        {
            if (IsEmpty())
                return;
            else
            {
                if(Top.Next == null) // 1(top)
                {
                    Top = null; //(top)
                }
                else
                {
                    Node Deleted = Top;
                    Top = Top.Next;
                    Deleted.Next = null;
                }
            }
        }
        public void Traverse()
        {
            Node Current = Top;
            while(Current != null)
            {
                Console.WriteLine(Current.Data);
                Current = Current.Next;
            }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {

            List<int> list = new List<int>();
            list.Add(1);
            Console.WriteLine(list.Capacity); // 4
            list.TrimExcess();
            Console.WriteLine(list.Capacity); // 1



            List<Employee> employees = new List<Employee>();

            employees.Add(new Employee(10, "Eslam", 2000));
            employees.Add(new Employee(10, "Ali", 9000));

            foreach (var employee in employees)
                Console.WriteLine(employee.Name);

            Dictionary<string, string> Dic = new Dictionary<string, string>();
            Dic.Add("A", "Ahmed");
            Dic.Add("B", "Basel");
            Console.WriteLine($"A letter is : {Dic["A"]}");



            Stack StackOne = new Stack();
            StackOne.Push(10);
            StackOne.Push(20);
            StackOne.Push(30);
            StackOne.Pop();
            StackOne.Traverse();
        }
    }
    class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Salary { get; set; }

        public Employee(int Id, string name, int salary)
        {
            this.Id = Id;
            this.Name = name;
            this.Salary = salary;
        }
    }
}
