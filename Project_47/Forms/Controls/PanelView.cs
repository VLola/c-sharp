using System.Drawing;
using System.Windows.Forms;

namespace Project_47.Forms.Controls
{
    public class PanelView: Panel
    {
        public GroupBoxScale boxScale = new GroupBoxScale();
        public GroupBoxShowOrHide boxShowOrHide = new GroupBoxShowOrHide();
        public GroupBoxParameters boxParameters = new GroupBoxParameters();
        public PanelView()
        {
            Location = new Point(0, 18);
            Size = new Size(1060, 105);
            Anchor = AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top;
            BackColor = Color.White;

            Controls.Add(boxScale);
            Controls.Add(boxShowOrHide);
            Controls.Add(boxParameters);
        }
    }
}
