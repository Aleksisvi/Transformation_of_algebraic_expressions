using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Model1
{
    public partial class AlgExpConverter : Form
    {
        public AlgExpConverter()
        {
            InitializeComponent();
            stack = new StackArr(80);
            stackPost = new StackArrString(80);
            modeBox.Enabled = false;
            
            //таблица принятия решений
            decisionTable = new int[8][]
             {new int[]{4, 1, 1, 1, 1, 1, 1, 5, 1, 6},
              new int[]{2, 2, 2, 1, 1, 1, 1, 2, 1, 6},
              new int[]{2, 2, 2, 1, 1, 1, 1, 2, 1, 6},
              new int[]{2, 2, 2, 2, 2, 1, 1, 2, 1, 6},
              new int[]{2, 2, 2, 2, 2, 1, 1, 2, 1, 6},
              new int[]{2, 2, 2, 2, 2, 2, 1, 2, 1, 6},
              new int[]{5, 1, 1, 1, 1, 1, 1, 3, 1, 6},
              new int[]{2, 2, 2, 2, 2, 2, 1, 7, 7, 6}};
            //таблица соответствия имен функций и символов алфавита
            tableFunct = new string[6][]
           {
                new string []{ "arcsin", "а" },new string [] {"arccos", "б" },new string[]{"sin", "в" },
                new string [] {"cos", "г" }, new string [] {"arctg", "д" },
                new string []{"tg", "е" }
           };
 
            //визуализация таблицы принятия решений
            {
                decisionTableBox.RowCount = 8;
                decisionTableBox.ColumnCount = 10;
                decisionTableBox.ClearSelection();

                for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    decisionTableBox.Rows[i].Cells[j].Value = decisionTable[i][j];
                }
            }
            foreach (DataGridViewColumn dg in decisionTableBox.Columns)
            {
                dg.SortMode = DataGridViewColumnSortMode.NotSortable;
            }
                decisionTableBox.Columns[0].Name = " ";
                decisionTableBox.Columns[1].Name = "+";
                decisionTableBox.Columns[2].Name = "-";
                decisionTableBox.Columns[3].Name = "*";
                decisionTableBox.Columns[4].Name = "/";
                decisionTableBox.Columns[5].Name = "^";
                decisionTableBox.Columns[6].Name = "(";
                decisionTableBox.Columns[7].Name = ")";
                decisionTableBox.Columns[8].Name = "F";
                decisionTableBox.Columns[9].Name = "P";
                decisionTableBox.Rows[0].HeaderCell.Value = " ";
                decisionTableBox.Rows[1].HeaderCell.Value = "+";
                decisionTableBox.Rows[2].HeaderCell.Value = "-";
                decisionTableBox.Rows[3].HeaderCell.Value = "*";
                decisionTableBox.Rows[4].HeaderCell.Value = "/";
                decisionTableBox.Rows[5].HeaderCell.Value = "^";
                decisionTableBox.Rows[6].HeaderCell.Value = "(";
                decisionTableBox.Rows[7].HeaderCell.Value = "F"; }
        }
        private string[][] tableFunct;
        private List<char> changedInputStr;
        private List<char> changedPostStr;
        private StackArr stack;
        private StackArrString stackPost;
        private WinForValues wfv;
        private int[][] decisionTable;
        private string[] emptyStack;
        private int indxTopInStackBox, stopCycle, currSymbIputStr;
        private List<string> outStr;
        
        //получение входной строки в инфиксной форме с окна ввода выражения
        //по нажатию кнопки "Задать"
        private void SetInputStr_Click(object sender, EventArgs e)
        {
            wfv = new WinForValues();
            this.Enabled = false;
            //в окне ввода выражения нажата кнопка ОК - окно закрыто
            if (wfv.ShowDialog(this) == DialogResult.OK)
            {
                toInfix.Enabled = false;
                this.Enabled = true;
                stack.delStack();
                stackPost.delStack();
                inputStrBox.Clear(); 
                stackBox.Items.Clear();
                stackBoxPost.Items.Clear();
                bottomStackBox.Items.Clear();
                currentStepBox.SelectedIndex = -1;
                bottomStackBoxPost.Items.Clear();
                tactMode.Checked = true; // вкл. пошаговый режим 
                string sourseInputStr = wfv.GetStr(); //получение входной строки с формы ввода
               
                if (sourseInputStr.Length != 0) //строка не пустая
                {
                    modeBox.Enabled = true; // доступен выбор режимов
                    allButtons.Enabled = true; //доступна только кнопка "Такт"
                    startStopButton.Enabled = false;
                    outputStrBox.Clear();
                    outputStrBoxPost.Clear();
                    outStr = new List<string>();
                    inputStrBox.Text = sourseInputStr; //вывод входной строки
                    //строка, содержащая в себе символы входной строки с замененными именами функций
                    changedInputStr = new List<char>(ReplaceFunctions(sourseInputStr,0,1)); 
                    emptyStack = new string[changedInputStr.Count];
                    //создание пустого списка для дальнейшей виз-ции стека
                    for (int i = 0; i < emptyStack.Length; i++)
                    {
                        emptyStack[i] = "";
                    }
                    stackBox.Items.AddRange(emptyStack);
                    stackBoxPost.Items.AddRange(emptyStack);
                    bottomStackBox.Items.AddRange(emptyStack);
                    bottomStackBoxPost.Items.AddRange(emptyStack);
                    //индекс вершины стека - дно стека, т.к. стек пустой
                    indxTopInStackBox = stackBox.Items.Count - 1;
                    //currSymbIputStr - индекс символа входной строки на тек.шаге
                    //stopCycle=1 - прерывание цикла
                    currSymbIputStr = 0; stopCycle = 0;
                    
                }
            }
            else this.Enabled = true;
        }

        //замена имен функций символами и наоборот из таблицы соответствия
        private string ReplaceFunctions(string inpStr, int  first, int second )
        {
            for (int i = 0; i < tableFunct.Length; i++)
            {
                inpStr = inpStr.Replace(tableFunct[i][first], tableFunct[i][second]);
            }
            return inpStr;
        }
        
        private int buttomStack;
        //метод преобразования исходного выражения в постфиксную форму
        private void CreatePostfix (List<char> inputStr)
        { //индекс текущего символа входной строки в таблице принятия решений
            int symbNumbInIputStr = 0;
            //если строка не закончилась, то определяется индекс текущего символа
            if (currSymbIputStr < inputStr.Count)
            {
                symbNumbInIputStr = SymbNumInputStr(inputStr[currSymbIputStr]);
            }

            if (stopCycle != 1)
            {
                //в визуализации табл. принятия решений выделяется ячейка с номером действия
                decisionTableBox.Rows[SymbNumInStek()].Cells[symbNumbInIputStr].Selected = true;
                //получаем из табл. принятия решений номер действия
                switch (decisionTable[SymbNumInStek()][symbNumbInIputStr])
                {
                    case 1: //поместить символ из входной строки в стек
                        {
                            stack.Push(inputStr[currSymbIputStr]); //помещаем символ в стек
                            //выводим последний символ в стеке в визуализацию стека и выделяем его
                            stackBox.Items.RemoveAt(indxTopInStackBox); //удаление пустого символа 
                            stackBox.Items.Insert(indxTopInStackBox, stack.Peek()); //на его место помещается символ
                            stackBox.SetSelected(indxTopInStackBox, true); // выделяется 
                            stackBox.TopIndex = stackBox.SelectedIndex; //фокус на элементе
                            //выделяем дно стека в его визуализации
                            buttomStack = indxTopInStackBox + stack.Count() - 1; 
                            bottomStackBox.SetSelected(buttomStack, true);
                            indxTopInStackBox--;
                        }
                        break;
                    case 2://извлечь символ из стека и отправить его в выходную строку
                        {
                            //извлекаем последний символ в стеке в выходную строку,
                            //если встречается символ функции, то по таблице соответсвия
                            //заменяем его на имя функции
                            outStr.Add(ReplaceFunctions(stack.Pop().ToString(),1,0));
                            stackBox.SetSelected(buttomStack - stack.Count(), true);
                            stackBox.TopIndex = stackBox.SelectedIndex;
                            //выводим выходную строку
                            outputStrBox.Text = string.Join("", outStr);
                            currSymbIputStr--;
                        }
                        break;
                    case 3: //удалить символ ")" из входной строки и символ "(" из стека
                        {
                            stack.Pop();//извлекаем символ с вершины стека
                            stackBox.SetSelected(buttomStack - stack.Count(), true);
                        }
                        break;
                    case 4:// успешное окончание преобразования
                        { stopCycle = 1; modeBox.Enabled = false; allButtons.Enabled = false;
                            toInfix.Enabled = true;
                            inputStrPostBox.Text = outputStrBox.Text;
                            changedPostStr = new List<char>(ReplaceFunctions(outputStrBox.Text,0,1));
                            inStrPostCurStepBox.Text = string.Join("", changedPostStr);
                            indxTopInStackBox = stackBoxPost.Items.Count - 1;
                            currSymbIputStr = -1;
                            outStr.Clear();
                            tactModePost.Checked = true; // вкл. пошаговый режим 
                            modeBoxPost.Enabled = true; // доступен выбор режимов
                            allButtonsPost.Enabled = true; //доступна только кнопка "Такт"
                            startStopButtonPost.Enabled = false;
                            MessageBox.Show("Успешное окончание преобразования", "Внимание", MessageBoxButtons.OK);
                        } break;
                    case 5: //ошибка скобочной структуры
                        {
                            MessageBox.Show("Ошибка скобочной структуры", "Внимание", MessageBoxButtons.OK);
                            //цикл останавливается, кнопки и выбор режима - недоступны
                            stopCycle = 1; modeBox.Enabled = false; allButtons.Enabled = false;
                        }
                        break;
                    case 6: //переслать символ из входной строки в выходную строку
                        {
                            //в выходную строку записывается текущий символ входной строки
                            outStr.Add(inputStr[currSymbIputStr].ToString());
                            outputStrBox.Text = string.Join("",outStr);
                        }
                        break;
                    case 7: //ошибка: после функции отсутствует "("
                        {
                            MessageBox.Show("Ошибка: после функции отсутствует (", "Внимание", MessageBoxButtons.OK);
                            //цикл останавливается, кнопки и выбор режима - недоступны
                            stopCycle = 1;modeBox.Enabled = false; allButtons.Enabled = false;
                        }
                        break;
                }
            }
            else
            {
                TactButton.Enabled = false;
            }
        }

        //метод преобразования постфиксного выражения в инфиксную форму
        private void CreateInfix(List<char> inputStr)
        { 
            int symbNumbPostStr = 0;
            //если строка не закончилась, то определяется индекс текущего символа
            //из визуализации входной строки на текущем шаге слева удаляется символ
            if (currSymbIputStr < inputStr.Count)
            {
                inStrPostCurStepBox.Text = inStrPostCurStepBox.Text.Remove(0,1);
                symbNumbPostStr = SymbNumInputStr(inputStr[currSymbIputStr]);
            }

            if (stopCycle != 2)
            {
                //индекс текущего символа
                switch (symbNumbPostStr)
                {
                    case 9: //поместить символ из входной строки в стек
                        {
                           currentStepBox.SetSelected(0, true);
                           removeAddStackPost(inputStr[currSymbIputStr].ToString());
                        }
                        break;
                    case 8: //извлечь элемент из стека, применить к нему функцию и поместить в стек
                        {
                            currentStepBox.SetSelected(1, true); 
                            removeAddStackPost(inputStr[currSymbIputStr].ToString() + "(" + stackPost.Pop() + ")");  
                        }
                        break;
                    case 0: //извлечь результат преобразования в выходную строку
                        {
                            modeBoxPost.Enabled = false; allButtonsPost.Enabled = false;
                            currentStepBox.SetSelected(3, true); 
                            outStr.Add(ReplaceFunctions(stackPost.Pop(),1,0));
                            //выводим выходную строку
                            outputStrBoxPost.Text = string.Join("", outStr);
                            stopCycle = 2;
                            sek = delayTrackBar.Value;
                            MessageBox.Show("Успешное окончание преобразования", "Внимание", MessageBoxButtons.OK);
                        }
                        break;
                    default: //извлечь элементы, находящиеся на вершине и под вершиной стека
                        //применить бинарную операцию и поместить в стек
                        {
                            string top = stackPost.Pop(); //с вершины
                            currentStepBox.SetSelected(2, true); 
                            removeAddStackPost("(" +stackPost.Pop()+ inputStr[currSymbIputStr].ToString()+ top+")");
                        }
                        break;
                }
            }
        }
        //добавление элемента в стек и визуализация
        private void removeAddStackPost(string stackPush)
        {
            stackPost.Push(stackPush);//помещаем  в стек
            stackBoxPost.Items.RemoveAt(indxTopInStackBox); //удаление пустого символа из визуализации
            stackBoxPost.Items.Insert(indxTopInStackBox, stackPost.Peek()); //на его место помещается элемент
            stackBoxPost.SetSelected(indxTopInStackBox, true); // выделение
            stackBoxPost.TopIndex = stackBoxPost.SelectedIndex; //фокус на элементе
            //выделяем дно стека в его визуализации
            buttomStack = indxTopInStackBox + stackPost.Count() - 1;
            bottomStackBoxPost.SetSelected(buttomStack, true);
            indxTopInStackBox-=1;
        }

     //символ входной строки
     private int SymbNumInputStr(char symb)
        {
            String variable = "ABCDEFGHIJKLMNOPQRSTUVWXYZ"; //переменные
            string function = "абвгдеж"; //функции
            int symbInputStr = 0;
            switch (symb)
            {
                case '+': symbInputStr = 1; break;
                case '-': symbInputStr = 2; break;
                case '*': symbInputStr = 3; break;
                case '/': symbInputStr = 4; break;
                case '^': symbInputStr = 5; break;
                case '(': symbInputStr = 6; break;
                case ')': symbInputStr = 7; break;
            }
            foreach (char v in variable) //переменные
            {
                if (symb == v) { symbInputStr = 9; break; }
            }
            foreach (char f in function) //функции
            {
                if (symb == f) { symbInputStr = 8; break; }
            }
            return symbInputStr;
        }
        //символ в вершине стека
        private int SymbNumInStek()
        {
            int symbStack = 0;
            string symbFunction = "абвгдеж"; //символы функций
            if (stack.Count() != 0)
            {
                switch (stack.Peek())
                {
                    case '+': symbStack = 1; break;
                    case '-': symbStack = 2; break;
                    case '*': symbStack = 3; break;
                    case '/': symbStack = 4; break;
                    case '^': symbStack = 5; break;
                    case '(': symbStack = 6; break;
                }
                foreach (char sf in symbFunction) //символы функций
                {
                    if (stack.Peek() == sf) { symbStack = 7; break; }
                }
            }
            return symbStack;
        }
        //обработчик нажатия на кнопку "Такт"
        private void TactButton_Click(object sender, EventArgs e)
        {
            //вызов метода преобразования
            //в постфиксную форму
            if (Convert.ToInt32(((Button)sender).Tag) == 1)
            {
                decisionTableBox.ClearSelection();
                CreatePostfix(changedInputStr);
            }//в инфиксную форму
            else CreateInfix(changedPostStr);

            currSymbIputStr++;
        }
       
        //метод автоматического режима 
        async void AutoCreate(int mod)
            
        {//цикл выполняется до момента, когда и стек и строка пустые или встретилась ошибка
            while (stopCycle !=mod)
            {
                //вызов метода преобразования
                if (mod == 1) //в постфиксную форму
                {
                    decisionTableBox.ClearSelection();
                    CreatePostfix(changedInputStr);
                }
                else CreateInfix(changedPostStr); //в инфиксную форму
                currSymbIputStr++;
                await Task.Delay(sek);
            }
            stopCycle = 0;
        }
       
        //обработчик нажатия на кнопку "Старт"
        private void StartButton_Click(object sender, EventArgs e)
        {
            //при преобразовании в постфиксную форму
            if (Convert.ToInt32(((Button)sender).Tag) == 1) 
            {
                StopButton.Enabled = true;
                setInputStr.Enabled = false;
                StartButton.Enabled = false;
                TactButton.Enabled = false;
                tactMode.Enabled = false;
                delayTrackBar.Enabled = false;
                AutoCreate(1);
            }
            //при преобразовании в инфиксную форму
            else
            {
                setInputStr.Enabled = false;
                StopButtonPost.Enabled = true;
                StartButtonPost.Enabled = false;
                tactButtonPost.Enabled = false;
                tactModePost.Enabled = false;
                delayTrackBarPost.Enabled = false;
                AutoCreate(2);
            }
        }

        //обработчик нажатия на кнопку "Стоп"
        private void StopButton_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(((Button)sender).Tag) == 1)
            {
                stopCycle = 1;
                setInputStr.Enabled = true;
                StopButton.Enabled = false;
                StartButton.Enabled = true;
                tactMode.Enabled = true;
                delayTrackBar.Enabled = true;
            }
            else
            {
                stopCycle = 2;
                setInputStr.Enabled = true;
                StopButtonPost.Enabled = false;
                StartButtonPost.Enabled = true;
                tactModePost.Enabled = true;
                delayTrackBarPost.Enabled = true;
            }
            
        }
        //выбор режима: пошаговый (tag=0) или автоматический (tag=1)
        //при преобразовании в постфиксную форму
        private void TactAutoButton_CheckedChanged(object sender, EventArgs e)
        { 
            //пошаговый режим
            if (Convert.ToInt32(((RadioButton)sender).Tag) == 0)
            {
                delayTrackBar.Enabled = false;
                startStopButton.Enabled = false;
                if (stopCycle == 0) TactButton.Enabled = true;
            }
            else //автоматический режим
            {
                TactButton.Enabled = false;
                startStopButton.Enabled = true;
                StopButton.Enabled = false;
                delayTrackBar.Enabled = true;
                if (stopCycle ==0) StartButton.Enabled = true;
            }
        }
        //выбор режима: пошаговый (tag=0) или автоматический (tag=1)
        //при преобразовании в инфиксную форму
        private void TactAutoButtonPost_CheckedChanged(object sender, EventArgs e)
        {
            //пошаговый режим
            if (Convert.ToInt32(((RadioButton)sender).Tag) == 0)
            {
                delayTrackBarPost.Enabled = false;
                startStopButtonPost.Enabled = false;
                if (stopCycle == 0) tactButtonPost.Enabled = true;
            }
            else //автоматический режим
            {
                tactButtonPost.Enabled = false;
                startStopButtonPost.Enabled = true;
                StopButtonPost.Enabled = false;
                delayTrackBarPost.Enabled = true;
                if (stopCycle == 0) StartButtonPost.Enabled = true;
            }
        }
        private int sek=10;
        //установка величины задержки (сек.) ползунком
        private void delayTrackBar_ValueChanged(object sender, EventArgs e)
        {
            sek = ((TrackBar)sender).Value;
            if (Convert.ToInt32(((TrackBar)sender).Tag) == 1)// постфикс. форму
            {
                delayLabel.Text = (((double)sek) / 1000).ToString();
            }else delayLabelPost.Text = (((double)sek) / 1000).ToString();//в инфикс. форму
        }

       
    }
}
