using Modelos;
using System;
using System.Windows.Forms;
using Controllers;

namespace WindowsFormView.cs.TelasProfessor
{
    public partial class frmCadastroProfessor : Form
    {
        public frmCadastroProfessor()
        {
            InitializeComponent();
        }

        private void frmCadastroProfessor_Load(object sender, EventArgs e)
        {
            this.AlterarBotoes(1);
        }

        public void LimparCampos()
        {
            txtIDProfessor.Text = string.Empty;
            txtNomeProfessor.Text = string.Empty;
            txtCPF.Text = string.Empty;
            txtEmailProfessor.Text = string.Empty;
            cmbFormacao.Text = string.Empty;
            txtFoneProfessor.Text = string.Empty;

            this.AlterarBotoes(1);
        }

        public void AlterarBotoes(int op)
        {

            btnSalvarProfessor.Enabled = false;
            btnLocalizarProfessor.Enabled = false;
            btnAlterarProfessor.Enabled = false;
            btnExcluirProfessor.Enabled = false;
            btnCancelarProfessor.Enabled = false;

            if (op == 1)
            {
                btnSalvarProfessor.Enabled = true;
                btnLocalizarProfessor.Enabled = true;
                btnCancelarProfessor.Enabled = true;
            }

            if (op == 2)
            {
                btnSalvarProfessor.Enabled = false;
                btnLocalizarProfessor.Enabled = true;
                btnAlterarProfessor.Enabled = true;
                btnExcluirProfessor.Enabled = true;
                btnCancelarProfessor.Enabled = true;
            }

        }

        private void btnSalvarProfessor_Click(object sender, EventArgs e)
        {
            Professor novoprofessor = new Professor();

            if (txtNomeProfessor.Text != "" && txtCPF.Text != "")
            {
                novoprofessor.NomeProfessor = txtNomeProfessor.Text;
                novoprofessor.CPF = txtCPF.Text;
                novoprofessor.EmailProfessor = txtEmailProfessor.Text;
                novoprofessor.Formacao = cmbFormacao.Text;
                novoprofessor.FoneProfessor = txtFoneProfessor.Text;

                ProfessoresController professorsController = new ProfessoresController();
                professorsController.Inserir(novoprofessor);

                this.LimparCampos();
                MessageBox.Show("Professor Cadastrado com sucesso!", "AVISO");
            }
            else
            {
                MessageBox.Show("Obrigatório digitar um nome e um CPF", "AVISO");
            }
        }

        private void btnLocalizarProfessor_Click(object sender, EventArgs e)
        {
            frmListaProfessores f = new frmListaProfessores();
            f.ShowDialog();

            if (f.ID != 0)
            {
                Professor professor = new Professor();
                ProfessoresController professoresController = new ProfessoresController();

                professor = professoresController.BuscarPorID(f.ID);

                txtNomeProfessor.Text = professor.NomeProfessor;
                txtCPF.Text = professor.CPF.ToString();
                txtIDProfessor.Text = professor.ProfessorID.ToString();
                txtEmailProfessor.Text = professor.EmailProfessor.ToString();
                cmbFormacao.Text = professor.Formacao.ToString();
                txtFoneProfessor.Text = professor.FoneProfessor.ToString();

                this.AlterarBotoes(2);
            }
        }

        private void btnAlterarProfessor_Click(object sender, EventArgs e)
        {
            if (txtNomeProfessor.Text != "" && txtCPF.Text != "")
            {
                Professor professor = new Professor();
                ProfessoresController professoresController = new ProfessoresController();
                professor = professoresController.BuscarPorID(int.Parse(txtIDProfessor.Text));

                professor.NomeProfessor = txtNomeProfessor.Text;
                professor.CPF = txtCPF.Text;
                professor.EmailProfessor = txtEmailProfessor.Text;
                professor.Formacao = cmbFormacao.Text;
                professor.FoneProfessor = txtFoneProfessor.Text;

                professoresController.Atualizar(professor);
                this.LimparCampos();
                MessageBox.Show("Dados do Professor Alterados com sucesso", "AVISO");
            }
            else
            {
                MessageBox.Show("Obrigatório digitar um nome e um CPF", "AVISO");
            }
        }

        private void btnCancelarProfessor_Click(object sender, EventArgs e)
        {
            this.LimparCampos();
        }

        private void btnExcluirProfessor_Click(object sender, EventArgs e)
        {
            DialogResult d = MessageBox.Show("Realmente deseja Excluir?", "AVISO", MessageBoxButtons.YesNo);
            if (d.ToString() == "Yes")
            {
                Professor professor = new Professor();
                ProfessoresController professoresController = new ProfessoresController();
                professor = professoresController.BuscarPorID(int.Parse(txtIDProfessor.Text));
                professoresController.Excluir(professor.ProfessorID);
                this.LimparCampos();
                MessageBox.Show("Professor excluído do sistema!", "AVISO");
            }
        }
    }
}
