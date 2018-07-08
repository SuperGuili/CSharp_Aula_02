namespace WindowsFormView.cs
{
    partial class frmMenu
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
            this.btnAlunos = new System.Windows.Forms.Button();
            this.btnProfessores = new System.Windows.Forms.Button();
            this.btnDisciplinas = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnAlunos
            // 
            this.btnAlunos.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnAlunos.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAlunos.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlunos.Location = new System.Drawing.Point(81, 99);
            this.btnAlunos.Name = "btnAlunos";
            this.btnAlunos.Size = new System.Drawing.Size(75, 23);
            this.btnAlunos.TabIndex = 0;
            this.btnAlunos.Text = "Alunos";
            this.btnAlunos.UseVisualStyleBackColor = false;
            this.btnAlunos.Click += new System.EventHandler(this.btnAlunos_Click);
            // 
            // btnProfessores
            // 
            this.btnProfessores.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnProfessores.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnProfessores.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProfessores.Location = new System.Drawing.Point(214, 99);
            this.btnProfessores.Name = "btnProfessores";
            this.btnProfessores.Size = new System.Drawing.Size(81, 23);
            this.btnProfessores.TabIndex = 1;
            this.btnProfessores.Text = "Professores";
            this.btnProfessores.UseVisualStyleBackColor = false;
            // 
            // btnDisciplinas
            // 
            this.btnDisciplinas.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnDisciplinas.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDisciplinas.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDisciplinas.Location = new System.Drawing.Point(361, 99);
            this.btnDisciplinas.Name = "btnDisciplinas";
            this.btnDisciplinas.Size = new System.Drawing.Size(75, 23);
            this.btnDisciplinas.TabIndex = 2;
            this.btnDisciplinas.Text = "Disciplinas";
            this.btnDisciplinas.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(112, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(308, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "SISTEMA DE CADASTRO ESCOLAR";
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(524, 176);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnDisciplinas);
            this.Controls.Add(this.btnProfessores);
            this.Controls.Add(this.btnAlunos);
            this.MaximizeBox = false;
            this.Name = "frmMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAlunos;
        private System.Windows.Forms.Button btnProfessores;
        private System.Windows.Forms.Button btnDisciplinas;
        private System.Windows.Forms.Label label1;
    }
}