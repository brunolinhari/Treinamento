namespace WF_Livros
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.edTitulo = new System.Windows.Forms.TextBox();
            this.edDtaLancamento = new System.Windows.Forms.DateTimePicker();
            this.edAutor = new System.Windows.Forms.TextBox();
            this.edId = new System.Windows.Forms.TextBox();
            this.edNrPaginas = new System.Windows.Forms.NumericUpDown();
            this.btnSalvar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.edNrPaginas)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Título";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(49, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Data de Lançamento";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(50, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Autor";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(54, 174);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Nr Páginas";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(49, 21);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(16, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Id";
            // 
            // edTitulo
            // 
            this.edTitulo.Location = new System.Drawing.Point(156, 54);
            this.edTitulo.Name = "edTitulo";
            this.edTitulo.Size = new System.Drawing.Size(100, 20);
            this.edTitulo.TabIndex = 5;
            // 
            // edDtaLancamento
            // 
            this.edDtaLancamento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.edDtaLancamento.Location = new System.Drawing.Point(156, 89);
            this.edDtaLancamento.Name = "edDtaLancamento";
            this.edDtaLancamento.Size = new System.Drawing.Size(100, 20);
            this.edDtaLancamento.TabIndex = 6;
            // 
            // edAutor
            // 
            this.edAutor.Location = new System.Drawing.Point(156, 129);
            this.edAutor.Name = "edAutor";
            this.edAutor.Size = new System.Drawing.Size(100, 20);
            this.edAutor.TabIndex = 7;
            // 
            // edId
            // 
            this.edId.Location = new System.Drawing.Point(156, 18);
            this.edId.Name = "edId";
            this.edId.Size = new System.Drawing.Size(100, 20);
            this.edId.TabIndex = 9;
            // 
            // edNrPaginas
            // 
            this.edNrPaginas.Location = new System.Drawing.Point(156, 172);
            this.edNrPaginas.Name = "edNrPaginas";
            this.edNrPaginas.Size = new System.Drawing.Size(120, 20);
            this.edNrPaginas.TabIndex = 10;
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(193, 208);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(83, 26);
            this.btnSalvar.TabIndex = 11;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(368, 279);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.edNrPaginas);
            this.Controls.Add(this.edId);
            this.Controls.Add(this.edAutor);
            this.Controls.Add(this.edDtaLancamento);
            this.Controls.Add(this.edTitulo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.edNrPaginas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox edTitulo;
        private System.Windows.Forms.DateTimePicker edDtaLancamento;
        private System.Windows.Forms.TextBox edAutor;
        private System.Windows.Forms.TextBox edId;
        private System.Windows.Forms.NumericUpDown edNrPaginas;
        private System.Windows.Forms.Button btnSalvar;
    }
}

