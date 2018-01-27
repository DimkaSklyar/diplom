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
using System.Data.OleDb;


/*  !!!!!!!!!!!!!!!! ВАЖНО !!!!!!!!!!!!!!!!!!!!!!
    Обновление старых данных!
    Закрашивать синие квадраты в белые
    Вопрос об изменениях
     */

namespace schedule.mainPanelControls {
    public partial class PanelBusy : UserControl {
        Schedule OwnerForm;
        RadButton MainButton;
        BindingSource Source;
        int speedAnimation = 100;
        string id_teacher;
        public PanelBusy(Schedule ownerForm, BindingSource source, RadButton mainButton) {
            this.OwnerForm = ownerForm;
            this.MainButton = mainButton;
            this.Source = source;
            InitializeComponent();

            //Отображаем панель
            this.employeeTableAdapter.Fill(this.scheduleDataSet.employee);
            RefreshPictureBox();
        }
    
        /* *************************************************
         * *************************************************
         * ******************DevFunction********************
         * *************************************************
         * ************************************************* */

        //Обнуление сетки
        private void RefreshPictureBox() {

            //Делим PictureBox 6х6 
            pictureBox.Image = (Image)new Bitmap(pictureBox.Width, pictureBox.Height);
            Graphics g = Graphics.FromImage(pictureBox.Image);

            //Чёрными линиями
            Pen p = new Pen(Color.Black);

            for (int i = 0; i < 5; i++) {
                g.DrawLine(p, new Point((pictureBox.Width / 6 * (i + 1)), 0), new Point((pictureBox.Width / 6 * (i + 1)), pictureBox.Height));
                g.DrawLine(p, new Point(0, (pictureBox.Height / 6 * (i + 1))), new Point(pictureBox.Width, (pictureBox.Height / 6 * (i + 1))));
            }
        }

        private void BlueRectagle(MouseEventArgs e) {

            int X = pictureBox.Width / 6;       //ширина квадрата
            int Y = pictureBox.Height / 6;      //высота квадрата

            for (int i = 0; i < 7; i++) {
                if (e.X <= (X * i)) {
                    for (int j = 0; j < 7; j++) {
                        if (e.Y <= (Y * j)) {
                            Graphics a = Graphics.FromImage(pictureBox.Image);
                            a.FillRectangle(Brushes.Blue, (X * (i - 1)) + 1, (Y * (j - 1)) + 1, X - 1, Y - 1);
                            pictureBox.Refresh();

                            //Сообщения о активном в данный момент квадрате
                            //MessageBox.Show((X * (i - 1)).ToString() + ":" + (X * i).ToString() + " - " + (Y * (i1 - 1)).ToString() + ":" + (Y * i1).ToString());
                            break;
                        }
                    }
                    break;
                }
            }
        }


        /* *************************************************
         * *************************************************
         * ******************end****************************
         * *************************************************
         * ************************************************* */

        //если зажата левая клавиша мыши то при её движении, квадратики заполняются синим цветом, то есть True
        private void pictureBox_MouseMove(object sender, MouseEventArgs e) {

            if (e.Button == MouseButtons.Left) {
                BlueRectagle(e);
            }
        }

        //закрашиваем квадратик синим, при клике
        private void pictureBox_MouseClick(object sender, MouseEventArgs e) {
            BlueRectagle(e);
        }

        private void radPanel6_Initialized(object sender, EventArgs e) {

            //-99 Высота подогнанная под окно программы в полном режиме, -500 спрятано по Y появляется при анимации.
            radPanel6.Height = OwnerForm.Height - 99;
            radPanel6.Location = new Point(-500, 1);
            //Запускаем анимацию
            timer1.Enabled = true;
            //radGridView1.Height = radPanel1.Height - 117;
        }


        //Анимация появления
        private void timer1_Tick(object sender, EventArgs e) {
            if (radPanel6.Location.X >= 0) {
                timer1.Enabled = false;
                radPanel6.Location = new Point(radPanel6.Location.X + 1, 1);

                //ВАЖНО!!!!!!
                //при появлении панели, выбираем первую строку и делаем клик с ID преподавателя равным 1
                radGridView1.Rows[0].Cells[1].IsSelected = true;
                id_teacher = "1";
                radGridView1_Click(sender, e);
            }
            else
                radPanel6.Location = new Point(radPanel6.Location.X + speedAnimation, 1);
        }

        //Анимация закрытия
        private void timer2_Tick(object sender, EventArgs e) {
            if (radPanel6.Location.X <= -500) {
                timer2.Enabled = false;
                radPanel6.Location = new Point(radPanel6.Location.X, 1);

                //Уничтожаем объекты панели.
                OwnerForm.countPanel--;
                this.Dispose();
            }
            else
                radPanel6.Location = new Point(radPanel6.Location.X - speedAnimation, 1);
        }

        private void closePanel_Click(object sender, EventArgs e) {

            //Прекращаем редактирование
            employeeBindingSource.EndEdit();
            //Сохраняем данные
            OwnerForm.tableMGMT.UpdateAll(OwnerForm.scheduleDataSet);

            //Включаем кнопку
            MainButton.Enabled = true;
            //Запускаем анимацию скрытия панели
            timer2.Enabled = true;
        }

        private void radGridView1_Click(object sender, EventArgs e) {

            RefreshPictureBox();

            int X = pictureBox.Width / 6;
            int Y = pictureBox.Height / 6;

            try {
                //ID преподавателя [строка][первый столбец] при клике на одно из значений GridView
                id_teacher = radGridView1.Rows[radGridView1.CurrentCell.RowIndex].Cells[radGridView1.CurrentCell.ColumnIndex - 1].Value.ToString();
            }
            catch { }

            //проходим по всем строкам таблицы time_work_teachers
            //если строка соответствует ID преподавателя, тогда
            //берём эту строку и смотрим в ней колонки, если колонка в данной строке равна True
            //закрашиваем на сетке квадрат в синний цвет равный:
            //по строке равный номеру пары (numDouble) 
            //по колонке равный колонке таблицы + 3 (нулевая строка ID, первая строка №пары, вторая строка Время)
            for (int i = 0; i < OwnerForm.scheduleDataSet.Tables["time_work_teachers"].Rows.Count; i++) 
                {
                if (OwnerForm.scheduleDataSet.Tables["time_work_teachers"].Rows[i][0].ToString() == id_teacher) 
                    {
                    for (int j = 3; j < OwnerForm.scheduleDataSet.Tables["time_work_teachers"].Columns.Count; j++) 
                        {
                        if (OwnerForm.scheduleDataSet.Tables["time_work_teachers"].Rows[i][j].ToString() == "True") 
                            {
                            int numDouble = Int32.Parse(OwnerForm.scheduleDataSet.Tables["time_work_teachers"].Rows[i][1].ToString()) - 1; //номер пары
                            Graphics a = Graphics.FromImage(pictureBox.Image);
                            a.FillRectangle(Brushes.Blue, ((j - 3) * 57)+1, (numDouble * 40)+1, X -1, Y -1);
                            pictureBox.Refresh();
                        }
                    }
                }
            }
        }

        //сохранение данных из сетки в БД
        private void radButton1_Click(object sender, EventArgs e) {
            OleDbConnection sqlConnection = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.16.0;Data Source=|DataDirectory|\\schedule.accdb");
            sqlConnection.Open();
            OleDbCommand cmd = new OleDbCommand();
            cmd.Connection = sqlConnection;
            cmd.CommandType = CommandType.Text;


            int numDouble = 0;  //счётчик "Учебной пары" для записи в БД
            int X = pictureBox.Width / 6;
            int Y = pictureBox.Height / 6;

            bool[] dayweek = new bool[6];   //Массив для "Работает в этот день, в этот час преподаватель или нет"

            id_teacher = radGridView1.Rows[radGridView1.CurrentCell.RowIndex].Cells[radGridView1.CurrentCell.ColumnIndex - 1].Value.ToString();

            //От нуля до Шести проходим по всей сетки, по каждому квадрату
            //проверяет точку в цетре каждого квадрата на цвет Синий - True, Белый - False
            //записываем данные в массив
            for (int i = 0; i < 6; i++) {
                for (int j = 3; j < OwnerForm.scheduleDataSet.Tables["time_work_teachers"].Columns.Count; j++) {
                    Graphics a = Graphics.FromImage(pictureBox.Image);
                    if (((Bitmap)pictureBox.Image).GetPixel(((j - 2) * 57) - 28, (i * 40) + 20).ToArgb() == Color.Blue.ToArgb()) {
                        dayweek[j - 3] = true;
                    }
                    else {
                        dayweek[j - 3] = false;
                    }
                }
                numDouble++; // +1 Номер "Учебной пары"

                //Запрос на добавление строки в таблицу
                string queryString =
                    "INSERT INTO time_work_teachers (ID_teacher, `double`, double_time, monday, tuesday, wednesday, thursday, friday, Saturday) " +
                    "VALUES (" + id_teacher + "," + (numDouble) + "," + "'test'" + "," + dayweek[0] + "," + dayweek[1] + "," + dayweek[2]
                    + "," + dayweek[3] + "," + dayweek[4] + "," + dayweek[5] + ");";

                //MessageBox.Show(queryString);     //Посмотреть запрос....
                cmd.CommandText = queryString;
                cmd.ExecuteNonQuery();
            }
            sqlConnection.Close();
            OwnerForm.time_work_teachersTableAdapter.Fill(OwnerForm.scheduleDataSet.time_work_teachers);
        }
    }
}
