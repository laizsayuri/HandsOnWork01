namespace HandsOnWork01
{
    partial class FormDetalhes
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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxNome = new System.Windows.Forms.TextBox();
            this.textBoxApresentacao = new System.Windows.Forms.TextBox();
            this.textBoxUso = new System.Windows.Forms.TextBox();
            this.textBoxComposicao = new System.Windows.Forms.TextBox();
            this.textBoxIndicacao = new System.Windows.Forms.TextBox();
            this.buttonAlterar = new System.Windows.Forms.Button();
            this.buttonRemover = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome Comercial:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Apresentação:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(70, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Uso:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(31, 196);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Composição:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(42, 283);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Indicação:";
            // 
            // textBoxNome
            // 
            this.textBoxNome.Location = new System.Drawing.Point(105, 34);
            this.textBoxNome.Name = "textBoxNome";
            this.textBoxNome.ReadOnly = true;
            this.textBoxNome.Size = new System.Drawing.Size(492, 20);
            this.textBoxNome.TabIndex = 5;
            // 
            // textBoxApresentacao
            // 
            this.textBoxApresentacao.Location = new System.Drawing.Point(105, 78);
            this.textBoxApresentacao.Name = "textBoxApresentacao";
            this.textBoxApresentacao.ReadOnly = true;
            this.textBoxApresentacao.Size = new System.Drawing.Size(492, 20);
            this.textBoxApresentacao.TabIndex = 6;
            // 
            // textBoxUso
            // 
            this.textBoxUso.Location = new System.Drawing.Point(105, 124);
            this.textBoxUso.Multiline = true;
            this.textBoxUso.Name = "textBoxUso";
            this.textBoxUso.ReadOnly = true;
            this.textBoxUso.Size = new System.Drawing.Size(492, 46);
            this.textBoxUso.TabIndex = 7;
            // 
            // textBoxComposicao
            // 
            this.textBoxComposicao.Location = new System.Drawing.Point(105, 196);
            this.textBoxComposicao.Multiline = true;
            this.textBoxComposicao.Name = "textBoxComposicao";
            this.textBoxComposicao.ReadOnly = true;
            this.textBoxComposicao.Size = new System.Drawing.Size(492, 59);
            this.textBoxComposicao.TabIndex = 8;
            // 
            // textBoxIndicacao
            // 
            this.textBoxIndicacao.Location = new System.Drawing.Point(105, 283);
            this.textBoxIndicacao.Multiline = true;
            this.textBoxIndicacao.Name = "textBoxIndicacao";
            this.textBoxIndicacao.ReadOnly = true;
            this.textBoxIndicacao.Size = new System.Drawing.Size(492, 118);
            this.textBoxIndicacao.TabIndex = 9;
            // 
            // buttonAlterar
            // 
            this.buttonAlterar.Location = new System.Drawing.Point(522, 429);
            this.buttonAlterar.Name = "buttonAlterar";
            this.buttonAlterar.Size = new System.Drawing.Size(75, 23);
            this.buttonAlterar.TabIndex = 10;
            this.buttonAlterar.Text = "Alterar";
            this.buttonAlterar.UseVisualStyleBackColor = true;
            this.buttonAlterar.Click += new System.EventHandler(this.buttonAlterar_Click);
            // 
            // buttonRemover
            // 
            this.buttonRemover.Location = new System.Drawing.Point(441, 429);
            this.buttonRemover.Name = "buttonRemover";
            this.buttonRemover.Size = new System.Drawing.Size(75, 23);
            this.buttonRemover.TabIndex = 11;
            this.buttonRemover.Text = "Remover";
            this.buttonRemover.UseVisualStyleBackColor = true;
            this.buttonRemover.Click += new System.EventHandler(this.buttonRemover_Click);
            // 
            // FormDetalhes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(626, 464);
            this.Controls.Add(this.buttonRemover);
            this.Controls.Add(this.buttonAlterar);
            this.Controls.Add(this.textBoxIndicacao);
            this.Controls.Add(this.textBoxComposicao);
            this.Controls.Add(this.textBoxUso);
            this.Controls.Add(this.textBoxApresentacao);
            this.Controls.Add(this.textBoxNome);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "FormDetalhes";
            this.Text = "Detalhes";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxNome;
        private System.Windows.Forms.TextBox textBoxApresentacao;
        private System.Windows.Forms.TextBox textBoxUso;
        private System.Windows.Forms.TextBox textBoxComposicao;
        private System.Windows.Forms.TextBox textBoxIndicacao;
        private System.Windows.Forms.Button buttonAlterar;
        private System.Windows.Forms.Button buttonRemover;
    }
}