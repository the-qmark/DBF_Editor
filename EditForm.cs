using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DBF_Editor
{
    public partial class EditForm : Form
    {
        private DataRow _dataRow;

        public EditForm(DataRow dataRow)
        {
            InitializeComponent();
            _dataRow = dataRow;
        }

        private void EditForm_Load(object sender, EventArgs e)
        {
            oldBankTextBox.Text = _dataRow[1].ToString();
            oldFamTextBox.Text = _dataRow[2].ToString();
            oldNameTextBox.Text = _dataRow[3].ToString();
            oldOtchTextBox.Text = _dataRow[4].ToString();
            oldSumTextBox.Text = _dataRow[5].ToString();

            newBankTextBox.Text = _dataRow[1].ToString();
            newFamTextBox.Text = _dataRow[2].ToString();
            newNameTextBox.Text = _dataRow[3].ToString();
            newOtchTextBox.Text = _dataRow[4].ToString();
            newSumTextBox.Text = _dataRow[5].ToString();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            _dataRow[1] = newBankTextBox.Text;
            _dataRow[2] = newFamTextBox.Text;
            _dataRow[3] = newNameTextBox.Text;
            _dataRow[4] = newOtchTextBox.Text;
            _dataRow[5] = newSumTextBox.Text;

            Close();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void newSumTextBox_TextChanged(object sender, EventArgs e)
        {
            if (CheckValid(newSumTextBox.Text))
            {
                saveButton.Enabled = true;
                saveButton.BackColor = Color.AliceBlue;
                newSumTextBox.BackColor = Color.White;
                toolTip1.RemoveAll();
            }
            else
            {
                saveButton.Enabled = false;
                saveButton.BackColor = Color.Gray;
                newSumTextBox.BackColor = Color.Red;
                toolTip1.SetToolTip(newSumTextBox, "Должны использоваться только цифры, разделитель \"точка\" и ДВЕ цифры после него");
            }
        }

        private bool CheckValid(string text)
        {
            string _alphabet = "0123456789.";
            foreach (char c in text)
                if (!_alphabet.Contains(c))
                    return false;

            if (!Decimal.TryParse(text, out decimal sum))
                return false;

            if (text.IndexOf("0") == 0 && text.IndexOf(".") != 1)
                return false;

            if (!text.Contains("."))
                return false;

            int _dotIndex = newSumTextBox.Text.IndexOf(".");
            if (_dotIndex == 0) // перед точкой нет ничего
                return false;

            if (_dotIndex != text.Length - 3) // после точки НЕ две цифры
                return false;

            return true;
        }
    }
}
