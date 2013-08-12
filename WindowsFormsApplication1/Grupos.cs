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
    public partial class Grupos : Form
    {
        public Grupos()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Grupos_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'meReservasDsvDataSet.GrupoUsuario' table. You can move, or remove it, as needed.
            this.grupoUsuarioTableAdapter.Fill(this.meReservasDsvDataSet.GrupoUsuario);
            // TODO: This line of code loads data into the 'meReservasDsvDataSet.Grupo' table. You can move, or remove it, as needed.
            this.grupoTableAdapter.Fill(this.meReservasDsvDataSet.Grupo);

        }

        private void grupoDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            EditarGrupo editarGrupo = new EditarGrupo();
            editarGrupo.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            EditarGrupo editarGrupo = new EditarGrupo();
            editarGrupo.Show();
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            EditarGrupo editarGrupo = new EditarGrupo();
            editarGrupo.ShowDialog();
        }
    }
}
