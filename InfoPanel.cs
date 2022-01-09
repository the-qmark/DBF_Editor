using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DBF_Editor
{
    class InfoPanel
    {
        public TextBox NameTextBox;
        private Label _totalSumLabel;
        private Label _totalRowsLabel;
        private Label _selectedLabel;

        private Table _table = new Table();
        
        public InfoPanel(TextBox nameTextBox, Label totalSumLabel, Label totalRowsLabel, Label selectedLabel, Table table)
        {
            NameTextBox = nameTextBox;
            _totalSumLabel = totalSumLabel;
            _totalRowsLabel = totalRowsLabel;
            _selectedLabel = selectedLabel;
            _table = table;

            _table.TableChanged += OnTableChanged;
            _table.SelectedChanged += OnSelectedChanged;

            NameTextBox.TextChanged += OnNameChanged;
        }

        private void OnNameChanged(object sender, EventArgs e)
        {
            _table.UpdateName(NameTextBox.Text);
        }

        private void OnTableChanged()
        {
            string _totalSum = string.Format("{0:n}", _table.TotalSum);
            _totalSumLabel.Text = _totalSum;
            _totalRowsLabel.Text = _table.RowsCount.ToString();
        }

        private void OnSelectedChanged()
        {
            string _selectedSum = string.Format("{0:n}", _table.SeletedSum);
            _selectedLabel.Text = $"{_selectedSum} ({_table.SelectedRows})";
        }
    }
}
