using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.BandedGrid;
using DevExpress.Utils;
using DevExpress.XtraEditors.Controls;
using StudentTrackingSoftware.UI.Win.Interfaces;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraEditors.Mask;
using DevExpress.XtraGrid.Views.Base;
using System.Drawing;
using System.ComponentModel;
using DevExpress.XtraGrid.Registrator;

namespace StudentTrackingSoftware.UI.Win.UserControls.Grids
{[ToolboxItem(true)]
    public class MyBandedGridControl : GridControl
    {
        protected override BaseView CreateDefaultView()
        {
            var view = (MyBandedGridView)CreateView("MyBandedGridView");

            view.Appearance.BandPanel.ForeColor = Color.DarkBlue;
            view.Appearance.BandPanel.Font = new Font(new FontFamily("Tahoma"), 8.25f, FontStyle.Bold);
            view.Appearance.BandPanel.TextOptions.HAlignment = HorzAlignment.Center;
            view.BandPanelRowHeight = 40;

            view.Appearance.ViewCaption.ForeColor = Color.Maroon;
            view.Appearance.HeaderPanel.ForeColor = Color.Maroon;
            view.Appearance.HeaderPanel.TextOptions.HAlignment = HorzAlignment.Center;

            view.Appearance.FooterPanel.ForeColor = Color.Maroon;
            view.Appearance.FooterPanel.Font = new Font(new FontFamily("Tahoma"), 8.25f, FontStyle.Bold);

            view.OptionsMenu.EnableColumnMenu = false;
            view.OptionsMenu.EnableFooterMenu = false;
            view.OptionsMenu.EnableGroupPanelMenu = false;

            view.OptionsNavigation.EnterMoveNextColumn = true;

            view.OptionsPrint.AutoWidth = false;
            view.OptionsPrint.PrintFooter = false;
            view.OptionsPrint.PrintGroupFooter = false;

            view.OptionsView.ShowAutoFilterRow = true;
            view.OptionsView.ShowViewCaption = true;
            view.OptionsView.ShowGroupPanel = false;
            view.OptionsView.ColumnAutoWidth = false;
            view.OptionsView.RowAutoHeight = true;
            view.OptionsView.HeaderFilterButtonShowMode = FilterButtonShowMode.Button;

            var columns = new[]
            {
                new BandedGridColumn()
                {
                     Caption = "ID",
                     FieldName = "id",
                     OptionsColumn = {AllowEdit=false,ShowInCustomizationForm=false}
                },
                new BandedGridColumn()
                {
                     Caption = "CODE",
                     FieldName = "code",
                     Visible = true,
                     OptionsColumn = {AllowEdit=false},
                     AppearanceCell ={ TextOptions = { HAlignment=HorzAlignment.Center }, Options = {   UseTextOptions=true } }
                }
            };
                view.Columns.AddRange(columns);
                return view;
        }
        protected override void RegisterAvailableViewsCore(InfoCollection collection)
        {
            base.RegisterAvailableViewsCore(collection);
            collection.Add(new MyBandedGridInfoRegistrator());
        }

        private class MyBandedGridInfoRegistrator : BandedGridInfoRegistrator
        {
            public override string ViewName => "MyBandedGridView";
            public override BaseView CreateView(GridControl grid) => new MyBandedGridView(grid);
            
            
        }
    }
    public class MyBandedGridView : BandedGridView, IStatusBarShortCut
    {
        public MyBandedGridView(){}

        public MyBandedGridView(GridControl ownerGrid) : base(ownerGrid){ }


        #region Properties
        public string statusBarShortCut { get; set; }
        public string statusBarShortCutDescription { get; set; }
        public string statusBarDescription { get; set; }
        #endregion
        protected override void OnColumnChangedCore(GridColumn column)
        {
            base.OnColumnChangedCore(column);
            if (column.ColumnEdit == null) return;
            if (column.ColumnEdit.GetType() == typeof(RepositoryItemDateEdit))
            {
                column.AppearanceCell.TextOptions.HAlignment =HorzAlignment.Center;
                ((RepositoryItemDateEdit)column.ColumnEdit).Mask.MaskType = MaskType.DateTimeAdvancingCaret;
            }
            
        }
        protected override GridColumnCollection CreateColumnCollection()
        {
            return new MyBandedGridColumnCollection(this);
        }

        private class MyBandedGridColumnCollection : BandedGridColumnCollection
        {
            public MyBandedGridColumnCollection(ColumnView view) : base(view) { }
            protected override GridColumn CreateColumn()
            {
                var column = new MyBandedGridColumn();
                column.OptionsColumn.AllowEdit = false;
                return column;
            }
        }
    }
    public class MyBandedGridColumn : BandedGridColumn, IStatusBarShortCut
    {
        #region Properties
        public string statusBarShortCut { get; set; }
        public string statusBarShortCutDescription { get; set; }
        public string statusBarDescription { get; set; } 
        #endregion
    }
}
