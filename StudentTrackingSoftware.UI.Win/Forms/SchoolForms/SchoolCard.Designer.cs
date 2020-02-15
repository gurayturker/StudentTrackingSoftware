namespace StudentTrackingSoftware.UI.Win.Forms.SchoolForms
{
    partial class SchoolCard
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
            DevExpress.XtraLayout.ColumnDefinition columnDefinition1 = new DevExpress.XtraLayout.ColumnDefinition();
            DevExpress.XtraLayout.ColumnDefinition columnDefinition2 = new DevExpress.XtraLayout.ColumnDefinition();
            DevExpress.XtraLayout.ColumnDefinition columnDefinition3 = new DevExpress.XtraLayout.ColumnDefinition();
            DevExpress.XtraLayout.RowDefinition rowDefinition1 = new DevExpress.XtraLayout.RowDefinition();
            DevExpress.XtraLayout.RowDefinition rowDefinition2 = new DevExpress.XtraLayout.RowDefinition();
            DevExpress.XtraLayout.RowDefinition rowDefinition3 = new DevExpress.XtraLayout.RowDefinition();
            DevExpress.XtraLayout.RowDefinition rowDefinition4 = new DevExpress.XtraLayout.RowDefinition();
            DevExpress.XtraLayout.RowDefinition rowDefinition5 = new DevExpress.XtraLayout.RowDefinition();
            this.myDataLayoutControl = new StudentTrackingSoftware.UI.Win.UserControls.Controls.MyDataLayoutControl();
            this.memoEditDescription = new StudentTrackingSoftware.UI.Win.UserControls.Controls.MyMemoEdit();
            this.TgleCase = new StudentTrackingSoftware.UI.Win.UserControls.Controls.MyToggleSwitch();
            this.btnEditDistrict = new StudentTrackingSoftware.UI.Win.UserControls.Controls.MyButtonEdit();
            this.btnEditCity = new StudentTrackingSoftware.UI.Win.UserControls.Controls.MyButtonEdit();
            this.txtSchoolName = new StudentTrackingSoftware.UI.Win.UserControls.Controls.MyTextEdit();
            this.txtCode = new StudentTrackingSoftware.UI.Win.UserControls.Controls.MyCodeTextEdit();
            this.layoutControlGroup = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem6 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.myDataLayoutControl)).BeginInit();
            this.myDataLayoutControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.memoEditDescription.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TgleCase.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnEditDistrict.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnEditCity.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSchoolName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCode.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonControl
            // 
            this.ribbonControl.ExpandCollapseItem.Id = 0;
            this.ribbonControl.Size = new System.Drawing.Size(390, 102);
            this.ribbonControl.Toolbar.ShowCustomizeItem = false;
            // 
            // myDataLayoutControl
            // 
            this.myDataLayoutControl.Controls.Add(this.memoEditDescription);
            this.myDataLayoutControl.Controls.Add(this.TgleCase);
            this.myDataLayoutControl.Controls.Add(this.btnEditDistrict);
            this.myDataLayoutControl.Controls.Add(this.btnEditCity);
            this.myDataLayoutControl.Controls.Add(this.txtSchoolName);
            this.myDataLayoutControl.Controls.Add(this.txtCode);
            this.myDataLayoutControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.myDataLayoutControl.Location = new System.Drawing.Point(0, 102);
            this.myDataLayoutControl.Name = "myDataLayoutControl";
            this.myDataLayoutControl.OptionsFocus.EnableAutoTabOrder = false;
            this.myDataLayoutControl.Root = this.layoutControlGroup;
            this.myDataLayoutControl.Size = new System.Drawing.Size(390, 170);
            this.myDataLayoutControl.TabIndex = 2;
            this.myDataLayoutControl.Text = "myDataLayoutControl1";
            // 
            // memoEditDescription
            // 
            this.memoEditDescription.EnterMoveNextControl = true;
            this.memoEditDescription.Location = new System.Drawing.Point(83, 108);
            this.memoEditDescription.MenuManager = this.ribbonControl;
            this.memoEditDescription.Name = "memoEditDescription";
            this.memoEditDescription.Properties.AppearanceFocused.BackColor = System.Drawing.Color.LightCyan;
            this.memoEditDescription.Properties.AppearanceFocused.Options.UseBackColor = true;
            this.memoEditDescription.Properties.MaxLength = 500;
            this.memoEditDescription.Size = new System.Drawing.Size(295, 50);
            this.memoEditDescription.statusBarDescription = "Enter Description";
            this.memoEditDescription.StyleController = this.myDataLayoutControl;
            this.memoEditDescription.TabIndex = 9;
            // 
            // TgleCase
            // 
            this.TgleCase.Location = new System.Drawing.Point(272, 12);
            this.TgleCase.MenuManager = this.ribbonControl;
            this.TgleCase.Name = "TgleCase";
            this.TgleCase.Properties.Appearance.ForeColor = System.Drawing.Color.Maroon;
            this.TgleCase.Properties.Appearance.Options.UseForeColor = true;
            this.TgleCase.Properties.AutoHeight = false;
            this.TgleCase.Properties.AutoWidth = true;
            this.TgleCase.Properties.GlyphAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.TgleCase.Properties.OffText = "Passive";
            this.TgleCase.Properties.OnText = "Active";
            this.TgleCase.Size = new System.Drawing.Size(109, 20);
            this.TgleCase.statusBarDescription = "Select Card Case";
            this.TgleCase.StyleController = this.myDataLayoutControl;
            this.TgleCase.TabIndex = 8;
            // 
            // btnEditDistrict
            // 
            this.btnEditDistrict.EnterMoveNextControl = true;
            this.btnEditDistrict.ID = null;
            this.btnEditDistrict.Location = new System.Drawing.Point(83, 84);
            this.btnEditDistrict.MenuManager = this.ribbonControl;
            this.btnEditDistrict.Name = "btnEditDistrict";
            this.btnEditDistrict.Properties.AppearanceFocused.BackColor = System.Drawing.Color.LightCyan;
            this.btnEditDistrict.Properties.AppearanceFocused.Options.UseBackColor = true;
            this.btnEditDistrict.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.btnEditDistrict.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.btnEditDistrict.Size = new System.Drawing.Size(125, 20);
            this.btnEditDistrict.statusBarDescription = null;
            this.btnEditDistrict.statusBarShortCut = "F4:";
            this.btnEditDistrict.statusBarShortCutDescription = null;
            this.btnEditDistrict.StyleController = this.myDataLayoutControl;
            this.btnEditDistrict.TabIndex = 7;
            // 
            // btnEditCity
            // 
            this.btnEditCity.EnterMoveNextControl = true;
            this.btnEditCity.ID = null;
            this.btnEditCity.Location = new System.Drawing.Point(83, 60);
            this.btnEditCity.MenuManager = this.ribbonControl;
            this.btnEditCity.Name = "btnEditCity";
            this.btnEditCity.Properties.AppearanceFocused.BackColor = System.Drawing.Color.LightCyan;
            this.btnEditCity.Properties.AppearanceFocused.Options.UseBackColor = true;
            this.btnEditCity.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.btnEditCity.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.btnEditCity.Size = new System.Drawing.Size(125, 20);
            this.btnEditCity.statusBarDescription = null;
            this.btnEditCity.statusBarShortCut = "F4:";
            this.btnEditCity.statusBarShortCutDescription = null;
            this.btnEditCity.StyleController = this.myDataLayoutControl;
            this.btnEditCity.TabIndex = 6;
            // 
            // txtSchoolName
            // 
            this.txtSchoolName.EnterMoveNextControl = true;
            this.txtSchoolName.Location = new System.Drawing.Point(83, 36);
            this.txtSchoolName.MenuManager = this.ribbonControl;
            this.txtSchoolName.Name = "txtSchoolName";
            this.txtSchoolName.Properties.AppearanceFocused.BackColor = System.Drawing.Color.LightCyan;
            this.txtSchoolName.Properties.AppearanceFocused.Options.UseBackColor = true;
            this.txtSchoolName.Properties.MaxLength = 50;
            this.txtSchoolName.Size = new System.Drawing.Size(295, 20);
            this.txtSchoolName.statusBarDescription = null;
            this.txtSchoolName.StyleController = this.myDataLayoutControl;
            this.txtSchoolName.TabIndex = 5;
            // 
            // txtCode
            // 
            this.txtCode.EnterMoveNextControl = true;
            this.txtCode.Location = new System.Drawing.Point(83, 12);
            this.txtCode.MenuManager = this.ribbonControl;
            this.txtCode.Name = "txtCode";
            this.txtCode.Properties.Appearance.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.txtCode.Properties.Appearance.Options.UseBackColor = true;
            this.txtCode.Properties.Appearance.Options.UseTextOptions = true;
            this.txtCode.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.txtCode.Properties.AppearanceFocused.BackColor = System.Drawing.Color.LightCyan;
            this.txtCode.Properties.AppearanceFocused.Options.UseBackColor = true;
            this.txtCode.Properties.MaxLength = 20;
            this.txtCode.Size = new System.Drawing.Size(125, 20);
            this.txtCode.statusBarDescription = "Enter Code";
            this.txtCode.StyleController = this.myDataLayoutControl;
            this.txtCode.TabIndex = 4;
            // 
            // layoutControlGroup
            // 
            this.layoutControlGroup.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup.GroupBordersVisible = false;
            this.layoutControlGroup.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlItem2,
            this.layoutControlItem3,
            this.layoutControlItem4,
            this.layoutControlItem5,
            this.layoutControlItem6});
            this.layoutControlGroup.LayoutMode = DevExpress.XtraLayout.Utils.LayoutMode.Table;
            this.layoutControlGroup.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup.Name = "layoutControlGroup";
            columnDefinition1.SizeType = System.Windows.Forms.SizeType.Absolute;
            columnDefinition1.Width = 200D;
            columnDefinition2.SizeType = System.Windows.Forms.SizeType.Percent;
            columnDefinition2.Width = 100D;
            columnDefinition3.SizeType = System.Windows.Forms.SizeType.Absolute;
            columnDefinition3.Width = 110D;
            this.layoutControlGroup.OptionsTableLayoutGroup.ColumnDefinitions.AddRange(new DevExpress.XtraLayout.ColumnDefinition[] {
            columnDefinition1,
            columnDefinition2,
            columnDefinition3});
            rowDefinition1.Height = 24D;
            rowDefinition1.SizeType = System.Windows.Forms.SizeType.Absolute;
            rowDefinition2.Height = 24D;
            rowDefinition2.SizeType = System.Windows.Forms.SizeType.Absolute;
            rowDefinition3.Height = 24D;
            rowDefinition3.SizeType = System.Windows.Forms.SizeType.Absolute;
            rowDefinition4.Height = 24D;
            rowDefinition4.SizeType = System.Windows.Forms.SizeType.Absolute;
            rowDefinition5.Height = 100D;
            rowDefinition5.SizeType = System.Windows.Forms.SizeType.Percent;
            this.layoutControlGroup.OptionsTableLayoutGroup.RowDefinitions.AddRange(new DevExpress.XtraLayout.RowDefinition[] {
            rowDefinition1,
            rowDefinition2,
            rowDefinition3,
            rowDefinition4,
            rowDefinition5});
            this.layoutControlGroup.Size = new System.Drawing.Size(390, 170);
            this.layoutControlGroup.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.AppearanceItemCaption.ForeColor = System.Drawing.Color.Maroon;
            this.layoutControlItem1.AppearanceItemCaption.Options.UseForeColor = true;
            this.layoutControlItem1.Control = this.txtCode;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(200, 24);
            this.layoutControlItem1.Text = "Code";
            this.layoutControlItem1.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.CustomSize;
            this.layoutControlItem1.TextSize = new System.Drawing.Size(61, 13);
            this.layoutControlItem1.TextToControlDistance = 10;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.AppearanceItemCaption.ForeColor = System.Drawing.Color.Maroon;
            this.layoutControlItem2.AppearanceItemCaption.Options.UseForeColor = true;
            this.layoutControlItem2.Control = this.txtSchoolName;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 24);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.OptionsTableLayoutItem.ColumnSpan = 3;
            this.layoutControlItem2.OptionsTableLayoutItem.RowIndex = 1;
            this.layoutControlItem2.Size = new System.Drawing.Size(370, 24);
            this.layoutControlItem2.Text = "School Name";
            this.layoutControlItem2.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.CustomSize;
            this.layoutControlItem2.TextSize = new System.Drawing.Size(61, 13);
            this.layoutControlItem2.TextToControlDistance = 10;
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.AppearanceItemCaption.ForeColor = System.Drawing.Color.Maroon;
            this.layoutControlItem3.AppearanceItemCaption.Options.UseForeColor = true;
            this.layoutControlItem3.Control = this.btnEditCity;
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 48);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.OptionsTableLayoutItem.RowIndex = 2;
            this.layoutControlItem3.Size = new System.Drawing.Size(200, 24);
            this.layoutControlItem3.Text = "City";
            this.layoutControlItem3.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.CustomSize;
            this.layoutControlItem3.TextSize = new System.Drawing.Size(61, 13);
            this.layoutControlItem3.TextToControlDistance = 10;
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.AppearanceItemCaption.ForeColor = System.Drawing.Color.Maroon;
            this.layoutControlItem4.AppearanceItemCaption.Options.UseForeColor = true;
            this.layoutControlItem4.Control = this.btnEditDistrict;
            this.layoutControlItem4.Location = new System.Drawing.Point(0, 72);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.OptionsTableLayoutItem.RowIndex = 3;
            this.layoutControlItem4.Size = new System.Drawing.Size(200, 24);
            this.layoutControlItem4.Text = "District";
            this.layoutControlItem4.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.CustomSize;
            this.layoutControlItem4.TextSize = new System.Drawing.Size(61, 13);
            this.layoutControlItem4.TextToControlDistance = 10;
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.AppearanceItemCaption.ForeColor = System.Drawing.Color.Maroon;
            this.layoutControlItem5.AppearanceItemCaption.Options.UseForeColor = true;
            this.layoutControlItem5.Control = this.TgleCase;
            this.layoutControlItem5.Location = new System.Drawing.Point(260, 0);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.OptionsTableLayoutItem.ColumnIndex = 2;
            this.layoutControlItem5.Size = new System.Drawing.Size(110, 24);
            this.layoutControlItem5.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem5.TextVisible = false;
            // 
            // layoutControlItem6
            // 
            this.layoutControlItem6.AppearanceItemCaption.ForeColor = System.Drawing.Color.Maroon;
            this.layoutControlItem6.AppearanceItemCaption.Options.UseForeColor = true;
            this.layoutControlItem6.Control = this.memoEditDescription;
            this.layoutControlItem6.Location = new System.Drawing.Point(0, 96);
            this.layoutControlItem6.Name = "layoutControlItem6";
            this.layoutControlItem6.OptionsTableLayoutItem.ColumnSpan = 3;
            this.layoutControlItem6.OptionsTableLayoutItem.RowIndex = 4;
            this.layoutControlItem6.Size = new System.Drawing.Size(370, 54);
            this.layoutControlItem6.Text = "Description";
            this.layoutControlItem6.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.CustomSize;
            this.layoutControlItem6.TextSize = new System.Drawing.Size(61, 13);
            this.layoutControlItem6.TextToControlDistance = 10;
            // 
            // SchoolCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(390, 299);
            this.Controls.Add(this.myDataLayoutControl);
            this.MinimumSize = new System.Drawing.Size(400, 300);
            this.Name = "SchoolCard";
            this.Text = "School Card";
            this.Controls.SetChildIndex(this.ribbonControl, 0);
            this.Controls.SetChildIndex(this.myDataLayoutControl, 0);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.myDataLayoutControl)).EndInit();
            this.myDataLayoutControl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.memoEditDescription.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TgleCase.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnEditDistrict.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnEditCity.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSchoolName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCode.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private UserControls.Controls.MyDataLayoutControl myDataLayoutControl;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup;
        private UserControls.Controls.MyMemoEdit memoEditDescription;
        private UserControls.Controls.MyToggleSwitch TgleCase;
        private UserControls.Controls.MyButtonEdit btnEditDistrict;
        private UserControls.Controls.MyButtonEdit btnEditCity;
        private UserControls.Controls.MyTextEdit txtSchoolName;
        private UserControls.Controls.MyCodeTextEdit txtCode;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem6;
    }
}