using DevExpress.XtraEditors;
using StudentTrackingSoftware.UI.Win.Interfaces;
using System.ComponentModel;

namespace StudentTrackingSoftware.UI.Win.UserControls.Controls
{
    public class MyFilterControl:FilterControl,IStatusBarDescription
    {
        [ToolboxItem(true)]
        public MyFilterControl()
        {
            ShowGroupCommandsIcon = true;
        }

        public string statusBarDescription { get; set; } = "Enter Filter Text";

    }
}
