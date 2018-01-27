namespace schedule.mainPanelControls {
    partial class addTeachers {
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
            Telerik.WinControls.UI.TableViewDefinition tableViewDefinition1 = new Telerik.WinControls.UI.TableViewDefinition();
            Telerik.WinControls.UI.GridViewRelation gridViewRelation1 = new Telerik.WinControls.UI.GridViewRelation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(addTeachers));
            this.radDropDownList1 = new Telerik.WinControls.UI.RadDropDownList();
            this.radGridView2 = new Telerik.WinControls.UI.RadGridView();
            this.radButton1 = new Telerik.WinControls.UI.RadButton();
            ((System.ComponentModel.ISupportInitialize)(this.radDropDownList1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGridView2.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButton1)).BeginInit();
            this.SuspendLayout();
            // 
            // radDropDownList1
            // 
            this.radDropDownList1.DisplayMember = "name_specialty";
            this.radDropDownList1.Location = new System.Drawing.Point(12, 3);
            this.radDropDownList1.Name = "radDropDownList1";
            this.radDropDownList1.Size = new System.Drawing.Size(456, 36);
            this.radDropDownList1.TabIndex = 4;
            this.radDropDownList1.ThemeName = "Material";
            this.radDropDownList1.ValueMember = "name_specialty";
            // 
            // radGridView2
            // 
            this.radGridView2.Location = new System.Drawing.Point(12, 54);
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
            this.radGridView2.Size = new System.Drawing.Size(456, 708);
            this.radGridView2.TabIndex = 3;
            this.radGridView2.Text = "radGridView2";
            this.radGridView2.ThemeName = "Material";
            // 
            // radButton1
            // 
            this.radButton1.Location = new System.Drawing.Point(12, 778);
            this.radButton1.Name = "radButton1";
            this.radButton1.Size = new System.Drawing.Size(120, 36);
            this.radButton1.TabIndex = 5;
            this.radButton1.Text = "Добавить";
            this.radButton1.ThemeName = "Material";
            // 
            // addTeachers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.radButton1);
            this.Controls.Add(this.radDropDownList1);
            this.Controls.Add(this.radGridView2);
            this.Name = "addTeachers";
            this.Size = new System.Drawing.Size(488, 841);
            ((System.ComponentModel.ISupportInitialize)(this.radDropDownList1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGridView2.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButton1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public Telerik.WinControls.UI.RadDropDownList radDropDownList1;
        public Telerik.WinControls.UI.RadGridView radGridView2;
        private Telerik.WinControls.UI.RadButton radButton1;
    }
}
