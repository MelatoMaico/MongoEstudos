namespace MongoEstudos
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            txtNome = new TextBox();
            txtEndereco = new TextBox();
            txtCidade = new TextBox();
            txtEstado = new TextBox();
            txtTelefone = new TextBox();
            txtEmail = new TextBox();
            txtObservacao = new TextBox();
            btnSalvar = new Button();
            btnListar = new Button();
            lstAlunos = new ListBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(24, 37);
            label1.Name = "label1";
            label1.Size = new Size(43, 15);
            label1.TabIndex = 0;
            label1.Text = "Nome:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(20, 64);
            label2.Name = "label2";
            label2.Size = new Size(59, 15);
            label2.TabIndex = 0;
            label2.Text = "Endereço:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(24, 93);
            label3.Name = "label3";
            label3.Size = new Size(47, 15);
            label3.TabIndex = 0;
            label3.Text = "Cidade:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(27, 166);
            label4.Name = "label4";
            label4.Size = new Size(55, 15);
            label4.TabIndex = 0;
            label4.Text = "Telefone:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(24, 129);
            label5.Name = "label5";
            label5.Size = new Size(45, 15);
            label5.TabIndex = 0;
            label5.Text = "Estado:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(27, 195);
            label6.Name = "label6";
            label6.Size = new Size(44, 15);
            label6.TabIndex = 0;
            label6.Text = "E-Mail:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(19, 235);
            label7.Name = "label7";
            label7.Size = new Size(72, 15);
            label7.TabIndex = 0;
            label7.Text = "Observação:";
            // 
            // txtNome
            // 
            txtNome.Location = new Point(97, 29);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(187, 23);
            txtNome.TabIndex = 1;
            // 
            // txtEndereco
            // 
            txtEndereco.Location = new Point(97, 61);
            txtEndereco.Name = "txtEndereco";
            txtEndereco.Size = new Size(244, 23);
            txtEndereco.TabIndex = 1;
            // 
            // txtCidade
            // 
            txtCidade.Location = new Point(97, 90);
            txtCidade.Name = "txtCidade";
            txtCidade.Size = new Size(187, 23);
            txtCidade.TabIndex = 1;
            // 
            // txtEstado
            // 
            txtEstado.Location = new Point(97, 126);
            txtEstado.Name = "txtEstado";
            txtEstado.Size = new Size(43, 23);
            txtEstado.TabIndex = 1;
            // 
            // txtTelefone
            // 
            txtTelefone.Location = new Point(97, 163);
            txtTelefone.Name = "txtTelefone";
            txtTelefone.Size = new Size(147, 23);
            txtTelefone.TabIndex = 1;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(97, 192);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(187, 23);
            txtEmail.TabIndex = 1;
            // 
            // txtObservacao
            // 
            txtObservacao.Location = new Point(97, 235);
            txtObservacao.Multiline = true;
            txtObservacao.Name = "txtObservacao";
            txtObservacao.Size = new Size(231, 66);
            txtObservacao.TabIndex = 1;
            // 
            // btnSalvar
            // 
            btnSalvar.Location = new Point(97, 323);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(75, 23);
            btnSalvar.TabIndex = 2;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = true;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // btnListar
            // 
            btnListar.Location = new Point(197, 323);
            btnListar.Name = "btnListar";
            btnListar.Size = new Size(75, 23);
            btnListar.TabIndex = 2;
            btnListar.Text = "Listar";
            btnListar.UseVisualStyleBackColor = true;
            // 
            // lstAlunos
            // 
            lstAlunos.FormattingEnabled = true;
            lstAlunos.ItemHeight = 15;
            lstAlunos.Location = new Point(362, 28);
            lstAlunos.Name = "lstAlunos";
            lstAlunos.Size = new Size(277, 274);
            lstAlunos.TabIndex = 3;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(662, 404);
            Controls.Add(lstAlunos);
            Controls.Add(btnListar);
            Controls.Add(btnSalvar);
            Controls.Add(txtObservacao);
            Controls.Add(txtEmail);
            Controls.Add(txtTelefone);
            Controls.Add(txtEstado);
            Controls.Add(txtCidade);
            Controls.Add(txtEndereco);
            Controls.Add(txtNome);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox txtNome;
        private TextBox txtEndereco;
        private TextBox txtCidade;
        private TextBox txtEstado;
        private TextBox txtTelefone;
        private TextBox txtEmail;
        private TextBox txtObservacao;
        private Button btnSalvar;
        private Button btnListar;
        private ListBox lstAlunos;
    }
}
