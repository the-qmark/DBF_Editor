using System;
using System.Collections.Generic;
using System.Linq;
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
        
        public InfoPanel(TextBox nameTextBox, Label totalSumLabel, Label totalRowsLabel, Label selectedLabel)
        {
            NameTextBox = nameTextBox;
            TotalSumLabel = totalSumLabel;
            TotalRowsLabel = totalRowsLabel;
            SelectedLabel = selectedLabel;
        }
    }
}
