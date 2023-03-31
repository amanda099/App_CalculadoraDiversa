namespace AppCalculadoraDiversa.Formularios
{
    partial class FormCalcularDesconto
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbCliente = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtValorDaCompra = new System.Windows.Forms.TextBox();
            this.lbTipoCliente = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtValorDoDesconto = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtValorTotal = new System.Windows.Forms.TextBox();
            this.btCalcular = new System.Windows.Forms.Button();
            this.btNovo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Arial", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(716, 50);
            this.label1.TabIndex = 4;
            this.label1.Text = "Calcular Desconto";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(12, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(716, 32);
            this.label2.TabIndex = 7;
            this.label2.Text = "Selecione a categoria do cliente:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cbCliente
            // 
            this.cbCliente.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbCliente.FormattingEnabled = true;
            this.cbCliente.Items.AddRange(new object[] {
            "Comum",
            "Especial",
            "VIP",
            "Premium"});
            this.cbCliente.Location = new System.Drawing.Point(200, 109);
            this.cbCliente.Name = "cbCliente";
            this.cbCliente.Size = new System.Drawing.Size(335, 32);
            this.cbCliente.TabIndex = 8;
            this.cbCliente.SelectedIndexChanged += new System.EventHandler(this.cbCliente_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(69, 193);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(406, 29);
            this.label5.TabIndex = 16;
            this.label5.Text = "Informe o valor total da compra:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtValorDaCompra
            // 
            this.txtValorDaCompra.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValorDaCompra.Location = new System.Drawing.Point(73, 225);
            this.txtValorDaCompra.Name = "txtValorDaCompra";
            this.txtValorDaCompra.Size = new System.Drawing.Size(153, 30);
            this.txtValorDaCompra.TabIndex = 15;
            // 
            // lbTipoCliente
            // 
            this.lbTipoCliente.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTipoCliente.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbTipoCliente.Location = new System.Drawing.Point(14, 267);
            this.lbTipoCliente.Name = "lbTipoCliente";
            this.lbTipoCliente.Size = new System.Drawing.Size(716, 29);
            this.lbTipoCliente.TabIndex = 22;
            this.lbTipoCliente.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(69, 319);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(406, 29);
            this.label3.TabIndex = 24;
            this.label3.Text = "Valor do desconto:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtValorDoDesconto
            // 
            this.txtValorDoDesconto.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValorDoDesconto.Location = new System.Drawing.Point(73, 351);
            this.txtValorDoDesconto.Name = "txtValorDoDesconto";
            this.txtValorDoDesconto.Size = new System.Drawing.Size(153, 30);
            this.txtValorDoDesconto.TabIndex = 23;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(69, 439);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(406, 29);
            this.label4.TabIndex = 26;
            this.label4.Text = "Valor final com desconto:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtValorTotal
            // 
            this.txtValorTotal.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValorTotal.Location = new System.Drawing.Point(73, 471);
            this.txtValorTotal.Name = "txtValorTotal";
            this.txtValorTotal.Size = new System.Drawing.Size(153, 30);
            this.txtValorTotal.TabIndex = 25;
            // 
            // btCalcular
            // 
            this.btCalcular.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCalcular.Location = new System.Drawing.Point(487, 308);
            this.btCalcular.Name = "btCalcular";
            this.btCalcular.Size = new System.Drawing.Size(124, 66);
            this.btCalcular.TabIndex = 27;
            this.btCalcular.Text = "Calcular";
            this.btCalcular.UseVisualStyleBackColor = true;
            this.btCalcular.Click += new System.EventHandler(this.btCalcular_Click);
            // 
            // btNovo
            // 
            this.btNovo.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btNovo.Location = new System.Drawing.Point(487, 409);
            this.btNovo.Name = "btNovo";
            this.btNovo.Size = new System.Drawing.Size(124, 66);
            this.btNovo.TabIndex = 28;
            this.btNovo.Text = "Novo";
            this.btNovo.UseVisualStyleBackColor = true;
            this.btNovo.Click += new System.EventHandler(this.btNovo_Click);
            // 
            // FormCalcularDesconto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(740, 545);
            this.Controls.Add(this.btNovo);
            this.Controls.Add(this.btCalcular);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtValorTotal);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtValorDoDesconto);
            this.Controls.Add(this.lbTipoCliente);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtValorDaCompra);
            this.Controls.Add(this.cbCliente);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormCalcularDesconto";
            this.Text = "FormCalcularDesconto";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbCliente;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtValorDaCompra;
        private System.Windows.Forms.Label lbTipoCliente;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtValorDoDesconto;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtValorTotal;
        private System.Windows.Forms.Button btCalcular;
        private System.Windows.Forms.Button btNovo;
    }
}