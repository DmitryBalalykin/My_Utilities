﻿using System;
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

        public GeneratorPassword(CheckedListBox checkedListBox, NumericUpDown numericUpDown, Label label)
        {
            _checkedListBox = checkedListBox;
            _numericUpDown = numericUpDown;
            _label = label;
            _random = new Random();
        }

        /// <summary>
        /// Генерируем пароль
        /// </summary>
        public void Generator()
        {
            if (_checkedListBox.CheckedItems.Count == 0)
            {
                MessageBox.Show("Вы не выбрали не одного значения к паролю");
                return;
            }

            if (_label.Text != null)
            {
                password = "";
                _label.Text = password;
            }

            for (int i = 0; i < _numericUpDown.Value; i++)
            {
                int n = _random.Next(0, _checkedListBox.CheckedItems.Count);
                string s = _checkedListBox.CheckedItems[n].ToString();

                SymbolResult();

                switch (s)
                {
                    case "Цифры": password += _random.Next(10).ToString();
                        break;
                    case "Прописные буквы": password += Convert.ToChar(_random.Next(65, 88));
                        break;
                    case "Строчные буквы": password += Convert.ToChar(_random.Next(97, 122));
                        break;
                    default:
                        password += Symbol[_random.Next(Symbol.Length)];
                        break;
                }
            }

            _label.Text = password;
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
