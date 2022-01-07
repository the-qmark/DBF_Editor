using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DBF_Editor
{
    public partial class SaveForm : Form
    {
        private Table _table;
        private string _path;
        private bool _isCSV;

        public SaveForm(Table table, string path, bool withCSV)
        {
            InitializeComponent();
            _table = table;
            _path = path;
            _isCSV = withCSV;
        }

        private Thread backgroundThread;

        private void SaveForm_Shown(object sender, EventArgs e)
        {
            this.Text = $"Обработка {_path}\\{_table.Name}.dbf";
            backgroundThread = new Thread(
                new ThreadStart(() =>
                {
                    _table.SaveResult = Save(_table, _path);
                }
                ));

            backgroundThread.Start();
            //MessageBox.Show("TEST");
        }

        private bool Save(Table table, string filePath)
        {
            string currentRow = "";
            var sb = new StringBuilder();
            try
            {
                DataTable dataTable = table.DataTable;
                string fileName = table.Name;

                ArrayList list = new ArrayList();

                if (Directory.Exists(filePath))
                    Directory.Delete(filePath);
                else
                    Directory.CreateDirectory(filePath);

                string createSql = "create table [" + fileName + "] (";

                foreach (DataColumn dc in dataTable.Columns)
                {
                    string fieldName = dc.ColumnName;
                    createSql = createSql + "[" + fieldName + "]" + " varchar(40),";
                    list.Add(fieldName);
                }

                createSql = createSql.Substring(0, createSql.Length - 1) + ")";

                string connetionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + filePath + "; Extended Properties=dBASE IV;";

                using (OleDbConnection con = new OleDbConnection(connetionString))
                {
                    OleDbCommand cmd = new OleDbCommand();
                    cmd.Connection = con;
                    cmd.CommandText = createSql;

                    con.Open();
                    cmd.CommandText = createSql;
                    cmd.ExecuteNonQuery();

                    DataTable temp = table.Header.Copy();
                    table.Footer.Rows[0][5] = table.TotalSum.ToString();
                    temp.Merge(dataTable);
                    temp.Merge(table.Footer);

                    progressBar1.BeginInvoke(
                            new Action(() =>
                            {
                                progressBar1.Value = 0;
                                progressBar1.Maximum = temp.Rows.Count + 1;
                            }
                        ));


                    int id = 0;
                    int rowsCount = temp.Rows.Count;
                    foreach (DataRow row in temp.Rows)
                    {
                        string insertSql = "insert into " + fileName + " values(";
                        currentRow = row.Field<string>(0);
                        for (int i = 0; i < list.Count; i++)
                            insertSql = insertSql + "'" + ReplaceEscape(row[list[i].ToString()].ToString()) + "',";

                        insertSql = insertSql.Substring(0, insertSql.Length - 1) + ")";
                        cmd.CommandText = insertSql;
                        cmd.ExecuteNonQuery();
                        id++;
                        //statusStrip1.Text = $"Обработано {id} строк из {temp.Rows.Count}...";
                        if (progressBar1.InvokeRequired)
                            progressBar1.BeginInvoke(
                            new Action(() =>
                            {
                                progressBar1.Value = id;
                            }
                        ));
                        if (label1.InvokeRequired)
                            label1.BeginInvoke(new Action(() =>
                            {
                                label1.Text = $"Обработано {id} строк из {rowsCount}...";
                            }
                        ));
                        //SetStatus($"Обработано {id} строк для {table.Name}.dbf...");
                    }


                    con.Close();
                }

                if (_isCSV)
                {
                    if (File.Exists(filePath + @"\" + fileName + ".csv"))
                        File.Delete(filePath + @"\" + fileName + ".csv");

                    using (StreamWriter sw = new StreamWriter(filePath + @"\" + fileName + ".csv", false, Encoding.UTF8))
                    {
                        DataTable dataTableCSV = table.DataTable;
                        foreach (DataRow r in dataTableCSV.Rows)
                        {
                            var line = String.Format("{0};{1};{2};{3};{4}", r[1].ToString(), r[2].ToString(), r[3].ToString(), r[4].ToString(), r[5].ToString());
                            sw.WriteLine(line);
                        }
                    }

                }

                //saveProgressForm.Close();
                if (this.InvokeRequired)
                    this.BeginInvoke(new Action(() =>
                    {
                        //table.SaveResult = true;
                        Close();
                    }
                ));

                return true;
            }
            catch (ThreadAbortException eff)
            {
                table.SaveResult = false;
                if (Directory.Exists(_path))
                    Directory.Delete(_path);
                return false;
            }
            catch (Exception e)
            {
                MessageBox.Show("Ошибка сохранения. ПОПРОБУЙТЕ ОТКЛЮЧИТЬ АНТИВИРУС И ПЕРЕЗАПУСТИТЬ ПРОГРАММУ.", e.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
                table.SaveResult = false;
                if (Directory.Exists(_path))
                    Directory.Delete(_path);
                return false;
            }

            //table.SaveResult = false;
        }

        public static string ReplaceEscape(string str)
        {
            str = str.Replace("'", "''");
            return str;
        }

        private void SetStatus(string status)
        {
            label1.Text = status;
        }

        private void SaveProgressForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            while (backgroundThread.IsAlive)
            {
                if (Directory.Exists(_path))
                    Directory.Delete(_path);
                backgroundThread.Abort();
            }
        }

        private void SaveProgressForm_FormClosed(object sender, FormClosedEventArgs e)
        {


        }

        private void abortSaveButton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Вы действительно хотите прервать операцию сохранения?", "Прервать операцию сохранения", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                Close();
        }

        private void SaveForm_Load(object sender, EventArgs e)
        {

        }
    }
}
