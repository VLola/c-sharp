using System.Windows.Forms;

namespace Project_46.Forms.Controls
{
    public class NewMenu:MenuStrip
    {
        public ToolStripMenuItem File;
        public ToolStripMenuItem New;
        public ToolStripMenuItem Open;
        public ToolStripMenuItem Close;
        public ToolStripMenuItem CloseAll;
        public ToolStripMenuItem Save;
        public ToolStripMenuItem SaveAll;
        public ToolStripMenuItem SaveAs;
        public NewMenu(Form1 form)
        {
            Items.AddRange(new ToolStripItem[] { File = new ToolStripMenuItem("File") });

            File.DropDownItems.AddRange(new ToolStripItem[] {
                New = new ToolStripMenuItem("New"),
                Open = new ToolStripMenuItem("Open"),
                Close = new ToolStripMenuItem("Close"),
                CloseAll = new ToolStripMenuItem("Close All"),
                Save = new ToolStripMenuItem("Save"),
                SaveAll = new ToolStripMenuItem("Save All"),
                SaveAs = new ToolStripMenuItem("Save As") });
            
            form.Controls.Add(this);
        }
    }
}
