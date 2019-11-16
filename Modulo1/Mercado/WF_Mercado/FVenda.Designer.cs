namespace WF_Mercado
{
    partial class FVenda
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
            this.dgVenda = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbCliente = new System.Windows.Forms.ComboBox();
            this.cbProduto = new System.Windows.Forms.ComboBox();
            this.edQtde = new System.Windows.Forms.NumericUpDown();
            this.edVlTotal = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.edVlVenda = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnIncluir = new System.Windows.Forms.Button();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DescCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DescProduto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VlUnitario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Qtde = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VlTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgVenda)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edQtde)).BeginInit();
            this.SuspendLayout();
            // 
            // dgVenda
            // 
            this.dgVenda.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgVenda.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.DescCliente,
            this.DescProduto,
            this.VlUnitario,
            this.Qtde,
            this.VlTotal});
            this.dgVenda.Location = new System.Drawing.Point(1, 1);
            this.dgVenda.Margin = new System.Windows.Forms.Padding(4);
            this.dgVenda.Name = "dgVenda";
            this.dgVenda.RowHeadersWidth = 51;
            this.dgVenda.Size = new System.Drawing.Size(920, 325);
            this.dgVenda.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 343);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Cliente";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 377);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Produto";
            // 
            // cbCliente
            // 
            this.cbCliente.FormattingEnabled = true;
            this.cbCliente.Location = new System.Drawing.Point(140, 340);
            this.cbCliente.Margin = new System.Windows.Forms.Padding(4);
            this.cbCliente.Name = "cbCliente";
            this.cbCliente.Size = new System.Drawing.Size(769, 24);
            this.cbCliente.TabIndex = 1;
            // 
            // cbProduto
            // 
            this.cbProduto.FormattingEnabled = true;
            this.cbProduto.Location = new System.Drawing.Point(140, 373);
            this.cbProduto.Margin = new System.Windows.Forms.Padding(4);
            this.cbProduto.Name = "cbProduto";
            this.cbProduto.Size = new System.Drawing.Size(769, 24);
            this.cbProduto.TabIndex = 2;
            this.cbProduto.DropDownClosed += new System.EventHandler(this.cbProduto_DropDownClosed);
            this.cbProduto.Leave += new System.EventHandler(this.cbProduto_Leave);
            // 
            // edQtde
            // 
            this.edQtde.Location = new System.Drawing.Point(445, 407);
            this.edQtde.Margin = new System.Windows.Forms.Padding(4);
            this.edQtde.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.edQtde.Name = "edQtde";
            this.edQtde.Size = new System.Drawing.Size(85, 22);
            this.edQtde.TabIndex = 4;
            this.edQtde.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.edQtde.Leave += new System.EventHandler(this.edQtde_Leave);
            // 
            // edVlTotal
            // 
            this.edVlTotal.Enabled = false;
            this.edVlTotal.Location = new System.Drawing.Point(696, 405);
            this.edVlTotal.Margin = new System.Windows.Forms.Padding(4);
            this.edVlTotal.Name = "edVlTotal";
            this.edVlTotal.Size = new System.Drawing.Size(105, 22);
            this.edVlTotal.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(610, 409);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 17);
            this.label6.TabIndex = 32;
            this.label6.Text = "Valor Total";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(354, 410);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 17);
            this.label5.TabIndex = 31;
            this.label5.Text = "Quantidade";
            // 
            // edVlVenda
            // 
            this.edVlVenda.Location = new System.Drawing.Point(140, 406);
            this.edVlVenda.Margin = new System.Windows.Forms.Padding(4);
            this.edVlVenda.Name = "edVlVenda";
            this.edVlVenda.Size = new System.Drawing.Size(120, 22);
            this.edVlVenda.TabIndex = 3;
            this.edVlVenda.Leave += new System.EventHandler(this.edVlVenda_Leave);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 410);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 17);
            this.label4.TabIndex = 29;
            this.label4.Text = "Valor Venda";
            // 
            // btnIncluir
            // 
            this.btnIncluir.Location = new System.Drawing.Point(809, 403);
            this.btnIncluir.Margin = new System.Windows.Forms.Padding(4);
            this.btnIncluir.Name = "btnIncluir";
            this.btnIncluir.Size = new System.Drawing.Size(100, 28);
            this.btnIncluir.TabIndex = 6;
            this.btnIncluir.Text = "Incluir";
            this.btnIncluir.UseVisualStyleBackColor = true;
            this.btnIncluir.Click += new System.EventHandler(this.btnIncluir_Click);
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "Venda";
            this.Id.MinimumWidth = 6;
            this.Id.Name = "Id";
            this.Id.Width = 125;
            // 
            // DescCliente
            // 
            this.DescCliente.DataPropertyName = "DescCliente";
            this.DescCliente.HeaderText = "Cliente";
            this.DescCliente.MinimumWidth = 6;
            this.DescCliente.Name = "DescCliente";
            this.DescCliente.Width = 125;
            // 
            // DescProduto
            // 
            this.DescProduto.DataPropertyName = "DescProduto";
            this.DescProduto.HeaderText = "Produto";
            this.DescProduto.MinimumWidth = 6;
            this.DescProduto.Name = "DescProduto";
            this.DescProduto.Width = 125;
            // 
            // VlUnitario
            // 
            this.VlUnitario.DataPropertyName = "VlUnitario";
            this.VlUnitario.HeaderText = "VlUnitario";
            this.VlUnitario.MinimumWidth = 6;
            this.VlUnitario.Name = "VlUnitario";
            this.VlUnitario.Width = 125;
            // 
            // Qtde
            // 
            this.Qtde.DataPropertyName = "Qtde";
            this.Qtde.HeaderText = "Qtde";
            this.Qtde.MinimumWidth = 6;
            this.Qtde.Name = "Qtde";
            this.Qtde.Width = 125;
            // 
            // VlTotal
            // 
            this.VlTotal.DataPropertyName = "VlTotal";
            this.VlTotal.HeaderText = "VlTotal";
            this.VlTotal.MinimumWidth = 6;
            this.VlTotal.Name = "VlTotal";
            this.VlTotal.Width = 125;
            // 
            // FVenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(922, 476);
            this.Controls.Add(this.btnIncluir);
            this.Controls.Add(this.edQtde);
            this.Controls.Add(this.edVlTotal);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.edVlVenda);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbProduto);
            this.Controls.Add(this.cbCliente);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgVenda);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FVenda";
            this.Text = "FVenda";
            this.Load += new System.EventHandler(this.FVenda_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgVenda)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edQtde)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgVenda;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbCliente;
        private System.Windows.Forms.ComboBox cbProduto;
        private System.Windows.Forms.NumericUpDown edQtde;
        private System.Windows.Forms.TextBox edVlTotal;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox edVlVenda;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnIncluir;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn DescCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn DescProduto;
        private System.Windows.Forms.DataGridViewTextBoxColumn VlUnitario;
        private System.Windows.Forms.DataGridViewTextBoxColumn Qtde;
        private System.Windows.Forms.DataGridViewTextBoxColumn VlTotal;
    }
}