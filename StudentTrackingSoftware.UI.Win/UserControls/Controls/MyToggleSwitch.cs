using DevExpress.XtraEditors;
using DevExpress.Utils;
using System.Drawing;
using StudentTrackingSoftware.UI.Win.Interfaces;
using System.ComponentModel;

namespace StudentTrackingSoftware.UI.Win.UserControls.Controls
{[ToolboxItem(true)]
    public class MyToggleSwitch:ToggleSwitch,IStatusBarDescription
    {
        public MyToggleSwitch()
        {
            Name = "tgleCase";
            Properties.OffText = "Passive";
            Properties.OnText = "Active";
            Properties.AutoHeight = false;
            Properties.AutoWidth = true;
            Properties.GlyphAlignment = HorzAlignment.Far;
            Properties.Appearance.ForeColor = Color.Maroon;
        }
        public override bool EnterMoveNextControl { get ; set ; }
        public string statusBarDescription { get; set; } = "Select Card Case";
    }
}
