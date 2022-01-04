using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DBF_Editor
{
    class Table
    {
        private ButtonsPanel _buttonsPanel;
        private InfoPanel _infoPanel;
        private DataGridView _dataGridView;

        private DataTable _dataTable;

        public Table(ButtonsPanel buttonsPanel, InfoPanel infoPanel, DataGridView dataGridView)
        {
            _buttonsPanel = buttonsPanel;
            _infoPanel = infoPanel;
            _dataGridView = dataGridView;

            _buttonsPanel.MoveBtn.Click += MoveRows;
            _buttonsPanel.EditBtn.Click += EditRow;
            _buttonsPanel.CloneBtn.Click += CloneRow;
            _buttonsPanel.DeleteBtn.Click += DeleteRow;
        }

        public void GetDataFrom(DataTable tempTable)
        {
            try
            {
                _dataTable = tempTable.Copy(); // получается новая таблица

                for (int i = 0; i < 6; i++) // удаление шапки
                    _dataTable.Rows[i].Delete();

                _dataTable.Rows[_dataTable.Rows.Count - 1].Delete(); // удаление ИТОГО

                _dataGridView.DataSource = _dataTable;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Ошибка заполнения таблицы", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void MoveRows(object sender, EventArgs e)
        {
            MessageBox.Show("MOVE ROWS");
        }

        private void EditRow(object sender, EventArgs e)
        {
            MessageBox.Show("EDIT ROW");
        }

        private void CloneRow(object sender, EventArgs e)
        {
            MessageBox.Show("CLONE ROW");
        }

        private void DeleteRow(object sender, EventArgs e)
        {
            MessageBox.Show("DELETE ROW");
        }
    }
}
