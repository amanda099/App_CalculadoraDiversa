namespace AppCalculadoraDiversa.Formularios
{
    partial class FormSimularSalario
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
            this.cbCargo = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lbTotalDeVendas = new System.Windows.Forms.Label();
            this.txtTotalDeVendas = new System.Windows.Forms.TextBox();
            this.lbSalario = new System.Windows.Forms.Label();
            this.txtSalario = new System.Windows.Forms.TextBox();
            this.btNovo = new System.Windows.Forms.Button();
            this.btCalcular = new System.Windows.Forms.Button();
            this.lbResultado = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Arial", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(776, 50);
            this.label1.TabIndex = 3;
            this.label1.Text = "Simulador Salarial";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cbCargo
            // 
            this.cbCargo.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbCargo.FormattingEnabled = true;
            this.cbCargo.Items.AddRange(new object[] {
            "Estagiágio",
            "Junior",
            "Pleno",
            "Sênior",
            "Gerente"});
            this.cbCargo.Location = new System.Drawing.Point(231, 131);
            this.cbCargo.Name = "cbCargo";
            this.cbCargo.Size = new System.Drawing.Size(335, 32);
            this.cbCargo.TabIndex = 7;
            this.cbCargo.SelectedIndexChanged += new System.EventHandler(this.cbCargo_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(12, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(776, 32);
            this.label2.TabIndex = 6;
            this.label2.Text = "Selecione o cargo:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbTotalDeVendas
            // 
            this.lbTotalDeVendas.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTotalDeVendas.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbTotalDeVendas.Location = new System.Drawing.Point(66, 198);
            this.lbTotalDeVendas.Name = "lbTotalDeVendas";
            this.lbTotalDeVendas.Size = new System.Drawing.Size(374, 29);
            this.lbTotalDeVendas.TabIndex = 14;
            this.lbTotalDeVendas.Text = "Total das vendas:";
            this.lbTotalDeVendas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtTotalDeVendas
            // 
            this.txtTotalDeVendas.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalDeVendas.Location = new System.Drawing.Point(70, 230);
            this.txtTotalDeVendas.Name = "txtTotalDeVendas";
            this.txtTotalDeVendas.Size = new System.Drawing.Size(153, 30);
            this.txtTotalDeVendas.TabIndex = 13;
            // 
            // lbSalario
            // 
            this.lbSalario.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSalario.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbSalario.Location = new System.Drawing.Point(66, 276);
            this.lbSalario.Name = "lbSalario";
            this.lbSalario.Size = new System.Drawing.Size(374, 29);
            this.lbSalario.TabIndex = 16;
            this.lbSalario.Text = "Informe o seu salário:";
            this.lbSalario.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtSalario
            // 
            this.txtSalario.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSalario.Location = new System.Drawing.Point(70, 308);
            this.txtSalario.Name = "txtSalario";
            this.txtSalario.Size = new System.Drawing.Size(153, 30);
            this.txtSalario.TabIndex = 15;
            this.txtSalario.TextChanged += new System.EventHandler(this.txtSalario_TextChanged);
            // 
            // btNovo
            // 
            this.btNovo.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btNovo.Location = new System.Drawing.Point(531, 276);
            this.btNovo.Name = "btNovo";
            this.btNovo.Size = new System.Drawing.Size(135, 45);
            this.btNovo.TabIndex = 20;
            this.btNovo.Text = "Novo";
            this.btNovo.UseVisualStyleBackColor = true;
            this.btNovo.Click += new System.EventHandler(this.btNovo_Click);
            // 
            // btCalcular
            // 
            this.btCalcular.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCalcular.Location = new System.Drawing.Point(531, 225);
            this.btCalcular.Name = "btCalcular";
            this.btCalcular.Size = new System.Drawing.Size(135, 45);
            this.btCalcular.TabIndex = 19;
            this.btCalcular.Text = "Calcular";
            this.btCalcular.UseVisualStyleBackColor = true;
            this.btCalcular.Click += new System.EventHandler(this.btCalcular_Click);
            // 
            // lbResultado
            // 
            this.lbResultado.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbResultado.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbResultado.Location = new System.Drawing.Point(12, 405);
            this.lbResultado.Name = "lbResultado";
            this.lbResultado.Size = new System.Drawing.Size(776, 29);
            this.lbResultado.TabIndex = 21;
            this.lbResultado.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbResultado.Click += new System.EventHandler(this.lbResultado_Click);
            // 
            // FormSimularSalario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(800, 478);
            this.Controls.Add(this.lbResultado);
            this.Controls.Add(this.btNovo);
            this.Controls.Add(this.btCalcular);
            this.Controls.Add(this.lbSalario);
            this.Controls.Add(this.txtSalario);
            this.Controls.Add(this.lbTotalDeVendas);
            this.Controls.Add(this.txtTotalDeVendas);
            this.Controls.Add(this.cbCargo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormSimularSalario";
            this.Text = "FormSimularSalario";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbCargo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbTotalDeVendas;
        private System.Windows.Forms.TextBox txtTotalDeVendas;
        private System.Windows.Forms.Label lbSalario;
        private System.Windows.Forms.TextBox txtSalario;
        private System.Windows.Forms.Button btNovo;
        private System.Windows.Forms.Button btCalcular;
        private System.Windows.Forms.Label lbResultado;
    }
}