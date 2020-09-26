namespace HandsOnWork01
{
    partial class FormTabela
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonAddBula = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Apresentacao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.labelCarregando = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Location = new System.Drawing.Point(70, 22);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(441, 20);
            this.textBoxSearch.TabIndex = 0;
            this.textBoxSearch.TextChanged += new System.EventHandler(this.textBoxSearch_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Buscar:";
            // 
            // buttonAddBula
            // 
            this.buttonAddBula.Location = new System.Drawing.Point(517, 20);
            this.buttonAddBula.Name = "buttonAddBula";
            this.buttonAddBula.Size = new System.Drawing.Size(95, 23);
            this.buttonAddBula.TabIndex = 2;
            this.buttonAddBula.Text = "Adicionar";
            this.buttonAddBula.UseVisualStyleBackColor = true;
            this.buttonAddBula.Click += new System.EventHandler(this.buttonAddBula_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Nome,
            this.Apresentacao});
            this.dataGridView1.Location = new System.Drawing.Point(24, 72);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(588, 271);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // Id
            // 
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Visible = false;
            // 
            // Nome
            // 
            this.Nome.HeaderText = "Nome Comercial";
            this.Nome.Name = "Nome";
            this.Nome.ReadOnly = true;
            this.Nome.Width = 200;
            // 
            // Apresentacao
            // 
            this.Apresentacao.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Apresentacao.HeaderText = "Apresentação";
            this.Apresentacao.Name = "Apresentacao";
            this.Apresentacao.ReadOnly = true;
            // 
            // labelCarregando
            // 
            this.labelCarregando.AutoSize = true;
            this.labelCarregando.Location = new System.Drawing.Point(541, 346);
            this.labelCarregando.Name = "labelCarregando";
            this.labelCarregando.Size = new System.Drawing.Size(71, 13);
            this.labelCarregando.TabIndex = 4;
            this.labelCarregando.Text = "Carregando...";
            this.labelCarregando.Visible = false;
            // 
            // FormTabela
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(635, 370);
            this.Controls.Add(this.labelCarregando);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.buttonAddBula);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxSearch);
            this.MaximizeBox = false;
            this.Name = "FormTabela";
            this.Text = "Gerenciador de Bulas";
            this.Shown += new System.EventHandler(this.FormTabela_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonAddBula;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label labelCarregando;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn Apresentacao;
    }
}

