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
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
        }

        private void выданные_книгиBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.выданные_книгиBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.skibenkoDb);

        }

        private void Form8_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "skibenkoDb.Книги". При необходимости она может быть перемещена или удалена.
            this.книгиTableAdapter.Fill(this.skibenkoDb.Книги);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "skibenkoDb.Выданные_книги". При необходимости она может быть перемещена или удалена.
            this.выданные_книгиTableAdapter.Fill(this.skibenkoDb.Выданные_книги);

        }

        private void отметка_о_возвратеTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

       
    }
}
