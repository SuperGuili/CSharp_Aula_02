using Controllers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormView.cs.TelasProfessor
{
    public partial class frmListaProfessores : Form
    {
        public int ID = 0;

        public frmListaProfessores()
        {
            InitializeComponent();
        }

        private void frmListaProfessores_Load(object sender, EventArgs e)
        {
            // preencher a lista ao carregar a tela (LOAD)
            ProfessoresController professoresController = new ProfessoresController();

            dgvProfessores.DataSource = professoresController.ListarTodos();
            dgvProfessores.Columns[0].Visible = false;
        }

        private void dgvProfessores_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex >= 0 && e.RowIndex > -1)
            {
                this.ID = Convert.ToInt32(dgvProfessores.Rows[e.RowIndex].Cells[0].Value);
                Close();
            }
        }

        private void btnAcharProfessor_Click(object sender, EventArgs e)
        {
            ProfessoresController professorController = new ProfessoresController();

            dgvProfessores.DataSource = professorController.BuscarPorNomeProfessor(txtAcharProfessor.Text);
        }
    }
}
