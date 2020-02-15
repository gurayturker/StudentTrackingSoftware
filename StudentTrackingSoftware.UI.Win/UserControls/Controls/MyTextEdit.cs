﻿using DevExpress.XtraEditors;
using StudentTrackingSoftware.UI.Win.Interfaces;
using System.Drawing;
using System.ComponentModel;
namespace StudentTrackingSoftware.UI.Win.UserControls.Controls
{
    [ToolboxItem(true)]
    public class MyTextEdit:TextEdit,IStatusBarDescription
    {
        public MyTextEdit()
        {
            Properties.AppearanceFocused.BackColor = Color.LightCyan;
            Properties.MaxLength = 50;

        }
        public override bool EnterMoveNextControl { get; set; } = true;

        public string statusBarDescription { get ; set ; }

        
    }
}
