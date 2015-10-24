namespace semanaTec.Forms
{
    partial class conInscForms
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
            this.groupBox1.Size = new System.Drawing.Size(510, 292);
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
            this.buscarBtn.Text = "Buscar";
            this.buscarBtn.UseVisualStyleBackColor = true;
            // 
            // inscGV
            // 
            this.inscGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.inscGV.Location = new System.Drawing.Point(6, 154);
            this.inscGV.Name = "inscGV";
            this.inscGV.Size = new System.Drawing.Size(498, 130);
            this.inscGV.TabIndex = 2;
            // 
            // cpfMsk
            // 
            this.cpfMsk.Location = new System.Drawing.Point(204, 54);
            this.cpfMsk.Mask = "000,000,000-00";
            this.cpfMsk.Name = "cpfMsk";
            this.cpfMsk.Size = new System.Drawing.Size(119, 26);
            this.cpfMsk.TabIndex = 1;
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
            // conInscForms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 412);
            this.Controls.Add(this.groupBox1);
            this.Name = "conInscForms";
            this.Text = "conInscForms";
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
    }
}