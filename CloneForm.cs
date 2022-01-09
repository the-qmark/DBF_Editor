using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DBF_Editor
{
    public partial class CloneForm : Form
    {
        private DataRow _originalRow;
        private DataRow _cloneRow;
        private decimal _originalSum = 0.0m;
        private decimal _cloneSum = 0.0m;


        public CloneForm(DataRow originalRow, DataRow cloneRow)
        {
            InitializeComponent();
            _originalRow = originalRow;
            _cloneRow = cloneRow;
        }

        private void CloneForm_Load(object sender, EventArgs e)
        {
            originalBankTextBox.Text = _originalRow[1].ToString();
            originalFamTextBox.Text = _originalRow[2].ToString();
            originalNameTextBox.Text = _originalRow[3].ToString();
            originalOtchTextBox.Text = _originalRow[4].ToString();
            originalSumTextBox.Text = _originalRow[5].ToString();

            if (Decimal.TryParse(originalSumTextBox.Text, out decimal sum))
            {
                _originalSum = sum;
            }
            else
            {
                MessageBox.Show("Исходная строка содержит неверный формат суммы");
                return;
            }

            cloneBankTextBox.Text = _originalRow[1].ToString();
            cloneFamTextBox.Text = _originalRow[2].ToString();
            cloneNameTextBox.Text = _originalRow[3].ToString();
            cloneOtchTextBox.Text = _originalRow[4].ToString();
            cloneSumTextBox.Text = "0.00";
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            _originalRow[5] = originalSumTextBox.Text;
            _cloneRow[1] = cloneBankTextBox.Text;
            _cloneRow[2] = cloneFamTextBox.Text;
            _cloneRow[3] = cloneNameTextBox.Text;
            _cloneRow[4] = cloneOtchTextBox.Text;
            _cloneRow[5] = cloneSumTextBox.Text;

            this.DialogResult = DialogResult.OK;
            Close();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {        
            this.DialogResult = DialogResult.Cancel;
            Close();
        }

        private void cloneSumTextBox_TextChanged(object sender, EventArgs e)
        {
            if (CheckValid(cloneSumTextBox.Text))
            {
                saveButton.Enabled = true;
                saveButton.BackColor = Color.AliceBlue;
                cloneSumTextBox.BackColor = Color.White;
                decimal _delta = _originalSum - _cloneSum;
                originalSumTextBox.Text = _delta.ToString();
            }
            else
            {
                saveButton.Enabled = false;
                saveButton.BackColor = Color.Gray;
                cloneSumTextBox.BackColor = Color.IndianRed;
            }
        }

        private bool CheckValid(string text)
        {
            string _alphabet = "0123456789.";
            foreach (char c in text)
                if (!_alphabet.Contains(c))
                    return false;

            if (Decimal.TryParse(text, out decimal sum))
            {
                _cloneSum = sum;
                if (_cloneSum > _originalSum)
                    return false;
            }
            else
            {
                return false;
            }

            if (text.IndexOf("0") == 0 && text.IndexOf(".") != 1)
                return false;

            if (!text.Contains("."))
                return false;

            int _dotIndex = cloneSumTextBox.Text.IndexOf(".");
            if (_dotIndex == 0) // перед точкой нет ничего
                return false;

            if (_dotIndex != text.Length - 3) // после точки НЕ две цифры
                return false;

            return true;
        }
    }
}
