using Project_47.Properties;
using System.Drawing;
using System.Windows.Forms;

namespace Project_47.Forms.Controls
{
    public class GroupBoxInsert: GroupBox
    {
        private MenuStrip Button;
        private ToolStripMenuItem ButtonImage;

        private NewButton ButtonPaint;
        private NewButton ButtonDate;
        private NewButton ButtonObject;

        private MenuStrip ButtonList;
        private ToolStripMenuItem List;
        private NewToolStripMenuItem Image;
        private NewToolStripMenuItem ChangeImage;
        private NewToolStripMenuItem ResizeImage;
        public GroupBoxInsert()
        {
            Button = new MenuStrip() { BackColor = Color.White, ImageScalingSize = new Size(36, 36), AutoSize = false, Dock = DockStyle.None, Location = new Point(10, 10), Size = new Size(60, 45) };
            Button.Items.Add(ButtonImage = new ToolStripMenuItem(Resources.Image));

            ButtonList = new MenuStrip() { BackColor = Color.White, AutoSize = false, Dock = DockStyle.None, Location = new Point(10, 55), Size = new Size(60, 24) };
            ButtonList.Items.Add(List = new ToolStripMenuItem("Image"));

            List.DropDownItems.AddRange(new ToolStripItem[] {
                Image = new NewToolStripMenuItem("Image", Resources.Image_20x20)
                ,ChangeImage = new NewToolStripMenuItem("Change image", Resources.ChangeImage)
                ,ResizeImage = new NewToolStripMenuItem("Resize image", Resources.ChangeSizeImage)
            });


            ButtonPaint = new NewButton("Paint", Resources.Paint) { Location = new Point(70, 8) };
            ButtonDate = new NewButton("Date", Resources.Date) { Location = new Point(115, 8) };
            ButtonObject = new NewButton("Object", Resources.Object) { Location = new Point(160, 8) };

            Label label1 = new Label();
            label1.Text = "Insert";
            label1.Location = new Point(100, 80);
            label1.ForeColor = Color.Gray;

            Location = new Point(510, 0);
            Size = new Size(220, 105);
            Controls.Add(Button);
            Controls.Add(ButtonList);
            Controls.Add(ButtonPaint);
            Controls.Add(ButtonDate);
            Controls.Add(ButtonObject);
            Controls.Add(label1);
        }
    }
}
