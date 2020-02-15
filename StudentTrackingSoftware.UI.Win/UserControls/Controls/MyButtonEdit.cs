using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using System.Drawing;
using System;
using System.ComponentModel;
using StudentTrackingSoftware.UI.Win.Interfaces;
 

namespace StudentTrackingSoftware.UI.Win.UserControls.Controls
{
    [ToolboxItem(true)]
    public class MyButtonEdit:ButtonEdit,IStatusBarShortCut
    {
       
        
        public MyButtonEdit()
        {
            Properties.TextEditStyle =TextEditStyles.DisableTextEditor;
            Properties.AppearanceFocused.BackColor = Color.LightCyan;
        }
        public override bool EnterMoveNextControl { get; set; } = true;
        public string statusBarDescription { get; set; }
        public string statusBarShortCut { get; set; } = "F4:";
        public string statusBarShortCutDescription { get; set; }
        #region Events
        private long? _id;


        [Browsable(false)]
        public long? ID
        {
            get => _id;
            set
            {
                var oldValue = _id;
                var newValue = value;
                if (newValue == oldValue) return;
                _id = value;
                IdChanged(this, new IdChangedEventArgs(oldValue, newValue));

            }
        }

        public event EventHandler<IdChangedEventArgs> IdChanged = delegate { }; 

        #endregion
    }
    public class IdChangedEventArgs : EventArgs
    {
        public IdChangedEventArgs(long? oldValue,long? newValue)
        {
           this.oldValue =oldValue;
           this.newValue = newValue;
        }
        public long? oldValue { get; }
        public long? newValue { get; }
    }
}
