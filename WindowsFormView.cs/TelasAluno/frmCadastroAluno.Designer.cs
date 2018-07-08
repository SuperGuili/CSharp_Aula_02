namespace WindowsFormView.TelasAluno
{
    partial class frmCadastroAluno
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtNomeAluno = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMatricula = new System.Windows.Forms.TextBox();
            this.btnSalvarAluno = new System.Windows.Forms.Button();
            this.btnCancelarAluno = new System.Windows.Forms.Button();
            this.btnLocalizarAluno = new System.Windows.Forms.Button();
            this.btnAlterarAluno = new System.Windows.Forms.Button();
            this.btnExcluirAluno = new System.Windows.Forms.Button();
            this.txtIDAluno = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbAnoAluno = new System.Windows.Forms.ComboBox();
            this.txtEmailAluno = new System.Windows.Forms.TextBox();
            this.txtFoneAluno = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "NOME";
            // 
            // txtNomeAluno
            // 
            this.txtNomeAluno.Location = new System.Drawing.Point(87, 10);
            this.txtNomeAluno.Name = "txtNomeAluno";
            this.txtNomeAluno.Size = new System.Drawing.Size(423, 20);
            this.txtNomeAluno.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "MATRICULA";
            // 
            // txtMatricula
            // 
            this.txtMatricula.Location = new System.Drawing.Point(87, 40);
            this.txtMatricula.Name = "txtMatricula";
            this.txtMatricula.Size = new System.Drawing.Size(49, 20);
            this.txtMatricula.TabIndex = 3;
            // 
            // btnSalvarAluno
            // 
            this.btnSalvarAluno.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnSalvarAluno.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSalvarAluno.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvarAluno.Location = new System.Drawing.Point(21, 121);
            this.btnSalvarAluno.Name = "btnSalvarAluno";
            this.btnSalvarAluno.Size = new System.Drawing.Size(75, 23);
            this.btnSalvarAluno.TabIndex = 4;
            this.btnSalvarAluno.Text = "Inserir";
            this.btnSalvarAluno.UseVisualStyleBackColor = false;
            this.btnSalvarAluno.Click += new System.EventHandler(this.btnSalvarAluno_Click);
            // 
            // btnCancelarAluno
            // 
            this.btnCancelarAluno.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnCancelarAluno.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCancelarAluno.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelarAluno.Location = new System.Drawing.Point(426, 121);
            this.btnCancelarAluno.Name = "btnCancelarAluno";
            this.btnCancelarAluno.Size = new System.Drawing.Size(75, 23);
            this.btnCancelarAluno.TabIndex = 5;
            this.btnCancelarAluno.Text = "Limpar";
            this.btnCancelarAluno.UseVisualStyleBackColor = false;
            this.btnCancelarAluno.Click += new System.EventHandler(this.btnCancelarAluno_Click);
            // 
            // btnLocalizarAluno
            // 
            this.btnLocalizarAluno.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnLocalizarAluno.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLocalizarAluno.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLocalizarAluno.Location = new System.Drawing.Point(117, 121);
            this.btnLocalizarAluno.Name = "btnLocalizarAluno";
            this.btnLocalizarAluno.Size = new System.Drawing.Size(75, 23);
            this.btnLocalizarAluno.TabIndex = 6;
            this.btnLocalizarAluno.Text = "Localizar";
            this.btnLocalizarAluno.UseVisualStyleBackColor = false;
            this.btnLocalizarAluno.Click += new System.EventHandler(this.btnLocalizarAluno_Click);
            // 
            // btnAlterarAluno
            // 
            this.btnAlterarAluno.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnAlterarAluno.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAlterarAluno.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlterarAluno.Location = new System.Drawing.Point(217, 121);
            this.btnAlterarAluno.Name = "btnAlterarAluno";
            this.btnAlterarAluno.Size = new System.Drawing.Size(75, 23);
            this.btnAlterarAluno.TabIndex = 7;
            this.btnAlterarAluno.Text = "Alterar";
            this.btnAlterarAluno.UseVisualStyleBackColor = false;
            this.btnAlterarAluno.Click += new System.EventHandler(this.btnAlterarAluno_Click);
            // 
            // btnExcluirAluno
            // 
            this.btnExcluirAluno.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnExcluirAluno.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnExcluirAluno.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcluirAluno.Location = new System.Drawing.Point(323, 121);
            this.btnExcluirAluno.Name = "btnExcluirAluno";
            this.btnExcluirAluno.Size = new System.Drawing.Size(75, 23);
            this.btnExcluirAluno.TabIndex = 8;
            this.btnExcluirAluno.Text = "Excluir";
            this.btnExcluirAluno.UseVisualStyleBackColor = false;
            this.btnExcluirAluno.Click += new System.EventHandler(this.btnExcluirAluno_Click);
            // 
            // txtIDAluno
            // 
            this.txtIDAluno.Enabled = false;
            this.txtIDAluno.Location = new System.Drawing.Point(482, 70);
            this.txtIDAluno.Name = "txtIDAluno";
            this.txtIDAluno.Size = new System.Drawing.Size(28, 20);
            this.txtIDAluno.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(458, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(18, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "ID";
            // 
            // cmbAnoAluno
            // 
            this.cmbAnoAluno.FormattingEnabled = true;
            this.cmbAnoAluno.Items.AddRange(new object[] {
            "2017",
            "2018",
            "2019",
            "2020",
            "2021",
            "2022"});
            this.cmbAnoAluno.Location = new System.Drawing.Point(87, 70);
            this.cmbAnoAluno.Name = "cmbAnoAluno";
            this.cmbAnoAluno.Size = new System.Drawing.Size(121, 21);
            this.cmbAnoAluno.TabIndex = 12;
            // 
            // txtEmailAluno
            // 
            this.txtEmailAluno.Location = new System.Drawing.Point(190, 40);
            this.txtEmailAluno.Name = "txtEmailAluno";
            this.txtEmailAluno.Size = new System.Drawing.Size(320, 20);
            this.txtEmailAluno.TabIndex = 13;
            // 
            // txtFoneAluno
            // 
            this.txtFoneAluno.Location = new System.Drawing.Point(256, 71);
            this.txtFoneAluno.Name = "txtFoneAluno";
            this.txtFoneAluno.Size = new System.Drawing.Size(196, 20);
            this.txtFoneAluno.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(142, 43);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "E-MAIL";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 73);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "ANO LETIVO";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(214, 73);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(36, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = "FONE";
            // 
            // frmCadastroAluno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(524, 176);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtFoneAluno);
            this.Controls.Add(this.txtEmailAluno);
            this.Controls.Add(this.cmbAnoAluno);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtIDAluno);
            this.Controls.Add(this.btnExcluirAluno);
            this.Controls.Add(this.btnAlterarAluno);
            this.Controls.Add(this.btnLocalizarAluno);
            this.Controls.Add(this.btnCancelarAluno);
            this.Controls.Add(this.btnSalvarAluno);
            this.Controls.Add(this.txtMatricula);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNomeAluno);
            this.Controls.Add(this.label1);
            this.Name = "frmCadastroAluno";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Alunos";
            this.Load += new System.EventHandler(this.frmCadastroAluno_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNomeAluno;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMatricula;
        private System.Windows.Forms.Button btnSalvarAluno;
        private System.Windows.Forms.Button btnCancelarAluno;
        private System.Windows.Forms.Button btnLocalizarAluno;
        private System.Windows.Forms.Button btnAlterarAluno;
        private System.Windows.Forms.Button btnExcluirAluno;
        private System.Windows.Forms.TextBox txtIDAluno;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbAnoAluno;
        private System.Windows.Forms.TextBox txtEmailAluno;
        private System.Windows.Forms.TextBox txtFoneAluno;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}