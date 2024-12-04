using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Model1
{
    public partial class WinForValues : Form
    {
       
        public WinForValues()
        {
            InitializeComponent();
            OK.DialogResult = DialogResult.OK;
            inputStrBox.MaxLength = 80;
        }
        //шаблоны для входной строки
        private const string PatternSymb = @"^[\+\-\*\/\^\)]|[\+\-\*\/\^]{2}|\([\+\-\*\/\^\)]|[\+\-\*\/\^]\)|\)\(|[A-E]{2}|[A-E][\(\\s\\c\\a\\t]";
        private const string PatternFunc = @"\w*sin\($|\w*cos\($|\w*tg\($";
        //^[\+\-\*\/\^\)] - символы в [] встречаются в начале строки;
        //[\+\-\*\/\^]{2} - символы в [] встречаются 2 раза подряд;
        //\([\+\-\*\/\^\)] - символы в [] встречаются сразу после "(";
        //[\+\-\*\/\^]\) - сразу после символов в [] встречается ")";
        //\)\( - сразу после ")" встречается "(";
        //[A-E]{2} - символы алфавита с А по E встречаются два раза подряд;
        //[A-E][\(\\s\\c\\a\\t] - сразу после символов алфавита встречается "(" или функция;
        //\w*sin\($ - перед функцией может стоять алфавитно-цифровой символ, а после ф-и "(";

        //Обработчик изменения текста в InputStrBox
        private void InputStrBox_TextChanged(object sender, EventArgs e)
        {//если находится соответсвие одному из шаблонов, то оно удаляется из строки
           if (Regex.IsMatch(inputStrBox.Text, PatternSymb))
            {
               inputStrBox.Text = inputStrBox.Text.Remove(inputStrBox.Text.Length-1);
            }
        }
        //обработчик кнопок с символами переменных
        private void ButtonVarSymb_Click(object sender, EventArgs e)
        {
            inputStrBox.Text += ((Button)sender).Text;
        }
        //обработчик кнопок с названиями функций
        private void ButtonFunc_Click(object sender, EventArgs e)
        {//после названия функции добавляется "("
            inputStrBox.Text += ((Button)sender).Text+"(";
        }
        //обработчик кнопки удаления одного символа для переменных и символов
        //и удаления функции (по шаблону)
        private void Backspace_Click(object sender, EventArgs e)
        {
            if (inputStrBox.TextLength != 0)
            {
                if (Regex.IsMatch(inputStrBox.Text, PatternFunc))
                {
                    inputStrBox.Text = inputStrBox.Text.Remove(Regex.Match(inputStrBox.Text, PatternFunc).Index);
                }
                else
                {
                    inputStrBox.Text = inputStrBox.Text.Remove(inputStrBox.Text.Length - 1);
                }
            }
         }
        //Обработчик кнопки "Очистить"
        private void DeleteAll_Click(object sender, EventArgs e)
        {
            inputStrBox.Clear();
        }
        //получение введенной строки
        public string GetStr()
        {
            return inputStrBox.Text;
        }
    }
}
