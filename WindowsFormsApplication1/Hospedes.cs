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
    public partial class Hospedes : Form
    {
        public Hospedes()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            switch (e.ColumnIndex)
            {

                case 4:
                    //chamar função quartos
                    DetalhesHospede detalhesHospede = new DetalhesHospede();
                    detalhesHospede.Show();
                    break;
                case 3:
                    //chamar função Detalhes hospede
                    Reservas reservas = new Reservas();
                    reservas.Show();
                    break;

            }
        }
    }
}
