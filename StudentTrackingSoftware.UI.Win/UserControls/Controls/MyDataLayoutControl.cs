﻿using DevExpress.XtraDataLayout;
using DevExpress.XtraLayout;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using DevExpress.XtraLayout.Utils;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.ComponentModel;

namespace StudentTrackingSoftware.UI.Win.UserControls.Controls
{
    [ToolboxItem(true)]
    public class MyDataLayoutControl:DataLayoutControl
    {
        public MyDataLayoutControl()
        {
            OptionsFocus.EnableAutoTabOrder = false;

        }
        protected override LayoutControlImplementor CreateILayoutControlImplementorCore()
        {
            return new MyLayoutControlImplementor(this);
        }
    }

    internal class MyLayoutControlImplementor : LayoutControlImplementor
    {
        public MyLayoutControlImplementor(ILayoutControlOwner owner) : base(owner)
        {
        }
        public override BaseLayoutItem CreateLayoutItem(LayoutGroup parent)
        {
            var item= base.CreateLayoutItem(parent);
            item.AppearanceItemCaption.ForeColor = Color.Maroon;
            return item;
        }
        public override LayoutGroup CreateLayoutGroup(LayoutGroup parent)
        {
            var group= base.CreateLayoutGroup(parent);
            group.LayoutMode = LayoutMode.Table;
            group.OptionsTableLayoutGroup.ColumnDefinitions[0].SizeType = SizeType.Absolute;
            group.OptionsTableLayoutGroup.ColumnDefinitions[0].Width = 200;
            group.OptionsTableLayoutGroup.ColumnDefinitions[1].SizeType = SizeType.Percent;
            group.OptionsTableLayoutGroup.ColumnDefinitions[1].Width = 100;
            group.OptionsTableLayoutGroup.ColumnDefinitions.Add(new ColumnDefinition { SizeType = SizeType.Absolute, Width = 110 });
            group.OptionsTableLayoutGroup.RowDefinitions.Clear();
            for (int i = 0; i < 9; i++)
            {
                group.OptionsTableLayoutGroup.RowDefinitions.Add(new RowDefinition
                {
                    SizeType=SizeType.Absolute,
                    Height=24

                });
                if (i + 1 != 9) continue;
                group.OptionsTableLayoutGroup.RowDefinitions.Add(new RowDefinition {
                    SizeType = SizeType.Percent,
                    Height = 100  


                });
                
            }



            return group;
        }
    }
}
