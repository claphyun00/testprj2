namespace DEMO_FORM2DATA
{
    partial class Form1
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
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.GrdMain = new DevExpress.XtraGrid.GridControl();
            this.GrvMain = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repBte01 = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.colName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDescript = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUserId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUseYN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.BtnQuery = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton3 = new DevExpress.XtraEditors.SimpleButton();
            this.dteWDate = new DevExpress.XtraEditors.DateEdit();
            this.txtCd = new DevExpress.XtraEditors.TextEdit();
            this.imageComboBoxEdit1 = new DevExpress.XtraEditors.ImageComboBoxEdit();
            this.txtFrm2CD = new DevExpress.XtraEditors.TextEdit();
            this.txtFrm2NM = new DevExpress.XtraEditors.TextEdit();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem6 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem7 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem8 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem9 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GrdMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GrvMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repBte01)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteWDate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteWDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCd.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageComboBoxEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFrm2CD.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFrm2NM.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem9)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.GrdMain);
            this.layoutControl1.Controls.Add(this.BtnQuery);
            this.layoutControl1.Controls.Add(this.simpleButton2);
            this.layoutControl1.Controls.Add(this.simpleButton3);
            this.layoutControl1.Controls.Add(this.dteWDate);
            this.layoutControl1.Controls.Add(this.txtCd);
            this.layoutControl1.Controls.Add(this.imageComboBoxEdit1);
            this.layoutControl1.Controls.Add(this.txtFrm2CD);
            this.layoutControl1.Controls.Add(this.txtFrm2NM);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.Root;
            this.layoutControl1.Size = new System.Drawing.Size(766, 780);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // GrdMain
            // 
            this.GrdMain.Location = new System.Drawing.Point(12, 179);
            this.GrdMain.MainView = this.GrvMain;
            this.GrdMain.Name = "GrdMain";
            this.GrdMain.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repBte01});
            this.GrdMain.Size = new System.Drawing.Size(742, 589);
            this.GrdMain.TabIndex = 7;
            this.GrdMain.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.GrvMain});
            // 
            // GrvMain
            // 
            this.GrvMain.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colNo,
            this.colCode,
            this.colName,
            this.colDescript,
            this.colDate,
            this.colUserId,
            this.colUseYN});
            this.GrvMain.GridControl = this.GrdMain;
            this.GrvMain.Name = "GrvMain";
            this.GrvMain.OptionsView.ShowGroupPanel = false;
            // 
            // colNo
            // 
            this.colNo.Caption = "NO";
            this.colNo.FieldName = "NO";
            this.colNo.Name = "colNo";
            this.colNo.Visible = true;
            this.colNo.VisibleIndex = 0;
            // 
            // colCode
            // 
            this.colCode.Caption = "CODE";
            this.colCode.ColumnEdit = this.repBte01;
            this.colCode.FieldName = "CODE";
            this.colCode.Name = "colCode";
            this.colCode.Visible = true;
            this.colCode.VisibleIndex = 1;
            // 
            // repBte01
            // 
            this.repBte01.AutoHeight = false;
            this.repBte01.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.repBte01.Name = "repBte01";
            // 
            // colName
            // 
            this.colName.Caption = "NAME";
            this.colName.FieldName = "NAME";
            this.colName.Name = "colName";
            this.colName.Visible = true;
            this.colName.VisibleIndex = 2;
            // 
            // colDescript
            // 
            this.colDescript.Caption = "DECRIPT";
            this.colDescript.FieldName = "DECRIPT";
            this.colDescript.Name = "colDescript";
            this.colDescript.Visible = true;
            this.colDescript.VisibleIndex = 3;
            // 
            // colDate
            // 
            this.colDate.Caption = "DATE";
            this.colDate.FieldName = "DATE";
            this.colDate.Name = "colDate";
            this.colDate.Visible = true;
            this.colDate.VisibleIndex = 4;
            // 
            // colUserId
            // 
            this.colUserId.Caption = "USERID";
            this.colUserId.FieldName = "USERID";
            this.colUserId.Name = "colUserId";
            this.colUserId.Visible = true;
            this.colUserId.VisibleIndex = 5;
            // 
            // colUseYN
            // 
            this.colUseYN.Caption = "USEYN";
            this.colUseYN.FieldName = "USEYN";
            this.colUseYN.Name = "colUseYN";
            this.colUseYN.Visible = true;
            this.colUseYN.VisibleIndex = 6;
            // 
            // BtnQuery
            // 
            this.BtnQuery.Location = new System.Drawing.Point(220, 45);
            this.BtnQuery.Name = "BtnQuery";
            this.BtnQuery.Size = new System.Drawing.Size(160, 22);
            this.BtnQuery.StyleController = this.layoutControl1;
            this.BtnQuery.TabIndex = 4;
            this.BtnQuery.Text = "조회";
            //this.BtnQuery.Click += new System.EventHandler(this.BtnQuery_Click);
            // 
            // simpleButton2
            // 
            this.simpleButton2.Location = new System.Drawing.Point(384, 45);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(177, 22);
            this.simpleButton2.StyleController = this.layoutControl1;
            this.simpleButton2.TabIndex = 5;
            this.simpleButton2.Text = "임시1";
            // 
            // simpleButton3
            // 
            this.simpleButton3.Location = new System.Drawing.Point(565, 45);
            this.simpleButton3.Name = "simpleButton3";
            this.simpleButton3.Size = new System.Drawing.Size(177, 22);
            this.simpleButton3.StyleController = this.layoutControl1;
            this.simpleButton3.TabIndex = 6;
            this.simpleButton3.Text = "임시2";
            // 
            // dteWDate
            // 
            this.dteWDate.EditValue = null;
            this.dteWDate.Location = new System.Drawing.Point(461, 71);
            this.dteWDate.Name = "dteWDate";
            this.dteWDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dteWDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dteWDate.Size = new System.Drawing.Size(281, 20);
            this.dteWDate.StyleController = this.layoutControl1;
            this.dteWDate.TabIndex = 8;
            // 
            // txtCd
            // 
            this.txtCd.Location = new System.Drawing.Point(101, 71);
            this.txtCd.Name = "txtCd";
            this.txtCd.Size = new System.Drawing.Size(279, 20);
            this.txtCd.StyleController = this.layoutControl1;
            this.txtCd.TabIndex = 9;
            // 
            // imageComboBoxEdit1
            // 
            this.imageComboBoxEdit1.Location = new System.Drawing.Point(101, 95);
            this.imageComboBoxEdit1.Name = "imageComboBoxEdit1";
            this.imageComboBoxEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.imageComboBoxEdit1.Size = new System.Drawing.Size(641, 20);
            this.imageComboBoxEdit1.StyleController = this.layoutControl1;
            this.imageComboBoxEdit1.TabIndex = 10;
            // 
            // txtFrm2CD
            // 
            this.txtFrm2CD.Location = new System.Drawing.Point(101, 119);
            this.txtFrm2CD.Name = "txtFrm2CD";
            this.txtFrm2CD.Size = new System.Drawing.Size(641, 20);
            this.txtFrm2CD.StyleController = this.layoutControl1;
            this.txtFrm2CD.TabIndex = 11;
            // 
            // txtFrm2NM
            // 
            this.txtFrm2NM.Location = new System.Drawing.Point(101, 143);
            this.txtFrm2NM.Name = "txtFrm2NM";
            this.txtFrm2NM.Size = new System.Drawing.Size(641, 20);
            this.txtFrm2NM.StyleController = this.layoutControl1;
            this.txtFrm2NM.TabIndex = 12;
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem4,
            this.layoutControlGroup1});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(766, 780);
            this.Root.TextVisible = false;
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.GrdMain;
            this.layoutControlItem4.Location = new System.Drawing.Point(0, 167);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(746, 593);
            this.layoutControlItem4.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem4.TextVisible = false;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.emptySpaceItem1,
            this.layoutControlItem1,
            this.layoutControlItem2,
            this.layoutControlItem3,
            this.layoutControlItem6,
            this.layoutControlItem5,
            this.layoutControlItem7,
            this.layoutControlItem8,
            this.layoutControlItem9});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Size = new System.Drawing.Size(746, 167);
            this.layoutControlGroup1.Text = "Condition";
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.Location = new System.Drawing.Point(0, 0);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(196, 26);
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.BtnQuery;
            this.layoutControlItem1.Location = new System.Drawing.Point(196, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(164, 26);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.simpleButton2;
            this.layoutControlItem2.Location = new System.Drawing.Point(360, 0);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(181, 26);
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextVisible = false;
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.simpleButton3;
            this.layoutControlItem3.Location = new System.Drawing.Point(541, 0);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(181, 26);
            this.layoutControlItem3.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem3.TextVisible = false;
            // 
            // layoutControlItem6
            // 
            this.layoutControlItem6.Control = this.txtCd;
            this.layoutControlItem6.Location = new System.Drawing.Point(0, 26);
            this.layoutControlItem6.Name = "layoutControlItem6";
            this.layoutControlItem6.Size = new System.Drawing.Size(360, 24);
            this.layoutControlItem6.Text = "UserId";
            this.layoutControlItem6.TextSize = new System.Drawing.Size(65, 14);
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this.dteWDate;
            this.layoutControlItem5.Location = new System.Drawing.Point(360, 26);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Size = new System.Drawing.Size(362, 24);
            this.layoutControlItem5.Text = "Date";
            this.layoutControlItem5.TextSize = new System.Drawing.Size(65, 14);
            // 
            // layoutControlItem7
            // 
            this.layoutControlItem7.Control = this.imageComboBoxEdit1;
            this.layoutControlItem7.Location = new System.Drawing.Point(0, 50);
            this.layoutControlItem7.Name = "layoutControlItem7";
            this.layoutControlItem7.Size = new System.Drawing.Size(722, 24);
            this.layoutControlItem7.Text = "Code";
            this.layoutControlItem7.TextSize = new System.Drawing.Size(65, 14);
            // 
            // layoutControlItem8
            // 
            this.layoutControlItem8.Control = this.txtFrm2CD;
            this.layoutControlItem8.Location = new System.Drawing.Point(0, 74);
            this.layoutControlItem8.Name = "layoutControlItem8";
            this.layoutControlItem8.Size = new System.Drawing.Size(722, 24);
            this.layoutControlItem8.Text = "Form2Code";
            this.layoutControlItem8.TextSize = new System.Drawing.Size(65, 14);
            // 
            // layoutControlItem9
            // 
            this.layoutControlItem9.Control = this.txtFrm2NM;
            this.layoutControlItem9.Location = new System.Drawing.Point(0, 98);
            this.layoutControlItem9.Name = "layoutControlItem9";
            this.layoutControlItem9.Size = new System.Drawing.Size(722, 24);
            this.layoutControlItem9.Text = "Form2Name";
            this.layoutControlItem9.TextSize = new System.Drawing.Size(65, 14);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(766, 780);
            this.Controls.Add(this.layoutControl1);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GrdMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GrvMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repBte01)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteWDate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteWDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCd.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageComboBoxEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFrm2CD.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFrm2NM.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem9)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraGrid.GridControl GrdMain;
        private DevExpress.XtraGrid.Views.Grid.GridView GrvMain;
        private DevExpress.XtraEditors.SimpleButton BtnQuery;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private DevExpress.XtraEditors.SimpleButton simpleButton3;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraEditors.DateEdit dteWDate;
        private DevExpress.XtraEditors.TextEdit txtCd;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem6;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
        private DevExpress.XtraEditors.ImageComboBoxEdit imageComboBoxEdit1;
        private DevExpress.XtraEditors.TextEdit txtFrm2CD;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem7;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem8;
        private DevExpress.XtraEditors.TextEdit txtFrm2NM;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem9;
        private DevExpress.XtraGrid.Columns.GridColumn colNo;
        private DevExpress.XtraGrid.Columns.GridColumn colCode;
        private DevExpress.XtraGrid.Columns.GridColumn colName;
        private DevExpress.XtraGrid.Columns.GridColumn colDescript;
        private DevExpress.XtraGrid.Columns.GridColumn colDate;
        private DevExpress.XtraGrid.Columns.GridColumn colUserId;
        private DevExpress.XtraGrid.Columns.GridColumn colUseYN;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit repBte01;
    }
}

