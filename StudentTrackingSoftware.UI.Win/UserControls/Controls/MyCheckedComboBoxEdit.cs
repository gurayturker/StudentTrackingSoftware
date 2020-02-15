using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using StudentTrackingSoftware.UI.Win.Interfaces;
using System.Drawing;
using System.ComponentModel;

namespace StudentTrackingSoftware.UI.Win.UserControls.Controls
{
    [ToolboxItem(true)]
    public class MyCheckedComboBoxEdit:CheckedComboBoxEdit,IStatusBarShortCut
    {
        public MyCheckedComboBoxEdit()
        {

            Properties.AppearanceFocused.BackColor = Color.LightCyan;
            Properties.TextEditStyle = TextEditStyles.DisableTextEditor;
        }
        public override bool EnterMoveNextControl { get ; set ; }
        public string statusBarShortCut { get; set; } = "F4";
        public string statusBarShortCutDescription { get; set; }
        public string statusBarDescription { get; set; }
    }
}
