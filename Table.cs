﻿using System;
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
        //public event Action<string> NameSet;
        public event Action TableChanged;
        public event Action SelectedChanged;

        public DataTable DataTable { get => _dataTable; }
        public decimal TotalSum { get => UpdateTotal(); }
        public int RowsCount { get => UpdateRowsCount(); }
        public decimal SeletedSum { get => _seletedSum; }
        public decimal SelectedRows { get => _selectedRows; }

        private string _name;

        private ButtonsPanel _buttonsPanel;
        //private InfoPanel _infoPanel;
        private DataGridView _dataGridView;

        private DataTable _header = new DataTable();
        private DataTable _dataTable = new DataTable();
        private DataTable _footer = new DataTable();

        private decimal _totalSum = 0.00m;
        private int _rowsCount = 0;
        private decimal _seletedSum = 0.00m;
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
        }

        public void UpdateName(string newName)
        {
            _name = newName;
        }

        public void GetDataFrom(DataTable tempTable)
        {
            try
            {
                _dataGridView.SelectionChanged -= SelectRow;
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

                AcceptChanges();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Ошибка заполнения таблицы", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void AcceptChanges()
        {
            _dataTable?.AcceptChanges();
            UpdateNumbering();
            ClearSelection();
            _dataGridView.SelectionChanged += SelectRow;
            TableChanged?.Invoke();
        }

        private void MoveRows(object sender, EventArgs e)
        {
            MessageBox.Show("MOVE ROWS " + _name);
        }

        private void EditRow(object sender, EventArgs e)
        {
            EditForm _editForm = new EditForm();
            _editForm.ShowDialog();
        }

        private void CloneRow(object sender, EventArgs e)
        {
            MessageBox.Show("CLONE ROW" + _name);
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

                _dataGridView.SelectionChanged -= SelectRow;

                foreach (DataGridViewRow row in _dataGridView.SelectedRows)
                {
                    _dataTable.Rows.Remove(_dataTable.Rows[row.Index]);
                }

                AcceptChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка удаления строки", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SelectRow(object sender, EventArgs e)
        {
            _seletedSum = 0;
            _selectedRows = 0;
            decimal _step = 0;

            DataGridViewSelectedRowCollection _rowCollection = _dataGridView.SelectedRows;

            foreach (DataGridViewRow row in _rowCollection)
            {
                try
                {
                    if (Decimal.TryParse(_dataTable.Rows[row.Index].Field<string>(5), out _step))
                    {
                        _seletedSum += _step;
                        _selectedRows += 1;
                    }
                    else
                    {
                        _seletedSum = 0;
                        _selectedRows = 0;
                        break;
                    }
                }
                catch (Exception exc)
                {
                    MessageBox.Show("Ошибка #1 " + _name + " . Строка№" + _dataTable.Rows[row.Index].Field<string>(0), exc.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                MessageBox.Show(e.Message, "Ошибка вычисления суммы в таблице " + _name, MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            _seletedSum = 0;
            _selectedRows = 0;
            SelectedChanged?.Invoke();
        }
    }
}
