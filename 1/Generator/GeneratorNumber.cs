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
        private NumericUpDown _numOne;
        private NumericUpDown _numTwo;
        private readonly Label _label;
        private readonly TextBox _textBox;
        private readonly CheckBox _checkBox;

        public GeneratorNumber()
        {

        }

        public GeneratorNumber(Label label, NumericUpDown numOne, NumericUpDown numTwo, TextBox textBox, CheckBox checkBox)
        {
            _label = label;
            _numOne = numOne;
            _numTwo = numTwo;
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
        public void Generator()
        {
            numerOne = Convert.ToInt32(_numOne.Value);
            numerTwo = Convert.ToInt32(_numTwo.Value);

            bool result = CheckGenerator(numerOne, numerTwo);

            if (result is true)
            {
                resultRandom = _random.Next(numerOne, numerTwo) + 1;
                _label.Text = resultRandom.ToString();

                SaveGenerator();
            }
        }

        /// <summary>
        /// Проверка значений генератора
        /// </summary>
        /// <param name="numerOne">минимальное значение</param>
        /// <param name="numerTwo">максимальное значение</param>
        /// <returns></returns>
        public bool CheckGenerator(int numerOne, int numerTwo)
        {
            if (numerOne > numerTwo)
            {
                MessageBox.Show("Минимальное значение не может быть больше максимального значения");
                _label.Text = "0";
                return false;
            }
            else
            {
                return true;
            }
        }

        /// <summary>
        /// Сохранение значений генератора
        /// </summary>
        public void SaveGenerator()
        {
            if (_checkBox.Checked is true)
            {
                if (_textBox.Text.IndexOf(resultRandom.ToString()) == -1)
                    SaveResult(resultRandom);
            }
            else
                SaveResult(resultRandom);
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
