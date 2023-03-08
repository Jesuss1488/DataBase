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
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        private void читателиBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.читателиBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.skibenkoDb);

        }

        private void Form7_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "skibenkoDb.Читатели". При необходимости она может быть перемещена или удалена.
            this.читателиTableAdapter.Fill(this.skibenkoDb.Читатели);

        }
    }
}
