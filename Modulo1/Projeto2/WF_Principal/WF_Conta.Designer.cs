namespace WF_Principal
{
    partial class WF_Conta
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
            this.dgContas = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClienteId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BancoId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Agencia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ContaCorrente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Saldo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Limite = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnConta = new System.Windows.Forms.Button();
            this.btnCliente = new System.Windows.Forms.Button();
            this.btnBanco = new System.Windows.Forms.Button();
            this.btnCxEletronico = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgContas)).BeginInit();
            this.SuspendLayout();
            // 
            // dgContas
            // 
            this.dgContas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgContas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.ClienteId,
            this.BancoId,
            this.Agencia,
            this.ContaCorrente,
            this.Saldo,
            this.Limite});
            this.dgContas.Location = new System.Drawing.Point(0, 0);
            this.dgContas.Name = "dgContas";
            this.dgContas.Size = new System.Drawing.Size(800, 306);
            this.dgContas.TabIndex = 0;
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            // 
            // ClienteId
            // 
            this.ClienteId.DataPropertyName = "ClienteId";
            this.ClienteId.HeaderText = "ClienteId";
            this.ClienteId.Name = "ClienteId";
            // 
            // BancoId
            // 
            this.BancoId.DataPropertyName = "BancoId";
            this.BancoId.HeaderText = "BancoId";
            this.BancoId.Name = "BancoId";
            // 
            // Agencia
            // 
            this.Agencia.DataPropertyName = "Agencia";
            this.Agencia.HeaderText = "Agencia";
            this.Agencia.Name = "Agencia";
            // 
            // ContaCorrente
            // 
            this.ContaCorrente.DataPropertyName = "ContaCorrente";
            this.ContaCorrente.HeaderText = "ContaCorrente";
            this.ContaCorrente.Name = "ContaCorrente";
            // 
            // Saldo
            // 
            this.Saldo.DataPropertyName = "Saldo";
            this.Saldo.HeaderText = "Saldo";
            this.Saldo.Name = "Saldo";
            // 
            // Limite
            // 
            this.Limite.DataPropertyName = "Limite";
            this.Limite.HeaderText = "Limite";
            this.Limite.Name = "Limite";
            // 
            // btnConta
            // 
            this.btnConta.Location = new System.Drawing.Point(40, 324);
            this.btnConta.Name = "btnConta";
            this.btnConta.Size = new System.Drawing.Size(112, 37);
            this.btnConta.TabIndex = 1;
            this.btnConta.Text = "Conta";
            this.btnConta.UseVisualStyleBackColor = true;
            this.btnConta.Click += new System.EventHandler(this.btnConta_Click);
            // 
            // btnCliente
            // 
            this.btnCliente.Location = new System.Drawing.Point(171, 324);
            this.btnCliente.Name = "btnCliente";
            this.btnCliente.Size = new System.Drawing.Size(109, 37);
            this.btnCliente.TabIndex = 2;
            this.btnCliente.Text = "Cliente";
            this.btnCliente.UseVisualStyleBackColor = true;
            this.btnCliente.Click += new System.EventHandler(this.btnCliente_Click);
            // 
            // btnBanco
            // 
            this.btnBanco.Location = new System.Drawing.Point(300, 324);
            this.btnBanco.Name = "btnBanco";
            this.btnBanco.Size = new System.Drawing.Size(110, 37);
            this.btnBanco.TabIndex = 3;
            this.btnBanco.Text = "Banco";
            this.btnBanco.UseVisualStyleBackColor = true;
            this.btnBanco.Click += new System.EventHandler(this.btnBanco_Click);
            // 
            // btnCxEletronico
            // 
            this.btnCxEletronico.Location = new System.Drawing.Point(429, 324);
            this.btnCxEletronico.Name = "btnCxEletronico";
            this.btnCxEletronico.Size = new System.Drawing.Size(110, 37);
            this.btnCxEletronico.TabIndex = 4;
            this.btnCxEletronico.Text = "Caixa Eletrônico";
            this.btnCxEletronico.UseVisualStyleBackColor = true;
            this.btnCxEletronico.Click += new System.EventHandler(this.btnCxEletronico_Click);
            // 
            // WF_Conta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCxEletronico);
            this.Controls.Add(this.btnBanco);
            this.Controls.Add(this.btnCliente);
            this.Controls.Add(this.btnConta);
            this.Controls.Add(this.dgContas);
            this.Name = "WF_Conta";
            this.Text = "Contas";
            ((System.ComponentModel.ISupportInitialize)(this.dgContas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgContas;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClienteId;
        private System.Windows.Forms.DataGridViewTextBoxColumn BancoId;
        private System.Windows.Forms.DataGridViewTextBoxColumn Agencia;
        private System.Windows.Forms.DataGridViewTextBoxColumn ContaCorrente;
        private System.Windows.Forms.DataGridViewTextBoxColumn Saldo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Limite;
        private System.Windows.Forms.Button btnConta;
        private System.Windows.Forms.Button btnCliente;
        private System.Windows.Forms.Button btnBanco;
        private System.Windows.Forms.Button btnCxEletronico;
    }
}

