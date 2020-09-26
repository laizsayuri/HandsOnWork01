namespace HandsOnWork01
{
    partial class FormLogin
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
            this.comboBoxTipoAcesso = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonAcesso = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // comboBoxTipoAcesso
            // 
            this.comboBoxTipoAcesso.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxTipoAcesso.FormattingEnabled = true;
            this.comboBoxTipoAcesso.Items.AddRange(new object[] {
            "Atendente",
            "Gerente"});
            this.comboBoxTipoAcesso.Location = new System.Drawing.Point(26, 46);
            this.comboBoxTipoAcesso.Name = "comboBoxTipoAcesso";
            this.comboBoxTipoAcesso.Size = new System.Drawing.Size(209, 21);
            this.comboBoxTipoAcesso.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tipo de Acesso:";
            // 
            // buttonAcesso
            // 
            this.buttonAcesso.Location = new System.Drawing.Point(90, 92);
            this.buttonAcesso.Name = "buttonAcesso";
            this.buttonAcesso.Size = new System.Drawing.Size(75, 23);
            this.buttonAcesso.TabIndex = 2;
            this.buttonAcesso.Text = "Acessar";
            this.buttonAcesso.UseVisualStyleBackColor = true;
            this.buttonAcesso.Click += new System.EventHandler(this.buttonAcesso_Click);
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(262, 127);
            this.Controls.Add(this.buttonAcesso);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxTipoAcesso);
            this.MinimizeBox = false;
            this.Name = "FormLogin";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.FormLogin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxTipoAcesso;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonAcesso;
    }
}