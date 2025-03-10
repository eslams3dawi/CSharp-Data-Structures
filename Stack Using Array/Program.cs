using System.Diagnostics;
namespace Stack__Array
{
    class Stack
    {
        int[] StackArray;
        int Size;
        int Top;

        public Stack(int InputSize)
        {
            Size = InputSize;
            StackArray = new int[Size];
            Top = -1;
        }

        public bool IsEmpty()
        {
            return Top == -1;
        }

        public bool IsFull()
        {
            return Top == Size - 1;
        }
        
        public void Push(int Element)
        {
            if(IsFull())
                Console.WriteLine("Stack Overflow");
            else
             StackArray[++Top] = Element;
        }
        public void Pop()
        {
            if (Top < 0)
                Console.WriteLine("Stack Underflow");
            else
            {
                StackArray[Top] = 0;
                Top--;
            }
        }
        public void Traverse()
        {
            for(int Index = Top; Index >= 0; Index--)
            {
                Console.WriteLine(StackArray[Index]);
            }
        }
    }

    internal class Program
    {
        static void Menu()
        {
            Console.WriteLine("[1] Push");
            Console.WriteLine("[2] Pop");
            Console.WriteLine("[3] Traverse");
        }

        static void Main(string[] args)
        {
            Console.Write("Enter thte size : ");
            int inputSize = int.Parse(Console.ReadLine());
            Stack Stack = new Stack(inputSize);
            while (true)
            {
                Menu();
                Console.WriteLine("Choose an option [1-3]");
                string Choice = Console.ReadLine();

                switch(Choice)
                {
                    case "1":
                        Console.WriteLine("Enter the value");
                        int Value = int.Parse(Console.ReadLine());
                        Stack.Push(Value);
                        break;
                    case "2":
                        Stack.Pop();
                        Console.WriteLine("Last value poped successfully");
                        break;
                    case "3":
                        Stack.Traverse();
                        break;
                }
            }
        }
    }
}
