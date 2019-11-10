namespace WF_Mercado
{
    partial class FProduto
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
            this.btnFechar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.cbProduto = new System.Windows.Forms.ComboBox();
            this.edId = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ckAtivo = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.edVlCompra = new System.Windows.Forms.TextBox();
            this.edLucro = new System.Windows.Forms.TextBox();
            this.edVlVenda = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnFechar
            // 
            this.btnFechar.Location = new System.Drawing.Point(274, 153);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(75, 23);
            this.btnFechar.TabIndex = 7;
            this.btnFechar.Text = "Fechar";
            this.btnFechar.UseVisualStyleBackColor = true;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(193, 153);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(75, 23);
            this.btnExcluir.TabIndex = 6;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(112, 153);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 23);
            this.btnSalvar.TabIndex = 5;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // cbProduto
            // 
            this.cbProduto.FormattingEnabled = true;
            this.cbProduto.Location = new System.Drawing.Point(112, 46);
            this.cbProduto.Name = "cbProduto";
            this.cbProduto.Size = new System.Drawing.Size(275, 21);
            this.cbProduto.TabIndex = 1;
            this.cbProduto.DropDownClosed += new System.EventHandler(this.cbProduto_DropDownClosed);
            // 
            // edId
            // 
            this.edId.Enabled = false;
            this.edId.Location = new System.Drawing.Point(112, 20);
            this.edId.Name = "edId";
            this.edId.Size = new System.Drawing.Size(63, 20);
            this.edId.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Nome";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Id";
            // 
            // ckAtivo
            // 
            this.ckAtivo.AutoSize = true;
            this.ckAtivo.Location = new System.Drawing.Point(337, 19);
            this.ckAtivo.Name = "ckAtivo";
            this.ckAtivo.Size = new System.Drawing.Size(50, 17);
            this.ckAtivo.TabIndex = 18;
            this.ckAtivo.Text = "Ativo";
            this.ckAtivo.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 13);
            this.label3.TabIndex = 20;
            this.label3.Text = "Valor Compra";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 102);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 22;
            this.label4.Text = "Lucro";
            // 
            // edVlCompra
            // 
            this.edVlCompra.Location = new System.Drawing.Point(112, 73);
            this.edVlCompra.Name = "edVlCompra";
            this.edVlCompra.Size = new System.Drawing.Size(100, 20);
            this.edVlCompra.TabIndex = 2;
            this.edVlCompra.Leave += new System.EventHandler(this.edVlCompra_Leave);
            // 
            // edLucro
            // 
            this.edLucro.Location = new System.Drawing.Point(112, 99);
            this.edLucro.Name = "edLucro";
            this.edLucro.Size = new System.Drawing.Size(100, 20);
            this.edLucro.TabIndex = 3;
            this.edLucro.Leave += new System.EventHandler(this.edVlCompra_Leave);
            // 
            // edVlVenda
            // 
            this.edVlVenda.Location = new System.Drawing.Point(112, 125);
            this.edVlVenda.Name = "edVlVenda";
            this.edVlVenda.Size = new System.Drawing.Size(100, 20);
            this.edVlVenda.TabIndex = 4;
            this.edVlVenda.Leave += new System.EventHandler(this.edVlVenda_Leave);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(24, 128);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 13);
            this.label5.TabIndex = 24;
            this.label5.Text = "Valor Venda";
            // 
            // FProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(407, 188);
            this.Controls.Add(this.edVlVenda);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.edLucro);
            this.Controls.Add(this.edVlCompra);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ckAtivo);
            this.Controls.Add(this.btnFechar);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.cbProduto);
            this.Controls.Add(this.edId);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FProduto";
            this.Text = "FProduto";
            this.Load += new System.EventHandler(this.FProduto_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.ComboBox cbProduto;
        private System.Windows.Forms.TextBox edId;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox ckAtivo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox edVlCompra;
        private System.Windows.Forms.TextBox edLucro;
        private System.Windows.Forms.TextBox edVlVenda;
        private System.Windows.Forms.Label label5;
    }
}