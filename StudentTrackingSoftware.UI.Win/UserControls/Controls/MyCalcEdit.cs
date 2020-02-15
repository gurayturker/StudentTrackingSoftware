using DevExpress.XtraEditors;
using System.Drawing;
using DevExpress.Utils;
using StudentTrackingSoftware.UI.Win.Interfaces;
using System.ComponentModel;

namespace StudentTrackingSoftware.UI.Win.UserControls.Controls
{
    [ToolboxItem(true)]
    public class MyCalcEdit:CalcEdit,IStatusBarShortCut
    {
        public MyCalcEdit()
        {
            Properties.AppearanceFocused.BackColor = Color.LightCyan;
            Properties.AllowNullInput = DefaultBoolean.False;
            Properties.EditMask = "n2";
        }
        public override bool EnterMoveNextControl { get; set; } = true;

        public string statusBarShortCut { get; set; } = "F4:";

        public string statusBarShortCutDescription { get; set; } = "Hesap Makinesi";

        public string statusBarDescription { get ; set ; }
    }
}
