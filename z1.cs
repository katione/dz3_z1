using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dz3_z1
{
    public class Node<T>
    {
        public T Data { get; set; }
        public Node<T> Next { get; set; }

        public Node(T data)
        {
            Data = data;
        }
    }

    public class _Stack<T>
    {
        private Node<T> top;
        private int countt;

        public _Stack()
        {
            countt = 0;
        }

        public bool IsEmpty()
        {
            return countt == 0;
        }

        public int Size()
        {
            return countt;
        }

        public void Push(T data)
        {
            if (countt == 100)
            {
                Console.WriteLine("Стек заполнен,добавить элемент невозможно");
            }
            else 
            { 
            Node<T> newNode = new Node<T>(data);
            newNode.Next = top;
            top = newNode;
            countt++;
            Console.WriteLine("ok");
            }
        }

        public T Back()
        {
            if (IsEmpty())
            { 
                throw new InvalidOperationException("Стек пуст"); 
            }
            return top.Data;
        }

        public T Pop()
        {
            if (IsEmpty())
            { 
                throw new InvalidOperationException("Стек пуст"); 
            }
            T temp = top.Data;
            top = top.Next;
            countt--;
            return temp;
        }

        public void Clear()
        {
            while (!IsEmpty()) Pop();
   
        }

        public void Exit()
        {
            Clear();
            Console.WriteLine("bye");
        }
    }
    internal class z1
    {
        static void Main()
        {
            _Stack<int> stack = new _Stack<int>();
            stack.Push(3);
            stack.Push(14);
            int a = stack.Size();
            Console.WriteLine(a);
            stack.Clear();
            Console.WriteLine("ok");
            stack.Push(1);
            int b = stack.Back();
            Console.WriteLine(b);
            stack.Push(2);
            int b1 = stack.Back();
            Console.WriteLine(b1);
            int c = stack.Pop();
            Console.WriteLine(c);
            int a1 = stack.Size();
            Console.WriteLine(a1);
            int c1 = stack.Pop();
            Console.WriteLine(c1);
            int a2 = stack.Size();
            Console.WriteLine(a2);
            stack.Exit();
        }
    }
}
