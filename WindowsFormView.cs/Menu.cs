using System;
using System.Windows.Forms;
using WindowsFormView.cs.TelasDisciplina;
using WindowsFormView.cs.TelasProfessor;
using WindowsFormView.TelasAluno;

namespace WindowsFormView.cs
{
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        private void btnAlunos_Click(object sender, EventArgs e)
        {
            frmCadastroAluno f = new frmCadastroAluno();
            f.ShowDialog();
            f.Dispose();
        }

        private void btnProfessores_Click(object sender, EventArgs e)
        {
            frmCadastroProfessor f = new frmCadastroProfessor();
            f.ShowDialog();
            f.Dispose();
        }

        private void btnDisciplinas_Click(object sender, EventArgs e)
        {
            frmCadastroDisciplina f = new frmCadastroDisciplina();
            f.ShowDialog();
            f.Dispose();
        }
    }
}
