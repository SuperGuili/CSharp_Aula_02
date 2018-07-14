namespace WindowsFormView.cs.TelasDisciplina
{
    partial class frmCadastroDisciplina
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCodDisciplina = new System.Windows.Forms.TextBox();
            this.txtMateria = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbProfDisciplina = new System.Windows.Forms.ComboBox();
            this.professoresControllerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbAnoLetivo = new System.Windows.Forms.ComboBox();
            this.btnExcluirDisciplina = new System.Windows.Forms.Button();
            this.btnAlterarDisciplina = new System.Windows.Forms.Button();
            this.btnLocalizarDisciplina = new System.Windows.Forms.Button();
            this.btnCancelarDisciplina = new System.Windows.Forms.Button();
            this.btnSalvarDisciplina = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.professoresControllerBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Código";
            // 
            // txtCodDisciplina
            // 
            this.txtCodDisciplina.Location = new System.Drawing.Point(16, 30);
            this.txtCodDisciplina.Name = "txtCodDisciplina";
            this.txtCodDisciplina.Size = new System.Drawing.Size(66, 20);
            this.txtCodDisciplina.TabIndex = 1;
            // 
            // txtMateria
            // 
            this.txtMateria.Location = new System.Drawing.Point(187, 30);
            this.txtMateria.Name = "txtMateria";
            this.txtMateria.Size = new System.Drawing.Size(315, 20);
            this.txtMateria.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(184, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Matéria";
            // 
            // cmbProfDisciplina
            // 
            this.cmbProfDisciplina.FormattingEnabled = true;
            this.cmbProfDisciplina.Location = new System.Drawing.Point(16, 83);
            this.cmbProfDisciplina.Name = "cmbProfDisciplina";
            this.cmbProfDisciplina.Size = new System.Drawing.Size(358, 21);
            this.cmbProfDisciplina.TabIndex = 4;
            // 
            // professoresControllerBindingSource
            // 
            this.professoresControllerBindingSource.DataSource = typeof(Controllers.ProfessoresController);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Professor";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(377, 64);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Ano Letivo";
            // 
            // cmbAnoLetivo
            // 
            this.cmbAnoLetivo.FormattingEnabled = true;
            this.cmbAnoLetivo.Items.AddRange(new object[] {
            "2018",
            "2019",
            "2020",
            "2021",
            "2022"});
            this.cmbAnoLetivo.Location = new System.Drawing.Point(380, 83);
            this.cmbAnoLetivo.Name = "cmbAnoLetivo";
            this.cmbAnoLetivo.Size = new System.Drawing.Size(121, 21);
            this.cmbAnoLetivo.TabIndex = 6;
            // 
            // btnExcluirDisciplina
            // 
            this.btnExcluirDisciplina.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnExcluirDisciplina.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnExcluirDisciplina.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcluirDisciplina.Location = new System.Drawing.Point(323, 130);
            this.btnExcluirDisciplina.Name = "btnExcluirDisciplina";
            this.btnExcluirDisciplina.Size = new System.Drawing.Size(75, 23);
            this.btnExcluirDisciplina.TabIndex = 33;
            this.btnExcluirDisciplina.Text = "Excluir";
            this.btnExcluirDisciplina.UseVisualStyleBackColor = false;
            this.btnExcluirDisciplina.Click += new System.EventHandler(this.btnExcluirDisciplina_Click);
            // 
            // btnAlterarDisciplina
            // 
            this.btnAlterarDisciplina.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnAlterarDisciplina.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAlterarDisciplina.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlterarDisciplina.Location = new System.Drawing.Point(217, 130);
            this.btnAlterarDisciplina.Name = "btnAlterarDisciplina";
            this.btnAlterarDisciplina.Size = new System.Drawing.Size(75, 23);
            this.btnAlterarDisciplina.TabIndex = 34;
            this.btnAlterarDisciplina.Text = "Alterar";
            this.btnAlterarDisciplina.UseVisualStyleBackColor = false;
            this.btnAlterarDisciplina.Click += new System.EventHandler(this.btnAlterarDisciplina_Click);
            // 
            // btnLocalizarDisciplina
            // 
            this.btnLocalizarDisciplina.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnLocalizarDisciplina.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLocalizarDisciplina.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLocalizarDisciplina.Location = new System.Drawing.Point(117, 130);
            this.btnLocalizarDisciplina.Name = "btnLocalizarDisciplina";
            this.btnLocalizarDisciplina.Size = new System.Drawing.Size(75, 23);
            this.btnLocalizarDisciplina.TabIndex = 30;
            this.btnLocalizarDisciplina.Text = "Localizar";
            this.btnLocalizarDisciplina.UseVisualStyleBackColor = false;
            this.btnLocalizarDisciplina.Click += new System.EventHandler(this.btnLocalizarDisciplina_Click);
            // 
            // btnCancelarDisciplina
            // 
            this.btnCancelarDisciplina.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnCancelarDisciplina.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCancelarDisciplina.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelarDisciplina.Location = new System.Drawing.Point(426, 130);
            this.btnCancelarDisciplina.Name = "btnCancelarDisciplina";
            this.btnCancelarDisciplina.Size = new System.Drawing.Size(75, 23);
            this.btnCancelarDisciplina.TabIndex = 32;
            this.btnCancelarDisciplina.Text = "Limpar";
            this.btnCancelarDisciplina.UseVisualStyleBackColor = false;
            this.btnCancelarDisciplina.Click += new System.EventHandler(this.btnCancelarDisciplina_Click);
            // 
            // btnSalvarDisciplina
            // 
            this.btnSalvarDisciplina.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnSalvarDisciplina.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSalvarDisciplina.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvarDisciplina.Location = new System.Drawing.Point(21, 130);
            this.btnSalvarDisciplina.Name = "btnSalvarDisciplina";
            this.btnSalvarDisciplina.Size = new System.Drawing.Size(75, 23);
            this.btnSalvarDisciplina.TabIndex = 31;
            this.btnSalvarDisciplina.Text = "Inserir";
            this.btnSalvarDisciplina.UseVisualStyleBackColor = false;
            this.btnSalvarDisciplina.Click += new System.EventHandler(this.btnSalvarDisciplina_Click);
            // 
            // frmCadastroDisciplina
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(524, 176);
            this.Controls.Add(this.btnExcluirDisciplina);
            this.Controls.Add(this.btnAlterarDisciplina);
            this.Controls.Add(this.btnLocalizarDisciplina);
            this.Controls.Add(this.btnCancelarDisciplina);
            this.Controls.Add(this.btnSalvarDisciplina);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmbAnoLetivo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmbProfDisciplina);
            this.Controls.Add(this.txtMateria);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtCodDisciplina);
            this.Controls.Add(this.label1);
            this.Name = "frmCadastroDisciplina";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastrar Disciplina";
            this.Load += new System.EventHandler(this.frmCadastroDisciplina_Load);
            ((System.ComponentModel.ISupportInitialize)(this.professoresControllerBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCodDisciplina;
        private System.Windows.Forms.TextBox txtMateria;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbProfDisciplina;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbAnoLetivo;
        private System.Windows.Forms.Button btnExcluirDisciplina;
        private System.Windows.Forms.Button btnAlterarDisciplina;
        private System.Windows.Forms.Button btnLocalizarDisciplina;
        private System.Windows.Forms.Button btnCancelarDisciplina;
        private System.Windows.Forms.Button btnSalvarDisciplina;
        private System.Windows.Forms.BindingSource professoresControllerBindingSource;
    }
}