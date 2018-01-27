namespace schedule.mainPanelControls {
    partial class PanelJoin {
        /// <summary> 
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            Telerik.WinControls.UI.TableViewDefinition tableViewDefinition1 = new Telerik.WinControls.UI.TableViewDefinition();
            Telerik.WinControls.UI.GridViewRelation gridViewRelation1 = new Telerik.WinControls.UI.GridViewRelation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PanelJoin));
            this.radGridView2 = new Telerik.WinControls.UI.RadGridView();
            this.radDropDownList1 = new Telerik.WinControls.UI.RadDropDownList();
            this.radPanel1 = new Telerik.WinControls.UI.RadPanel();
            this.radPanel2 = new Telerik.WinControls.UI.RadPanel();
            this.radBindingNavigator1 = new Telerik.WinControls.UI.RadBindingNavigator();
            this.radBindingNavigator1RowElement = new Telerik.WinControls.UI.CommandBarRowElement();
            this.radBindingNavigator1FirstStrip = new Telerik.WinControls.UI.CommandBarStripElement();
            this.commandBarSeparator1 = new Telerik.WinControls.UI.CommandBarSeparator();
            this.commandBarSeparator2 = new Telerik.WinControls.UI.CommandBarSeparator();
            this.radBindingNavigator1PositionItem = new Telerik.WinControls.UI.CommandBarTextBox();
            this.radBindingNavigator1CountItem = new Telerik.WinControls.UI.CommandBarLabel();
            this.commandBarSeparator3 = new Telerik.WinControls.UI.CommandBarSeparator();
            this.commandBarSeparator4 = new Telerik.WinControls.UI.CommandBarSeparator();
            this.radBindingNavigator1SecondStrip = new Telerik.WinControls.UI.CommandBarStripElement();
            this.commandBarSeparator5 = new Telerik.WinControls.UI.CommandBarSeparator();
            this.header = new Telerik.WinControls.UI.RadLabel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.radBindingNavigator1MoveFirstItem = new Telerik.WinControls.UI.CommandBarButton();
            this.radBindingNavigator1MovePreviousItem = new Telerik.WinControls.UI.CommandBarButton();
            this.radBindingNavigator1MoveNextItem = new Telerik.WinControls.UI.CommandBarButton();
            this.radBindingNavigator1MoveLastItem = new Telerik.WinControls.UI.CommandBarButton();
            this.radBindingNavigator1AddNewItem = new Telerik.WinControls.UI.CommandBarButton();
            this.radBindingNavigator1DeleteItem = new Telerik.WinControls.UI.CommandBarButton();
            this.closePanel = new Telerik.WinControls.UI.RadButton();
            ((System.ComponentModel.ISupportInitialize)(this.radGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGridView2.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radDropDownList1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radPanel1)).BeginInit();
            this.radPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radPanel2)).BeginInit();
            this.radPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radBindingNavigator1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.header)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.closePanel)).BeginInit();
            this.SuspendLayout();
            // 
            // radGridView2
            // 
            this.radGridView2.Location = new System.Drawing.Point(12, 67);
            // 
            // 
            // 
            this.radGridView2.MasterTemplate.AddNewRowPosition = Telerik.WinControls.UI.SystemRowPosition.Bottom;
            this.radGridView2.MasterTemplate.EnableGrouping = false;
            this.radGridView2.MasterTemplate.ViewDefinition = tableViewDefinition1;
            this.radGridView2.Name = "radGridView2";
            gridViewRelation1.ChildColumnNames = ((System.Collections.Specialized.StringCollection)(resources.GetObject("gridViewRelation1.ChildColumnNames")));
            gridViewRelation1.ParentColumnNames = ((System.Collections.Specialized.StringCollection)(resources.GetObject("gridViewRelation1.ParentColumnNames")));
            this.radGridView2.Relations.AddRange(new Telerik.WinControls.UI.GridViewRelation[] {
            gridViewRelation1});
            this.radGridView2.Size = new System.Drawing.Size(456, 600);
            this.radGridView2.TabIndex = 1;
            this.radGridView2.Text = "radGridView2";
            this.radGridView2.ThemeName = "Material";
            this.radGridView2.Validated += new System.EventHandler(this.radGridView2_Validated);
            // 
            // radDropDownList1
            // 
            this.radDropDownList1.DisplayMember = "name_specialty";
            this.radDropDownList1.Location = new System.Drawing.Point(12, 16);
            this.radDropDownList1.Name = "radDropDownList1";
            this.radDropDownList1.Size = new System.Drawing.Size(456, 36);
            this.radDropDownList1.TabIndex = 2;
            this.radDropDownList1.ThemeName = "Material";
            this.radDropDownList1.ValueMember = "name_specialty";
            // 
            // radPanel1
            // 
            this.radPanel1.Controls.Add(this.radPanel2);
            this.radPanel1.Controls.Add(this.radBindingNavigator1);
            this.radPanel1.Controls.Add(this.closePanel);
            this.radPanel1.Controls.Add(this.header);
            this.radPanel1.Location = new System.Drawing.Point(3, 13);
            this.radPanel1.Name = "radPanel1";
            this.radPanel1.Size = new System.Drawing.Size(500, 807);
            this.radPanel1.TabIndex = 3;
            this.radPanel1.ThemeName = "Material";
            this.radPanel1.Initialized += new System.EventHandler(this.radPanel1_Initialized);
            // 
            // radPanel2
            // 
            this.radPanel2.Controls.Add(this.radDropDownList1);
            this.radPanel2.Controls.Add(this.radGridView2);
            this.radPanel2.Location = new System.Drawing.Point(10, 57);
            this.radPanel2.Name = "radPanel2";
            this.radPanel2.Size = new System.Drawing.Size(480, 692);
            this.radPanel2.TabIndex = 10;
            this.radPanel2.ThemeName = "Material";
            // 
            // radBindingNavigator1
            // 
            this.radBindingNavigator1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.radBindingNavigator1.Location = new System.Drawing.Point(0, 759);
            this.radBindingNavigator1.Name = "radBindingNavigator1";
            this.radBindingNavigator1.Rows.AddRange(new Telerik.WinControls.UI.CommandBarRowElement[] {
            this.radBindingNavigator1RowElement});
            this.radBindingNavigator1.Size = new System.Drawing.Size(500, 48);
            this.radBindingNavigator1.TabIndex = 9;
            this.radBindingNavigator1.Text = "radBindingNavigator1";
            this.radBindingNavigator1.ThemeName = "Material";
            // 
            // radBindingNavigator1RowElement
            // 
            this.radBindingNavigator1RowElement.MinSize = new System.Drawing.Size(25, 25);
            this.radBindingNavigator1RowElement.Strips.AddRange(new Telerik.WinControls.UI.CommandBarStripElement[] {
            this.radBindingNavigator1FirstStrip,
            this.radBindingNavigator1SecondStrip});
            // 
            // radBindingNavigator1FirstStrip
            // 
            this.radBindingNavigator1FirstStrip.DisplayName = "radBindingNavigator1FirstStrip";
            this.radBindingNavigator1FirstStrip.EnableDragging = false;
            // 
            // 
            // 
            this.radBindingNavigator1FirstStrip.Grip.Visibility = Telerik.WinControls.ElementVisibility.Collapsed;
            this.radBindingNavigator1FirstStrip.Items.AddRange(new Telerik.WinControls.UI.RadCommandBarBaseItem[] {
            this.radBindingNavigator1MoveFirstItem,
            this.commandBarSeparator1,
            this.radBindingNavigator1MovePreviousItem,
            this.commandBarSeparator2,
            this.radBindingNavigator1PositionItem,
            this.radBindingNavigator1CountItem,
            this.commandBarSeparator3,
            this.radBindingNavigator1MoveNextItem,
            this.commandBarSeparator4,
            this.radBindingNavigator1MoveLastItem});
            this.radBindingNavigator1FirstStrip.MinSize = new System.Drawing.Size(0, 0);
            // 
            // 
            // 
            this.radBindingNavigator1FirstStrip.OverflowButton.Visibility = Telerik.WinControls.ElementVisibility.Collapsed;
            ((Telerik.WinControls.UI.RadCommandBarGrip)(this.radBindingNavigator1FirstStrip.GetChildAt(0))).Visibility = Telerik.WinControls.ElementVisibility.Collapsed;
            ((Telerik.WinControls.UI.RadCommandBarOverflowButton)(this.radBindingNavigator1FirstStrip.GetChildAt(2))).Visibility = Telerik.WinControls.ElementVisibility.Collapsed;
            // 
            // commandBarSeparator1
            // 
            this.commandBarSeparator1.Name = "commandBarSeparator1";
            this.commandBarSeparator1.VisibleInOverflowMenu = false;
            // 
            // commandBarSeparator2
            // 
            this.commandBarSeparator2.Name = "commandBarSeparator2";
            this.commandBarSeparator2.VisibleInOverflowMenu = false;
            // 
            // radBindingNavigator1PositionItem
            // 
            this.radBindingNavigator1PositionItem.Name = "radBindingNavigator1PositionItem";
            // 
            // radBindingNavigator1CountItem
            // 
            this.radBindingNavigator1CountItem.Name = "radBindingNavigator1CountItem";
            this.radBindingNavigator1CountItem.Text = "of {0}";
            // 
            // commandBarSeparator3
            // 
            this.commandBarSeparator3.Name = "commandBarSeparator3";
            this.commandBarSeparator3.VisibleInOverflowMenu = false;
            // 
            // commandBarSeparator4
            // 
            this.commandBarSeparator4.Name = "commandBarSeparator4";
            this.commandBarSeparator4.VisibleInOverflowMenu = false;
            // 
            // radBindingNavigator1SecondStrip
            // 
            this.radBindingNavigator1SecondStrip.DisplayName = "radBindingNavigator1SecondStrip";
            this.radBindingNavigator1SecondStrip.EnableDragging = false;
            // 
            // 
            // 
            this.radBindingNavigator1SecondStrip.Grip.Visibility = Telerik.WinControls.ElementVisibility.Collapsed;
            this.radBindingNavigator1SecondStrip.Items.AddRange(new Telerik.WinControls.UI.RadCommandBarBaseItem[] {
            this.radBindingNavigator1AddNewItem,
            this.commandBarSeparator5,
            this.radBindingNavigator1DeleteItem});
            this.radBindingNavigator1SecondStrip.MinSize = new System.Drawing.Size(0, 0);
            // 
            // 
            // 
            this.radBindingNavigator1SecondStrip.OverflowButton.Visibility = Telerik.WinControls.ElementVisibility.Collapsed;
            ((Telerik.WinControls.UI.RadCommandBarGrip)(this.radBindingNavigator1SecondStrip.GetChildAt(0))).Visibility = Telerik.WinControls.ElementVisibility.Collapsed;
            ((Telerik.WinControls.UI.RadCommandBarOverflowButton)(this.radBindingNavigator1SecondStrip.GetChildAt(2))).Visibility = Telerik.WinControls.ElementVisibility.Collapsed;
            // 
            // commandBarSeparator5
            // 
            this.commandBarSeparator5.Name = "commandBarSeparator5";
            this.commandBarSeparator5.VisibleInOverflowMenu = false;
            // 
            // header
            // 
            this.header.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.header.ForeColor = System.Drawing.Color.Gray;
            this.header.Location = new System.Drawing.Point(10, 10);
            this.header.Name = "header";
            this.header.Size = new System.Drawing.Size(156, 38);
            this.header.TabIndex = 6;
            this.header.Text = "Кабинеты";
            this.header.ThemeName = "Material";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 5;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Interval = 5;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // radBindingNavigator1MoveFirstItem
            // 
            this.radBindingNavigator1MoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("radBindingNavigator1MoveFirstItem.Image")));
            this.radBindingNavigator1MoveFirstItem.Margin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.radBindingNavigator1MoveFirstItem.Name = "radBindingNavigator1MoveFirstItem";
            // 
            // radBindingNavigator1MovePreviousItem
            // 
            this.radBindingNavigator1MovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("radBindingNavigator1MovePreviousItem.Image")));
            this.radBindingNavigator1MovePreviousItem.Name = "radBindingNavigator1MovePreviousItem";
            // 
            // radBindingNavigator1MoveNextItem
            // 
            this.radBindingNavigator1MoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("radBindingNavigator1MoveNextItem.Image")));
            this.radBindingNavigator1MoveNextItem.Name = "radBindingNavigator1MoveNextItem";
            // 
            // radBindingNavigator1MoveLastItem
            // 
            this.radBindingNavigator1MoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("radBindingNavigator1MoveLastItem.Image")));
            this.radBindingNavigator1MoveLastItem.Name = "radBindingNavigator1MoveLastItem";
            // 
            // radBindingNavigator1AddNewItem
            // 
            this.radBindingNavigator1AddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("radBindingNavigator1AddNewItem.Image")));
            this.radBindingNavigator1AddNewItem.Margin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.radBindingNavigator1AddNewItem.Name = "radBindingNavigator1AddNewItem";
            // 
            // radBindingNavigator1DeleteItem
            // 
            this.radBindingNavigator1DeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("radBindingNavigator1DeleteItem.Image")));
            this.radBindingNavigator1DeleteItem.Name = "radBindingNavigator1DeleteItem";
            // 
            // closePanel
            // 
            this.closePanel.BackColor = System.Drawing.Color.Transparent;
            this.closePanel.BackgroundImage = global::schedule.Properties.Resources.close2;
            this.closePanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.closePanel.DisplayStyle = Telerik.WinControls.DisplayStyle.Image;
            this.closePanel.ForeColor = System.Drawing.Color.Transparent;
            this.closePanel.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.closePanel.ImeMode = System.Windows.Forms.ImeMode.Close;
            this.closePanel.Location = new System.Drawing.Point(454, 10);
            this.closePanel.Name = "closePanel";
            this.closePanel.Size = new System.Drawing.Size(36, 36);
            this.closePanel.TabIndex = 7;
            this.closePanel.ThemeName = "Material";
            this.closePanel.Click += new System.EventHandler(this.closePanel_Click);
            // 
            // PanelJoin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.radPanel1);
            this.Name = "PanelJoin";
            this.Size = new System.Drawing.Size(503, 837);
            ((System.ComponentModel.ISupportInitialize)(this.radGridView2.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radDropDownList1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radPanel1)).EndInit();
            this.radPanel1.ResumeLayout(false);
            this.radPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radPanel2)).EndInit();
            this.radPanel2.ResumeLayout(false);
            this.radPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radBindingNavigator1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.header)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.closePanel)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        public Telerik.WinControls.UI.RadDropDownList radDropDownList1;
        public Telerik.WinControls.UI.RadGridView radGridView2;
        private Telerik.WinControls.UI.RadPanel radPanel1;
        public Telerik.WinControls.UI.RadLabel header;
        private Telerik.WinControls.UI.RadButton closePanel;
        private Telerik.WinControls.UI.CommandBarRowElement radBindingNavigator1RowElement;
        private Telerik.WinControls.UI.CommandBarStripElement radBindingNavigator1FirstStrip;
        private Telerik.WinControls.UI.CommandBarButton radBindingNavigator1MoveFirstItem;
        private Telerik.WinControls.UI.CommandBarSeparator commandBarSeparator1;
        private Telerik.WinControls.UI.CommandBarButton radBindingNavigator1MovePreviousItem;
        private Telerik.WinControls.UI.CommandBarSeparator commandBarSeparator2;
        private Telerik.WinControls.UI.CommandBarTextBox radBindingNavigator1PositionItem;
        private Telerik.WinControls.UI.CommandBarLabel radBindingNavigator1CountItem;
        private Telerik.WinControls.UI.CommandBarSeparator commandBarSeparator3;
        private Telerik.WinControls.UI.CommandBarButton radBindingNavigator1MoveNextItem;
        private Telerik.WinControls.UI.CommandBarSeparator commandBarSeparator4;
        private Telerik.WinControls.UI.CommandBarButton radBindingNavigator1MoveLastItem;
        private Telerik.WinControls.UI.CommandBarStripElement radBindingNavigator1SecondStrip;
        private Telerik.WinControls.UI.CommandBarButton radBindingNavigator1AddNewItem;
        private Telerik.WinControls.UI.CommandBarSeparator commandBarSeparator5;
        private Telerik.WinControls.UI.CommandBarButton radBindingNavigator1DeleteItem;
        public Telerik.WinControls.UI.RadBindingNavigator radBindingNavigator1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        public Telerik.WinControls.UI.RadPanel radPanel2;
    }
}
