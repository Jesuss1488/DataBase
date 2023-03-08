﻿using System;
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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void книгиBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.книгиBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.skibenkoDb);

        }

        private void Form6_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "skibenkoDb.Книги". При необходимости она может быть перемещена или удалена.
            this.книгиTableAdapter.Fill(this.skibenkoDb.Книги);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.книгиBindingSource.MoveFirst();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.книгиBindingSource.MovePrevious();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.книгиBindingSource.AddNew();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.книгиBindingSource.MoveLast();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.книгиBindingSource.MoveNext();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.книгиBindingSource.RemoveCurrent();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.книгиBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.skibenkoDb);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Form9 frm = new Form9();
            frm.Show();
        }
    }
}
