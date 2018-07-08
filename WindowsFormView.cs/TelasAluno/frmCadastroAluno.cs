using System;
using System.Windows.Forms;
using Modelos;
using Controllers;
using WindowsFormView.cs.TelasAluno;

namespace WindowsFormView.TelasAluno
{
    public partial class frmCadastroAluno : Form
    {
        public frmCadastroAluno()
        {
            InitializeComponent();
        }

        private void frmCadastroAluno_Load(object sender, EventArgs e)
        {
            this.AlterarBotoes(1);
        }

        public void LimparCampos()
        {
            txtIDAluno.Text = string.Empty;
            txtNomeAluno.Text = string.Empty;
            txtMatricula.Text = string.Empty;
            txtEmailAluno.Text = string.Empty;
            cmbAnoAluno.Text = string.Empty;
            txtFoneAluno.Text = string.Empty;

            this.AlterarBotoes(1);

        }

        public void AlterarBotoes(int op)
        {
            
            btnSalvarAluno.Enabled = false;
            btnLocalizarAluno.Enabled = false;
            btnAlterarAluno.Enabled = false;
            btnExcluirAluno.Enabled = false;
            btnCancelarAluno.Enabled = false;

            if (op == 1)
            {
                btnSalvarAluno.Enabled = true;
                btnLocalizarAluno.Enabled = true;
                btnCancelarAluno.Enabled = true;
            }

            if (op == 2)
            {
                btnSalvarAluno.Enabled = false;
                btnLocalizarAluno.Enabled = true;
                btnAlterarAluno.Enabled = true;
                btnExcluirAluno.Enabled = true;
                btnCancelarAluno.Enabled = true;
            }

        }

        private void btnSalvarAluno_Click(object sender, EventArgs e)
        {
            Aluno novoaluno = new Aluno();

            if (txtNomeAluno.Text != "" && txtMatricula.Text != "")
            {
                novoaluno.Nome = txtNomeAluno.Text;
                novoaluno.Matricula = int.Parse(txtMatricula.Text);
                novoaluno.EmailAluno = txtEmailAluno.Text;
                novoaluno.AnoAluno = cmbAnoAluno.Text;
                novoaluno.FoneAluno = txtFoneAluno.Text;

                AlunosController alunosController = new AlunosController();
                alunosController.Inserir(novoaluno);

                this.LimparCampos();
                MessageBox.Show("Aluno Cadastrado com sucesso!", "AVISO");
            }
            else
            {
                MessageBox.Show("Obrigatório digitar um nome e uma matrícula", "AVISO");
            }
        }

        private void btnLocalizarAluno_Click(object sender, EventArgs e)
        {
            frmListaAlunos f = new frmListaAlunos();
            f.ShowDialog();

            if (f.ID != 0)
            {
                Aluno aluno = new Aluno();
                AlunosController alunosController = new AlunosController();

                aluno = alunosController.BuscarPorID(f.ID);

                txtNomeAluno.Text = aluno.Nome;
                txtMatricula.Text = aluno.Matricula.ToString();
                txtIDAluno.Text = aluno.AlunoID.ToString();
                txtEmailAluno.Text = aluno.EmailAluno.ToString();
                cmbAnoAluno.Text = aluno.AnoAluno.ToString();
                txtFoneAluno.Text = aluno.FoneAluno.ToString();

                this.AlterarBotoes(2);
            }
            
        }

        private void btnAlterarAluno_Click(object sender, EventArgs e)
        {
            if (txtNomeAluno.Text != "" && txtMatricula.Text != "")
            {
                Aluno aluno = new Aluno();
                AlunosController alunosController = new AlunosController();
                aluno = alunosController.BuscarPorID(int.Parse(txtIDAluno.Text));

                aluno.Nome = txtNomeAluno.Text;
                aluno.Matricula = int.Parse(txtMatricula.Text);
                aluno.EmailAluno = txtEmailAluno.Text;
                aluno.AnoAluno = cmbAnoAluno.Text;
                aluno.FoneAluno = txtFoneAluno.Text;

                alunosController.Atualizar(aluno);
                this.LimparCampos();
                MessageBox.Show("Dados do Aluno Alterados com sucesso", "AVISO");
            }
            else
            {
                MessageBox.Show("Obrigatório digitar um nome e uma matrícula", "AVISO");
            }
        }

        private void btnCancelarAluno_Click(object sender, EventArgs e)
        {
            this.LimparCampos();
        }

        private void btnExcluirAluno_Click(object sender, EventArgs e)
        {
            DialogResult d = MessageBox.Show("Realmente deseja Excluir?", "AVISO", MessageBoxButtons.YesNo);
            if (d.ToString() == "Yes")
            {
                Aluno aluno = new Aluno();
                AlunosController alunosController = new AlunosController();
                aluno = alunosController.BuscarPorID(int.Parse(txtIDAluno.Text));
                alunosController.Excluir(aluno.AlunoID);
                this.LimparCampos();
                MessageBox.Show("Aluno excluído do sistema!", "AVISO");
            }
        } 
    }
}