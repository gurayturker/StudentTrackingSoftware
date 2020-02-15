namespace StudentTrackingSoftware.UI.Win.Forms.SchoolForms
{
    partial class SchoolCards
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.grid = new StudentTrackingSoftware.UI.Win.UserControls.Grids.MyGridControl();
            this.colid = new StudentTrackingSoftware.UI.Win.UserControls.Grids.MyGridColumn();
            this.colcode = new StudentTrackingSoftware.UI.Win.UserControls.Grids.MyGridColumn();
            this.longNavigator1 = new StudentTrackingSoftware.UI.Win.UserControls.Navigators.LongNavigator();
            this.colSchoolName = new StudentTrackingSoftware.UI.Win.UserControls.Grids.MyGridColumn();
            this.colCityName = new StudentTrackingSoftware.UI.Win.UserControls.Grids.MyGridColumn();
            this.colDistrictName = new StudentTrackingSoftware.UI.Win.UserControls.Grids.MyGridColumn();
            this.colDescription = new StudentTrackingSoftware.UI.Win.UserControls.Grids.MyGridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablo)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonControl
            // 
            this.ribbonControl.ExpandCollapseItem.Id = 0;
            this.ribbonControl.Size = new System.Drawing.Size(891, 102);
            this.ribbonControl.Toolbar.ShowCustomizeItem = false;
            // 
            // grid
            // 
            this.grid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grid.Location = new System.Drawing.Point(0, 102);
            this.grid.MainView = this.tablo;
            this.grid.MenuManager = this.ribbonControl;
            this.grid.Name = "grid";
            this.grid.Size = new System.Drawing.Size(891, 342);
            this.grid.TabIndex = 2;
            this.grid.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.tablo});
            // 
            // tablo
            // 
            this.tablo.Appearance.FooterPanel.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.tablo.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Maroon;
            this.tablo.Appearance.FooterPanel.Options.UseFont = true;
            this.tablo.Appearance.FooterPanel.Options.UseForeColor = true;
            this.tablo.Appearance.FooterPanel.Options.UseTextOptions = true;
            this.tablo.Appearance.FooterPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.tablo.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Maroon;
            this.tablo.Appearance.HeaderPanel.Options.UseForeColor = true;
            this.tablo.Appearance.HeaderPanel.Options.UseTextOptions = true;
            this.tablo.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.tablo.Appearance.ViewCaption.ForeColor = System.Drawing.Color.Maroon;
            this.tablo.Appearance.ViewCaption.Options.UseForeColor = true;
            this.tablo.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colid,
            this.colcode,
            this.colSchoolName,
            this.colCityName,
            this.colDistrictName,
            this.colDescription});
            this.tablo.GridControl = this.grid;
            this.tablo.Name = "tablo";
            this.tablo.OptionsMenu.EnableColumnMenu = false;
            this.tablo.OptionsMenu.EnableFooterMenu = false;
            this.tablo.OptionsMenu.EnableGroupPanelMenu = false;
            this.tablo.OptionsNavigation.EnterMoveNextColumn = true;
            this.tablo.OptionsPrint.AutoWidth = false;
            this.tablo.OptionsPrint.PrintFooter = false;
            this.tablo.OptionsPrint.PrintGroupFooter = false;
            this.tablo.OptionsView.ColumnAutoWidth = false;
            this.tablo.OptionsView.HeaderFilterButtonShowMode = DevExpress.XtraEditors.Controls.FilterButtonShowMode.Button;
            this.tablo.OptionsView.RowAutoHeight = true;
            this.tablo.OptionsView.ShowAutoFilterRow = true;
            this.tablo.OptionsView.ShowGroupPanel = false;
            this.tablo.OptionsView.ShowViewCaption = true;
            this.tablo.statusBarDescription = null;
            this.tablo.statusBarShortCut = null;
            this.tablo.statusBarShortCutDescription = null;
            this.tablo.ViewCaption = "School Cards";
            // 
            // colid
            // 
            this.colid.Caption = "ID";
            this.colid.FieldName = "id";
            this.colid.Name = "colid";
            this.colid.OptionsColumn.AllowEdit = false;
            this.colid.OptionsColumn.ShowInCustomizationForm = false;
            this.colid.statusBarDescription = null;
            this.colid.statusBarShortCut = null;
            this.colid.statusBarShortCutDescription = null;
            // 
            // colcode
            // 
            this.colcode.AppearanceCell.Options.UseTextOptions = true;
            this.colcode.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colcode.Caption = "Code";
            this.colcode.FieldName = "code";
            this.colcode.Name = "colcode";
            this.colcode.OptionsColumn.AllowEdit = false;
            this.colcode.statusBarDescription = null;
            this.colcode.statusBarShortCut = null;
            this.colcode.statusBarShortCutDescription = null;
            this.colcode.Visible = true;
            this.colcode.VisibleIndex = 0;
            this.colcode.Width = 130;
            // 
            // longNavigator1
            // 
            this.longNavigator1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.longNavigator1.Location = new System.Drawing.Point(0, 444);
            this.longNavigator1.Name = "longNavigator1";
            this.longNavigator1.Size = new System.Drawing.Size(891, 24);
            this.longNavigator1.TabIndex = 3;
            // 
            // colSchoolName
            // 
            this.colSchoolName.Caption = "School Name";
            this.colSchoolName.FieldName = "SchoolName";
            this.colSchoolName.Name = "colSchoolName";
            this.colSchoolName.OptionsColumn.AllowEdit = false;
            this.colSchoolName.statusBarDescription = null;
            this.colSchoolName.statusBarShortCut = null;
            this.colSchoolName.statusBarShortCutDescription = null;
            this.colSchoolName.Visible = true;
            this.colSchoolName.VisibleIndex = 1;
            this.colSchoolName.Width = 260;
            // 
            // colCityName
            // 
            this.colCityName.Caption = "City";
            this.colCityName.FieldName = "CityName";
            this.colCityName.Name = "colCityName";
            this.colCityName.OptionsColumn.AllowEdit = false;
            this.colCityName.statusBarDescription = null;
            this.colCityName.statusBarShortCut = null;
            this.colCityName.statusBarShortCutDescription = null;
            this.colCityName.Visible = true;
            this.colCityName.VisibleIndex = 2;
            this.colCityName.Width = 130;
            // 
            // colDistrictName
            // 
            this.colDistrictName.Caption = "District";
            this.colDistrictName.FieldName = "DistrictName";
            this.colDistrictName.Name = "colDistrictName";
            this.colDistrictName.OptionsColumn.AllowEdit = false;
            this.colDistrictName.statusBarDescription = null;
            this.colDistrictName.statusBarShortCut = null;
            this.colDistrictName.statusBarShortCutDescription = null;
            this.colDistrictName.Visible = true;
            this.colDistrictName.VisibleIndex = 3;
            this.colDistrictName.Width = 130;
            // 
            // colDescription
            // 
            this.colDescription.Caption = "Description";
            this.colDescription.FieldName = "Description";
            this.colDescription.Name = "colDescription";
            this.colDescription.OptionsColumn.AllowEdit = false;
            this.colDescription.statusBarDescription = null;
            this.colDescription.statusBarShortCut = null;
            this.colDescription.statusBarShortCutDescription = null;
            this.colDescription.Visible = true;
            this.colDescription.VisibleIndex = 4;
            this.colDescription.Width = 450;
            // 
            // SchoolCards
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(891, 495);
            this.Controls.Add(this.grid);
            this.Controls.Add(this.longNavigator1);
            this.Name = "SchoolCards";
            this.Text = " School Cards";
            this.Controls.SetChildIndex(this.ribbonControl, 0);
            this.Controls.SetChildIndex(this.longNavigator1, 0);
            this.Controls.SetChildIndex(this.grid, 0);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private UserControls.Grids.MyGridControl grid;
        private UserControls.Grids.MyGridView myGridView1;
        private UserControls.Grids.MyGridColumn colid;
        private UserControls.Grids.MyGridColumn colcode;
        private UserControls.Grids.MyGridView tablo;
        private UserControls.Navigators.LongNavigator longNavigator1;
        private UserControls.Grids.MyGridColumn colSchoolName;
        private UserControls.Grids.MyGridColumn colCityName;
        private UserControls.Grids.MyGridColumn colDistrictName;
        private UserControls.Grids.MyGridColumn colDescription;
    }
}