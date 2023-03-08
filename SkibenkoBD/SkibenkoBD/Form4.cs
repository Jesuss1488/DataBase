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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void издательстваBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.издательстваBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.skibenkoDb);

        }

        private void Form4_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "skibenkoDb.Издательства". При необходимости она может быть перемещена или удалена.
            this.издательстваTableAdapter.Fill(this.skibenkoDb.Издательства);

        }
    }
}
