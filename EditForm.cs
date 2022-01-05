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
            if (Decimal.TryParse(newSumTextBox.Text, out decimal sum) && newSumTextBox.Text.Contains("."))
            {
                saveButton.Enabled = true;
                newSumTextBox.BackColor = Color.White;
                toolTip1.RemoveAll();
            }
            else
            {
                saveButton.Enabled = false;
                newSumTextBox.BackColor = Color.Red;
                toolTip1.SetToolTip(newSumTextBox, "Должны использоваться только цифры и делитель \"точка\"");
            }
        }

        private void newSumTextBox_Leave(object sender, EventArgs e)
        {
            
        }
    }
}
