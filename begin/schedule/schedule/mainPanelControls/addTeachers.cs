using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Telerik.WinControls.UI;

namespace schedule.mainPanelControls {
    public partial class addTeachers : UserControl {
        RadGridView GridView;
        RadBindingNavigator BindingNavigator;
        public addTeachers(RadGridView gridView, RadBindingNavigator bindingNavigator) {
            this.GridView = gridView;
            this.BindingNavigator = bindingNavigator;
            InitializeComponent();
        }

        private void radDropDownList1_SelectedValueChanged(object sender, EventArgs e) {
            if (radDropDownList1.SelectedValue.ToString() == "Бережная Людмила Владимировна") {
                radGridView2.Rows.RemoveAt(0);
                radGridView2.Rows.Add(false, "Химия");
                radGridView2.Rows.Add(false, "Биология");
            }
            if (radDropDownList1.SelectedValue.ToString() == "Скоринова Марина Борисовна") {
                radGridView2.Rows.RemoveAt(0);
                radGridView2.Rows.RemoveAt(0);
                radGridView2.Rows.Add(false, "Информатика");
            }
        }

        private void radButton1_Click(object sender, EventArgs e) {
            if (radDropDownList1.SelectedValue.ToString() == "Бережная Людмила Владимировна") {
                GridView.Rows.Add("Химия", "Бережная Людмила Владимировна");
                GridView.Rows.Add("Биология", "Бережная Людмила Владимировна");
                BindingNavigator.BindingNavigatorElement.CurrentNumberTextBox.Text = "9";
                BindingNavigator.BindingNavigatorElement.PageLabel.Text = "из 9";
            }
            if (radDropDownList1.SelectedValue.ToString() == "Скоринова Марина Борисовна") {
                radGridView2.Rows.RemoveAt(0);
                GridView.Rows.Add("Информатика", "Скоринова Марина Борисовна");
                BindingNavigator.BindingNavigatorElement.CurrentNumberTextBox.Text = "10";
                BindingNavigator.BindingNavigatorElement.PageLabel.Text = "из 10";
            }
        }
    }
}
