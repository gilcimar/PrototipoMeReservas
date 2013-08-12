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
    public partial class Categoria : Form
    {
        public Categoria()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            switch (e.ColumnIndex)
            {
                case 2:
                //chamar função Tarifa
                    Tarifas tarifas = new Tarifas();
                    tarifas.Show();
                    break;

                case 3:
                //chamar função Disponibilidade
                    Disponibilidade disponibilidade = new Disponibilidade();
                    disponibilidade.Show();
                    break;
                case 4:
                //chamar função Detalhes
                    DetalhesCategoria detalhesCategoria = new DetalhesCategoria();
                    detalhesCategoria.Show();
                    break;
                case 5:
                //Editar
                    EditarCategoria editarCategoria = new EditarCategoria();
                    editarCategoria.Show();
                    break;
                case 6:
                //Excluir
                    MessageBox.Show("Esta ação mudará o status desta categoria para Excluída. Deseja continuar?");
                    break;
            }
            ;

        }
    }
}
