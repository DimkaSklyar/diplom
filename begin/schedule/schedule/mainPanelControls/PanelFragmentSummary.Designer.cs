namespace schedule.mainPanelControls {
    partial class PanelFragmentSummary {
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
            Telerik.WinControls.UI.TableViewDefinition tableViewDefinition6 = new Telerik.WinControls.UI.TableViewDefinition();
            Telerik.WinControls.UI.RadListDataItem radListDataItem3 = new Telerik.WinControls.UI.RadListDataItem();
            Telerik.WinControls.UI.RadListDataItem radListDataItem4 = new Telerik.WinControls.UI.RadListDataItem();
            Telerik.WinControls.UI.RadListDataItem radListDataItem9 = new Telerik.WinControls.UI.RadListDataItem();
            Telerik.WinControls.UI.RadListDataItem radListDataItem10 = new Telerik.WinControls.UI.RadListDataItem();
            Telerik.WinControls.UI.RadListDataItem radListDataItem5 = new Telerik.WinControls.UI.RadListDataItem();
            Telerik.WinControls.UI.RadListDataItem radListDataItem6 = new Telerik.WinControls.UI.RadListDataItem();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PanelFragmentSummary));
            this.radPanel1 = new Telerik.WinControls.UI.RadPanel();
            this.radPanel2 = new Telerik.WinControls.UI.RadPanel();
            this.radLabel4 = new Telerik.WinControls.UI.RadLabel();
            this.radLabel3 = new Telerik.WinControls.UI.RadLabel();
            this.radLabel2 = new Telerik.WinControls.UI.RadLabel();
            this.radLabel1 = new Telerik.WinControls.UI.RadLabel();
            this.radGridView1 = new Telerik.WinControls.UI.RadGridView();
            this.radDropDownList1 = new Telerik.WinControls.UI.RadDropDownList();
            this.radDropDownList2 = new Telerik.WinControls.UI.RadDropDownList();
            this.radDropDownList3 = new Telerik.WinControls.UI.RadDropDownList();
            this.radButton1 = new Telerik.WinControls.UI.RadButton();
            this.header = new Telerik.WinControls.UI.RadLabel();
            this.closePanel = new Telerik.WinControls.UI.RadButton();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.radBindingNavigator1 = new Telerik.WinControls.UI.RadBindingNavigator();
            this.radBindingNavigator1RowElement = new Telerik.WinControls.UI.CommandBarRowElement();
            this.radBindingNavigator1FirstStrip = new Telerik.WinControls.UI.CommandBarStripElement();
            this.radBindingNavigator1MoveFirstItem = new Telerik.WinControls.UI.CommandBarButton();
            this.radBindingNavigator1MovePreviousItem = new Telerik.WinControls.UI.CommandBarButton();
            this.radBindingNavigator1PositionItem = new Telerik.WinControls.UI.CommandBarTextBox();
            this.radBindingNavigator1CountItem = new Telerik.WinControls.UI.CommandBarLabel();
            this.radBindingNavigator1MoveNextItem = new Telerik.WinControls.UI.CommandBarButton();
            this.radBindingNavigator1MoveLastItem = new Telerik.WinControls.UI.CommandBarButton();
            this.commandBarSeparator1 = new Telerik.WinControls.UI.CommandBarSeparator();
            this.commandBarSeparator2 = new Telerik.WinControls.UI.CommandBarSeparator();
            this.commandBarSeparator3 = new Telerik.WinControls.UI.CommandBarSeparator();
            this.commandBarSeparator4 = new Telerik.WinControls.UI.CommandBarSeparator();
            this.radBindingNavigator1SecondStrip = new Telerik.WinControls.UI.CommandBarStripElement();
            this.commandBarSeparator5 = new Telerik.WinControls.UI.CommandBarSeparator();
            ((System.ComponentModel.ISupportInitialize)(this.radPanel1)).BeginInit();
            this.radPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radPanel2)).BeginInit();
            this.radPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGridView1.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radDropDownList1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radDropDownList2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radDropDownList3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButton1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.header)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.closePanel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radBindingNavigator1)).BeginInit();
            this.SuspendLayout();
            // 
            // radPanel1
            // 
            this.radPanel1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.radPanel1.Controls.Add(this.radBindingNavigator1);
            this.radPanel1.Controls.Add(this.radPanel2);
            this.radPanel1.Controls.Add(this.header);
            this.radPanel1.Controls.Add(this.closePanel);
            this.radPanel1.Location = new System.Drawing.Point(3, 3);
            this.radPanel1.Name = "radPanel1";
            this.radPanel1.Size = new System.Drawing.Size(592, 985);
            this.radPanel1.TabIndex = 1;
            this.radPanel1.ThemeName = "Material";
            this.radPanel1.Initialized += new System.EventHandler(this.radPanel1_Initialized);
            // 
            // radPanel2
            // 
            this.radPanel2.Controls.Add(this.radLabel4);
            this.radPanel2.Controls.Add(this.radLabel3);
            this.radPanel2.Controls.Add(this.radLabel2);
            this.radPanel2.Controls.Add(this.radLabel1);
            this.radPanel2.Controls.Add(this.radGridView1);
            this.radPanel2.Controls.Add(this.radDropDownList1);
            this.radPanel2.Controls.Add(this.radDropDownList2);
            this.radPanel2.Controls.Add(this.radDropDownList3);
            this.radPanel2.Controls.Add(this.radButton1);
            this.radPanel2.Location = new System.Drawing.Point(6, 54);
            this.radPanel2.Name = "radPanel2";
            this.radPanel2.Size = new System.Drawing.Size(579, 919);
            this.radPanel2.TabIndex = 11;
            this.radPanel2.ThemeName = "Material";
            // 
            // radLabel4
            // 
            this.radLabel4.Location = new System.Drawing.Point(398, 809);
            this.radLabel4.Name = "radLabel4";
            this.radLabel4.Size = new System.Drawing.Size(166, 21);
            this.radLabel4.TabIndex = 11;
            this.radLabel4.Text = "Всего пар в неделю: 18";
            this.radLabel4.ThemeName = "Material";
            // 
            // radLabel3
            // 
            this.radLabel3.Location = new System.Drawing.Point(383, 782);
            this.radLabel3.Name = "radLabel3";
            this.radLabel3.Size = new System.Drawing.Size(181, 21);
            this.radLabel3.TabIndex = 11;
            this.radLabel3.Text = "Всего часов в неделю: 36";
            this.radLabel3.ThemeName = "Material";
            // 
            // radLabel2
            // 
            this.radLabel2.Location = new System.Drawing.Point(380, 755);
            this.radLabel2.Name = "radLabel2";
            this.radLabel2.Size = new System.Drawing.Size(193, 21);
            this.radLabel2.TabIndex = 11;
            this.radLabel2.Text = "Всего часов в семестр: 576";
            this.radLabel2.ThemeName = "Material";
            // 
            // radLabel1
            // 
            this.radLabel1.Location = new System.Drawing.Point(320, 728);
            this.radLabel1.Name = "radLabel1";
            this.radLabel1.Size = new System.Drawing.Size(244, 21);
            this.radLabel1.TabIndex = 11;
            this.radLabel1.Text = "Количество недель в семестре: 16";
            this.radLabel1.ThemeName = "Material";
            // 
            // radGridView1
            // 
            this.radGridView1.Location = new System.Drawing.Point(10, 55);
            // 
            // 
            // 
            this.radGridView1.MasterTemplate.AddNewRowPosition = Telerik.WinControls.UI.SystemRowPosition.Bottom;
            this.radGridView1.MasterTemplate.ViewDefinition = tableViewDefinition6;
            this.radGridView1.Name = "radGridView1";
            this.radGridView1.ShowGroupPanel = false;
            this.radGridView1.Size = new System.Drawing.Size(563, 667);
            this.radGridView1.TabIndex = 2;
            this.radGridView1.Text = "radGridView1";
            this.radGridView1.ThemeName = "Material";
            // 
            // radDropDownList1
            // 
            this.radDropDownList1.Location = new System.Drawing.Point(10, 13);
            this.radDropDownList1.Name = "radDropDownList1";
            this.radDropDownList1.Size = new System.Drawing.Size(243, 36);
            this.radDropDownList1.TabIndex = 7;
            this.radDropDownList1.Text = "Специальность";
            this.radDropDownList1.ThemeName = "Material";
            // 
            // radDropDownList2
            // 
            radListDataItem3.Text = "1 Курс";
            radListDataItem4.Text = "2 Курс";
            radListDataItem9.Text = "3 Курс";
            radListDataItem10.Text = "4 Курс";
            this.radDropDownList2.Items.Add(radListDataItem3);
            this.radDropDownList2.Items.Add(radListDataItem4);
            this.radDropDownList2.Items.Add(radListDataItem9);
            this.radDropDownList2.Items.Add(radListDataItem10);
            this.radDropDownList2.Location = new System.Drawing.Point(278, 13);
            this.radDropDownList2.Name = "radDropDownList2";
            this.radDropDownList2.Size = new System.Drawing.Size(145, 36);
            this.radDropDownList2.TabIndex = 8;
            this.radDropDownList2.Text = "Курс";
            this.radDropDownList2.ThemeName = "Material";
            // 
            // radDropDownList3
            // 
            radListDataItem5.Text = "1 Семестр";
            radListDataItem6.Text = "2 Семестр";
            this.radDropDownList3.Items.Add(radListDataItem5);
            this.radDropDownList3.Items.Add(radListDataItem6);
            this.radDropDownList3.Location = new System.Drawing.Point(448, 13);
            this.radDropDownList3.Name = "radDropDownList3";
            this.radDropDownList3.Size = new System.Drawing.Size(125, 36);
            this.radDropDownList3.TabIndex = 9;
            this.radDropDownList3.Text = "Семестр";
            this.radDropDownList3.ThemeName = "Material";
            // 
            // radButton1
            // 
            this.radButton1.Location = new System.Drawing.Point(10, 787);
            this.radButton1.Name = "radButton1";
            this.radButton1.Size = new System.Drawing.Size(120, 36);
            this.radButton1.TabIndex = 10;
            this.radButton1.Text = "Сохранить";
            this.radButton1.ThemeName = "Material";
            // 
            // header
            // 
            this.header.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.header.ForeColor = System.Drawing.Color.Gray;
            this.header.Location = new System.Drawing.Point(10, 10);
            this.header.Name = "header";
            this.header.Size = new System.Drawing.Size(266, 38);
            this.header.TabIndex = 5;
            this.header.Text = "Сводная выписка";
            this.header.ThemeName = "Material";
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
            this.closePanel.Location = new System.Drawing.Point(549, 10);
            this.closePanel.Name = "closePanel";
            this.closePanel.Size = new System.Drawing.Size(36, 36);
            this.closePanel.TabIndex = 3;
            this.closePanel.ThemeName = "Material";
            this.closePanel.Click += new System.EventHandler(this.closePanel_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 5;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Interval = 5;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // radBindingNavigator1
            // 
            this.radBindingNavigator1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.radBindingNavigator1.Location = new System.Drawing.Point(0, 937);
            this.radBindingNavigator1.Name = "radBindingNavigator1";
            this.radBindingNavigator1.Rows.AddRange(new Telerik.WinControls.UI.CommandBarRowElement[] {
            this.radBindingNavigator1RowElement});
            this.radBindingNavigator1.Size = new System.Drawing.Size(592, 48);
            this.radBindingNavigator1.TabIndex = 12;
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
            // radBindingNavigator1PositionItem
            // 
            this.radBindingNavigator1PositionItem.Name = "radBindingNavigator1PositionItem";
            // 
            // radBindingNavigator1CountItem
            // 
            this.radBindingNavigator1CountItem.Name = "radBindingNavigator1CountItem";
            this.radBindingNavigator1CountItem.Text = "of {0}";
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
            this.radBindingNavigator1SecondStrip.DesiredLocation = ((System.Drawing.PointF)(resources.GetObject("radBindingNavigator1SecondStrip.DesiredLocation")));
            this.radBindingNavigator1SecondStrip.DisplayName = "radBindingNavigator1SecondStrip";
            this.radBindingNavigator1SecondStrip.EnableDragging = false;
            // 
            // 
            // 
            this.radBindingNavigator1SecondStrip.Grip.Visibility = Telerik.WinControls.ElementVisibility.Collapsed;
            this.radBindingNavigator1SecondStrip.Items.AddRange(new Telerik.WinControls.UI.RadCommandBarBaseItem[] {
            this.commandBarSeparator5});
            this.radBindingNavigator1SecondStrip.MinSize = new System.Drawing.Size(0, 0);
            // 
            // 
            // 
            this.radBindingNavigator1SecondStrip.OverflowButton.Visibility = Telerik.WinControls.ElementVisibility.Collapsed;
            // 
            // commandBarSeparator5
            // 
            this.commandBarSeparator5.Name = "commandBarSeparator5";
            this.commandBarSeparator5.VisibleInOverflowMenu = false;
            // 
            // PanelFragmentSummary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.radPanel1);
            this.Name = "PanelFragmentSummary";
            this.Size = new System.Drawing.Size(601, 1018);
            ((System.ComponentModel.ISupportInitialize)(this.radPanel1)).EndInit();
            this.radPanel1.ResumeLayout(false);
            this.radPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radPanel2)).EndInit();
            this.radPanel2.ResumeLayout(false);
            this.radPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGridView1.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radDropDownList1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radDropDownList2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radDropDownList3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButton1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.header)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.closePanel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radBindingNavigator1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public Telerik.WinControls.UI.RadPanel radPanel1;
        private Telerik.WinControls.UI.RadPanel radPanel2;
        private Telerik.WinControls.UI.RadLabel radLabel4;
        private Telerik.WinControls.UI.RadLabel radLabel3;
        private Telerik.WinControls.UI.RadLabel radLabel2;
        private Telerik.WinControls.UI.RadLabel radLabel1;
        public Telerik.WinControls.UI.RadGridView radGridView1;
        private Telerik.WinControls.UI.RadButton radButton1;
        public Telerik.WinControls.UI.RadLabel header;
        private Telerik.WinControls.UI.RadButton closePanel;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        public Telerik.WinControls.UI.RadDropDownList radDropDownList1;
        public Telerik.WinControls.UI.RadDropDownList radDropDownList2;
        public Telerik.WinControls.UI.RadDropDownList radDropDownList3;
        private Telerik.WinControls.UI.RadBindingNavigator radBindingNavigator1;
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
        private Telerik.WinControls.UI.CommandBarSeparator commandBarSeparator5;
    }
}
