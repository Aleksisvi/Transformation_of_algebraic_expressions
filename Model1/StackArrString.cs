

namespace Model1
{
    class StackArrString
    {
        private string[] stack;
        private int top;
        public StackArrString(int size)
        {
            stack = new string[size];
            top = 0;
        }
        public int Top() { return top; } //вершина стека
        public void delStack() { top = 0; } //очистить стек
        public int Count() { return top; } //кол-во элементов
        //добавление элемента в стек
        public void Push(string element) { stack[++top] = element; }
        //получение элемента, находящегося в вершине
        public string Peek() { return stack[top]; }
        //извлечение элемента, находящегося в вершине
        public string Pop() { return stack[top--]; }

    }
}

