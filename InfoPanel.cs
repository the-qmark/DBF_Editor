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
        public Label TotalSumLabel;
        public Label TotalRowsLabel;
        public Label SelectedLabel;

        private Table _table = new Table();
        
        public InfoPanel(TextBox nameTextBox, Label totalSumLabel, Label totalRowsLabel, Label selectedLabel, Table table)
        {
            NameTextBox = nameTextBox;
            TotalSumLabel = totalSumLabel;
            TotalRowsLabel = totalRowsLabel;
            SelectedLabel = selectedLabel;
            _table = table;

            _table.TableChanged += OnTableChanged;

            NameTextBox.TextChanged += OnNameChanged;
        }

        private void OnNameChanged(object sender, EventArgs e)
        {
            _table.UpdateName(NameTextBox.Text);
        }

        private void OnTableChanged()
        {
            TotalSumLabel.Text = _table.TotalSum.ToString();
            TotalRowsLabel.Text = _table.RowsCount.ToString();
        }
    }
}
