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
    public partial class PanelTwoDownView : UserControl {
        Schedule OwnerForm;
        RadButton MainButton;
        BindingSource Source;
        int speedAnimation = 100;
        public PanelTwoDownView(Schedule ownerForm, BindingSource source, RadButton mainButton) {
            this.OwnerForm = ownerForm;
            this.MainButton = mainButton;
            this.Source = source;
            InitializeComponent();
        }

        private void closePanel_Click(object sender, EventArgs e) {

            //Прекращаем редактирование
            Source.EndEdit();
            //Сохраняем данные
            OwnerForm.tableMGMT.UpdateAll(OwnerForm.scheduleDataSet);

            //Включаем кнопку
            MainButton.Enabled = true;
            //Запускаем анимацию скрытия панели
            timer2.Enabled = true;
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

        private void timer1_Tick(object sender, EventArgs e) {
            if (radPanel1.Location.X >= 0) {
                timer1.Enabled = false;
                radPanel1.Location = new Point(radPanel1.Location.X + 1, 1);
            }
            else
                radPanel1.Location = new Point(radPanel1.Location.X + speedAnimation, 1);
        }

        private void radGridView2_Validated(object sender, EventArgs e) {
            this.Validate();
            Source.EndEdit();
            OwnerForm.courseBindingSource.EndEdit();
            OwnerForm.tableMGMT.UpdateAll(OwnerForm.scheduleDataSet);
        }

        private void radPanel1_Initialized(object sender, EventArgs e) {
            radPanel1.Height = OwnerForm.Height - 99;
            radPanel2.Height = radPanel1.Height - 119;
            radPanel1.Location = new Point(-500, 1);
            //Запускаем анимацию
            timer1.Enabled = true;
            radGridView2.Height = radPanel2.Height - 79;
        }
    }
}
