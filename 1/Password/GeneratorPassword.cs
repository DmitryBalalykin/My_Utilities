using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyUtilities.Password
{
    public class GeneratorPassword
    {
        private string password;
        private char [] Symbol;
        private readonly CheckedListBox _checkedListBox;
        private readonly NumericUpDown _numericUpDown;
        private readonly Label _label;
        Random _random;

        public GeneratorPassword()
        {
        }

        public GeneratorPassword(CheckedListBox checkedListBox, NumericUpDown numericUpDown, Label label)
        {
            _checkedListBox = checkedListBox;
            _numericUpDown = numericUpDown;
            _label = label;
            _random = new Random();
        }

        /// <summary>
        /// проверка на наличие хоть одного флажка
        /// </summary>
        /// <returns></returns>
        public bool CheckListBox(int checkedListBox)
        {
            if (checkedListBox == 0)
            {
                MessageBox.Show("Вы не выбрали не одного значения к паролю");
                return false;
            }
            else
                return true;
        }

        /// <summary>
        /// Показываем пароль
        /// </summary>
        public void Generator()
        {
            if (_label.Text != null)
            {
                password = "";
                _label.Text = password;
            }

            int checkedListBox = _checkedListBox.CheckedItems.Count;

            if (CheckListBox(checkedListBox) == true)
            {
                int quantityNumer = Convert.ToInt32(_numericUpDown.Value);
                _label.Text = Password(quantityNumer);
            }
        }

        /// <summary>
        /// Генерируем пароль
        /// </summary>
        /// <returns>Пароль</returns>
        public string Password(int quantityNumer)
        {
                for (int i = 0; i < quantityNumer; i++)
                {
                    int n = _random.Next(0, _checkedListBox.CheckedItems.Count);
                    string s = _checkedListBox.CheckedItems[n].ToString();

                    SymbolResult();

                    switch (s)
                    {
                        case "Цифры":
                            password += _random.Next(10).ToString();
                            break;
                        case "Прописные буквы":
                            password += Convert.ToChar(_random.Next(65, 88));
                            break;
                        case "Строчные буквы":
                            password += Convert.ToChar(_random.Next(97, 122));
                            break;
                        default:
                            password += Symbol[_random.Next(Symbol.Length)];
                            break;
                    }
                }
                return password;
        }

        /// <summary>
        /// Очистить поле пароля
        /// </summary>
        public void GeneratorClear()
        {
            password = "non";
            _label.Text = password;
        }

        /// <summary>
        /// Создаем массив символов
        /// </summary>
        /// <returns></returns>
        private char [] SymbolResult()
        {
            return Symbol = new char[] { '%', '*', '~', '#', '?', '№', '$', '&' };
        }

        /// <summary>
        /// Копируем пароль в буфер обмена.
        /// </summary>
        public void CopyInfo()
        {
            Clipboard.SetText(_label.Text);
            MessageBox.Show("Информация скопированна в буфер обмена!");
        }
    }
}
