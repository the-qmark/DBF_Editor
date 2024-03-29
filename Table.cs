﻿using DBF_Editor.Properties;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DBF_Editor
{
    public class Table
    {
        public event Action TableChanged;
        public event Action SelectedChanged;
        public bool SaveResult; 

        public DataTable DataTable { get => _dataTable; }
        public decimal TotalSum { get => UpdateTotal(); }
        public int RowsCount { get => UpdateRowsCount(); }
        public decimal SeletedSum { get => _selectedSum; }
        public decimal SelectedRows { get => _selectedRows; }
        public string Name { get => _name; }

        public DataTable Header { get => _header; }
        public DataTable Footer { get => _footer;  }
        public Table OtherTable { get => _otherTable; set => _otherTable = value; }

        private string _name;

        private ButtonsPanel _buttonsPanel;
        private DataGridView _dataGridView;

        private Table _otherTable;

        private DataTable _header = new DataTable();
        private DataTable _dataTable = new DataTable();
        private DataTable _footer = new DataTable();

        private decimal _totalSum = 0.00m;
        private int _rowsCount = 0;
        private decimal _selectedSum = 0.00m;
        private decimal _selectedRows = 0;

        public Table() { }

        public Table(ButtonsPanel buttonsPanel, DataGridView dataGridView)
        {
            _buttonsPanel = buttonsPanel;
            _dataGridView = dataGridView;

            _buttonsPanel.MoveBtn.Click += MoveRows;
            _buttonsPanel.EditBtn.Click += EditRow;
            _buttonsPanel.CloneBtn.Click += CloneRow;
            _buttonsPanel.DeleteBtn.Click += DeleteRow;
            SelectedChanged += ButtonsControl;
            _dataGridView.CellDoubleClick += EditRow;
            _dataGridView.ColumnHeaderMouseClick += Sotring;
        }

        private void Sotring(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (_dataGridView.SortOrder.ToString() == "Descending") // Check if sorting is Descending
            {
                _dataTable.DefaultView.Sort = _dataGridView.SortedColumn.Name + " DESC"; // Get Sorted Column name and sort it in Descending order
                
            }
            else
            {
                _dataTable.DefaultView.Sort = _dataGridView.SortedColumn.Name + " ASC";  // Otherwise sort it in Ascending order
            }

            _dataTable = _dataTable.DefaultView.ToTable(); // The Sorted View converted to DataTable and then assigned to table object.
            _dataGridView.DataSource = _dataTable;

            AcceptChanges();
        }

        public void UpdateName(string newName)
        {
            _name = newName;
            if (_name == "")
                _name = "NoNameDBF";
        }

        public void GetDataFrom(DataTable tempTable)
        {
            try
            {
                _dataTable?.Clear();
                _header?.Clear();
                _footer?.Clear();

                _dataTable = tempTable.Copy(); // получается новая таблица
                _header = tempTable.Clone();
                _footer = tempTable.Clone();
                                
                for (int i = 0; i < 6; i++)
                    _header.ImportRow(tempTable.Rows[i]);

                _footer.ImportRow(tempTable.Rows[tempTable.Rows.Count - 1]);

                for (int i = 0; i < 6; i++) // удаление шапки
                    _dataTable.Rows[i].Delete();

                _dataTable.Rows[_dataTable.Rows.Count - 1].Delete(); // удаление ИТОГО

                _dataGridView.DataSource = _dataTable;
                _dataGridView.SelectionChanged += SelectRow;

                AcceptChanges();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Ошибка заполнения таблицы", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        public void ClearTable()
        {
            _dataTable?.Clear();
            _header?.Clear();
            _footer?.Clear();
            AcceptChanges();
        }

        private void AcceptChanges()
        {
            _dataTable?.AcceptChanges();
            ClearSelection();
            UpdateNumbering();
            TableChanged?.Invoke();
        }

        public bool ImportNewRow(DataGridViewSelectedRowCollection dataRowCollection)
        {
            try
            {
                foreach (DataGridViewRow row in dataRowCollection)
                {
                    _dataTable.ImportRow(_otherTable.DataTable.Rows[row.Index]);
                }

                AcceptChanges();

                return true;
            }
            catch (Exception)
            {
                MessageBox.Show("Ошибка переноса строк");
                return false;
            }
        }

        private void MoveRows(object sender, EventArgs e)
        {
            DataGridViewSelectedRowCollection _selectedRows = _dataGridView.SelectedRows;

            if (_otherTable.ImportNewRow(_selectedRows))
            {
                foreach (DataGridViewRow row in _selectedRows)
                {
                    _dataTable.Rows.RemoveAt(row.Index);
                }

                AcceptChanges();
            }
        }

        private void EditRow(object sender, EventArgs e)
        {
            if (_dataGridView.SelectedRows.Count == 0)
                return;

            DataRow _rowForEdit = _dataTable.Rows[_dataGridView.SelectedRows[0].Index];

            EditForm _editForm = new EditForm(_rowForEdit);
            _editForm.ShowDialog();

            AcceptChanges();
        }

        private void CloneRow(object sender, EventArgs e)
        {
            if (_dataGridView.SelectedRows.Count == 0)
                return;

            DataRow _originalRow = _dataTable.Rows[_dataGridView.SelectedRows[0].Index];

            DataRow _cloneRow = _dataTable.NewRow();
            _dataTable.Rows.Add(_cloneRow);

            CloneForm _cloneForm = new CloneForm(_originalRow, _cloneRow);
            _cloneForm.ShowDialog();

            if (_cloneForm.DialogResult == DialogResult.OK)
            {
                //*** settings "перенести сразу"
            }
            else
            {
                _dataTable.Rows.Remove(_cloneRow);
            }

            AcceptChanges();

            if (Settings.Default.MoveNow)
            {
                object _sender = null;
                EventArgs _eventArgs = new EventArgs();

                _dataGridView.Rows[_dataTable.Rows.Count - 1].Selected = true;
                MoveRows(_sender, _eventArgs);
            }    
        }

        private void DeleteRow(object sender, EventArgs e)
        {
            try
            {
                if (_dataGridView.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Не выделены строки для удаления", "Ошибка удаления", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                DataGridViewSelectedRowCollection _selectedRows = _dataGridView.SelectedRows;

                foreach (DataGridViewRow row in _selectedRows)
                {
                    _dataTable.Rows.Remove(_dataTable.Rows[row.Index]);
                }

                AcceptChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка удаления строки", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void SelectRow(object sender, EventArgs e)
        {
            _selectedSum = 0;
            _selectedRows = 0;
            decimal _step = 0;

            _dataGridView.SelectionChanged -= SelectRow;
            if (Settings.Default.SolidSelection && _dataGridView.SelectedRows.Count == 1)
            {
                int _index = _dataGridView.SelectedRows[0].Index;
                for (int i = 0; i < _index; i++)
                {
                    _dataGridView.Rows[i].Selected = true;
                }
            }
            _dataGridView.SelectionChanged += SelectRow;

            DataGridViewSelectedRowCollection _rowCollection = _dataGridView.SelectedRows;

            foreach (DataGridViewRow row in _rowCollection)
            {
                try
                {
                    if (Decimal.TryParse(_dataTable.Rows[row.Index].Field<string>(5), out _step))
                    {
                        _selectedSum += _step;
                        _selectedRows += 1;
                    }
                    else
                    {
                        _selectedSum = 0;
                        _selectedRows = 0;
                        break;
                    }
                }
                catch (DeletedRowInaccessibleException)
                {
                    _selectedSum = 0;
                    _selectedRows = 0;
                    return;
                }
                catch (Exception exc)
                {
                    MessageBox.Show("Ошибка #001 " + _name + " . Строка№" + _dataTable.Rows[row.Index].Field<string>(0), exc.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            SelectedChanged?.Invoke();
        }

        private void ButtonsControl()
        {
            _buttonsPanel.MoveBtn.Enabled = _selectedRows > 0 ? true : false;
            _buttonsPanel.EditBtn.Enabled = _selectedRows == 1 ? true : false;
            _buttonsPanel.CloneBtn.Enabled = _selectedRows == 1 ? true : false;
            _buttonsPanel.DeleteBtn.Enabled = _selectedRows > 0 ? true : false;
        }

        private decimal UpdateTotal()
        {
            try
            {
                _totalSum = 0;
                decimal _step = 0;
                if (_dataTable == null || _dataTable.Rows.Count == 0)
                    return 0;

                for (int i = 0; i < _dataTable.Rows.Count; i++)
                {
                    if (Decimal.TryParse(_dataTable.Rows[i].Field<string>(5), out _step))
                        _totalSum += _step;
                    else
                        throw new Exception();
                }

                return _totalSum;
            }
            catch (Exception e)
            {
                MessageBox.Show("Ошибка вычисления суммы в таблице " + e.Message, "Ошибка вычисления суммы в таблице", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return 0;
            }
        }

        private int UpdateRowsCount()
        {
            _rowsCount = _dataTable.Rows.Count;
            return _rowsCount;
        }

        public void UpdateNumbering()
        {
            if (_dataTable == null || _dataTable.Rows.Count == 0)
                return;

            for (int i = 0; i < _dataTable.Rows.Count; i++)
                _dataTable.Rows[i][0] = (i + 1).ToString();
        }

        private void ClearSelection()
        {
            foreach (DataGridViewRow row in _dataGridView.SelectedRows)
                row.Selected = false;
            _dataGridView.ClearSelection();
            _selectedSum = 0;
            _selectedRows = 0;
            SelectedChanged?.Invoke();
        }
    }
}
