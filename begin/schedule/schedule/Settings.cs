using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;
using Telerik.WinControls.UI;

namespace schedule
{
    public partial class Settings : Telerik.WinControls.UI.RadForm
    {
        Schedule OwnerForm;
        public Settings(Schedule ownerForm)
        {
            this.OwnerForm = ownerForm;
            InitializeComponent();
        }

        private void radCheckBox1_ToggleStateChanged(object sender, Telerik.WinControls.UI.StateChangedEventArgs args) {
            if (radCheckBox1.Checked == true) {
                OwnerForm.menuPanel.Width += 200;
                OwnerForm.tableLayoutPanel1.ColumnStyles[0].Width += 200;

                OwnerForm.button1.Width += 200;
                OwnerForm.button1.Text = "Кабинеты";
                OwnerForm.button1.Image = null;

                OwnerForm.button2.Width += 200;
                OwnerForm.button2.Text = "Дисциплины";
                OwnerForm.button2.Image = null;

                OwnerForm.buttonTeachers.Width += 200;
                OwnerForm.buttonTeachers.Text = "Преподаватели";
                OwnerForm.buttonTeachers.Image = null;

                OwnerForm.buttonSpecialty.Width += 200;
                OwnerForm.buttonSpecialty.Text = "Специальности";
                OwnerForm.buttonSpecialty.Image = null;

                OwnerForm.buttonEmployee.Width += 200;
                OwnerForm.buttonEmployee.Text = "Время работы преподавателя";
                OwnerForm.buttonEmployee.Image = null;

                OwnerForm.groupButton.Width += 200;
                OwnerForm.groupButton.Text = "Список групп";
                OwnerForm.groupButton.Image = null;

                OwnerForm.teacherDisceplineButton.Width += 200;
                OwnerForm.teacherDisceplineButton.Text = "Дисциплины преподавателя";
                OwnerForm.teacherDisceplineButton.Image = null;

                OwnerForm.cabinetDisciplineButton.Width += 200;
                OwnerForm.cabinetDisciplineButton.Text = "Рейтинг кабинетов";
                OwnerForm.cabinetDisciplineButton.Image = null;

                OwnerForm.specialtyCourseButton.Width += 200;
                OwnerForm.specialtyCourseButton.Text = "Дисциплины специальностей";
                OwnerForm.specialtyCourseButton.Image = null;

                OwnerForm.fragmentSummaryButton.Width += 200;
                OwnerForm.fragmentSummaryButton.Text = "Сводная выписка";
                OwnerForm.fragmentSummaryButton.Image = null;

                OwnerForm.scheduleButton.Width += 200;
                OwnerForm.scheduleButton.Text = "Расписание занятий";
                OwnerForm.scheduleButton.Image = null;
            }
            if (radCheckBox1.Checked == false) {
                OwnerForm.menuPanel.Width -= 200;
                OwnerForm.tableLayoutPanel1.ColumnStyles[0].Width -= 200;

                OwnerForm.button1.Width -= 200;
                OwnerForm.button1.Text = "";
                OwnerForm.button1.Image = schedule.Properties.Resources.cabinet_ff;

                OwnerForm.button2.Width -= 200;
                OwnerForm.button2.Text = "";
                OwnerForm.button2.Image = schedule.Properties.Resources.disciplin1e;

                OwnerForm.buttonTeachers.Width -= 200;
                OwnerForm.buttonTeachers.Text = "";
                OwnerForm.buttonTeachers.Image = schedule.Properties.Resources.teacherf;

                OwnerForm.buttonSpecialty.Width -= 200;
                OwnerForm.buttonSpecialty.Text = "";
                OwnerForm.buttonSpecialty.Image = schedule.Properties.Resources.specialty1;

                OwnerForm.buttonEmployee.Width -= 200;
                OwnerForm.buttonEmployee.Text = "";
                OwnerForm.buttonEmployee.Image = schedule.Properties.Resources.time1;

                OwnerForm.groupButton.Width -= 200;
                OwnerForm.groupButton.Text = "";
                OwnerForm.groupButton.Image = schedule.Properties.Resources.gs;

                OwnerForm.teacherDisceplineButton.Width -= 200;
                OwnerForm.teacherDisceplineButton.Text = "";
                OwnerForm.teacherDisceplineButton.Image = schedule.Properties.Resources.sp;

                OwnerForm.cabinetDisciplineButton.Width -= 200;
                OwnerForm.cabinetDisciplineButton.Text = "";
                OwnerForm.cabinetDisciplineButton.Image = schedule.Properties.Resources.rat;

                OwnerForm.specialtyCourseButton.Width -= 200;
                OwnerForm.specialtyCourseButton.Text = "";
                OwnerForm.specialtyCourseButton.Image = schedule.Properties.Resources.dt;

                OwnerForm.fragmentSummaryButton.Width -= 200;
                OwnerForm.fragmentSummaryButton.Text = "";
                OwnerForm.fragmentSummaryButton.Image = schedule.Properties.Resources.fs;

                OwnerForm.scheduleButton.Width -= 200;
                OwnerForm.scheduleButton.Text = "";
                OwnerForm.scheduleButton.Image = schedule.Properties.Resources.schedule;
            }
        }
    }
}
