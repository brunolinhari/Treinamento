﻿namespace WF_Mercado
{
    partial class FPrincipal
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
            this.btnPedido = new System.Windows.Forms.Button();
            this.btnCliente = new System.Windows.Forms.Button();
            this.btnProduto = new System.Windows.Forms.Button();
            this.btnFornecedor = new System.Windows.Forms.Button();
            this.btnEstoque = new System.Windows.Forms.Button();
            this.btnVenda = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnPedido
            // 
            this.btnPedido.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPedido.Location = new System.Drawing.Point(0, 0);
            this.btnPedido.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnPedido.Name = "btnPedido";
            this.btnPedido.Size = new System.Drawing.Size(884, 90);
            this.btnPedido.TabIndex = 0;
            this.btnPedido.Text = "PEDIDOS";
            this.btnPedido.UseVisualStyleBackColor = true;
            this.btnPedido.Click += new System.EventHandler(this.btnPedido_Click);
            // 
            // btnCliente
            // 
            this.btnCliente.Location = new System.Drawing.Point(0, 177);
            this.btnCliente.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCliente.Name = "btnCliente";
            this.btnCliente.Size = new System.Drawing.Size(297, 92);
            this.btnCliente.TabIndex = 1;
            this.btnCliente.Text = "Clientes";
            this.btnCliente.UseVisualStyleBackColor = true;
            this.btnCliente.Click += new System.EventHandler(this.btnCliente_Click);
            // 
            // btnProduto
            // 
            this.btnProduto.Location = new System.Drawing.Point(293, 177);
            this.btnProduto.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnProduto.Name = "btnProduto";
            this.btnProduto.Size = new System.Drawing.Size(297, 92);
            this.btnProduto.TabIndex = 2;
            this.btnProduto.Text = "Produtos";
            this.btnProduto.UseVisualStyleBackColor = true;
            this.btnProduto.Click += new System.EventHandler(this.btnProduto_Click);
            // 
            // btnFornecedor
            // 
            this.btnFornecedor.Location = new System.Drawing.Point(587, 177);
            this.btnFornecedor.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnFornecedor.Name = "btnFornecedor";
            this.btnFornecedor.Size = new System.Drawing.Size(297, 92);
            this.btnFornecedor.TabIndex = 3;
            this.btnFornecedor.Text = "Fornecedores";
            this.btnFornecedor.UseVisualStyleBackColor = true;
            this.btnFornecedor.Click += new System.EventHandler(this.btnFornecedor_Click);
            // 
            // btnEstoque
            // 
            this.btnEstoque.Location = new System.Drawing.Point(293, 268);
            this.btnEstoque.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnEstoque.Name = "btnEstoque";
            this.btnEstoque.Size = new System.Drawing.Size(297, 90);
            this.btnEstoque.TabIndex = 4;
            this.btnEstoque.Text = "Controle de Estoque";
            this.btnEstoque.UseVisualStyleBackColor = true;
            this.btnEstoque.Click += new System.EventHandler(this.btnEstoque_Click);
            // 
            // btnVenda
            // 
            this.btnVenda.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVenda.Location = new System.Drawing.Point(0, 89);
            this.btnVenda.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnVenda.Name = "btnVenda";
            this.btnVenda.Size = new System.Drawing.Size(884, 90);
            this.btnVenda.TabIndex = 5;
            this.btnVenda.Text = "VENDAS";
            this.btnVenda.UseVisualStyleBackColor = true;
            this.btnVenda.Click += new System.EventHandler(this.btnVenda_Click);
            // 
            // FPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 361);
            this.Controls.Add(this.btnVenda);
            this.Controls.Add(this.btnEstoque);
            this.Controls.Add(this.btnFornecedor);
            this.Controls.Add(this.btnProduto);
            this.Controls.Add(this.btnCliente);
            this.Controls.Add(this.btnPedido);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FPrincipal";
            this.Text = "Mercadinho";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnPedido;
        private System.Windows.Forms.Button btnCliente;
        private System.Windows.Forms.Button btnProduto;
        private System.Windows.Forms.Button btnFornecedor;
        private System.Windows.Forms.Button btnEstoque;
        private System.Windows.Forms.Button btnVenda;
    }
}

