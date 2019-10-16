using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyUtilities.Converter
{
    public class ConvertUnit
    {
        private ComboBox _comboBoxFrom;
        private ComboBox _comboBoxTo;
        private TextBox _textBoxFrom;
        private TextBox _textBoxTo;
        private ComboBox _comboBoxMetric;
        Dictionary<string, double> metrica;

        public ConvertUnit(ComboBox comboBoxFrom, ComboBox comboBoxTo, TextBox textBoxFrom, TextBox textBoxTo, ComboBox comboBoxMetric)
        {
            _comboBoxFrom = comboBoxFrom;
            _comboBoxTo = comboBoxTo;
            _textBoxFrom = textBoxFrom;
            _textBoxTo = textBoxTo;
            _comboBoxMetric = comboBoxMetric;
        }

        /// <summary>
        /// Метод конвертации значений
        /// </summary>
        public void ConvertToValue()
        {
            if (_textBoxFrom.Text == "")
            {
                MessageBox.Show("Вы не заполнили значение");
                return;
            }

            FillInTheDictionary();

            double m1 = metrica[_comboBoxFrom.Text];
            double m2 = metrica[_comboBoxTo.Text];
            double n = Convert.ToDouble(_textBoxFrom.Text);
            _textBoxTo.Text = (n * m1 / m2).ToString();
        }
        
        /// <summary>
        /// Обмен значениями
        /// </summary>
        public void Swap()
        {
            if (_textBoxFrom.Text == "" || _textBoxTo.Text == "")
            {
                MessageBox.Show("Не все поля заполнены для обмена");
                return;
            }

            string unitCB = _comboBoxFrom.Text;
            _comboBoxFrom.Text = _comboBoxTo.Text;
            _comboBoxTo.Text = unitCB;

            string unitTB = _textBoxFrom.Text;
            _textBoxFrom.Text = _textBoxTo.Text;
            _textBoxTo.Text = unitTB;
        }

        /// <summary>
        /// Заполнение списка
        /// </summary>
        public void FillInTheDictionary()
        {
            metrica = new Dictionary<string, double>();

            switch (_comboBoxMetric.Text)
            {
                case "длина":
                    metrica.Clear();
                    metrica.Add("мм", 1);
                    metrica.Add("см", 10);
                    metrica.Add("дм", 100);
                    metrica.Add("м", 1000);
                    metrica.Add("км", 1000000);
                    metrica.Add("миля", 1609344);
                    _comboBoxTo.Items.Clear();
                    _comboBoxTo.Items.Add("мм");
                    _comboBoxTo.Items.Add("см");
                    _comboBoxTo.Items.Add("дм");
                    _comboBoxTo.Items.Add("м");
                    _comboBoxTo.Items.Add("км");
                    _comboBoxTo.Items.Add("миля");
                    _comboBoxFrom.Items.Clear();
                    _comboBoxFrom.Items.Add("мм");
                    _comboBoxFrom.Items.Add("см");
                    _comboBoxFrom.Items.Add("дм");
                    _comboBoxFrom.Items.Add("м");
                    _comboBoxFrom.Items.Add("км");
                    _comboBoxFrom.Items.Add("миля");
                    break;
                case "вес":
                    metrica.Clear();
                    metrica.Add("г", 1);
                    metrica.Add("кг", 1000);
                    metrica.Add("тонна", 1000000);
                    metrica.Add("фунт", 453.59237);
                    metrica.Add("унция", 28.349523125);
                    _comboBoxTo.Items.Clear();
                    _comboBoxTo.Items.Add("г");
                    _comboBoxTo.Items.Add("кг");
                    _comboBoxTo.Items.Add("тонна");
                    _comboBoxTo.Items.Add("фунт");
                    _comboBoxTo.Items.Add("унция");
                    _comboBoxFrom.Items.Clear();
                    _comboBoxFrom.Items.Add("г");
                    _comboBoxFrom.Items.Add("кг");
                    _comboBoxFrom.Items.Add("тонна");
                    _comboBoxFrom.Items.Add("фунт");
                    _comboBoxFrom.Items.Add("унция");
                    break;
                default:
                    break;
            }

        }
    }
}
