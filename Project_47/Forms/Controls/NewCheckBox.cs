using System.Drawing;
using System.Windows.Forms;

namespace Project_47.Forms.Controls
{
    public class NewCheckBox: CheckBox
    {
        public NewCheckBox(Image image)
        {
            BackColor = Color.White;
            Image = image;
            AutoSize = false;
            Size = new Size(24, 24);
            Appearance = Appearance.Button;
            FlatStyle = FlatStyle.Standard;
            BackgroundImage = image;
            BackgroundImageLayout = ImageLayout.Center;

        }
    }
}
