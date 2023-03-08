using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SkibenkoBD
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void сотрудникиBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.сотрудникиBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.skibenkoDb);

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "skibenkoDb.Сотрудники". При необходимости она может быть перемещена или удалена.
            this.сотрудникиTableAdapter.Fill(this.skibenkoDb.Сотрудники);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.сотрудникиBindingSource.MoveFirst();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.сотрудникиBindingSource.MovePrevious();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.сотрудникиBindingSource.AddNew();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.сотрудникиBindingSource.MoveLast();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.сотрудникиBindingSource.MoveNext();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.сотрудникиBindingSource.RemoveCurrent();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.сотрудникиBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.skibenkoDb);
        }

        private void сотрудникиBindingNavigator_RefreshItems(object sender, EventArgs e)
        {

        }
    }
}
