namespace WF_Mercado
{
    partial class FEstoque
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
            this.dgEstoque = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.edAtualizaSaldo = new System.Windows.Forms.TextBox();
            this.btnAtualizaSoldo = new System.Windows.Forms.Button();
            this.lblNovoSaldo = new System.Windows.Forms.Label();
            this.edProdutoId = new System.Windows.Forms.TextBox();
            this.edSaldoAtual = new System.Windows.Forms.TextBox();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DescProduto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Saldo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnEditar = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgEstoque)).BeginInit();
            this.SuspendLayout();
            // 
            // dgEstoque
            // 
            this.dgEstoque.AllowUserToOrderColumns = true;
            this.dgEstoque.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgEstoque.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.DescProduto,
            this.Saldo,
            this.btnEditar});
            this.dgEstoque.Location = new System.Drawing.Point(1, 1);
            this.dgEstoque.Name = "dgEstoque";
            this.dgEstoque.RowHeadersWidth = 51;
            this.dgEstoque.RowTemplate.Height = 24;
            this.dgEstoque.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgEstoque.Size = new System.Drawing.Size(798, 388);
            this.dgEstoque.TabIndex = 0;
            this.dgEstoque.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgEstoque_CellClick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(690, 395);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(98, 43);
            this.button1.TabIndex = 1;
            this.button1.Text = "Fechar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // edAtualizaSaldo
            // 
            this.edAtualizaSaldo.Location = new System.Drawing.Point(102, 405);
            this.edAtualizaSaldo.Name = "edAtualizaSaldo";
            this.edAtualizaSaldo.Size = new System.Drawing.Size(100, 22);
            this.edAtualizaSaldo.TabIndex = 2;
            this.edAtualizaSaldo.Visible = false;
            // 
            // btnAtualizaSoldo
            // 
            this.btnAtualizaSoldo.Location = new System.Drawing.Point(208, 405);
            this.btnAtualizaSoldo.Name = "btnAtualizaSoldo";
            this.btnAtualizaSoldo.Size = new System.Drawing.Size(124, 23);
            this.btnAtualizaSoldo.TabIndex = 3;
            this.btnAtualizaSoldo.Text = "Atualiza Saldo";
            this.btnAtualizaSoldo.UseVisualStyleBackColor = true;
            this.btnAtualizaSoldo.Visible = false;
            this.btnAtualizaSoldo.Click += new System.EventHandler(this.btnAtualizaSoldo_Click);
            // 
            // lblNovoSaldo
            // 
            this.lblNovoSaldo.AutoSize = true;
            this.lblNovoSaldo.Location = new System.Drawing.Point(12, 408);
            this.lblNovoSaldo.Name = "lblNovoSaldo";
            this.lblNovoSaldo.Size = new System.Drawing.Size(81, 17);
            this.lblNovoSaldo.TabIndex = 4;
            this.lblNovoSaldo.Text = "Novo Saldo";
            this.lblNovoSaldo.Visible = false;
            // 
            // edProdutoId
            // 
            this.edProdutoId.Location = new System.Drawing.Point(139, 405);
            this.edProdutoId.Name = "edProdutoId";
            this.edProdutoId.Size = new System.Drawing.Size(26, 22);
            this.edProdutoId.TabIndex = 5;
            this.edProdutoId.Visible = false;
            // 
            // edSaldoAtual
            // 
            this.edSaldoAtual.Location = new System.Drawing.Point(171, 405);
            this.edSaldoAtual.Name = "edSaldoAtual";
            this.edSaldoAtual.Size = new System.Drawing.Size(26, 22);
            this.edSaldoAtual.TabIndex = 6;
            this.edSaldoAtual.Visible = false;
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "Codigo";
            this.Id.MinimumWidth = 6;
            this.Id.Name = "Id";
            this.Id.Width = 70;
            // 
            // DescProduto
            // 
            this.DescProduto.DataPropertyName = "DescProduto";
            this.DescProduto.HeaderText = "Produto";
            this.DescProduto.MinimumWidth = 6;
            this.DescProduto.Name = "DescProduto";
            this.DescProduto.Width = 270;
            // 
            // Saldo
            // 
            this.Saldo.DataPropertyName = "Saldo";
            this.Saldo.HeaderText = "Saldo";
            this.Saldo.MinimumWidth = 6;
            this.Saldo.Name = "Saldo";
            // 
            // btnEditar
            // 
            this.btnEditar.HeaderText = "Editar";
            this.btnEditar.MinimumWidth = 6;
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseColumnTextForButtonValue = true;
            // 
            // FEstoque
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.edSaldoAtual);
            this.Controls.Add(this.edProdutoId);
            this.Controls.Add(this.lblNovoSaldo);
            this.Controls.Add(this.btnAtualizaSoldo);
            this.Controls.Add(this.edAtualizaSaldo);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dgEstoque);
            this.Name = "FEstoque";
            this.Text = "Controle de Estoque";
            this.Load += new System.EventHandler(this.FEstoque_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgEstoque)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgEstoque;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox edAtualizaSaldo;
        private System.Windows.Forms.Button btnAtualizaSoldo;
        private System.Windows.Forms.Label lblNovoSaldo;
        private System.Windows.Forms.TextBox edProdutoId;
        private System.Windows.Forms.TextBox edSaldoAtual;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn DescProduto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Saldo;
        private System.Windows.Forms.DataGridViewButtonColumn btnEditar;
    }
}