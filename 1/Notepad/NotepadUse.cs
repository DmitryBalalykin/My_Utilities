using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyUtilities.Notepad
{
    public class NotepadUse
    {
        private readonly RichTextBox _richTextBox;

        public NotepadUse(RichTextBox richTextBox)
        {
            _richTextBox = richTextBox;
        }

        /// <summary>
        /// Сохраняем введенный текст в файл
        /// </summary>
        public void SaveNotepad()
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();

            try
            {
                saveFileDialog.Filter = "RTF Files|*.rtf";
                saveFileDialog.FilterIndex = 2;
                saveFileDialog.RestoreDirectory = true;
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    _richTextBox.SaveFile(saveFileDialog.FileName);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Ошибка при сохранении!");
            }
        }

        /// <summary>
        /// Открываем сохраненный текст
        /// </summary>
        public void LoadNotepad()
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "RTF Files|*.rtf";
            openFileDialog.FilterIndex = 2;
            openFileDialog.RestoreDirectory = true;

            try
            {
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    _richTextBox.LoadFile(openFileDialog.FileName);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Ошибка при открытии!");
            }

        }
    }
}
