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
    public partial class PanelFragmentSummary : UserControl {
        Schedule OwnerForm;
        RadButton MainButton;
        BindingSource Source;
        int speedAnimation = 100;
        public PanelFragmentSummary(Schedule ownerForm, BindingSource source, RadButton mainButton) {
            this.OwnerForm = ownerForm;
            this.MainButton = mainButton;
            this.Source = source;
            InitializeComponent();
        }

        private void radPanel1_Initialized(object sender, EventArgs e) {
            radPanel1.Height = OwnerForm.Height - 99;
            radPanel2.Height = radPanel1.Height - 119;
            radPanel1.Location = new Point(-500, 1);
            //Запускаем анимацию
            timer1.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e) {
            if (radPanel1.Location.X >= 0) {
                timer1.Enabled = false;
                radPanel1.Location = new Point(radPanel1.Location.X + 1, 1);
            }
            else
                radPanel1.Location = new Point(radPanel1.Location.X + speedAnimation, 1);
        }

        private void timer2_Tick(object sender, EventArgs e) {
            if (radPanel1.Location.X <= -500) {
                timer2.Enabled = false;
                radPanel1.Location = new Point(radPanel1.Location.X, 1);

                //Уничтожаем объекты панели.
                OwnerForm.countPanel--;
                this.Dispose();
            }
            else
                radPanel1.Location = new Point(radPanel1.Location.X - speedAnimation, 1);
        }

        private void closePanel_Click(object sender, EventArgs e) {
            //Включаем кнопку
            MainButton.Enabled = true;
            //Запускаем анимацию скрытия панели
            timer2.Enabled = true;
        }

        private void radDropDownList3_SelectedValueChanged(object sender, EventArgs e) {
        }

        private void radDropDownList3_SelectedIndexChanged(object sender, Telerik.WinControls.UI.Data.PositionChangedEventArgs e) {
            radGridView1.Rows.Add("Русский язык", 78, 5, "Николаева Наталья Николаевна");
            radGridView1.Rows.Add("Иностраный язык", 48, 3, "Семёнов Николай Геннадьевич");
            radGridView1.Rows.Add("История", 48, 3, "Калюжная Маргарита Вячеславовна");
            radGridView1.Rows.Add("Физическая культура", 48, 3, "Шевченко Елена Викторовна");
            radGridView1.Rows.Add("Математика", 60, 4, "Сахарова Наталья Евгеньевна");
            radGridView1.Rows.Add("ОБЖ", 32, 2, "Семёнов Николай Геннадьевич");
            radGridView1.Rows.Add("Обществознание", 48, 3, "Калюжная Маргарита Вячеславовна");
            radGridView1.Rows.Add("Биология", "" , "", "Бережная Людмила Владимировна");
            radGridView1.Rows.Add("Химия", "", "", "Бережная Людмила Владимировна");
            radGridView1.Rows.Add("Информатика", "", "", "Скоринова Марина Борисовна");

            radLabel2.Text = "Всего часов в семестр: 362";
            radLabel3.Text = "Всего часов в неделю: 24";
            radLabel4.Text = "Всего пар в неделю: 12";
        }

        private void radGridView1_RowsChanged(object sender, GridViewCollectionChangedEventArgs e) {
            
        }

        private void radGridView1_RowFormatting(object sender, RowFormattingEventArgs e) {
            
        }
        int digit = 0;
        private void radGridView1_CellEndEdit(object sender, GridViewCellEventArgs e) {
            if (digit == 0) {
                radGridView1.Rows[7].Cells[2].Value = 2;
                digit = 1;
                radLabel2.Text = "Всего часов в семестр: 398";
                radLabel3.Text = "Всего часов в неделю: 26";
                radLabel4.Text = "Всего пар в неделю: 13";
                return;
            }
            if (digit == 1) {
                radGridView1.Rows[8].Cells[2].Value = 5;
                digit = 2;
                radLabel2.Text = "Всего часов в семестр: 476";
                radLabel3.Text = "Всего часов в неделю: 31";
                radLabel4.Text = "Всего пар в неделю: 15";
                return;
            }
            if (digit == 2) {
                radGridView1.Rows[9].Cells[2].Value = 6;
                radLabel2.Text = "Всего часов в семестр: 576";
                radLabel3.Text = "Всего часов в неделю: 36";
                radLabel4.Text = "Всего пар в неделю: 18";
            }
        }
    }
}
