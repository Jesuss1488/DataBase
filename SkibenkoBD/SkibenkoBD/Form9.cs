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
    public partial class Form9 : Form
    {
        public Form9()
        {
            InitializeComponent();
        }

        private void книгиBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.книгиBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.skibenkoDb);

        }

        private void Form9_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'skibenkoDb.Книги' table. You can move, or remove it, as needed.
            this.книгиTableAdapter.Fill(this.skibenkoDb.Книги);

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.DataGridViewColumn Col = default(System.Windows.Forms.DataGridViewColumn);
            switch (listBox1.SelectedIndex)
            {
                case 0:
                    Col = dataGridViewTextBoxColumn1;
                    break;
                case 1:
                    Col = dataGridViewTextBoxColumn2;
                    break;
                case 2:
                    Col = dataGridViewTextBoxColumn3;
                    break;
                case 3:
                    Col = dataGridViewTextBoxColumn4;
                    break;
                case 4:
                    Col = dataGridViewTextBoxColumn5;
                    break;
            }
            if (radioButton1.Checked)
            {
                книгиDataGridView.Sort(Col, System.ComponentModel.ListSortDirection.Ascending);
            }
            else
            {
                книгиDataGridView.Sort(Col, System.ComponentModel.ListSortDirection.Descending);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            книгиBindingSource.Filter = "Год_издания=" + comboBox1.Text + "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            книгиBindingSource.Filter = "";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int i = 0;
            int j = 0;

            for (i = 0; i < книгиDataGridView.ColumnCount - 1; i++ )
            {
                for (j = 0; j < книгиDataGridView.RowCount - 1; j++ )
                {
                    книгиDataGridView.Rows[j].Cells[i].Style.BackColor = Color.White;
                    книгиDataGridView.Rows[j].Cells[i].Style.ForeColor = Color.Black;
                }
            }

            for (i = 0; i < книгиDataGridView.ColumnCount; i++)
            {
                for (j = 0; j < книгиDataGridView.RowCount; j++)
                {
                    var value = книгиDataGridView.Rows[j].Cells[i].Value;
                    if (value != null)
                    {
                        string baseStr = value.ToString();

                        if (baseStr.IndexOf(textBox1.Text) > -1)
                        {
                            книгиDataGridView.Rows[j].Cells[i].Style.BackColor = Color.Aqua;
                            книгиDataGridView.Rows[j].Cells[i].Style.ForeColor = Color.Blue;
                        }
                    }
                }
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
