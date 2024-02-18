using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackImplementation
{
    public class Program
    {
        static void Main(string[] args)
        {
            bool exit = false;
            var stack = new Stack(10);

            while (!exit)
            {
                Console.WriteLine("Choose an operations:");
                Console.WriteLine("1) Push");
                Console.WriteLine("2) Pop");
                Console.WriteLine("3) Display Stack");
                Console.WriteLine("4) Peek Stack");
                Console.WriteLine("5) Size of Stack");

                var key = Console.ReadKey();
                char operation = key.KeyChar;

                Console.WriteLine();

                int n;

                switch (operation)
                {
                    case '1':
                        Console.Write("Insert a number: ");
                        var line = Console.ReadLine();

                        if (int.TryParse(line, out n))
                            stack.Push(n);
                        else
                            Console.WriteLine("Invalid input...");
                        break;

                    case '2':
                        n = stack.Pop();
                        Console.WriteLine($"Deleted data: {n}");
                        break;

                    case '3':
                        stack.Display();

                        break;
                    case '4':
                        stack.Peek();
                        //n = stack.Peek();
                        //Console.WriteLine($"Last Number is: {n}");


                        break;
                    case '5':
                        stack.Size();

                        break;


                    default:
                        Console.WriteLine("Exiting...");
                        exit = true;
                        break;
                }

                Console.WriteLine();
            }

        }

        class Stack
        {
            public int Count { get; private set; }
            private int[] stack;

            public Stack(int size)
            {
                stack = new int[size];
                Count = 0;
            }

            public void Push(int n)
            {
                if (Count == stack.Length)
                {
                    Console.WriteLine("Stack is full!");
                }
                else
                {
                    stack[Count++] = n;
                }
            }

            public bool IsEmpty()
            {
                if (Count == 0)
                {


                    Console.WriteLine("True");
                    return true;
                }
                Console.WriteLine("False");
                return false;

                

            }
           
            public int Size()
            {
                Console.WriteLine("Size of the stack is" + Count);

                return Count;
            }

            public int Peek()
            {
                int result = -1;

                if (Count == 0)
                {
                    Console.WriteLine("Stack is empty!");
                }
                else
                {
                    result = stack[Count - 1];
                    Console.WriteLine($"Last item added to the stack5 is: {result}");
                }

                return result;
            }



           

            public int Pop()
            {
                int result = -1;

                if (Count == 0)
                {
                    Console.WriteLine("Stack is empty!");
                }
                else
                {
                    result = stack[--Count];
                }

                return result;
            }

            public void Display()
            {
                if (Count == 0)
                {
                    Console.WriteLine("Stack is empty!");
                }
                else
                {
                    Console.WriteLine("Stack data:");
                    for (int i = Count - 1; i >= 0; i--)
                        Console.WriteLine(stack[i]);
                }
            }
        }
    }
}
