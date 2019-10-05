namespace WF_Livros
{
    partial class FListagemLivros
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgListagemLivros = new System.Windows.Forms.DataGridView();
            this.btnNovo = new System.Windows.Forms.Button();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Titulo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Autor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataLancamento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NrPaginas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnEditar2 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnApagar = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgListagemLivros)).BeginInit();
            this.SuspendLayout();
            // 
            // dgListagemLivros
            // 
            this.dgListagemLivros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgListagemLivros.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.Titulo,
            this.Autor,
            this.DataLancamento,
            this.NrPaginas,
            this.btnEditar2,
            this.btnApagar});
            this.dgListagemLivros.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgListagemLivros.Location = new System.Drawing.Point(0, 0);
            this.dgListagemLivros.Name = "dgListagemLivros";
            this.dgListagemLivros.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgListagemLivros.Size = new System.Drawing.Size(836, 392);
            this.dgListagemLivros.TabIndex = 0;
            this.dgListagemLivros.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgListagemLivros_CellClick);
            this.dgListagemLivros.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgListagemLivros_CellContentClick);
            // 
            // btnNovo
            // 
            this.btnNovo.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnNovo.Location = new System.Drawing.Point(761, 398);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(75, 23);
            this.btnNovo.TabIndex = 1;
            this.btnNovo.Text = "Novo";
            this.btnNovo.UseVisualStyleBackColor = true;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // id
            // 
            this.id.DataPropertyName = "id";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.id.DefaultCellStyle = dataGridViewCellStyle4;
            this.id.HeaderText = "Id";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Width = 40;
            // 
            // Titulo
            // 
            this.Titulo.DataPropertyName = "Titulo";
            this.Titulo.HeaderText = "Título";
            this.Titulo.Name = "Titulo";
            this.Titulo.ReadOnly = true;
            this.Titulo.Width = 200;
            // 
            // Autor
            // 
            this.Autor.DataPropertyName = "Autor";
            this.Autor.HeaderText = "Autor";
            this.Autor.Name = "Autor";
            this.Autor.ReadOnly = true;
            this.Autor.Width = 200;
            // 
            // DataLancamento
            // 
            this.DataLancamento.DataPropertyName = "DataLancamento";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.Format = "d";
            dataGridViewCellStyle5.NullValue = null;
            this.DataLancamento.DefaultCellStyle = dataGridViewCellStyle5;
            this.DataLancamento.HeaderText = "Data de Lançamento";
            this.DataLancamento.Name = "DataLancamento";
            this.DataLancamento.ReadOnly = true;
            // 
            // NrPaginas
            // 
            this.NrPaginas.DataPropertyName = "NrPaginas";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.NrPaginas.DefaultCellStyle = dataGridViewCellStyle6;
            this.NrPaginas.HeaderText = "Pg";
            this.NrPaginas.Name = "NrPaginas";
            this.NrPaginas.ReadOnly = true;
            this.NrPaginas.Width = 50;
            // 
            // btnEditar2
            // 
            this.btnEditar2.HeaderText = "Editar";
            this.btnEditar2.Name = "btnEditar2";
            this.btnEditar2.Text = "Editar";
            this.btnEditar2.UseColumnTextForButtonValue = true;
            // 
            // btnApagar
            // 
            this.btnApagar.HeaderText = "Apagar";
            this.btnApagar.Name = "btnApagar";
            this.btnApagar.Text = "Apagar";
            this.btnApagar.UseColumnTextForButtonValue = true;
            // 
            // FListagemLivros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(836, 450);
            this.Controls.Add(this.btnNovo);
            this.Controls.Add(this.dgListagemLivros);
            this.Name = "FListagemLivros";
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.dgListagemLivros)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgListagemLivros;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Titulo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Autor;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataLancamento;
        private System.Windows.Forms.DataGridViewTextBoxColumn NrPaginas;
        private System.Windows.Forms.DataGridViewButtonColumn btnEditar2;
        private System.Windows.Forms.DataGridViewButtonColumn btnApagar;
    }
}