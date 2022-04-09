using Project_47;
using System;
using System.Windows.Forms;

namespace Project_46.Forms.Controls
{
    public class NewMenu:MenuStrip
    {
        public ToolStripMenuItem File;

        public ToolStripMenuItem New;
        public ToolStripMenuItem Open;
        public ToolStripMenuItem Save;
        public ToolStripMenuItem SaveAll;
        public ToolStripMenuItem SaveAs;
        public ToolStripMenuItem Print;

        public NewMenu(Form1 form)
        {
            Items.AddRange(new ToolStripItem[] { File = new ToolStripMenuItem("File") });

            File.DropDownItems.AddRange(new ToolStripItem[] {
                New = new ToolStripMenuItem("New")
                ,Open = new ToolStripMenuItem("Open")
                ,Save = new ToolStripMenuItem("Save")
                ,SaveAll = new ToolStripMenuItem("Save All")
                ,SaveAs = new ToolStripMenuItem("Save As")
                ,Print = new ToolStripMenuItem("Print") 
            });
            form.Controls.Add(this);

        }
    }
}
