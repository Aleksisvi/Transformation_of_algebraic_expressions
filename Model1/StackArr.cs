
namespace Model1
{
    class StackArr
    {
        private char[] stack;
        private int top;
        public StackArr(int size)
        {
            stack = new char[size];
            top = 0;
        }
        public int Top() { return top;} //вершина стека
        public void delStack() { top = 0;} //очистить стек
        public int Count() { return top;} //кол-во элементов
        //добавление элемента в стек
        public void Push(char element) { stack[++top] = element;} 
        //получение элемента, находящегося в вершине
        public char Peek() { return stack[top];}
        //извлечение элемента, находящегося в вершине
        public char Pop() { return stack[top--];}
     
    }
}

