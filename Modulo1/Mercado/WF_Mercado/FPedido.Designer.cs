namespace WF_Mercado
{
    partial class FPedido
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
            this.dgPedido = new System.Windows.Forms.DataGridView();
            this.cbFornecedor = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbProduto = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.edDtaRecebimento = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.edVlCompra = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.edVlTotal = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnIncluir = new System.Windows.Forms.Button();
            this.edQtdRecebida = new System.Windows.Forms.NumericUpDown();
            this.edNumero = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.Nomero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fornecedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Produto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VlUnitario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QtdRecebida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VlTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnEstornar = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgPedido)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edQtdRecebida)).BeginInit();
            this.SuspendLayout();
            // 
            // dgPedido
            // 
            this.dgPedido.AllowUserToOrderColumns = true;
            this.dgPedido.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgPedido.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nomero,
            this.Fornecedor,
            this.Produto,
            this.VlUnitario,
            this.QtdRecebida,
            this.VlTotal,
            this.btnEstornar});
            this.dgPedido.Location = new System.Drawing.Point(1, 1);
            this.dgPedido.Margin = new System.Windows.Forms.Padding(4);
            this.dgPedido.Name = "dgPedido";
            this.dgPedido.RowHeadersWidth = 51;
            this.dgPedido.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgPedido.Size = new System.Drawing.Size(956, 303);
            this.dgPedido.TabIndex = 0;
            this.dgPedido.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgPedido_CellClick);
            // 
            // cbFornecedor
            // 
            this.cbFornecedor.FormattingEnabled = true;
            this.cbFornecedor.Location = new System.Drawing.Point(125, 340);
            this.cbFornecedor.Margin = new System.Windows.Forms.Padding(4);
            this.cbFornecedor.Name = "cbFornecedor";
            this.cbFornecedor.Size = new System.Drawing.Size(823, 24);
            this.cbFornecedor.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 343);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 17);
            this.label2.TabIndex = 14;
            this.label2.Text = "Fornecedor";
            // 
            // cbProduto
            // 
            this.cbProduto.FormattingEnabled = true;
            this.cbProduto.Location = new System.Drawing.Point(125, 371);
            this.cbProduto.Margin = new System.Windows.Forms.Padding(4);
            this.cbProduto.Name = "cbProduto";
            this.cbProduto.Size = new System.Drawing.Size(823, 24);
            this.cbProduto.TabIndex = 3;
            this.cbProduto.DropDownClosed += new System.EventHandler(this.cbProduto_DropDownClosed);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 375);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 17);
            this.label1.TabIndex = 17;
            this.label1.Text = "Produto";
            // 
            // edDtaRecebimento
            // 
            this.edDtaRecebimento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.edDtaRecebimento.Location = new System.Drawing.Point(788, 402);
            this.edDtaRecebimento.Margin = new System.Windows.Forms.Padding(4);
            this.edDtaRecebimento.Name = "edDtaRecebimento";
            this.edDtaRecebimento.Size = new System.Drawing.Size(160, 22);
            this.edDtaRecebimento.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(669, 406);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 17);
            this.label3.TabIndex = 18;
            this.label3.Text = "Data de Entrega";
            // 
            // edVlCompra
            // 
            this.edVlCompra.Location = new System.Drawing.Point(125, 402);
            this.edVlCompra.Margin = new System.Windows.Forms.Padding(4);
            this.edVlCompra.Name = "edVlCompra";
            this.edVlCompra.Size = new System.Drawing.Size(105, 22);
            this.edVlCompra.TabIndex = 4;
            this.edVlCompra.Leave += new System.EventHandler(this.edVlCompra_Leave);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 406);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 17);
            this.label4.TabIndex = 22;
            this.label4.Text = "Valor Compra";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(245, 406);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 17);
            this.label5.TabIndex = 24;
            this.label5.Text = "Quantidade";
            // 
            // edVlTotal
            // 
            this.edVlTotal.Enabled = false;
            this.edVlTotal.Location = new System.Drawing.Point(539, 402);
            this.edVlTotal.Margin = new System.Windows.Forms.Padding(4);
            this.edVlTotal.Name = "edVlTotal";
            this.edVlTotal.Size = new System.Drawing.Size(105, 22);
            this.edVlTotal.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(453, 406);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 17);
            this.label6.TabIndex = 26;
            this.label6.Text = "Valor Total";
            // 
            // btnIncluir
            // 
            this.btnIncluir.Location = new System.Drawing.Point(849, 434);
            this.btnIncluir.Margin = new System.Windows.Forms.Padding(4);
            this.btnIncluir.Name = "btnIncluir";
            this.btnIncluir.Size = new System.Drawing.Size(100, 28);
            this.btnIncluir.TabIndex = 8;
            this.btnIncluir.Text = "Incluir";
            this.btnIncluir.UseVisualStyleBackColor = true;
            this.btnIncluir.Click += new System.EventHandler(this.btnIncluir_Click);
            // 
            // edQtdRecebida
            // 
            this.edQtdRecebida.Location = new System.Drawing.Point(336, 403);
            this.edQtdRecebida.Margin = new System.Windows.Forms.Padding(4);
            this.edQtdRecebida.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.edQtdRecebida.Name = "edQtdRecebida";
            this.edQtdRecebida.Size = new System.Drawing.Size(85, 22);
            this.edQtdRecebida.TabIndex = 5;
            this.edQtdRecebida.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.edQtdRecebida.Leave += new System.EventHandler(this.edVlCompra_Leave);
            // 
            // edNumero
            // 
            this.edNumero.Location = new System.Drawing.Point(125, 311);
            this.edNumero.Margin = new System.Windows.Forms.Padding(4);
            this.edNumero.Name = "edNumero";
            this.edNumero.Size = new System.Drawing.Size(105, 22);
            this.edNumero.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(8, 315);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 17);
            this.label7.TabIndex = 28;
            this.label7.Text = "Número";
            // 
            // Nomero
            // 
            this.Nomero.DataPropertyName = "Numero";
            this.Nomero.HeaderText = "Numero";
            this.Nomero.MinimumWidth = 6;
            this.Nomero.Name = "Nomero";
            this.Nomero.Width = 80;
            // 
            // Fornecedor
            // 
            this.Fornecedor.DataPropertyName = "DescFornecedor";
            this.Fornecedor.HeaderText = "Fornecedor";
            this.Fornecedor.MinimumWidth = 6;
            this.Fornecedor.Name = "Fornecedor";
            this.Fornecedor.Width = 120;
            // 
            // Produto
            // 
            this.Produto.DataPropertyName = "DescProduto";
            this.Produto.HeaderText = "Produto";
            this.Produto.MinimumWidth = 6;
            this.Produto.Name = "Produto";
            this.Produto.Width = 120;
            // 
            // VlUnitario
            // 
            this.VlUnitario.DataPropertyName = "VlUnitario";
            this.VlUnitario.HeaderText = "VlUnitario";
            this.VlUnitario.MinimumWidth = 6;
            this.VlUnitario.Name = "VlUnitario";
            this.VlUnitario.Width = 80;
            // 
            // QtdRecebida
            // 
            this.QtdRecebida.DataPropertyName = "QtdRecebida";
            this.QtdRecebida.HeaderText = "Qtde";
            this.QtdRecebida.MinimumWidth = 6;
            this.QtdRecebida.Name = "QtdRecebida";
            this.QtdRecebida.Width = 80;
            // 
            // VlTotal
            // 
            this.VlTotal.DataPropertyName = "VlTotal";
            this.VlTotal.HeaderText = "VlTotal";
            this.VlTotal.MinimumWidth = 6;
            this.VlTotal.Name = "VlTotal";
            this.VlTotal.Width = 80;
            // 
            // btnEstornar
            // 
            this.btnEstornar.HeaderText = "";
            this.btnEstornar.MinimumWidth = 6;
            this.btnEstornar.Name = "btnEstornar";
            this.btnEstornar.Text = "Estornar";
            this.btnEstornar.UseColumnTextForButtonValue = true;
            this.btnEstornar.Width = 80;
            // 
            // FPedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(958, 466);
            this.Controls.Add(this.edNumero);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.edQtdRecebida);
            this.Controls.Add(this.btnIncluir);
            this.Controls.Add(this.edVlTotal);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.edVlCompra);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.edDtaRecebimento);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbProduto);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbFornecedor);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgPedido);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FPedido";
            this.Text = "Pedidos";
            this.Load += new System.EventHandler(this.FPedido_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgPedido)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edQtdRecebida)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgPedido;
        private System.Windows.Forms.ComboBox cbFornecedor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbProduto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker edDtaRecebimento;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox edVlCompra;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox edVlTotal;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnIncluir;
        private System.Windows.Forms.NumericUpDown edQtdRecebida;
        private System.Windows.Forms.TextBox edNumero;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nomero;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fornecedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Produto;
        private System.Windows.Forms.DataGridViewTextBoxColumn VlUnitario;
        private System.Windows.Forms.DataGridViewTextBoxColumn QtdRecebida;
        private System.Windows.Forms.DataGridViewTextBoxColumn VlTotal;
        private System.Windows.Forms.DataGridViewButtonColumn btnEstornar;
    }
}