using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DBF_Editor
{
    class ButtonsPanel
    {
        public Button MoveBtn;
        public Button EditBtn;
        public Button CloneBtn;
        public Button DeleteBtn;
        
        public ButtonsPanel(Button moveBtn, Button editBtn, Button cloneBtn, Button deleteBtn)
        {
            MoveBtn = moveBtn;
            EditBtn = editBtn;
            CloneBtn = cloneBtn;
            DeleteBtn = deleteBtn;
        }
    }
}
