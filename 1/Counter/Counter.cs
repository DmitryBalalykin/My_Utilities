using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyUtilities
{
    public class Counter
    {
        /// <summary>
        /// Результат цифры
        /// </summary>
        private int Number;

        /// <summary>
        /// Увеличение цифры в поле
        /// </summary>
        /// <param name="label">Цифра</param>
        /// <returns>Возвращает итоговую цифру</returns>
        public int IncreaseNumber(string label)
        {
            Number = Int32.Parse(label);
            return Number = Number + 1;
        }

        /// <summary>
        /// Уменьшение цифры в поле
        /// </summary>
        /// <param name="label">Цифра</param>
        /// <returns>Возвращает итоговую цифру</returns>
        public int Decrease (string label)
        {
            Number = Int32.Parse(label);
            return Number = Number - 1;
        }

        /// <summary>
        /// Сбрасывает счётчик на 0
        /// </summary>
        /// <param name="label">Цифра</param>
        /// <returns>Возвращает итоговую цифру</returns>
        public string Discharge (string label)
        {
            return "0";
        }
    }
}
