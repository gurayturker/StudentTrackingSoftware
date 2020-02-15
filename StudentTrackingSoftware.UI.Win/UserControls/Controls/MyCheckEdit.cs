using DevExpress.XtraEditors;
using System.Drawing;
using StudentTrackingSoftware.UI.Win.Interfaces;
using System.ComponentModel;

namespace StudentTrackingSoftware.UI.Win.UserControls.Controls
{
    [ToolboxItem(true)]
    public class MyCheckEdit:CheckEdit,IStatusBarDescription
    {
        public MyCheckEdit()
        {
            Properties.AppearanceFocused.BackColor = Color.Transparent;
        }
        public override bool EnterMoveNextControl { get ; set ; }
        public string statusBarDescription { get ; set ; }
    }
}
