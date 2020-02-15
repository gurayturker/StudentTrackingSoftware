using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraEditors.Mask;
using StudentTrackingSoftware.UI.Win.Interfaces;
using DevExpress.XtraEditors.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DevExpress.Utils;
using System.Threading.Tasks;
using System.Drawing;
using DevExpress.XtraGrid.Views.Base;
using System.ComponentModel;
using DevExpress.XtraGrid.Registrator;

namespace StudentTrackingSoftware.UI.Win.UserControls.Grids
{
    [ToolboxItem(true)]
    public class MyGridControl:GridControl
    {
        protected override BaseView CreateDefaultView()
        {
            var view = (GridView)CreateView("MyGridView");
            view.Appearance.ViewCaption.ForeColor = Color.Maroon;
            view.Appearance.HeaderPanel.ForeColor = Color.Maroon;
            view.Appearance.HeaderPanel.TextOptions.HAlignment = HorzAlignment.Center;
            view.Appearance.FooterPanel.ForeColor = Color.Maroon;
            view.Appearance.FooterPanel.Font = new Font(new FontFamily("Tahoma"), 8.25f, FontStyle.Bold);
            view.Appearance.FooterPanel.TextOptions.HAlignment = HorzAlignment.Center;

            view.OptionsMenu.EnableColumnMenu = false;
            view.OptionsMenu.EnableFooterMenu = false;
            view.OptionsMenu.EnableGroupPanelMenu = false;

            view.OptionsNavigation.EnterMoveNextColumn = true;

            view.OptionsPrint.AutoWidth = false;
            view.OptionsPrint.PrintFooter = false;
            view.OptionsPrint.PrintGroupFooter = false;

            view.OptionsView.ShowViewCaption = true;
            view.OptionsView.ShowAutoFilterRow = true;
            view.OptionsView.ShowGroupPanel = false;
            view.OptionsView.ColumnAutoWidth = false;
            view.OptionsView.RowAutoHeight = true;
            view.OptionsView.HeaderFilterButtonShowMode =FilterButtonShowMode.Button;

            var idColumn = new MyGridColumn
            {
                Caption = "ID",
                FieldName = "id"
            };
            idColumn.OptionsColumn.AllowEdit = false;
            idColumn.OptionsColumn.ShowInCustomizationForm = false;
            view.Columns.Add(idColumn);

            var codeColumn = new MyGridColumn
            {
                Caption = "Code",
                FieldName = "code"
            };
            codeColumn.OptionsColumn.AllowEdit = false;
            codeColumn.Visible = true;
            codeColumn.AppearanceCell.TextOptions.HAlignment = HorzAlignment.Center;
            codeColumn.AppearanceCell.Options.UseTextOptions = true;
            view.Columns.Add(codeColumn);

            return view;
        }
        protected override void RegisterAvailableViewsCore(InfoCollection collection)
        {
            base.RegisterAvailableViewsCore(collection);
            collection.Add(new MyGridInfoRegistrator());
        }

        private class MyGridInfoRegistrator : GridInfoRegistrator
        {
            public override string ViewName => "MyGridView";
            public override BaseView CreateView(GridControl grid)=> new MyGridView(grid);
            
        }
    }
    public class MyGridView : GridView, IStatusBarShortCut
    {
  
        #region Properties
        public string statusBarShortCut { get; set; }

        public string statusBarShortCutDescription { get; set; }

        public string statusBarDescription { get; set; }
        #endregion
    

        public MyGridView(GridControl ownerGrid) : base(ownerGrid) { }

        protected override void OnColumnChangedCore(GridColumn column)
        {
            base.OnColumnChangedCore(column);
            if (column.ColumnEdit == null) return;
            if(column.ColumnEdit.GetType()==typeof(RepositoryItemDateEdit))
            {
                column.AppearanceCell.TextOptions.HAlignment = HorzAlignment.Center;
                ((RepositoryItemDateEdit)column.ColumnEdit).Mask.MaskType = MaskType.DateTimeAdvancingCaret;
            }
        }
        protected override GridColumnCollection CreateColumnCollection()
        {
            return new MyGridColumnCollection(this);
        }

        private class MyGridColumnCollection : GridColumnCollection
        {
            public MyGridColumnCollection(ColumnView view) : base(view){ }
            protected override GridColumn CreateColumn()
            {
                var column = new MyGridColumn();
                column.OptionsColumn.AllowEdit = false;
                return column;
            }
        }
    }
    public class MyGridColumn : GridColumn, IStatusBarShortCut
    {
        #region Properties
        public string statusBarShortCut { get; set; }

        public string statusBarShortCutDescription { get; set; }

        public string statusBarDescription { get; set; } 
        #endregion
    }
}
