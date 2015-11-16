namespace semanaTec.Forms
{
    partial class cadInscEvForms
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
            this.eventoCB = new System.Windows.Forms.ComboBox();
            this.cpfMsk = new System.Windows.Forms.MaskedTextBox();
            this.dataPck = new System.Windows.Forms.DateTimePicker();
            this.limparBtn = new System.Windows.Forms.Button();
            this.salvarBtn = new System.Windows.Forms.Button();
            this.inscricaoEvento = new System.Windows.Forms.GroupBox();
            this.inscricaoEvento.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Palestra";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(33, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "CPF";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(219, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Data";
            // 
            // eventoCB
            // 
            this.eventoCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.eventoCB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eventoCB.FormattingEnabled = true;
            this.eventoCB.Location = new System.Drawing.Point(73, 43);
            this.eventoCB.Name = "eventoCB";
            this.eventoCB.Size = new System.Drawing.Size(424, 28);
            this.eventoCB.TabIndex = 1;
            this.eventoCB.Tag = "Palestra";
            // 
            // cpfMsk
            // 
            this.cpfMsk.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cpfMsk.Location = new System.Drawing.Point(73, 82);
            this.cpfMsk.Mask = "000,000,000-00";
            this.cpfMsk.Name = "cpfMsk";
            this.cpfMsk.Size = new System.Drawing.Size(121, 26);
            this.cpfMsk.TabIndex = 2;
            this.cpfMsk.Tag = "CPF";
            this.cpfMsk.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // dataPck
            // 
            this.dataPck.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataPck.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dataPck.Location = new System.Drawing.Point(269, 80);
            this.dataPck.Name = "dataPck";
            this.dataPck.Size = new System.Drawing.Size(100, 26);
            this.dataPck.TabIndex = 3;
            this.dataPck.Tag = "Data";
            // 
            // limparBtn
            // 
            this.limparBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.limparBtn.Location = new System.Drawing.Point(158, 199);
            this.limparBtn.Name = "limparBtn";
            this.limparBtn.Size = new System.Drawing.Size(75, 30);
            this.limparBtn.TabIndex = 5;
            this.limparBtn.Text = "Limpar";
            this.limparBtn.UseVisualStyleBackColor = true;
            this.limparBtn.Click += new System.EventHandler(this.limparBtn_Click);
            // 
            // salvarBtn
            // 
            this.salvarBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.salvarBtn.Location = new System.Drawing.Point(285, 199);
            this.salvarBtn.Name = "salvarBtn";
            this.salvarBtn.Size = new System.Drawing.Size(75, 30);
            this.salvarBtn.TabIndex = 4;
            this.salvarBtn.Text = "Salvar";
            this.salvarBtn.UseVisualStyleBackColor = true;
            this.salvarBtn.Click += new System.EventHandler(this.salvarBtn_Click);
            // 
            // inscricaoEvento
            // 
            this.inscricaoEvento.Controls.Add(this.label1);
            this.inscricaoEvento.Controls.Add(this.eventoCB);
            this.inscricaoEvento.Controls.Add(this.cpfMsk);
            this.inscricaoEvento.Controls.Add(this.dataPck);
            this.inscricaoEvento.Controls.Add(this.label2);
            this.inscricaoEvento.Controls.Add(this.label3);
            this.inscricaoEvento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inscricaoEvento.Location = new System.Drawing.Point(12, 12);
            this.inscricaoEvento.Name = "inscricaoEvento";
            this.inscricaoEvento.Size = new System.Drawing.Size(503, 161);
            this.inscricaoEvento.TabIndex = 8;
            this.inscricaoEvento.TabStop = false;
            this.inscricaoEvento.Text = "Inscrição de evento";
            // 
            // cadInscEvForms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(527, 241);
            this.Controls.Add(this.inscricaoEvento);
            this.Controls.Add(this.salvarBtn);
            this.Controls.Add(this.limparBtn);
            this.Name = "cadInscEvForms";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inscrição em evento";
            this.Load += new System.EventHandler(this.cadInscForms_Load);
            this.inscricaoEvento.ResumeLayout(false);
            this.inscricaoEvento.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox eventoCB;
        private System.Windows.Forms.MaskedTextBox cpfMsk;
        private System.Windows.Forms.DateTimePicker dataPck;
        private System.Windows.Forms.Button limparBtn;
        private System.Windows.Forms.Button salvarBtn;
        private System.Windows.Forms.GroupBox inscricaoEvento;
    }
}