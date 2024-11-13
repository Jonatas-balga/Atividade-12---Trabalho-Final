namespace Atividade_12___Trabalho_Final
{
    partial class FormCadastro
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
            btnCadastro = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtNome = new TextBox();
            txtPreco = new TextBox();
            SuspendLayout();
            // 
            // btnCadastro
            // 
            btnCadastro.Location = new Point(336, 320);
            btnCadastro.Name = "btnCadastro";
            btnCadastro.Size = new Size(98, 34);
            btnCadastro.TabIndex = 0;
            btnCadastro.Text = "Salvar";
            btnCadastro.UseVisualStyleBackColor = true;
            btnCadastro.Click += btnCadastro_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 45F);
            label1.Location = new Point(154, 9);
            label1.Name = "label1";
            label1.Size = new Size(470, 81);
            label1.TabIndex = 1;
            label1.Text = "Tela de Cadastro";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(192, 165);
            label2.Name = "label2";
            label2.Size = new Size(40, 15);
            label2.TabIndex = 2;
            label2.Text = "Nome";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(192, 241);
            label3.Name = "label3";
            label3.Size = new Size(37, 15);
            label3.TabIndex = 3;
            label3.Text = "Preço";
            // 
            // txtNome
            // 
            txtNome.Location = new Point(260, 162);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(297, 23);
            txtNome.TabIndex = 4;
            // 
            // txtPreco
            // 
            txtPreco.Location = new Point(260, 238);
            txtPreco.Name = "txtPreco";
            txtPreco.Size = new Size(297, 23);
            txtPreco.TabIndex = 5;
            // 
            // FormCadastro
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtPreco);
            Controls.Add(txtNome);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnCadastro);
            Name = "FormCadastro";
            Text = "FormCadastro";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCadastro;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtNome;
        private TextBox txtPreco;
    }
}