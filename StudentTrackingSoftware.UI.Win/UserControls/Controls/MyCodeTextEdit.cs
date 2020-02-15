using System.Drawing;
using DevExpress.Utils;
using System.ComponentModel;

namespace StudentTrackingSoftware.UI.Win.UserControls.Controls
{
    [ToolboxItem(true)]
    public  class MyCodeTextEdit:MyTextEdit
    {
        public MyCodeTextEdit()
        {
            Properties.Appearance.BackColor = Color.PaleGoldenrod;
            Properties.Appearance.TextOptions.HAlignment = HorzAlignment.Center;
            Properties.MaxLength = 20;
            statusBarDescription = "Enter Code";    
        }
    }
}
