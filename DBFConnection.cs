using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DBF_Editor
{
    class DBFConnection
    {
        private string _fileName;
        private string _filePath;

        public DBFConnection(string fileName, string filePath)
        {
            _fileName = fileName;
            _filePath = filePath;
        }

        public DataTable GetDataTable()
        {
            string _connetionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + _filePath + ";Extended Properties=dBASE IV;";
            string _sqlCommand = "SELECT * FROM " + _fileName;

            try
            {
                DataTable _tempTable = new DataTable();

                using (OleDbConnection oleDbConnection = new OleDbConnection(_connetionString))
                {
                    OleDbCommand oleDbCommand = new OleDbCommand();
                    oleDbCommand.Connection = oleDbConnection;
                    oleDbCommand.CommandText = _sqlCommand;

                    using (OleDbDataAdapter oleDbDataAdapter = new OleDbDataAdapter(oleDbCommand))
                    {
                        oleDbDataAdapter.Fill(_tempTable);
                    }
                }

                return _tempTable;
            }
            catch (Exception e)
            {
                MessageBox.Show($"Ошибка при чтении файла {_filePath}\\{_fileName}", e.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

    }
}
