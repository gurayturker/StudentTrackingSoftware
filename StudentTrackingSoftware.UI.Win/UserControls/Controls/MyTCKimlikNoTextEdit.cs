using DevExpress.Utils;
using DevExpress.XtraEditors.Mask;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace StudentTrackingSoftware.UI.Win.UserControls.Controls
{
    [ToolboxItem(true)]
   public class MyTCKimlikNoTextEdit:MyTextEdit
    {
        public MyTCKimlikNoTextEdit()
        {
            Properties.Appearance.TextOptions.HAlignment =HorzAlignment.Center;
            Properties.Mask.MaskType =MaskType.Regular;
            Properties.Mask.EditMask = @"\d?\d?\d?\d?\d?\d?\d?\d?\d?\d?\d?";
            Properties.Mask.AutoComplete = AutoCompleteType.None;
            statusBarDescription = "Enter TC Kimlik No";
        }
        
    }
}
