using Controllers;
using System;
using System.Windows.Forms;

namespace WindowsFormView.cs.TelasAluno
{
    public partial class frmListaAlunos : Form
    {
        public int ID = 0;

        public frmListaAlunos()
        {
            InitializeComponent();
        }

        private void frmListaAlunos_Load(object sender, EventArgs e)
        {
            // preencher a lista ao carregar a tela (LOAD)
            AlunosController alunosController = new AlunosController();
            
            dgvAlunos.DataSource = alunosController.ListarTodos();
            dgvAlunos.Columns[0].Visible = false;
            
        }

        private void dgvAlunos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex >= 0)
            {
                this.ID = Convert.ToInt32(dgvAlunos.Rows[e.RowIndex].Cells[0].Value);
                Close();
                               
            }
        }
    }
}
