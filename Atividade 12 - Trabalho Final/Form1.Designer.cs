namespace Atividade_12___Trabalho_Final
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
            dataGridView = new DataGridView();
            btnAdicionar = new Button();
            btnEditar = new Button();
            btnExcluir = new Button();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            SuspendLayout();
            // 
            // dataGridView
            // 
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView.Location = new Point(151, 138);
            dataGridView.Name = "dataGridView";
            dataGridView.Size = new Size(504, 150);
            dataGridView.TabIndex = 0;
            // 
            // btnAdicionar
            // 
            btnAdicionar.Location = new Point(151, 350);
            btnAdicionar.Name = "btnAdicionar";
            btnAdicionar.Size = new Size(75, 33);
            btnAdicionar.TabIndex = 1;
            btnAdicionar.Text = "Adicionar";
            btnAdicionar.UseVisualStyleBackColor = true;
            btnAdicionar.Click += btnAdicionar_Click;
            // 
            // btnEditar
            // 
            btnEditar.Location = new Point(366, 350);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(75, 33);
            btnEditar.TabIndex = 2;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = true;
            btnEditar.Click += btnEditar_Click;
            // 
            // btnExcluir
            // 
            btnExcluir.Location = new Point(580, 350);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(75, 33);
            btnExcluir.TabIndex = 3;
            btnExcluir.Text = "Excluir";
            btnExcluir.UseVisualStyleBackColor = true;
            btnExcluir.Click += btnExcluir_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 45F);
            label1.Location = new Point(176, 23);
            label1.Name = "label1";
            label1.Size = new Size(463, 81);
            label1.TabIndex = 4;
            label1.Text = "Tela de Principal";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(btnExcluir);
            Controls.Add(btnEditar);
            Controls.Add(btnAdicionar);
            Controls.Add(dataGridView);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView;
        private Button btnAdicionar;
        private Button btnEditar;
        private Button btnExcluir;
        private Label label1;
    }
}
