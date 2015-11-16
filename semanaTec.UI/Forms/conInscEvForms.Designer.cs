namespace semanaTec.Forms
{
    partial class conInscEvForms
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
            this.buscarBtn = new System.Windows.Forms.Button();
            this.inscGV = new System.Windows.Forms.DataGridView();
            this.sNome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cpfMsk = new System.Windows.Forms.MaskedTextBox();
            this.cpfLbl = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.inscGV)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buscarBtn);
            this.groupBox1.Controls.Add(this.inscGV);
            this.groupBox1.Controls.Add(this.cpfMsk);
            this.groupBox1.Controls.Add(this.cpfLbl);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(510, 328);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Informações de inscrição";
            // 
            // buscarBtn
            // 
            this.buscarBtn.Location = new System.Drawing.Point(222, 101);
            this.buscarBtn.Name = "buscarBtn";
            this.buscarBtn.Size = new System.Drawing.Size(75, 30);
            this.buscarBtn.TabIndex = 2;
            this.buscarBtn.Tag = "Buscar";
            this.buscarBtn.Text = "Buscar";
            this.buscarBtn.UseVisualStyleBackColor = true;
            this.buscarBtn.Click += new System.EventHandler(this.buscarBtn_Click);
            // 
            // inscGV
            // 
            this.inscGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.inscGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.sNome});
            this.inscGV.Location = new System.Drawing.Point(6, 148);
            this.inscGV.Name = "inscGV";
            this.inscGV.Size = new System.Drawing.Size(498, 174);
            this.inscGV.TabIndex = 2;
            this.inscGV.Tag = "Informações";
            // 
            // sNome
            // 
            this.sNome.DataPropertyName = "sNome";
            this.sNome.HeaderText = "Nome";
            this.sNome.Name = "sNome";
            this.sNome.ReadOnly = true;
            this.sNome.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.sNome.Width = 455;
            // 
            // cpfMsk
            // 
            this.cpfMsk.Location = new System.Drawing.Point(204, 54);
            this.cpfMsk.Mask = "000,000,000-00";
            this.cpfMsk.Name = "cpfMsk";
            this.cpfMsk.Size = new System.Drawing.Size(119, 26);
            this.cpfMsk.TabIndex = 1;
            this.cpfMsk.Tag = "CPF";
            this.cpfMsk.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // cpfLbl
            // 
            this.cpfLbl.AutoSize = true;
            this.cpfLbl.Location = new System.Drawing.Point(158, 57);
            this.cpfLbl.Name = "cpfLbl";
            this.cpfLbl.Size = new System.Drawing.Size(40, 20);
            this.cpfLbl.TabIndex = 0;
            this.cpfLbl.Text = "CPF";
            // 
            // conInscEvForms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 352);
            this.Controls.Add(this.groupBox1);
            this.Name = "conInscEvForms";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consulta de inscrição";
            this.Load += new System.EventHandler(this.conInscEvForms_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.inscGV)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView inscGV;
        private System.Windows.Forms.MaskedTextBox cpfMsk;
        private System.Windows.Forms.Label cpfLbl;
        private System.Windows.Forms.Button buscarBtn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sNome;
    }
}