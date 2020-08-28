namespace PadawanCupomDesconto
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.btn_Gravar = new System.Windows.Forms.Button();
            this.btn_GerarCupom = new System.Windows.Forms.Button();
            this.txt_CupomDesconto = new System.Windows.Forms.TextBox();
            this.txt_Listagem = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.txt_NomeCliente = new System.Windows.Forms.TextBox();
            this.txt_Cpf = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_Gravar
            // 
            this.btn_Gravar.Location = new System.Drawing.Point(540, 324);
            this.btn_Gravar.Name = "btn_Gravar";
            this.btn_Gravar.Size = new System.Drawing.Size(80, 37);
            this.btn_Gravar.TabIndex = 0;
            this.btn_Gravar.Text = "Gravar";
            this.btn_Gravar.UseVisualStyleBackColor = true;
            this.btn_Gravar.Click += new System.EventHandler(this.btn_Gravar_Click);
            // 
            // btn_GerarCupom
            // 
            this.btn_GerarCupom.Location = new System.Drawing.Point(65, 54);
            this.btn_GerarCupom.Name = "btn_GerarCupom";
            this.btn_GerarCupom.Size = new System.Drawing.Size(168, 71);
            this.btn_GerarCupom.TabIndex = 1;
            this.btn_GerarCupom.Text = "Gerar Cupom";
            this.btn_GerarCupom.UseVisualStyleBackColor = true;
            this.btn_GerarCupom.Click += new System.EventHandler(this.btn_GerarCupom_Click);
            // 
            // txt_CupomDesconto
            // 
            this.txt_CupomDesconto.Location = new System.Drawing.Point(265, 54);
            this.txt_CupomDesconto.Multiline = true;
            this.txt_CupomDesconto.Name = "txt_CupomDesconto";
            this.txt_CupomDesconto.Size = new System.Drawing.Size(355, 71);
            this.txt_CupomDesconto.TabIndex = 2;
            // 
            // txt_Listagem
            // 
            this.txt_Listagem.Location = new System.Drawing.Point(655, 54);
            this.txt_Listagem.Multiline = true;
            this.txt_Listagem.Name = "txt_Listagem";
            this.txt_Listagem.Size = new System.Drawing.Size(355, 307);
            this.txt_Listagem.TabIndex = 3;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // txt_NomeCliente
            // 
            this.txt_NomeCliente.Location = new System.Drawing.Point(65, 185);
            this.txt_NomeCliente.Name = "txt_NomeCliente";
            this.txt_NomeCliente.Size = new System.Drawing.Size(555, 26);
            this.txt_NomeCliente.TabIndex = 5;
            // 
            // txt_Cpf
            // 
            this.txt_Cpf.Location = new System.Drawing.Point(65, 259);
            this.txt_Cpf.Name = "txt_Cpf";
            this.txt_Cpf.Size = new System.Drawing.Size(555, 26);
            this.txt_Cpf.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(65, 159);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "Nome Cliente";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(65, 236);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "CPF";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1022, 487);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_Cpf);
            this.Controls.Add(this.txt_NomeCliente);
            this.Controls.Add(this.txt_Listagem);
            this.Controls.Add(this.txt_CupomDesconto);
            this.Controls.Add(this.btn_GerarCupom);
            this.Controls.Add(this.btn_Gravar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Gravar;
        private System.Windows.Forms.Button btn_GerarCupom;
        private System.Windows.Forms.TextBox txt_CupomDesconto;
        private System.Windows.Forms.TextBox txt_Listagem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox txt_NomeCliente;
        private System.Windows.Forms.TextBox txt_Cpf;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

