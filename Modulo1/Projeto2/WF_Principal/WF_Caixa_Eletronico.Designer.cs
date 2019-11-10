namespace WF_Principal
{
    partial class WF_Caixa_Eletronico
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.edSqConta = new System.Windows.Forms.TextBox();
            this.edSqValor = new System.Windows.Forms.TextBox();
            this.btnSacar = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnDepositar = new System.Windows.Forms.Button();
            this.edDpValor = new System.Windows.Forms.TextBox();
            this.edDpConta = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnTransferir = new System.Windows.Forms.Button();
            this.edTrValor = new System.Windows.Forms.TextBox();
            this.edTrOrigem = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.edTrDestino = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnSacar);
            this.groupBox1.Controls.Add(this.edSqValor);
            this.groupBox1.Controls.Add(this.edSqConta);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(9, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(355, 78);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Saque";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Conta";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 48);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Valor";
            // 
            // edSqConta
            // 
            this.edSqConta.Location = new System.Drawing.Point(98, 19);
            this.edSqConta.Name = "edSqConta";
            this.edSqConta.Size = new System.Drawing.Size(100, 20);
            this.edSqConta.TabIndex = 6;
            // 
            // edSqValor
            // 
            this.edSqValor.Location = new System.Drawing.Point(98, 45);
            this.edSqValor.Name = "edSqValor";
            this.edSqValor.Size = new System.Drawing.Size(100, 20);
            this.edSqValor.TabIndex = 7;
            // 
            // btnSacar
            // 
            this.btnSacar.Location = new System.Drawing.Point(213, 19);
            this.btnSacar.Name = "btnSacar";
            this.btnSacar.Size = new System.Drawing.Size(123, 46);
            this.btnSacar.TabIndex = 8;
            this.btnSacar.Text = "Sacar";
            this.btnSacar.UseVisualStyleBackColor = true;
            this.btnSacar.Click += new System.EventHandler(this.btnSacar_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnDepositar);
            this.groupBox2.Controls.Add(this.edDpValor);
            this.groupBox2.Controls.Add(this.edDpConta);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Location = new System.Drawing.Point(9, 86);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(355, 85);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Deposito";
            // 
            // btnDepositar
            // 
            this.btnDepositar.Location = new System.Drawing.Point(213, 21);
            this.btnDepositar.Name = "btnDepositar";
            this.btnDepositar.Size = new System.Drawing.Size(123, 46);
            this.btnDepositar.TabIndex = 8;
            this.btnDepositar.Text = "Depositar";
            this.btnDepositar.UseVisualStyleBackColor = true;
            this.btnDepositar.Click += new System.EventHandler(this.btnDepositar_Click);
            // 
            // edDpValor
            // 
            this.edDpValor.Location = new System.Drawing.Point(98, 47);
            this.edDpValor.Name = "edDpValor";
            this.edDpValor.Size = new System.Drawing.Size(100, 20);
            this.edDpValor.TabIndex = 7;
            // 
            // edDpConta
            // 
            this.edDpConta.Location = new System.Drawing.Point(98, 21);
            this.edDpConta.Name = "edDpConta";
            this.edDpConta.Size = new System.Drawing.Size(100, 20);
            this.edDpConta.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 50);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Valor";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(21, 24);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "Conta";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.edTrDestino);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.btnTransferir);
            this.groupBox3.Controls.Add(this.edTrValor);
            this.groupBox3.Controls.Add(this.edTrOrigem);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Location = new System.Drawing.Point(9, 177);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(355, 101);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Transferência";
            // 
            // btnTransferir
            // 
            this.btnTransferir.Location = new System.Drawing.Point(213, 19);
            this.btnTransferir.Name = "btnTransferir";
            this.btnTransferir.Size = new System.Drawing.Size(123, 72);
            this.btnTransferir.TabIndex = 8;
            this.btnTransferir.Text = "Transferir";
            this.btnTransferir.UseVisualStyleBackColor = true;
            this.btnTransferir.Click += new System.EventHandler(this.btnTransferir_Click);
            // 
            // edTrValor
            // 
            this.edTrValor.Location = new System.Drawing.Point(98, 71);
            this.edTrValor.Name = "edTrValor";
            this.edTrValor.Size = new System.Drawing.Size(100, 20);
            this.edTrValor.TabIndex = 7;
            // 
            // edTrOrigem
            // 
            this.edTrOrigem.Location = new System.Drawing.Point(98, 19);
            this.edTrOrigem.Name = "edTrOrigem";
            this.edTrOrigem.Size = new System.Drawing.Size(100, 20);
            this.edTrOrigem.TabIndex = 6;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(21, 74);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(31, 13);
            this.label9.TabIndex = 4;
            this.label9.Text = "Valor";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(21, 22);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(71, 13);
            this.label10.TabIndex = 3;
            this.label10.Text = "Conta Origem";
            // 
            // edTrDestino
            // 
            this.edTrDestino.Location = new System.Drawing.Point(98, 45);
            this.edTrDestino.Name = "edTrDestino";
            this.edTrDestino.Size = new System.Drawing.Size(100, 20);
            this.edTrDestino.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Conta Destino";
            // 
            // WF_Caixa_Eletronico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(376, 290);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "WF_Caixa_Eletronico";
            this.Text = "Caixa Eletrônico";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button btnSacar;
        private System.Windows.Forms.TextBox edSqValor;
        private System.Windows.Forms.TextBox edSqConta;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnDepositar;
        private System.Windows.Forms.TextBox edDpValor;
        private System.Windows.Forms.TextBox edDpConta;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox edTrDestino;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnTransferir;
        private System.Windows.Forms.TextBox edTrValor;
        private System.Windows.Forms.TextBox edTrOrigem;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
    }
}