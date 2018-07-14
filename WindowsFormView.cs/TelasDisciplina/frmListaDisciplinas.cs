using System;
using System.Windows.Forms;
using Controllers;

namespace WindowsFormView.cs.TelasDisciplina
{
    public partial class frmListaDisciplinas : Form
    {
        public int ID = 0;

        public frmListaDisciplinas()
        {
            InitializeComponent();
        }

        private void frmListaDisciplinas_Load(object sender, EventArgs e)
        {
            DisciplinasController disciplinasController = new DisciplinasController();

            dgvDisciplinas.DataSource = disciplinasController.ListarTodos();
            dgvDisciplinas.Columns[0].Visible = false;
        }
    }
}
