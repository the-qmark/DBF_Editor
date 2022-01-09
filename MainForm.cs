using DBF_Editor.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DBF_Editor
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private ButtonsPanel _buttonsPanel1, _buttonsPanel2;
        private InfoPanel _infoPanel1, _infoPanel2;
        private Table _table1, _table2;

        private void MainForm_Load(object sender, EventArgs e)
        {
            #region системные настройки
            dataGridView1.GetType().GetProperty("DoubleBuffered", BindingFlags.Instance | BindingFlags.NonPublic).SetValue(dataGridView1, true, null);
            dataGridView2.GetType().GetProperty("DoubleBuffered", BindingFlags.Instance | BindingFlags.NonPublic).SetValue(dataGridView2, true, null);
            mainSplitContainer.GetType().GetProperty("DoubleBuffered", BindingFlags.Instance | BindingFlags.NonPublic).SetValue(mainSplitContainer, true, null);
            var myCulture = (CultureInfo)new CultureInfo("ru-RU").Clone();
            myCulture.NumberFormat.NumberDecimalSeparator = ".";
            Thread.CurrentThread.CurrentCulture = myCulture;
            #endregion

            solidSelectionToolStripMenuItem.Checked = Settings.Default.SolidSelection;

            _buttonsPanel1 = new ButtonsPanel(moveButton1, editButton1, cloneButton1, deleteButton1);
            _table1 = new Table(_buttonsPanel1, dataGridView1);
            _infoPanel1 = new InfoPanel(nameTextBox1, totalSumLabel1, totalRowsLabel1, selectedSumAndRowsLabel1, _table1);

            _buttonsPanel2 = new ButtonsPanel(moveButton2, editButton2, cloneButton2, deleteButton2);
            _table2 = new Table(_buttonsPanel2, dataGridView2);
            _infoPanel2 = new InfoPanel(nameTextBox2, totalSumLabel2, totalRowsLabel2, selectedSumAndRowsLabel2, _table2);
        }

        private void открытьdbfToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.Cancel)
                return;

            string _filePath = Path.GetDirectoryName(openFileDialog.FileName);
            string _fileName = Path.GetFileNameWithoutExtension(openFileDialog.FileName);

            DBFConnection _dbfConnection = new DBFConnection(_fileName, _filePath);
            DataTable _tempTable = _dbfConnection.GetDataTable();

            if (CheckValid(_tempTable, out string _errorMessage) == false)
            {
                MessageBox.Show($"Ошибка при обработке таблицы: {_errorMessage}", "Ошибка при обработке таблицы", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            _table1.GetDataFrom(_tempTable);
            _table2.GetDataFrom(_tempTable);

            _table1.OtherTable = _table2;
            _table2.OtherTable = _table1;

            _table2.DataTable.Clear();

            string _shortName = _fileName.Length > 3 ? _fileName.Substring(_fileName.Length - 3) : _fileName;

            _infoPanel1.NameTextBox.Text = _shortName; // ** settings
            _infoPanel2.NameTextBox.Text = _shortName + "new"; // ** settings

            saveTodbfToolStripMenuItem.Enabled = true;
            saveTodbfcsvToolStripMenuItem.Enabled = true;
        }

        private bool CheckValid(DataTable dt, out string errorMessage)
        {
            errorMessage = "";

            if (dt == null)
            {
                errorMessage = "Таблица равна NULL";
                return false;
            }

            if (dt.Rows.Count < 8 || dt.Columns.Count < 7)
            {
                errorMessage = "Неверная структура таблицы. Должно быть минимум 8 строк и 7 столбцов";
                return false;
            }

            for (int i = 6; i < dt.Rows.Count - 1; i++)
                if (!Decimal.TryParse(dt.Rows[i].Field<string>(5), out decimal _step))
                {
                    errorMessage = $"Строка {i-5} содержит неверный формат суммы";
                    return false;
                }

            return true;
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void saveTodbfToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveDbf(false);
        }

        private void saveTodbfcsvToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveDbf(true);
        }

        private void SaveDbf(bool isCSV)
        {
            if (_table1.Name == _table2.Name)
                nameTextBox2.Text = _table2.Name + "new";

            saveFileDialog.FileName = $"DBF_Editor_{_table1.Name}_{_table2.Name}";

            if (saveFileDialog.ShowDialog() == DialogResult.Cancel)
                return;

            string _pathToSave = saveFileDialog.FileName;

            if (Directory.Exists(_pathToSave))
                Directory.Delete(_pathToSave);
            else
                Directory.CreateDirectory(_pathToSave);

            SaveForm _saveForm = new SaveForm(_table1, _pathToSave, isCSV);
            _saveForm.ShowDialog();

            if (_table1.SaveResult)
            {
                _saveForm = new SaveForm(_table2, _pathToSave, isCSV);
                _saveForm.ShowDialog();

                if (_table2.SaveResult)
                {
                    toolStripStatusLabel1.Text = $"Файл сохранен {_pathToSave}";
                    Process.Start("explorer.exe", _pathToSave);
                }
            }
        }

        private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            About _aboutform = new About();
            _aboutform.ShowDialog();
        }

        private void solidSelectionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Settings.Default.SolidSelection = solidSelectionToolStripMenuItem.Checked;
            Settings.Default.Save();
        }
    }
}
