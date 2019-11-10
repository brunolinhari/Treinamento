﻿namespace WF_Mercado
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
            this.Nomero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fornecedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Produto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VlCompra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QtdRecebida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VlTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            ((System.ComponentModel.ISupportInitialize)(this.dgPedido)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edQtdRecebida)).BeginInit();
            this.SuspendLayout();
            // 
            // dgPedido
            // 
            this.dgPedido.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgPedido.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nomero,
            this.Fornecedor,
            this.Produto,
            this.VlCompra,
            this.QtdRecebida,
            this.VlTotal});
            this.dgPedido.Location = new System.Drawing.Point(1, 1);
            this.dgPedido.Name = "dgPedido";
            this.dgPedido.Size = new System.Drawing.Size(722, 246);
            this.dgPedido.TabIndex = 0;
            // 
            // Nomero
            // 
            this.Nomero.DataPropertyName = "Numero";
            this.Nomero.HeaderText = "Numero";
            this.Nomero.Name = "Nomero";
            // 
            // Fornecedor
            // 
            this.Fornecedor.DataPropertyName = "DescFornecedor";
            this.Fornecedor.HeaderText = "Fornecedor";
            this.Fornecedor.Name = "Fornecedor";
            // 
            // Produto
            // 
            this.Produto.DataPropertyName = "DescProduto";
            this.Produto.HeaderText = "Produto";
            this.Produto.Name = "Produto";
            // 
            // VlCompra
            // 
            this.VlCompra.DataPropertyName = "VlCompra";
            this.VlCompra.HeaderText = "VlCompra";
            this.VlCompra.Name = "VlCompra";
            // 
            // QtdRecebida
            // 
            this.QtdRecebida.DataPropertyName = "VlCompra";
            this.QtdRecebida.HeaderText = "QtdRecebida";
            this.QtdRecebida.Name = "QtdRecebida";
            // 
            // VlTotal
            // 
            this.VlTotal.DataPropertyName = "VlTotal";
            this.VlTotal.HeaderText = "VlTotal";
            this.VlTotal.Name = "VlTotal";
            // 
            // cbFornecedor
            // 
            this.cbFornecedor.FormattingEnabled = true;
            this.cbFornecedor.Location = new System.Drawing.Point(94, 280);
            this.cbFornecedor.Name = "cbFornecedor";
            this.cbFornecedor.Size = new System.Drawing.Size(618, 21);
            this.cbFornecedor.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 283);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Fornecedor";
            // 
            // cbProduto
            // 
            this.cbProduto.FormattingEnabled = true;
            this.cbProduto.Location = new System.Drawing.Point(94, 307);
            this.cbProduto.Name = "cbProduto";
            this.cbProduto.Size = new System.Drawing.Size(618, 21);
            this.cbProduto.TabIndex = 16;
            this.cbProduto.DropDownClosed += new System.EventHandler(this.cbProduto_DropDownClosed);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 310);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "Produto";
            // 
            // edDtaRecebimento
            // 
            this.edDtaRecebimento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.edDtaRecebimento.Location = new System.Drawing.Point(591, 334);
            this.edDtaRecebimento.Name = "edDtaRecebimento";
            this.edDtaRecebimento.Size = new System.Drawing.Size(121, 20);
            this.edDtaRecebimento.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(502, 337);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "Data de Entrega";
            // 
            // edVlCompra
            // 
            this.edVlCompra.Location = new System.Drawing.Point(94, 334);
            this.edVlCompra.Name = "edVlCompra";
            this.edVlCompra.Size = new System.Drawing.Size(80, 20);
            this.edVlCompra.TabIndex = 21;
            this.edVlCompra.Leave += new System.EventHandler(this.edVlCompra_Leave);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 337);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 13);
            this.label4.TabIndex = 22;
            this.label4.Text = "Valor Compra";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(184, 337);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 13);
            this.label5.TabIndex = 24;
            this.label5.Text = "Quantidade";
            // 
            // edVlTotal
            // 
            this.edVlTotal.Enabled = false;
            this.edVlTotal.Location = new System.Drawing.Point(404, 334);
            this.edVlTotal.Name = "edVlTotal";
            this.edVlTotal.Size = new System.Drawing.Size(80, 20);
            this.edVlTotal.TabIndex = 23;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(340, 337);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 13);
            this.label6.TabIndex = 26;
            this.label6.Text = "Valor Total";
            // 
            // btnIncluir
            // 
            this.btnIncluir.Location = new System.Drawing.Point(637, 360);
            this.btnIncluir.Name = "btnIncluir";
            this.btnIncluir.Size = new System.Drawing.Size(75, 23);
            this.btnIncluir.TabIndex = 25;
            this.btnIncluir.Text = "Incluir";
            this.btnIncluir.UseVisualStyleBackColor = true;
            this.btnIncluir.Click += new System.EventHandler(this.btnIncluir_Click);
            // 
            // edQtdRecebida
            // 
            this.edQtdRecebida.Location = new System.Drawing.Point(252, 335);
            this.edQtdRecebida.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.edQtdRecebida.Name = "edQtdRecebida";
            this.edQtdRecebida.Size = new System.Drawing.Size(64, 20);
            this.edQtdRecebida.TabIndex = 22;
            this.edQtdRecebida.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.edQtdRecebida.Leave += new System.EventHandler(this.edVlCompra_Leave);
            // 
            // edNumero
            // 
            this.edNumero.Location = new System.Drawing.Point(94, 253);
            this.edNumero.Name = "edNumero";
            this.edNumero.Size = new System.Drawing.Size(80, 20);
            this.edNumero.TabIndex = 27;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 256);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 13);
            this.label7.TabIndex = 28;
            this.label7.Text = "Número";
            // 
            // FPedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(724, 386);
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
        private System.Windows.Forms.DataGridViewTextBoxColumn Nomero;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fornecedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Produto;
        private System.Windows.Forms.DataGridViewTextBoxColumn VlCompra;
        private System.Windows.Forms.DataGridViewTextBoxColumn QtdRecebida;
        private System.Windows.Forms.DataGridViewTextBoxColumn VlTotal;
        private System.Windows.Forms.TextBox edNumero;
        private System.Windows.Forms.Label label7;
    }
}