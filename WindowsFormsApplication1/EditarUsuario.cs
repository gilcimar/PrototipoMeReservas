using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class EditarUsuario : Form
    {
        public EditarUsuario()
        {
            InitializeComponent();

            textBox1.Visible = true;
            textBox2.Visible = true;
            textBox3.Visible = true;
            textBox4.Visible = true;
            label2.Visible = true;
            label3.Visible = true;
            label4.Visible = true;
            label5.Visible = true;
            label6.Visible = true;
            checkBox1.Visible = true;
            comboBox1.Visible = true;

            dataGridView1.Visible = false;

            label7.Visible = false;
            comboBox2.Visible = false;
            dataGridView2.Visible = false;
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void ffToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.Visible = true;
            textBox2.Visible = true;
            textBox3.Visible = true;
            textBox4.Visible = true;
            label2.Visible   = true;
            label3.Visible   = true;
            label4.Visible   = true;
            label5.Visible   = true;
            label6.Visible   = true;
            checkBox1.Visible = true;
            comboBox1.Visible = true;

            label7.Visible = false;
            comboBox2.Visible = false;
            dataGridView2.Visible = false;

            dataGridView1.Visible = false;
        }

        private void gruposToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.Visible = false;
            textBox2.Visible = false;
            textBox3.Visible = false;
            textBox4.Visible = false;
            label2.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
            label5.Visible = false;
            label6.Visible = false;
            checkBox1.Visible = false;
            comboBox1.Visible = false;

            label7.Visible = false;
            comboBox2.Visible = false;
            dataGridView2.Visible = false;

            dataGridView1.Visible = true;
        }

        private void fToolStripMenuItem_Click(object sender, EventArgs e)
        {
            label7.Visible    = true;
            comboBox2.Visible = true;
            dataGridView2.Visible = true;

            textBox1.Visible = false;
            textBox2.Visible = false;
            textBox3.Visible = false;
            textBox4.Visible = false;
            label2.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
            label5.Visible = false;
            label6.Visible = false;
            checkBox1.Visible = false;
            comboBox1.Visible = false;

            dataGridView1.Visible = false;


        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
