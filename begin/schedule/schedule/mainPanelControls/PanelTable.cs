using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Telerik.WinControls;
using Telerik.WinControls.UI;

namespace schedule.mainPanelControls {
    public partial class PanelTable : UserControl {
        Schedule OwnerForm;
        BindingSource Source;
        RadButton MainButton;
        public PanelTable(Schedule ownerForm, BindingSource bindingSource, RadButton mainButton) {
            this.Source = bindingSource;
            this.OwnerForm = ownerForm;
            this.MainButton = mainButton;
            InitializeComponent();
        }

        int speedAnimation = 100; //скорость анимации
        private void radPanel1_Initialized(object sender, EventArgs e) {
            //Отображаем панель
            radPanel1.Height = OwnerForm.Height - 99;
            radPanel1.Location = new Point(-500, 1);
            radGridView1.Height = radPanel1.Height - 117;
            //Задействуем анимацию
            animationPanel.Enabled = true;
            //подключаем к GridView навигацию
            radBindingNavigator1.BindingSource = Source;
        }

        //Анимация открытия панели
        private void AnimationPanel_Tick(object sender, EventArgs e) {
            if (radPanel1.Location.X >= 0) { 
                animationPanel.Enabled = false;
                radPanel1.Location = new Point(radPanel1.Location.X + 1, 1);
            }
            else
            radPanel1.Location = new Point(radPanel1.Location.X + speedAnimation, 1);
        }

        //Анимация закрытия панели
        private void animationPanelClose_Tick(object sender, EventArgs e) {
            if (radPanel1.Location.X <= -500) {
                animationPanel.Enabled = false;
                radPanel1.Location = new Point(radPanel1.Location.X, 1);

                //Закрываем панель
                OwnerForm.countPanel--;
                this.Dispose();
            }
            else
                radPanel1.Location = new Point(radPanel1.Location.X - speedAnimation, 1);
        }

        //Анимация закрытия панелли + сохранение всех данных
        private void closePanel_Click(object sender, EventArgs e) {

            //Прекращаем редактирование
            Source.EndEdit();
            //Сохраняем данные
            OwnerForm.tableMGMT.UpdateAll(OwnerForm.scheduleDataSet);

            //Включаем кнопку
            MainButton.Enabled = true;
            //Запускаем анимацию скрытия панели
            animationPanelClose.Enabled = true;


        }

        //автоматическое сохранение
        private void radGridView1_Validated(object sender, EventArgs e) {
            Source.EndEdit();
            OwnerForm.tableMGMT.UpdateAll(OwnerForm.scheduleDataSet);
        }
    }
}
