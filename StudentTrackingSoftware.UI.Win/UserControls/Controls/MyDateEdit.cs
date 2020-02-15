using System.Drawing;
using DevExpress.Utils;
using DevExpress.XtraEditors.Mask;
using System.ComponentModel;
using DevExpress.XtraEditors;
using StudentTrackingSoftware.UI.Win.Interfaces;

namespace StudentTrackingSoftware.UI.Win.UserControls.Controls
{
    [ToolboxItem(true)]
    public class MyDateEdit:DateEdit,IStatusBarShortCut
    {
        public MyDateEdit()
        {
            Properties.AppearanceFocused.BackColor = Color.LightCyan;
            Properties.AllowNullInput = DefaultBoolean.False;
            Properties.Appearance.TextOptions.HAlignment = HorzAlignment.Center;
            Properties.Mask.MaskType = MaskType.DateTimeAdvancingCaret;
        }
        public override bool EnterMoveNextControl { get; set; } = true;
        public string statusBarShortCut { get; set; } = "F4";
        public string statusBarShortCutDescription { get; set; } = "Enter Date";
        public string statusBarDescription { get; set; }
    }
}
