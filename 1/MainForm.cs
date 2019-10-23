using MyUtilities.Converter;
using MyUtilities.Notepad;
using MyUtilities.Password;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyUtilities
{
    public partial class MainForm : Form
    {
        Counter counter;
        GeneratorNumber generatorNumber;
        NotepadUse notepadUse;
        GeneratorPassword generatorPassword;
        ConvertUnit convertUnit;


        public MainForm()
        {
            InitializeComponent();
            generatorNumber = new GeneratorNumber(lbl_numer, nud_1, nud_2, tbRandom, cbNumer);
            counter = new Counter();
            notepadUse = new NotepadUse(rtb);
            
            generatorPassword = new GeneratorPassword(clbPassword, nudPassLenght, Password);
            convertUnit = new ConvertUnit(cbFrom, cbTo, tbFrom, tbTo, cbMetric);
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            label1.Text = counter.Discharge(label1.Text);
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            label1.Text = counter.IncreaseNumber(label1.Text).ToString();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            label1.Text = counter.Decrease(label1.Text).ToString();
        }

        private void TsmiExit(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TsmiAbout_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Программа мои утилиты, " +
                "\nсодержит ряд небольших программ которые могут пригодиться в жизни.", "О программе");
        }

        private void Btn_generator_Click(object sender, EventArgs e)
        {
            generatorNumber.Generator();
        }

        private void BtnClearGenerate_Click(object sender, EventArgs e)
        {
            tbRandom.Clear();
        }

        private void BtnCopy_Click(object sender, EventArgs e)
        {
            generatorNumber.CopyInfo();
        }

        private void TsmData_Click(object sender, EventArgs e)
        {
            rtb.AppendText($"{DateTime.Now.ToShortDateString()}\n");
        }

        private void TsmTime_Click(object sender, EventArgs e)
        {
            rtb.AppendText($"{DateTime.Now.ToLongTimeString()}\n");
        }

        private void TsmiSave_Click(object sender, EventArgs e)
        {
            notepadUse.SaveNotepad();
        }

        private void TsmiLoad_Click(object sender, EventArgs e)
        {
            notepadUse.LoadNotepad();
        }

        private void BtnPasword_Click(object sender, EventArgs e)
        {
            generatorPassword.Generator();
        }

        private void BtnClearPassword_Click(object sender, EventArgs e)
        {
            generatorPassword.GeneratorClear();
        }

        private void Button1_Click_1(object sender, EventArgs e)
        {
            generatorPassword.CopyInfo();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            clbPassword.SetItemChecked(0, true);
            clbPassword.SetItemChecked(1, true);
        }

        private void BtnConvert_Click(object sender, EventArgs e)
        {
            convertUnit.ConvertToValue();
        }

        private void BtnSwap_Click(object sender, EventArgs e)
        {
            convertUnit.Swap();
        }

        private void CbMetric_SelectedIndexChanged(object sender, EventArgs e)
        {
            convertUnit.FillInTheDictionary();
        }
    }
}
