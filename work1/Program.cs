namespace work1
{
    public class MyStack<T>
    {
        private T[] stackArray;
        private int top;
        public void InitStack(int size)
        {
            stackArray = new T[size];
            top = -1;
        }
        public void ClearStack()
        {
            top = -1;
        }
        public void Push(T element)
        {
            if (top == stackArray.Length - 1)
            {
                Console.WriteLine("栈已满，无法添加新元素。");
                return;
            }
            top++;
            stackArray[top] = element;
        }
        public T Pop()
        {
            if (top == -1)
            {
                Console.WriteLine("栈已空，无法执行出栈操作。");
                return default(T);
            }
            T element = stackArray[top];
            top--;
            return element;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            MyStack<int> stack = new MyStack<int>();
            stack.InitStack(5);
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);

            Console.WriteLine(stack.Pop());
            Console.WriteLine(stack.Pop());
            Console.WriteLine(stack.Pop());
            stack.ClearStack();
        }
    }
}