using System;
using System.Windows.Forms;
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
    }
}
