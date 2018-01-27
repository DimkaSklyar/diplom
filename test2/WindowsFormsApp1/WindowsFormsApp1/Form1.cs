using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1 {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dBDataSet.Таблица1". При необходимости она может быть перемещена или удалена.
            this.таблица1TableAdapter.Fill(this.dBDataSet.Таблица1);
            this.таблица2TableAdapter1.Fill(this.dBDataSet.Таблица2);

        }

        private void сохранитьToolStripButton_Click(object sender, EventArgs e) {
            this.Validate();
            this.таблица1BindingSource.EndEdit();
            this.таблица1Таблица2BindingSource.EndEdit();
            this.tableAdapterManager1.UpdateAll(this.dBDataSet);
        }
    }
}
