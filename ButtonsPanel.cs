using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DBF_Editor
{
    public class ButtonsPanel
    {
        public ToolStripButton MoveBtn;
        public ToolStripButton EditBtn;
        public ToolStripButton CloneBtn;
        public ToolStripButton DeleteBtn;
        
        public ButtonsPanel(ToolStripButton moveBtn, ToolStripButton editBtn, ToolStripButton cloneBtn, ToolStripButton deleteBtn)
        {
            MoveBtn = moveBtn;
            EditBtn = editBtn;
            CloneBtn = cloneBtn;
            DeleteBtn = deleteBtn;
        }
    }
}
