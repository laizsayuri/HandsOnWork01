namespace HandsOnWork01
{
    partial class FormSenha
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
            this.buttonAcessar = new System.Windows.Forms.Button();
            this.textBoxSenha = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Senha:";
            // 
            // buttonAcessar
            // 
            this.buttonAcessar.Location = new System.Drawing.Point(58, 83);
            this.buttonAcessar.Name = "buttonAcessar";
            this.buttonAcessar.Size = new System.Drawing.Size(75, 23);
            this.buttonAcessar.TabIndex = 1;
            this.buttonAcessar.Text = "Acessar";
            this.buttonAcessar.UseVisualStyleBackColor = true;
            this.buttonAcessar.Click += new System.EventHandler(this.buttonAcessar_Click);
            // 
            // textBoxSenha
            // 
            this.textBoxSenha.Location = new System.Drawing.Point(25, 48);
            this.textBoxSenha.Name = "textBoxSenha";
            this.textBoxSenha.Size = new System.Drawing.Size(158, 20);
            this.textBoxSenha.TabIndex = 2;
            this.textBoxSenha.UseSystemPasswordChar = true;
            // 
            // FormSenha
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(206, 118);
            this.Controls.Add(this.textBoxSenha);
            this.Controls.Add(this.buttonAcessar);
            this.Controls.Add(this.label1);
            this.Name = "FormSenha";
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonAcessar;
        private System.Windows.Forms.TextBox textBoxSenha;
    }
}