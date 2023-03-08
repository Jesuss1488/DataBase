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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void жанрыBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.жанрыBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.skibenkoDb);

        }

        private void Form5_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "skibenkoDb.Жанры". При необходимости она может быть перемещена или удалена.
            this.жанрыTableAdapter.Fill(this.skibenkoDb.Жанры);

        }
    }
}
