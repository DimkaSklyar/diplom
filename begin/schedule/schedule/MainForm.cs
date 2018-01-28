using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;
using schedule.mainPanelControls;
using Telerik.WinControls.UI.Localization;
using Telerik.WinControls.UI;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Threading;

namespace schedule
{
    // TODO: добавить таблицу с настройками + предворительные настройки в самом начале!
    public partial class Schedule : Telerik.WinControls.UI.RadForm
    { 
        PanelBusy busy;
        PanelJoin panelJoin;
        PanelTwoDownView twoDownView;
        PanelFragmentSummary fragmentSummary;
        RadButton buttonSave;

        GridViewComboBoxColumn supplierColumn;
        public Schedule()
        {

            InitializeComponent();
            LayoutControlLocalizationProvider.CurrentProvider = new MyEnglishLayoutControlLocalizationProvider();
            RadGridLocalizationProvider.CurrentProvider = new MyEnglishRadGridLocalizationProvider();

            //Загрузка данных таблиц
            this.cabinetTableAdapter.Fill(this.scheduleDataSet.cabinet);
            this.disciplineTableAdapter.Fill(this.scheduleDataSet.discipline);
            this.employeeTableAdapter.Fill(this.scheduleDataSet.employee);
            this.specialtyTableAdapter.Fill(this.scheduleDataSet.specialty);
            this.time_work_teachersTableAdapter.Fill(this.scheduleDataSet.time_work_teachers);
            this.courseTableAdapter.Fill(this.scheduleDataSet.course);
            this.teacherTableAdapter.Fill(this.scheduleDataSet.teacher);
            this.discipline_cabinetTableAdapter.Fill(this.scheduleDataSet.discipline_cabinet);
            radProgressBar1.Visible = false;
        }

        public int countPanel = 0;


        //Открытие панели с таблицей КАБИНЕТЫ
        private void button1_Click(object sender, EventArgs e) {
            PanelTable panelCabinet = new PanelTable(this, cabinetBindingSource, button1);
            panelCabinet.Dock = DockStyle.Left;
            countPanel++;
            this.cabinetTableAdapter.Fill(this.scheduleDataSet.cabinet);
            //tableLayoutPanel1.Controls.Add(panelCabinet, 1, 1);
            radPanel1.Controls.Add(panelCabinet);

            panelCabinet.header.Text = "Кабинеты";

            button1.Enabled = false;

            panelCabinet.radGridView1.DataSource = cabinetBindingSource;
            panelCabinet.radGridView1.Columns[0].IsVisible = false;
            panelCabinet.radGridView1.Columns[1].HeaderText = "Номер кабинета";
            panelCabinet.radGridView1.Columns[1].Width = 420;

        }

        private void MainForm_Load(object sender, EventArgs e) {
            
            //MessageBox.Show(a.ToString());


        }

        private void button2_Click(object sender, EventArgs e) {
            PanelTable panelDiscipline = new PanelTable(this, disciplineBindingSource, button2);

            panelDiscipline.Dock = DockStyle.Left;
            countPanel++;
            this.disciplineTableAdapter.Fill(this.scheduleDataSet.discipline);
            //tableLayoutPanel1.Controls.Add(panelCabinet, 1, 1);
            radPanel1.Controls.Add(panelDiscipline);

            panelDiscipline.header.Text = "Дисциплины";

            button2.Enabled = false;

            panelDiscipline.radGridView1.DataSource = disciplineBindingSource;
            panelDiscipline.radGridView1.Columns[0].IsVisible = false;
            panelDiscipline.radGridView1.Columns[1].HeaderText = "Наименование дисциплины";
            panelDiscipline.radGridView1.Columns[1].Width = 415;
        }

        private void buttonTeachers_Click(object sender, EventArgs e) {
            PanelTable panelEmployee = new PanelTable(this, employeeBindingSource, buttonTeachers);

            panelEmployee.Dock = DockStyle.Left;
            countPanel++;
            this.employeeTableAdapter.Fill(this.scheduleDataSet.employee);
            //tableLayoutPanel1.Controls.Add(panelCabinet, 1, 1);
            radPanel1.Controls.Add(panelEmployee);

            panelEmployee.header.Text = "Преподователи";

            buttonTeachers.Enabled = false;

            panelEmployee.radGridView1.DataSource = employeeBindingSource;
            panelEmployee.radGridView1.Columns[0].IsVisible = false;
            panelEmployee.radGridView1.Columns[1].HeaderText = "ФИО преподавателя";
            panelEmployee.radGridView1.Columns[1].Width = 420;
        }

        private void buttonSpecialty_Click(object sender, EventArgs e) {
            PanelTable panelSpecialty = new PanelTable(this, specialtyBindingSource, buttonSpecialty);

            panelSpecialty.Dock = DockStyle.Left;
            countPanel++;
            this.specialtyTableAdapter.Fill(this.scheduleDataSet.specialty);
            //tableLayoutPanel1.Controls.Add(panelCabinet, 1, 1);
            radPanel1.Controls.Add(panelSpecialty);

            panelSpecialty.header.Text = "Специальности";

            buttonSpecialty.Enabled = false;

            panelSpecialty.radGridView1.DataSource = specialtyBindingSource;
            panelSpecialty.radGridView1.Columns[0].IsVisible = false;
            panelSpecialty.radGridView1.Columns[1].HeaderText = "Наименование специальности";
            panelSpecialty.radGridView1.Columns[1].Width = 420;
        }

        private void buttonEmployee_Click(object sender, EventArgs e) {
            busy = new PanelBusy(this, employeeBindingSource, buttonEmployee);

            busy.Dock = DockStyle.Left;

            //tableLayoutPanel1.Controls.Add(panelCabinet, 1, 1);
            this.employeeTableAdapter.Fill(this.scheduleDataSet.employee);

            buttonEmployee.Enabled = false;

            busy.radGridView1.DataSource = employeeBindingSource;
            busy.radGridView1.Columns[0].IsVisible = false;
            busy.radGridView1.Columns[1].HeaderText = "ФИО Преподавателя";
            busy.radGridView1.Columns[1].Width = 410;
            radPanel1.Controls.Add(busy);
        }

        private void groupButton_Click(object sender, EventArgs e) {
            panelJoin = new PanelJoin(this, specialtyBindingSource, groupButton);
            panelJoin.Dock = DockStyle.Left;

            this.cabinetTableAdapter.Fill(this.scheduleDataSet.cabinet);
            this.disciplineTableAdapter.Fill(this.scheduleDataSet.discipline);
            this.employeeTableAdapter.Fill(this.scheduleDataSet.employee);
            this.specialtyTableAdapter.Fill(this.scheduleDataSet.specialty);
            this.time_work_teachersTableAdapter.Fill(this.scheduleDataSet.time_work_teachers);
            this.courseTableAdapter.Fill(this.scheduleDataSet.course);
            this.teacherTableAdapter.Fill(this.scheduleDataSet.teacher);
            this.discipline_cabinetTableAdapter.Fill(this.scheduleDataSet.discipline_cabinet);

            groupButton.Enabled = false;
            //tableLayoutPanel1.Controls.Add(panelCabinet, 1, 1);
            radPanel1.Controls.Add(panelJoin);

            panelJoin.header.Text = "Группы специальностей";

            panelJoin.radDropDownList1.DataSource = specialtyBindingSource;
            panelJoin.radDropDownList1.DisplayMember = "name_specialty";
            panelJoin.radDropDownList1.ValueMember = "name_specialty";

            BindingSource bindingSource = new BindingSource();
            bindingSource.DataSource = specialtyBindingSource;
            bindingSource.DataMember = "specialtycourse";

            panelJoin.radGridView2.DataSource = bindingSource;
            panelJoin.radGridView2.Columns[0].IsVisible = false;
            panelJoin.radGridView2.Columns[1].HeaderText = "Наименование группы";
            panelJoin.radGridView2.Columns[1].Width = 405;

            panelJoin.radBindingNavigator1.BindingSource = bindingSource;
        }

        private void teacherDisceplineButton_Click(object sender, EventArgs e) {

            //Сохранение в таблицу tacher
            //Кнопку на СОХРАНИТЬ
            //Считывание с таблицы
            //
            this.employeeTableAdapter.Fill(this.scheduleDataSet.employee);
            teacherDisceplineButton.Enabled = false;
            panelJoin = new PanelJoin(this, specialtyBindingSource, teacherDisceplineButton);
            panelJoin.Dock = DockStyle.Left;

            radPanel1.Controls.Add(panelJoin);

            panelJoin.header.Text = "Преподаватели дисциплин";

            panelJoin.radDropDownList1.DataSource = employeeBindingSource;
            panelJoin.radDropDownList1.DisplayMember = "FIO";
            panelJoin.radDropDownList1.ValueMember = "FIO";
            panelJoin.radDropDownList1.SelectedValueChanged += RadDropDownList1_SelectedValueChanged;

            BindingSource bindingSource = new BindingSource();
            bindingSource.DataSource = disciplineBindingSource;

            panelJoin.radGridView2.DataSource = bindingSource;

            GridViewCheckBoxColumn checkBoxColumn = new GridViewCheckBoxColumn();
            checkBoxColumn.DataType = typeof(int);
            checkBoxColumn.Name = "check";
            checkBoxColumn.FieldName = "Да/Нет";
            checkBoxColumn.HeaderText = "Да/Нет";

            panelJoin.radGridView2.MasterTemplate.Columns.Add(checkBoxColumn);
            panelJoin.radGridView2.Columns.Move(2, 0);

            panelJoin.radGridView2.Columns[0].Width = 70;
            panelJoin.radGridView2.Columns[1].IsVisible = false;
            panelJoin.radGridView2.Columns[2].HeaderText = "Наименование дисциплины";
            panelJoin.radGridView2.Columns[2].Width = 320;
            panelJoin.radGridView2.Columns[2].ReadOnly = true;

            panelJoin.radGridView2.AllowAddNewRow = false;
            panelJoin.radBindingNavigator1.BindingSource = bindingSource;

            panelJoin.radGridView2.Height = 710;

            //кнопка сохранить
            RadButton buttonSave = new RadButton();
            panelJoin.radPanel2.Controls.Add(buttonSave);
            buttonSave.Location = new Point(12, 790);
            buttonSave.ThemeName = "Material";
            buttonSave.Text = "Сохранить";
            buttonSave.Click += ButtonSave_Click;

            //инициализация CheckBox PS> magic! without this code don't work
            for (int i = 0; i < panelJoin.radGridView2.RowCount; i++) {
                panelJoin.radGridView2.Rows[i].Cells[0].Value = 0;
            }


            //проставляем галочки с таблицы teacher
            CheckBoxTableDiscipline();
            //конец простановки
            }

        private void RadDropDownList1_SelectedValueChanged(object sender, EventArgs e) {
            for (int i = 0; i < panelJoin.radGridView2.RowCount; i++) {
                panelJoin.radGridView2.Rows[i].Cells[0].Value = 0;
            }
            CheckBoxTableDiscipline();
        }

        //TODO: получение ID_teacher быстрее
        private void ButtonSave_Click(object sender, EventArgs e) {
            OleDbConnection sqlConnection = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.16.0;Data Source=|DataDirectory|\\schedule.accdb");
            sqlConnection.Open();
            OleDbCommand cmd = new OleDbCommand();
            cmd.Connection = sqlConnection;
            cmd.CommandType = CommandType.Text;

            //находим ID Преподавателя в таблице employee
            string nameTeacher = panelJoin.radDropDownList1.SelectedValue.ToString();   //имя преподавателя выбранное в DropDownList
            string idTeacher="";                                                           //переменная для хранение id Преподавателя
            string discepline="";

            //пробегаемся по всей таблице ища имя, после успешного нахождения, сохраняем ID найденной строки в переменную idTeacher
            for (int i = 0; i < scheduleDataSet.Tables["employee"].Rows.Count; i++) {
                if (scheduleDataSet.Tables["employee"].Rows[i][1].ToString() == nameTeacher) {
                    idTeacher = scheduleDataSet.Tables["employee"].Rows[i][0].ToString();
                }
            }

            for (int i = 0; i < panelJoin.radGridView2.RowCount; i++) {
                int j = 0 ;
                if (panelJoin.radGridView2.Rows[i].Cells[0].Value.ToString() == "1") {
                    discepline = panelJoin.radGridView2.Rows[i].Cells[1].Value.ToString();
                    string queryString =
                    "INSERT INTO teacher (ID_teacher, ID_discipline) " +
                    "VALUES (" + idTeacher + "," + discepline + ");";

                    //MessageBox.Show(queryString);     //Посмотреть запрос....
                    cmd.CommandText = queryString;
                    cmd.ExecuteNonQuery();
                }
            }
            sqlConnection.Close();
        }

        private void cabinetDisciplineButton_Click(object sender, EventArgs e) {

            cabinetDisciplineButton.Enabled = false;
            twoDownView = new PanelTwoDownView(this, disciplineBindingSource, cabinetDisciplineButton);
            twoDownView.Dock = DockStyle.Left;

            this.discipline_cabinetTableAdapter.Fill(this.scheduleDataSet.discipline_cabinet);

            twoDownView.Width -= 150;
            twoDownView.radPanel1.Width -=150;
            twoDownView.closePanel.Location = new Point(twoDownView.closePanel.Location.X - 150, twoDownView.closePanel.Location.Y);
            twoDownView.radPanel2.Width -= 150;
            twoDownView.radDropDownList1.Width -= 150;
            twoDownView.radDropDownList2.Width -= 150;
            twoDownView.radGridView2.Width -= 148;
            twoDownView.radGridView2.Height -= 110;

            //кнопка сохранить
            RadButton buttonSave = new RadButton();
            twoDownView.radPanel2.Controls.Add(buttonSave);
            buttonSave.Location = new Point(12, 790);
            buttonSave.ThemeName = "Material";
            buttonSave.Text = "Сохранить";
            buttonSave.Click += ButtonSave_Click1;

            radPanel1.Controls.Add(twoDownView);

            twoDownView.header.Text = "Кабинеты дисциплин";

            twoDownView.radDropDownList1.DataSource = disciplineBindingSource;
            twoDownView.radDropDownList1.DisplayMember = "name_discipline";
            twoDownView.radDropDownList1.ValueMember = "name_discipline";


            twoDownView.radGridView2.DataSource = cabinetBindingSource;

            GridViewRatingColumn column = new GridViewRatingColumn("Rating Column");
            twoDownView.radGridView2.Columns.Add(column);
            column.Name = "rating";
            column.FieldName = "Рейтинг";
            column.HeaderText = "Рейтинг";
            column.SelectionMode = RatingSelectionMode.FullItem;
            column.Minimum = 0;
            column.Maximum = 5;
            twoDownView.radGridView2.Columns.Move(1, 0);

            twoDownView.radGridView2.Columns[0].Width = 265;
            twoDownView.radGridView2.Columns[0].HeaderText = "Название кабинета";
            twoDownView.radGridView2.Columns[1].IsVisible = false;
            twoDownView.radGridView2.Columns[2].HeaderText = "Рейтинг";
            twoDownView.radGridView2.Columns[2].Width = 145;
            twoDownView.radGridView2.Columns[2].ReadOnly = true;

            twoDownView.radGridView2.AllowAddNewRow = false;
            twoDownView.radBindingNavigator1.BindingSource = cabinetBindingSource;

            CheckTableDisciplineCabinet();
            //получение значений
            twoDownView.radDropDownList1.SelectedValueChanged += RadDropDownList1_SelectedValueChanged1;
            twoDownView.radDropDownList2.SelectedIndexChanged += RadDropDownList2_SelectedValueChanged;
        }

        private void RadDropDownList2_SelectedValueChanged(object sender, EventArgs e) {
            CheckTableDisciplineCabinet();
        }

        private void RadDropDownList1_SelectedValueChanged1(object sender, EventArgs e) {
            CheckTableDisciplineCabinet();

        }


        private void ButtonSave_Click1(object sender, EventArgs e) {
            OleDbConnection sqlConnection = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.16.0;Data Source=|DataDirectory|\\schedule.accdb");
            sqlConnection.Open();
            OleDbCommand cmd = new OleDbCommand();
            cmd.Connection = sqlConnection;
            cmd.CommandType = CommandType.Text;

            string nameDiscepline = twoDownView.radDropDownList1.SelectedValue.ToString();
            string idDiscepline = "";
            string course = "";
            string numCourse = "";

            for (int i = 0; i < scheduleDataSet.Tables["discipline"].Rows.Count; i++) {
                if (scheduleDataSet.Tables["discipline"].Rows[i][1].ToString() == nameDiscepline) {
                    idDiscepline = scheduleDataSet.Tables["discipline"].Rows[i][0].ToString();
                }
            }
            try {
                numCourse = twoDownView.radDropDownList2.SelectedItem.Text;
            }
            catch (Exception) {
                numCourse = "1 Курс";
            }

            switch (numCourse) {
                case "1 Курс":
                    course = "1";
                    break;
                case "2 Курс":
                    course = "2";
                    break;
                case "3 Курс":
                    course = "3";
                    break;
                case "4 Курс":
                    course = "4";
                    break;
            }

            for (int i = 0; i < twoDownView.radGridView2.RowCount; i++) {
                string idCabinet = idCabinet = twoDownView.radGridView2.Rows[i].Cells[1].Value.ToString();
                string rating = twoDownView.radGridView2.Rows[i].Cells[2].Value.ToString();
                string queryString =
                    "INSERT INTO discipline_cabinet (ID_discipline, ID_cabinet, course, rating) " +
                    "VALUES (" + idDiscepline + "," + idCabinet + "," + course + "," + rating + ");";

                cmd.CommandText = queryString;
                cmd.ExecuteNonQuery();
            }
            
            sqlConnection.Close();
            tableMGMT.UpdateAll(scheduleDataSet);
            this.discipline_cabinetTableAdapter.Fill(this.scheduleDataSet.discipline_cabinet);

        }

        private void specialtyCourseButton_Click(object sender, EventArgs e) {
            twoDownView = new PanelTwoDownView(this, specialtyBindingSource, specialtyCourseButton);
            twoDownView.Dock = DockStyle.Left;

            radPanel1.Controls.Add(twoDownView);

            twoDownView.header.Text = "Преподаватели дисциплин на курсе";

            specialtyCourseButton.Enabled = false;
            twoDownView.radDropDownList1.DataSource = specialtyBindingSource;
            twoDownView.radDropDownList1.DisplayMember = "name_specialty";
            twoDownView.radDropDownList1.ValueMember = "name_specialty";

            supplierColumn = new GridViewComboBoxColumn {
                 Name = "supplierColumn",
                 HeaderText = "ФИО Преподавателя",
                 DataSource = this.employeeBindingSource,
                 ValueMember = "FIO",
                 DisplayMember = "FIO",
                 FieldName = "ФИО Преподавателя",
                 Width = 300
             };

            GridViewComboBoxColumn disceplineColumn = new GridViewComboBoxColumn {
                Name = "disceplineColumn",
                HeaderText = "Дисциплина",
                DataSource = this.disciplineBindingSource,
                ValueMember = "name_discipline",
                DisplayMember = "name_discipline",
                FieldName = "Наименование дисциплины",
                Width = 250
            };


            twoDownView.radGridView2.Columns.Add(disceplineColumn);
            twoDownView.radGridView2.Columns.Add(supplierColumn);
            twoDownView.radGridView2.Rows.Add("Русский язык", "Иванов Иван Иванович");
            twoDownView.radGridView2.Rows.Add("Иностранный язык", "Семёнов Николай Геннадьевич");
            twoDownView.radGridView2.Rows.Add("История", "Калюжная Маргарита Вячеславовна");
            twoDownView.radGridView2.Rows.Add("Физическая культура", "Шевченко Елена Викторовна");
            twoDownView.radGridView2.Rows.Add("ОБЖ", "Семёнов Николай Геннадьевич");
            twoDownView.radGridView2.Rows.Add("Обществознание", "Калюжная Маргарита Вячеславовна");
            twoDownView.radGridView2.Rows.Add("Математика", "Сахарова Наталья Евгеньевна");


            twoDownView.radGridView2.Height -= 110;

            buttonSave = new RadButton();
            twoDownView.radPanel2.Controls.Add(buttonSave);
            buttonSave.Location = new Point(497, 790);
            buttonSave.ThemeName = "Material";
            buttonSave.Text = "Добавить";

            buttonSave.Click += ButtonSave_Click2;

            //twoDownView.radGridView2.Columns[0].PropertyChanged += MainForm_PropertyChanged;

            //twoDownView.radGridView1.AutoGenerateColumns = false;

            //twoDownView.radGridView1.DataSource = this.employeeTableAdapter.GetDataBy(twoDownView.radGridView2.CurrentCell.Value.ToString());

            //supplierColumn.DataSource = Table;
            //supplierColumn.DisplayMember = Table.Tables[0].ToString();
            //twoDownView.radGridView2.Columns[0].IsVisible = false;
            //twoDownView.radGridView2.Columns[1].Width = 250;
            //twoDownView.radGridView2.Columns[1].HeaderText = "Наименование дисциплины";

            //twoDownView.radBindingNavigator1.DataBindings = twoDownView.radGridView2.DataBindings;
        }
        int digit = 0;
        private void ButtonSave_Click2(object sender, EventArgs e) {
            if (digit == 1) {
                twoDownView.Width -= 500;
                twoDownView.radPanel1.Width -= 480;
                twoDownView.radPanel2.Width -= 480;
                buttonSave.Text = "Добавить";
                digit = 0;
                twoDownView.closePanel.Location = new Point(twoDownView.closePanel.Location.X - 480, 12);
                return;
            }
            twoDownView.Width += 500;
            twoDownView.radPanel1.Width += 480;
            twoDownView.radPanel2.Width += 480;
            addTeachers addTeachers = new addTeachers(twoDownView.radGridView2, twoDownView.radBindingNavigator1);
            twoDownView.radPanel2.Controls.Add(addTeachers);
            addTeachers.Location = new Point(625, 12);
            twoDownView.closePanel.Location = new Point(twoDownView.closePanel.Location.X + 480, 12);

            GridViewCheckBoxColumn checkBoxColumn = new GridViewCheckBoxColumn();
            checkBoxColumn.DataType = typeof(int);
            checkBoxColumn.Name = "check";
            checkBoxColumn.FieldName = "Да/Нет";
            checkBoxColumn.HeaderText = "Да/Нет";

            GridViewTextBoxColumn gridViewTextBoxColumn = new GridViewTextBoxColumn();
            gridViewTextBoxColumn.Name = "dis";
            gridViewTextBoxColumn.HeaderText = "Наименование дисциплины";

            addTeachers.radGridView2.MasterTemplate.Columns.Add(checkBoxColumn);
            addTeachers.radGridView2.MasterTemplate.Columns.Add(gridViewTextBoxColumn);

            addTeachers.radGridView2.Rows.Add(false, "Русский язык");
            addTeachers.radGridView2.Columns[0].Width = 70;
            addTeachers.radGridView2.Columns[1].HeaderText = "Наименование дисциплины";
            addTeachers.radGridView2.Columns[1].Width = 320;



            addTeachers.radDropDownList1.DataSource = employeeBindingSource;
            addTeachers.radDropDownList1.DisplayMember = "FIO";
            addTeachers.radDropDownList1.ValueMember = "FIO";

            buttonSave.Text = "Закрыть";
            digit = 1;

        }

        private void MainForm_PropertyChanged(object sender, PropertyChangedEventArgs e) {
            //ChangeComboBox();
            try {
                supplierColumn.DataSource = this.employeeTableAdapter.GetDataBy(twoDownView.radGridView2.CurrentCell.Value.ToString());
            }
            catch (Exception) {

            }

        }

        private void fragmentSummaryButtn_Click(object sender, EventArgs e) {
            fragmentSummary = new PanelFragmentSummary(this, specialtyBindingSource, fragmentSummaryButton);
            fragmentSummary.Dock = DockStyle.Left;

            radPanel1.Controls.Add(fragmentSummary);

            fragmentSummaryButton.Enabled = false;
            fragmentSummary.radDropDownList1.DataSource = specialtyBindingSource;
            fragmentSummary.radDropDownList1.DisplayMember = "name_specialty";
            fragmentSummary.radDropDownList1.ValueMember = "name_specialty";

            GridViewTextBoxColumn gridViewTextBoxColumn = new GridViewTextBoxColumn();
            gridViewTextBoxColumn.Name = "dis";
            gridViewTextBoxColumn.HeaderText = "Наименование дисциплины";

            GridViewTextBoxColumn gridViewTextBoxColumn1 = new GridViewTextBoxColumn();
            gridViewTextBoxColumn1.Name = "hour";
            gridViewTextBoxColumn1.HeaderText = "Часы";

            GridViewTextBoxColumn gridViewTextBoxColumn2 = new GridViewTextBoxColumn();
            gridViewTextBoxColumn2.Name = "amount";
            gridViewTextBoxColumn2.HeaderText = "Количество пар";

            GridViewTextBoxColumn gridViewTextBoxColumn3 = new GridViewTextBoxColumn();
            gridViewTextBoxColumn3.Name = "teacher";
            gridViewTextBoxColumn3.HeaderText = "ФИО Преподавателя";

            fragmentSummary.radGridView1.MasterTemplate.Columns.Add(gridViewTextBoxColumn);
            fragmentSummary.radGridView1.MasterTemplate.Columns.Add(gridViewTextBoxColumn1);
            fragmentSummary.radGridView1.MasterTemplate.Columns.Add(gridViewTextBoxColumn2);
            fragmentSummary.radGridView1.MasterTemplate.Columns.Add(gridViewTextBoxColumn3);

            fragmentSummary.radGridView1.Columns[0].Width = 175;
            fragmentSummary.radGridView1.Columns[1].Width = 50;
            fragmentSummary.radGridView1.Columns[2].Width = 100;
            fragmentSummary.radGridView1.Columns[3].Width = 190;
        }


        //**************************************************************//
        //***********************MyFunc*********************************//

        private void CheckBoxTableDiscipline() {
            //проставляем галочки с таблицы teacher
            string idTeacher = "";
            string dis = "";
            string nameTeacher = panelJoin.radDropDownList1.SelectedValue.ToString();

            for (int i = 0; i < scheduleDataSet.Tables["employee"].Rows.Count; i++) {
                if (scheduleDataSet.Tables["employee"].Rows[i][1].ToString() == nameTeacher) {
                    idTeacher = scheduleDataSet.Tables["employee"].Rows[i][0].ToString();
                }
            }

            for (int i = 0; i < scheduleDataSet.Tables["teacher"].Rows.Count; i++) {
                if (scheduleDataSet.Tables["teacher"].Rows[i][0].ToString() == idTeacher) {
                    dis = scheduleDataSet.Tables["teacher"].Rows[i][1].ToString();
                    for (int j = 0; j < panelJoin.radGridView2.RowCount; j++) {
                        if (panelJoin.radGridView2.Rows[j].Cells[1].Value.ToString() == dis) {
                            panelJoin.radGridView2.Rows[j].Cells[0].Value = 1;
                        }
                    }
                }
            }
        }


        //проставляем звёздочки с таблицы discipline_cabinet
        private void CheckTableDisciplineCabinet() {
            string idDiscipline = "",
                   idCabinet = "",
                   course = "",
                   numCourse = "",
                   rating = "";

            for (int i = 0; i < twoDownView.radGridView2.RowCount; i++) {
                twoDownView.radGridView2.Rows[i].Cells[2].Value = 0;
            }

            for (int i = 0; i < scheduleDataSet.Tables["discipline"].Rows.Count; i++) {
                if (scheduleDataSet.Tables["discipline"].Rows[i][1].ToString() == twoDownView.radDropDownList1.SelectedValue.ToString()) {
                    idDiscipline = scheduleDataSet.Tables["discipline"].Rows[i][0].ToString();
                }
            }
            
            try {
                numCourse = twoDownView.radDropDownList2.SelectedItem.Text;
            }
            catch (Exception) {
                numCourse = "1 Курс";
            }

            switch (numCourse) {
                case "1 Курс":
                    course = "1";
                    break;
                case "2 Курс":
                    course = "2";
                    break;
                case "3 Курс":
                    course = "3";
                    break;
                case "4 Курс":
                    course = "4";
                    break;
            }
            for (int i = 0; i < scheduleDataSet.Tables["discipline_cabinet"].Rows.Count; i++) {
                int j = twoDownView.radGridView2.RowCount;
                if (scheduleDataSet.Tables["discipline_cabinet"].Rows[i][0].ToString() == idDiscipline && scheduleDataSet.Tables["discipline_cabinet"].Rows[i][2].ToString() == course) {
                    string cab = twoDownView.radGridView2.Rows[i].Cells[1].Value.ToString();
                    if (scheduleDataSet.Tables["discipline_cabinet"].Rows[i][1].ToString() == cab) {
                        twoDownView.radGridView2.Rows[i].Cells[2].Value = scheduleDataSet.Tables["discipline_cabinet"].Rows[i][3].ToString();
                    }
                }
            }
        }

        //При выборе одного выпадающего списка изменяется другой
        private string[] ChangeComboBox() {
            OleDbConnection sqlConnection = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.16.0;Data Source=|DataDirectory|\\schedule.accdb");
            sqlConnection.Open();
            OleDbCommand cmd = new OleDbCommand {
                Connection = sqlConnection,
                CommandType = CommandType.Text
            };

            string queryString =
                "SELECT employee.FIO " +
                "FROM teacher, discipline, employee " +
                "WHERE teacher.ID_discipline = discipline.ID_discipline AND " +
                "teacher.ID_teacher = employee.ID_teacher AND(discipline.name_discipline = '"+ twoDownView.radGridView2.CurrentCell.Value.ToString() +"')";

            cmd.CommandText = queryString;

            OleDbDataAdapter sqlDataAdapter = new OleDbDataAdapter(cmd);
            DataSet dataTable = new DataSet();
            sqlDataAdapter.Fill(dataTable);

            //TODO: странное получение списка из таблицы
            string[] Table = new string[dataTable.Tables[0].Rows.Count];
            for (int i = 0; i < dataTable.Tables[0].Rows.Count; i++) {
                Table[i] = dataTable.Tables[0].Rows[i][0].ToString();
            }

            sqlConnection.Close();
            return Table;
        }

        private void RefrechAll() {
            
        }

        private void radMenuItem1_Click(object sender, EventArgs e) {

        }

        private void radMenuItem5_Click(object sender, EventArgs e) {

        }

        private void radMenuItem9_Click(object sender, EventArgs e) {
           
        }

        private void radMenuItem17_Click(object sender, EventArgs e) {
            Report report = new Report();
            report.radPdfViewer1.LoadDocument("D:\\OneDrive\\work\\diplom\\begin\\screenshot\\Отчёты\\Список групп.pdf");
            report.Show();
        }

        private void radMenuItem18_Click(object sender, EventArgs e) {
            this.Close();
        }

        private int digit0 = 0;
        GeneralSchedulecs generalSchedule;
        private void scheduleButton_Click(object sender, EventArgs e) {



            generalSchedule = new GeneralSchedulecs();
            if (digit0 == 1) {
                //generalSchedule.Dispose();
                radPanel1.Controls.Clear();
                digit0 = 0;
                return;
            }
            else {
                timer1.Enabled = true;
                digit0 = 1;
                generalSchedule.Width = radPanel1.Width - 20;
                //generalSchedule.Height = radPanel1.Height;
                Thread.Sleep(600);
            }

        }

        private void radMenuItem11_Click(object sender, EventArgs e) {
            RadAboutBox1 aboutBox1 = new RadAboutBox1();
            aboutBox1.Show();
        }

        private void radMenuItem10_Click(object sender, EventArgs e) {
            Settings settings = new Settings(this);
            settings.Show();
        }

        private void radMenuItem12_Click(object sender, EventArgs e) {
            Report report = new Report();
            report.radPdfViewer1.LoadDocument("D:\\OneDrive\\work\\diplom\\begin\\screenshot\\Отчёты\\Расписание.pdf");
            report.Show();

        }

        private void radMenuItem13_Click(object sender, EventArgs e) {
            Report report = new Report();
            report.radPdfViewer1.LoadDocument("D:\\OneDrive\\work\\diplom\\begin\\screenshot\\Отчёты\\Сводная выписка.pdf");
            report.Show();
        }

        private void radMenuItem14_Click(object sender, EventArgs e) {
            Report report = new Report();
            report.radPdfViewer1.LoadDocument("D:\\OneDrive\\work\\diplom\\begin\\screenshot\\Отчёты\\Дисциплины преподавателя.pdf");
            report.Show();
        }

        private void radMenuItem15_Click(object sender, EventArgs e) {

        }

        private void radMenuItem16_Click(object sender, EventArgs e) {
            Report report = new Report();
            report.radPdfViewer1.LoadDocument("D:\\OneDrive\\work\\diplom\\begin\\screenshot\\Отчёты\\Время работы преподавателя.pdf");
            report.Show();
        }
        int ticks = 0;
        private void timer1_Tick(object sender, EventArgs e) {
            radProgressBar1.Visible = true;
            ticks += 2;
            radProgressBar1.Value1 = ticks;
            if (ticks == 100) {
                timer1.Enabled = false;
                radProgressBar1.Visible = false;
                radPanel1.Controls.Add(generalSchedule);
                ticks = 0;
            }
        }
    }
}
