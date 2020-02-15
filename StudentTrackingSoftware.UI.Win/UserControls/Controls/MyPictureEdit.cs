using DevExpress.XtraEditors;
using System.Drawing;
using DevExpress.XtraEditors.Controls;
using StudentTrackingSoftware.UI.Win.Interfaces;
using System.ComponentModel;

namespace StudentTrackingSoftware.UI.Win.UserControls.Controls
{
    [ToolboxItem(true)]
    public class MyPictureEdit:PictureEdit,IStatusBarShortCut
    {
        public MyPictureEdit()
        {
            Properties.AppearanceFocused.BackColor = Color.LightCyan;
            Properties.Appearance.ForeColor = Color.Maroon;
            Properties.NullText = "No Picture";
            Properties.SizeMode = PictureSizeMode.Stretch;
            Properties.ShowMenu = false;
        }
        public override bool EnterMoveNextControl { get ; set ; }
        public string statusBarShortCut { get; set; }
        public string statusBarShortCutDescription { get; set; }
        public string statusBarDescription { get; set; }
    }
}
