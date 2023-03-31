namespace AppCalculadoraDiversa.Formularios
{
    partial class FormCalcularRaizes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCalcularRaizes));
            this.label1 = new System.Windows.Forms.Label();
            this.cbTipoRaiz = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lbBase = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtResultado = new System.Windows.Forms.TextBox();
            this.txtBase = new System.Windows.Forms.TextBox();
            this.txtExpoente = new System.Windows.Forms.TextBox();
            this.lbExpoente = new System.Windows.Forms.Label();
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
            this.label1.Size = new System.Drawing.Size(687, 50);
            this.label1.TabIndex = 2;
            this.label1.Text = "Calculadora de Potências e Raizes";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cbTipoRaiz
            // 
            this.cbTipoRaiz.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbTipoRaiz.FormattingEnabled = true;
            this.cbTipoRaiz.Items.AddRange(new object[] {
            "Potência",
            "Raiz Quadrada",
            "Raiz Cúbica",
            "Raiz Enésima"});
            this.cbTipoRaiz.Location = new System.Drawing.Point(188, 117);
            this.cbTipoRaiz.Name = "cbTipoRaiz";
            this.cbTipoRaiz.Size = new System.Drawing.Size(335, 32);
            this.cbTipoRaiz.TabIndex = 5;
            this.cbTipoRaiz.SelectedIndexChanged += new System.EventHandler(this.cmbOpcao_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(19, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(680, 32);
            this.label2.TabIndex = 4;
            this.label2.Text = "Selecione a opção de calculo:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbBase
            // 
            this.lbBase.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbBase.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbBase.Location = new System.Drawing.Point(97, 201);
            this.lbBase.Name = "lbBase";
            this.lbBase.Size = new System.Drawing.Size(374, 29);
            this.lbBase.TabIndex = 12;
            this.lbBase.Text = "Informe a base:";
            this.lbBase.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(97, 421);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(296, 29);
            this.label5.TabIndex = 16;
            this.label5.Text = "Resultado:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtResultado
            // 
            this.txtResultado.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtResultado.Location = new System.Drawing.Point(101, 453);
            this.txtResultado.Name = "txtResultado";
            this.txtResultado.Size = new System.Drawing.Size(153, 30);
            this.txtResultado.TabIndex = 15;
            // 
            // txtBase
            // 
            this.txtBase.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBase.Location = new System.Drawing.Point(101, 233);
            this.txtBase.Name = "txtBase";
            this.txtBase.Size = new System.Drawing.Size(153, 30);
            this.txtBase.TabIndex = 11;
            this.txtBase.TextChanged += new System.EventHandler(this.txtBase_TextChanged);
            // 
            // txtExpoente
            // 
            this.txtExpoente.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtExpoente.Location = new System.Drawing.Point(101, 309);
            this.txtExpoente.Name = "txtExpoente";
            this.txtExpoente.Size = new System.Drawing.Size(153, 30);
            this.txtExpoente.TabIndex = 13;
            // 
            // lbExpoente
            // 
            this.lbExpoente.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbExpoente.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbExpoente.Location = new System.Drawing.Point(97, 277);
            this.lbExpoente.Name = "lbExpoente";
            this.lbExpoente.Size = new System.Drawing.Size(345, 29);
            this.lbExpoente.TabIndex = 14;
            this.lbExpoente.Text = "Informe o expoente:";
            this.lbExpoente.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btCalcular
            // 
            this.btCalcular.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCalcular.Location = new System.Drawing.Point(448, 294);
            this.btCalcular.Name = "btCalcular";
            this.btCalcular.Size = new System.Drawing.Size(135, 45);
            this.btCalcular.TabIndex = 17;
            this.btCalcular.Text = "Calcular";
            this.btCalcular.UseVisualStyleBackColor = true;
            this.btCalcular.Click += new System.EventHandler(this.btCalcular_Click);
            // 
            // btNovo
            // 
            this.btNovo.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btNovo.Location = new System.Drawing.Point(448, 345);
            this.btNovo.Name = "btNovo";
            this.btNovo.Size = new System.Drawing.Size(135, 45);
            this.btNovo.TabIndex = 18;
            this.btNovo.Text = "Novo";
            this.btNovo.UseVisualStyleBackColor = true;
            this.btNovo.Click += new System.EventHandler(this.btNovo_Click);
            // 
            // FormCalcularRaizes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(711, 535);
            this.Controls.Add(this.btNovo);
            this.Controls.Add(this.btCalcular);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtResultado);
            this.Controls.Add(this.lbExpoente);
            this.Controls.Add(this.txtExpoente);
            this.Controls.Add(this.lbBase);
            this.Controls.Add(this.txtBase);
            this.Controls.Add(this.cbTipoRaiz);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormCalcularRaizes";
            this.Text = "Calcular Potências e Raízes";
            this.Load += new System.EventHandler(this.FormCalcularRaizes_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbTipoRaiz;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbBase;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtResultado;
        private System.Windows.Forms.TextBox txtBase;
        private System.Windows.Forms.TextBox txtExpoente;
        private System.Windows.Forms.Label lbExpoente;
        private System.Windows.Forms.Button btCalcular;
        private System.Windows.Forms.Button btNovo;
    }
}