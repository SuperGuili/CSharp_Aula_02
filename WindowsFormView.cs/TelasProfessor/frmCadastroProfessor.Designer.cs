namespace WindowsFormView.cs.TelasProfessor
{
    partial class frmCadastroProfessor
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
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtFoneProfessor = new System.Windows.Forms.TextBox();
            this.txtEmailProfessor = new System.Windows.Forms.TextBox();
            this.cmbFormacao = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtIDProfessor = new System.Windows.Forms.TextBox();
            this.btnExcluirProfessor = new System.Windows.Forms.Button();
            this.btnAlterarProfessor = new System.Windows.Forms.Button();
            this.btnLocalizarProfessor = new System.Windows.Forms.Button();
            this.btnCancelarProfessor = new System.Windows.Forms.Button();
            this.btnSalvarProfessor = new System.Windows.Forms.Button();
            this.txtCPF = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNomeProfessor = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(214, 73);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(36, 13);
            this.label6.TabIndex = 34;
            this.label6.Text = "FONE";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 74);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 13);
            this.label5.TabIndex = 33;
            this.label5.Text = "FORMAÇÃO";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(192, 43);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 13);
            this.label4.TabIndex = 32;
            this.label4.Text = "E-MAIL";
            // 
            // txtFoneProfessor
            // 
            this.txtFoneProfessor.Location = new System.Drawing.Point(256, 71);
            this.txtFoneProfessor.Name = "txtFoneProfessor";
            this.txtFoneProfessor.Size = new System.Drawing.Size(196, 20);
            this.txtFoneProfessor.TabIndex = 25;
            // 
            // txtEmailProfessor
            // 
            this.txtEmailProfessor.Location = new System.Drawing.Point(240, 40);
            this.txtEmailProfessor.Name = "txtEmailProfessor";
            this.txtEmailProfessor.Size = new System.Drawing.Size(270, 20);
            this.txtEmailProfessor.TabIndex = 23;
            // 
            // cmbFormacao
            // 
            this.cmbFormacao.FormattingEnabled = true;
            this.cmbFormacao.Items.AddRange(new object[] {
            "Artes",
            "Educação Física",
            "Física",
            "Geografia",
            "História",
            "Matemática"});
            this.cmbFormacao.Location = new System.Drawing.Point(87, 70);
            this.cmbFormacao.Name = "cmbFormacao";
            this.cmbFormacao.Size = new System.Drawing.Size(121, 21);
            this.cmbFormacao.TabIndex = 24;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(458, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(18, 13);
            this.label3.TabIndex = 31;
            this.label3.Text = "ID";
            // 
            // txtIDProfessor
            // 
            this.txtIDProfessor.Enabled = false;
            this.txtIDProfessor.Location = new System.Drawing.Point(482, 70);
            this.txtIDProfessor.Name = "txtIDProfessor";
            this.txtIDProfessor.Size = new System.Drawing.Size(28, 20);
            this.txtIDProfessor.TabIndex = 30;
            // 
            // btnExcluirProfessor
            // 
            this.btnExcluirProfessor.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnExcluirProfessor.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnExcluirProfessor.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcluirProfessor.Location = new System.Drawing.Point(323, 121);
            this.btnExcluirProfessor.Name = "btnExcluirProfessor";
            this.btnExcluirProfessor.Size = new System.Drawing.Size(75, 23);
            this.btnExcluirProfessor.TabIndex = 28;
            this.btnExcluirProfessor.Text = "Excluir";
            this.btnExcluirProfessor.UseVisualStyleBackColor = false;
            this.btnExcluirProfessor.Click += new System.EventHandler(this.btnExcluirProfessor_Click);
            // 
            // btnAlterarProfessor
            // 
            this.btnAlterarProfessor.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnAlterarProfessor.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAlterarProfessor.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlterarProfessor.Location = new System.Drawing.Point(217, 121);
            this.btnAlterarProfessor.Name = "btnAlterarProfessor";
            this.btnAlterarProfessor.Size = new System.Drawing.Size(75, 23);
            this.btnAlterarProfessor.TabIndex = 29;
            this.btnAlterarProfessor.Text = "Alterar";
            this.btnAlterarProfessor.UseVisualStyleBackColor = false;
            this.btnAlterarProfessor.Click += new System.EventHandler(this.btnAlterarProfessor_Click);
            // 
            // btnLocalizarProfessor
            // 
            this.btnLocalizarProfessor.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnLocalizarProfessor.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLocalizarProfessor.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLocalizarProfessor.Location = new System.Drawing.Point(117, 121);
            this.btnLocalizarProfessor.Name = "btnLocalizarProfessor";
            this.btnLocalizarProfessor.Size = new System.Drawing.Size(75, 23);
            this.btnLocalizarProfessor.TabIndex = 19;
            this.btnLocalizarProfessor.Text = "Localizar";
            this.btnLocalizarProfessor.UseVisualStyleBackColor = false;
            this.btnLocalizarProfessor.Click += new System.EventHandler(this.btnLocalizarProfessor_Click);
            // 
            // btnCancelarProfessor
            // 
            this.btnCancelarProfessor.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnCancelarProfessor.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCancelarProfessor.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelarProfessor.Location = new System.Drawing.Point(426, 121);
            this.btnCancelarProfessor.Name = "btnCancelarProfessor";
            this.btnCancelarProfessor.Size = new System.Drawing.Size(75, 23);
            this.btnCancelarProfessor.TabIndex = 27;
            this.btnCancelarProfessor.Text = "Limpar";
            this.btnCancelarProfessor.UseVisualStyleBackColor = false;
            this.btnCancelarProfessor.Click += new System.EventHandler(this.btnCancelarProfessor_Click);
            // 
            // btnSalvarProfessor
            // 
            this.btnSalvarProfessor.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnSalvarProfessor.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSalvarProfessor.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvarProfessor.Location = new System.Drawing.Point(21, 121);
            this.btnSalvarProfessor.Name = "btnSalvarProfessor";
            this.btnSalvarProfessor.Size = new System.Drawing.Size(75, 23);
            this.btnSalvarProfessor.TabIndex = 26;
            this.btnSalvarProfessor.Text = "Inserir";
            this.btnSalvarProfessor.UseVisualStyleBackColor = false;
            this.btnSalvarProfessor.Click += new System.EventHandler(this.btnSalvarProfessor_Click);
            // 
            // txtCPF
            // 
            this.txtCPF.Location = new System.Drawing.Point(87, 40);
            this.txtCPF.Name = "txtCPF";
            this.txtCPF.Size = new System.Drawing.Size(99, 20);
            this.txtCPF.TabIndex = 22;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 13);
            this.label2.TabIndex = 21;
            this.label2.Text = "CPF";
            // 
            // txtNomeProfessor
            // 
            this.txtNomeProfessor.Location = new System.Drawing.Point(87, 10);
            this.txtNomeProfessor.Name = "txtNomeProfessor";
            this.txtNomeProfessor.Size = new System.Drawing.Size(423, 20);
            this.txtNomeProfessor.TabIndex = 20;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 18;
            this.label1.Text = "NOME";
            // 
            // frmCadastroProfessor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(524, 176);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtFoneProfessor);
            this.Controls.Add(this.txtEmailProfessor);
            this.Controls.Add(this.cmbFormacao);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtIDProfessor);
            this.Controls.Add(this.btnExcluirProfessor);
            this.Controls.Add(this.btnAlterarProfessor);
            this.Controls.Add(this.btnLocalizarProfessor);
            this.Controls.Add(this.btnCancelarProfessor);
            this.Controls.Add(this.btnSalvarProfessor);
            this.Controls.Add(this.txtCPF);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNomeProfessor);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "frmCadastroProfessor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Professor";
            this.Load += new System.EventHandler(this.frmCadastroProfessor_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtFoneProfessor;
        private System.Windows.Forms.TextBox txtEmailProfessor;
        private System.Windows.Forms.ComboBox cmbFormacao;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtIDProfessor;
        private System.Windows.Forms.Button btnExcluirProfessor;
        private System.Windows.Forms.Button btnAlterarProfessor;
        private System.Windows.Forms.Button btnLocalizarProfessor;
        private System.Windows.Forms.Button btnCancelarProfessor;
        private System.Windows.Forms.Button btnSalvarProfessor;
        private System.Windows.Forms.TextBox txtCPF;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNomeProfessor;
        private System.Windows.Forms.Label label1;
    }
}