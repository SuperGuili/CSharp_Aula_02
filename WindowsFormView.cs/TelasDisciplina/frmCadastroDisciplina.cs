using Controllers;
using Modelos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormView.cs.TelasDisciplina
{
    public partial class frmCadastroDisciplina : Form
    {
        public frmCadastroDisciplina()
        {
            InitializeComponent();
        }

        private void frmCadastroDisciplina_Load(object sender, EventArgs e)
        {
            this.AlterarBotoes(1);

           // ProfessoresController professoresController = new ProfessoresController();

           // cmbProfDisciplina.DataSource = professoresController.BuscarPorNome();
           
        }

        public void LimparCampos()
        {
            txtCodDisciplina.Text = string.Empty;
            txtMateria.Text = string.Empty;
            cmbProfDisciplina.Text = string.Empty;
            cmbAnoLetivo.Text = string.Empty;
            
            this.AlterarBotoes(1);
        }

        public void AlterarBotoes(int op)
        {

            btnSalvarDisciplina.Enabled = false;
            btnLocalizarDisciplina.Enabled = false;
            btnAlterarDisciplina.Enabled = false;
            btnExcluirDisciplina.Enabled = false;
            btnCancelarDisciplina.Enabled = false;

            if (op == 1)
            {
                btnSalvarDisciplina.Enabled = true;
                btnLocalizarDisciplina.Enabled = true;
                btnCancelarDisciplina.Enabled = true;
            }

            if (op == 2)
            {
                btnSalvarDisciplina.Enabled = false;
                btnLocalizarDisciplina.Enabled = true;
                btnAlterarDisciplina.Enabled = true;
                btnExcluirDisciplina.Enabled = true;
                btnCancelarDisciplina.Enabled = true;
            }

        }

        private void btnSalvarDisciplina_Click(object sender, EventArgs e)
        {
            Disciplina novadisciplina = new Disciplina();

            if (txtMateria.Text != "" && txtCodDisciplina.Text != "")
            {
                novadisciplina.Materia = txtMateria.Text;
                novadisciplina.Codigo = int.Parse(txtCodDisciplina.Text);
                novadisciplina.Professor = cmbProfDisciplina.Text;
                novadisciplina.AnoLetivo = cmbAnoLetivo.Text;

                DisciplinasController disciplinasController = new DisciplinasController();
                disciplinasController.Inserir(novadisciplina);

                this.LimparCampos();
                MessageBox.Show("Disciplina Cadastrada com sucesso!", "AVISO");
            }
            else
            {
                MessageBox.Show("Obrigatório digitar um Código e Escolher um Professor", "AVISO");
            }
        }

        private void btnLocalizarDisciplina_Click(object sender, EventArgs e)
        {
            frmListaDisciplinas f = new frmListaDisciplinas();
            f.ShowDialog();

            if (f.ID != 0)
            {
                Disciplina disciplina = new Disciplina();
                DisciplinasController disciplinasController = new DisciplinasController();

                disciplina = disciplinasController.BuscarPorID(f.ID);

                txtMateria.Text = disciplina.Materia;
                txtCodDisciplina.Text = disciplina.Codigo.ToString();
                cmbProfDisciplina.Text = disciplina.Professor.ToString();
                cmbAnoLetivo.Text = disciplina.AnoLetivo.ToString();

                this.AlterarBotoes(2);
            }
        }

        private void btnAlterarDisciplina_Click(object sender, EventArgs e)
        {

        }

        private void btnExcluirDisciplina_Click(object sender, EventArgs e)
        {

        }

        private void btnCancelarDisciplina_Click(object sender, EventArgs e)
        {

        }
    }
}
