namespace semanaTec.Forms
{
    partial class cadInscSemForms
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
            this.cpfMsk = new System.Windows.Forms.MaskedTextBox();
            this.dataPck = new System.Windows.Forms.DateTimePicker();
            this.cpfLbl = new System.Windows.Forms.Label();
            this.dataLbl = new System.Windows.Forms.Label();
            this.salvarBtn = new System.Windows.Forms.Button();
            this.limparBtn = new System.Windows.Forms.Button();
            this.seminfoGB = new System.Windows.Forms.GroupBox();
            this.seminfoGB.SuspendLayout();
            this.SuspendLayout();
            // 
            // cpfMsk
            // 
            this.cpfMsk.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cpfMsk.Location = new System.Drawing.Point(185, 80);
            this.cpfMsk.Mask = "000,000,000-00";
            this.cpfMsk.Name = "cpfMsk";
            this.cpfMsk.Size = new System.Drawing.Size(119, 26);
            this.cpfMsk.TabIndex = 1;
            this.cpfMsk.Tag = "CPF";
            this.cpfMsk.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // dataPck
            // 
            this.dataPck.CustomFormat = "dd/MM/aaaa";
            this.dataPck.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataPck.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dataPck.Location = new System.Drawing.Point(185, 121);
            this.dataPck.Name = "dataPck";
            this.dataPck.ShowUpDown = true;
            this.dataPck.Size = new System.Drawing.Size(105, 26);
            this.dataPck.TabIndex = 2;
            this.dataPck.Tag = "Data";
            this.dataPck.Value = new System.DateTime(2015, 11, 2, 0, 0, 0, 0);
            // 
            // cpfLbl
            // 
            this.cpfLbl.AutoSize = true;
            this.cpfLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cpfLbl.Location = new System.Drawing.Point(121, 83);
            this.cpfLbl.Name = "cpfLbl";
            this.cpfLbl.Size = new System.Drawing.Size(40, 20);
            this.cpfLbl.TabIndex = 2;
            this.cpfLbl.Text = "CPF";
            // 
            // dataLbl
            // 
            this.dataLbl.AutoSize = true;
            this.dataLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataLbl.Location = new System.Drawing.Point(121, 126);
            this.dataLbl.Name = "dataLbl";
            this.dataLbl.Size = new System.Drawing.Size(44, 20);
            this.dataLbl.TabIndex = 3;
            this.dataLbl.Text = "Data";
            // 
            // salvarBtn
            // 
            this.salvarBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.salvarBtn.Location = new System.Drawing.Point(241, 253);
            this.salvarBtn.Name = "salvarBtn";
            this.salvarBtn.Size = new System.Drawing.Size(75, 30);
            this.salvarBtn.TabIndex = 3;
            this.salvarBtn.Text = "Salvar";
            this.salvarBtn.UseVisualStyleBackColor = true;
            this.salvarBtn.Click += new System.EventHandler(this.salvarBtn_Click);
            // 
            // limparBtn
            // 
            this.limparBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.limparBtn.Location = new System.Drawing.Point(137, 253);
            this.limparBtn.Name = "limparBtn";
            this.limparBtn.Size = new System.Drawing.Size(75, 30);
            this.limparBtn.TabIndex = 4;
            this.limparBtn.Text = "Limpar";
            this.limparBtn.UseVisualStyleBackColor = true;
            this.limparBtn.Click += new System.EventHandler(this.limparBtn_Click);
            // 
            // seminfoGB
            // 
            this.seminfoGB.Controls.Add(this.cpfMsk);
            this.seminfoGB.Controls.Add(this.cpfLbl);
            this.seminfoGB.Controls.Add(this.dataPck);
            this.seminfoGB.Controls.Add(this.dataLbl);
            this.seminfoGB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.seminfoGB.Location = new System.Drawing.Point(12, 12);
            this.seminfoGB.Name = "seminfoGB";
            this.seminfoGB.Size = new System.Drawing.Size(434, 225);
            this.seminfoGB.TabIndex = 6;
            this.seminfoGB.TabStop = false;
            this.seminfoGB.Text = "Inscrição - Seminfo";
            // 
            // cadInscSemForms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(458, 295);
            this.Controls.Add(this.seminfoGB);
            this.Controls.Add(this.limparBtn);
            this.Controls.Add(this.salvarBtn);
            this.Name = "cadInscSemForms";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inscrição na Semana da Informática";
            this.Load += new System.EventHandler(this.cadInscSemForms_Load);
            this.seminfoGB.ResumeLayout(false);
            this.seminfoGB.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox cpfMsk;
        private System.Windows.Forms.DateTimePicker dataPck;
        private System.Windows.Forms.Label cpfLbl;
        private System.Windows.Forms.Label dataLbl;
        private System.Windows.Forms.Button salvarBtn;
        private System.Windows.Forms.Button limparBtn;
        private System.Windows.Forms.GroupBox seminfoGB;
    }
}