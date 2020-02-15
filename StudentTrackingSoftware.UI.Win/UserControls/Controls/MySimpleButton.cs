using DevExpress.XtraEditors;
using StudentTrackingSoftware.UI.Win.Interfaces;
using System.Drawing;
using System.ComponentModel;

namespace StudentTrackingSoftware.UI.Win.UserControls.Controls
{
    [ToolboxItem(true)]
    class MySimpleButton:SimpleButton,IStatusBarDescription
    {
        public MySimpleButton()
        {
            Appearance.ForeColor = Color.Maroon;
        }

        public string statusBarDescription { get; set ; }
    }
}
