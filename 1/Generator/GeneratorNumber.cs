using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyUtilities
{
    public class GeneratorNumber
    {
        Random _random;
        private int numerOne;
        private int numerTwo;
        private int resultRandom;
        private readonly Label _label;
        private readonly TextBox _textBox;
        private readonly CheckBox _checkBox;

        public GeneratorNumber(Label label,TextBox textBox, CheckBox checkBox)
        {
            _label = label;
            _textBox = textBox;
            _checkBox = checkBox;
            _random = new Random();
        }

        /// <summary>
        /// Генерируем случайное число и выводим его в listBox
        /// </summary>
        /// <param name="numOne">минимальное значение</param>
        /// <param name="numTwo">максимальное значение</param>
        /// <returns></returns>
        public void Generator(NumericUpDown numOne, NumericUpDown numTwo)
        {
            numerOne = Convert.ToInt32(numOne.Value);
            numerTwo = Convert.ToInt32(numTwo.Value);

            resultRandom = _random.Next(numerOne, numerTwo) + 1;
            _label.Text = resultRandom.ToString();

            if (numOne.Value > numTwo.Value)
            {
                MessageBox.Show("Минимальное значение не может быть больше максимального значения");
                _label.Text = "0";
            }
            else
            {
                if (_checkBox.Checked is true)
                {
                    if (_textBox.Text.IndexOf(resultRandom.ToString()) == -1)
                        SaveResult(resultRandom);
                }
                else
                    SaveResult(resultRandom);
            }
        }

        /// <summary>
        /// Сохраняем результат в TextBox
        /// </summary>
        /// <param name="result"></param>
        private void SaveResult(int result)
        {
            _textBox.AppendText($"{result.ToString()}\n");
        }

        /// <summary>
        /// Копируем информацию в буфер обмена и сообщаем об этом пользователю.
        /// </summary>
        public void CopyInfo()
        {
            Clipboard.SetText(_textBox.Text);
            MessageBox.Show("Информация скопированна в буфер обмена!");
        }
    }
}
