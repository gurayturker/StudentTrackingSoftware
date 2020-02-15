using DevExpress.XtraEditors;
using System.Drawing;
using DevExpress.Utils;
using StudentTrackingSoftware.UI.Win.Interfaces;
using System.ComponentModel;

namespace StudentTrackingSoftware.UI.Win.UserControls.Controls
{[ToolboxItem(true)]
    public class MySpinEdit:SpinEdit,IStatusBarDescription
    {
        public MySpinEdit()
        {
            Properties.AppearanceFocused.BackColor = Color.LightCyan;
            Properties.AllowNullInput = DefaultBoolean.False;
            Properties.EditMask = "d";
        }
        public override bool EnterMoveNextControl { get; set; } = true;
        public string statusBarDescription { get ; set ; }
    }
}
