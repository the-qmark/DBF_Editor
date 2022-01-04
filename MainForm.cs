using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
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

        private ButtonsPanel _buttonsPanel1;
        private InfoPanel _infoPanel1;
        private Table _table1;
       


        private void MainForm_Load(object sender, EventArgs e)
        {
            #region системные настройки
            var myCulture = (CultureInfo)new CultureInfo("ru-RU").Clone();
            myCulture.NumberFormat.NumberDecimalSeparator = ".";
            Thread.CurrentThread.CurrentCulture = myCulture;
            #endregion

            _buttonsPanel1 = new ButtonsPanel(moveButton1, editButton1, cloneButton1, deleteButton1);
            _infoPanel1 = new InfoPanel(nameTextBox1, totalSumLabel1, totalRowsLabel1, selectedSumAndRowsLabel1);
            _table1 = new Table(_buttonsPanel1, _infoPanel1, dataGridView1);
        }

        private void открытьdbfToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.Cancel)
                return;

            string _fileName = Path.GetFileNameWithoutExtension(openFileDialog.FileName);
            string _filePath = Path.GetDirectoryName(openFileDialog.FileName);

            DBFConnection _dbfConnection = new DBFConnection(_fileName, _filePath);

            DataTable _tempTable = _dbfConnection.GetDataTable();

            if (CheckValid(_tempTable) == false)
            {
                MessageBox.Show($"Ошибка сруктуры таблицы", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            _table1.GetDataFrom(_tempTable);
        }

        private bool CheckValid(DataTable dt)
        {
            if (dt == null)
                return false;

            if (dt.Rows.Count < 8 || dt.Columns.Count < 7)
                return false;

            if (!Decimal.TryParse(dt.Rows[6].Field<string>(5), out decimal _step))
                return false;

            return true;
        }
    }
}
