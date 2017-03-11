namespace CrudBasico
{
    partial class frmCadastro
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
            this.lblNome = new System.Windows.Forms.Label();
            this.lblEndereco = new System.Windows.Forms.Label();
            this.txtBoxNome = new System.Windows.Forms.TextBox();
            this.txtBoxEndereco = new System.Windows.Forms.TextBox();
            this.lblTelefone = new System.Windows.Forms.Label();
            this.radioBtnFeminino = new System.Windows.Forms.RadioButton();
            this.radioBtnMasculino = new System.Windows.Forms.RadioButton();
            this.radioBtnInativo = new System.Windows.Forms.RadioButton();
            this.radioBtnAtivo = new System.Windows.Forms.RadioButton();
            this.btnGravar = new System.Windows.Forms.Button();
            this.mTxtBoxTelefone = new System.Windows.Forms.MaskedTextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(13, 43);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(38, 13);
            this.lblNome.TabIndex = 0;
            this.lblNome.Text = "Nome:";
            // 
            // lblEndereco
            // 
            this.lblEndereco.AutoSize = true;
            this.lblEndereco.Location = new System.Drawing.Point(12, 81);
            this.lblEndereco.Name = "lblEndereco";
            this.lblEndereco.Size = new System.Drawing.Size(56, 13);
            this.lblEndereco.TabIndex = 1;
            this.lblEndereco.Text = "Endereço:";
            // 
            // txtBoxNome
            // 
            this.txtBoxNome.Location = new System.Drawing.Point(71, 40);
            this.txtBoxNome.Name = "txtBoxNome";
            this.txtBoxNome.Size = new System.Drawing.Size(181, 20);
            this.txtBoxNome.TabIndex = 2;
            // 
            // txtBoxEndereco
            // 
            this.txtBoxEndereco.Location = new System.Drawing.Point(71, 78);
            this.txtBoxEndereco.Name = "txtBoxEndereco";
            this.txtBoxEndereco.Size = new System.Drawing.Size(181, 20);
            this.txtBoxEndereco.TabIndex = 3;
            // 
            // lblTelefone
            // 
            this.lblTelefone.AutoSize = true;
            this.lblTelefone.Location = new System.Drawing.Point(12, 115);
            this.lblTelefone.Name = "lblTelefone";
            this.lblTelefone.Size = new System.Drawing.Size(52, 13);
            this.lblTelefone.TabIndex = 5;
            this.lblTelefone.Text = "Telefone:";
            // 
            // radioBtnFeminino
            // 
            this.radioBtnFeminino.AutoSize = true;
            this.radioBtnFeminino.Location = new System.Drawing.Point(18, 19);
            this.radioBtnFeminino.Name = "radioBtnFeminino";
            this.radioBtnFeminino.Size = new System.Drawing.Size(67, 17);
            this.radioBtnFeminino.TabIndex = 7;
            this.radioBtnFeminino.TabStop = true;
            this.radioBtnFeminino.Text = "Feminino";
            this.radioBtnFeminino.UseVisualStyleBackColor = true;
            // 
            // radioBtnMasculino
            // 
            this.radioBtnMasculino.AutoSize = true;
            this.radioBtnMasculino.Location = new System.Drawing.Point(126, 19);
            this.radioBtnMasculino.Name = "radioBtnMasculino";
            this.radioBtnMasculino.Size = new System.Drawing.Size(73, 17);
            this.radioBtnMasculino.TabIndex = 8;
            this.radioBtnMasculino.TabStop = true;
            this.radioBtnMasculino.Text = "Masculino";
            this.radioBtnMasculino.UseVisualStyleBackColor = true;
            // 
            // radioBtnInativo
            // 
            this.radioBtnInativo.AutoSize = true;
            this.radioBtnInativo.Location = new System.Drawing.Point(126, 19);
            this.radioBtnInativo.Name = "radioBtnInativo";
            this.radioBtnInativo.Size = new System.Drawing.Size(57, 17);
            this.radioBtnInativo.TabIndex = 11;
            this.radioBtnInativo.TabStop = true;
            this.radioBtnInativo.Text = "Inativo";
            this.radioBtnInativo.UseVisualStyleBackColor = true;
            // 
            // radioBtnAtivo
            // 
            this.radioBtnAtivo.AutoSize = true;
            this.radioBtnAtivo.Location = new System.Drawing.Point(18, 19);
            this.radioBtnAtivo.Name = "radioBtnAtivo";
            this.radioBtnAtivo.Size = new System.Drawing.Size(49, 17);
            this.radioBtnAtivo.TabIndex = 10;
            this.radioBtnAtivo.TabStop = true;
            this.radioBtnAtivo.Text = "Ativo";
            this.radioBtnAtivo.UseVisualStyleBackColor = true;
            // 
            // btnGravar
            // 
            this.btnGravar.Location = new System.Drawing.Point(94, 355);
            this.btnGravar.Name = "btnGravar";
            this.btnGravar.Size = new System.Drawing.Size(75, 23);
            this.btnGravar.TabIndex = 12;
            this.btnGravar.Text = "Gravar";
            this.btnGravar.UseVisualStyleBackColor = true;
            this.btnGravar.Click += new System.EventHandler(this.btnGravar_Click);
            // 
            // mTxtBoxTelefone
            // 
            this.mTxtBoxTelefone.Location = new System.Drawing.Point(71, 115);
            this.mTxtBoxTelefone.Mask = "(99) 00000-0000";
            this.mTxtBoxTelefone.Name = "mTxtBoxTelefone";
            this.mTxtBoxTelefone.Size = new System.Drawing.Size(181, 20);
            this.mTxtBoxTelefone.TabIndex = 13;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioBtnFeminino);
            this.groupBox1.Controls.Add(this.radioBtnMasculino);
            this.groupBox1.Location = new System.Drawing.Point(33, 178);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(219, 52);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sexo";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radioBtnAtivo);
            this.groupBox2.Controls.Add(this.radioBtnInativo);
            this.groupBox2.Location = new System.Drawing.Point(33, 284);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 49);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Status";
            // 
            // frmCadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 406);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.mTxtBoxTelefone);
            this.Controls.Add(this.btnGravar);
            this.Controls.Add(this.lblTelefone);
            this.Controls.Add(this.txtBoxEndereco);
            this.Controls.Add(this.txtBoxNome);
            this.Controls.Add(this.lblEndereco);
            this.Controls.Add(this.lblNome);
            this.Name = "frmCadastro";
            this.Text = "Gerenciamento de Clientes";
            this.Load += new System.EventHandler(this.frmCadastro_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblEndereco;
        private System.Windows.Forms.TextBox txtBoxNome;
        private System.Windows.Forms.TextBox txtBoxEndereco;
        private System.Windows.Forms.Label lblTelefone;
        private System.Windows.Forms.RadioButton radioBtnFeminino;
        private System.Windows.Forms.RadioButton radioBtnMasculino;
        private System.Windows.Forms.RadioButton radioBtnInativo;
        private System.Windows.Forms.RadioButton radioBtnAtivo;
        private System.Windows.Forms.Button btnGravar;
        private System.Windows.Forms.MaskedTextBox mTxtBoxTelefone;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}