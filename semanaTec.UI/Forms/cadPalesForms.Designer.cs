namespace semanaTec.Forms
{
    partial class cadPalesForms
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
            this.nomeLbl = new System.Windows.Forms.Label();
            this.titulacaoLbl = new System.Windows.Forms.Label();
            this.miniCLbl = new System.Windows.Forms.Label();
            this.cidadeLbl = new System.Windows.Forms.Label();
            this.telefoneLbl = new System.Windows.Forms.Label();
            this.emailLbl = new System.Windows.Forms.Label();
            this.nomeTxt = new System.Windows.Forms.TextBox();
            this.miniCTxt = new System.Windows.Forms.TextBox();
            this.cidadeTxt = new System.Windows.Forms.TextBox();
            this.emailTxt = new System.Windows.Forms.TextBox();
            this.telMsk = new System.Windows.Forms.MaskedTextBox();
            this.titulacaoCB = new System.Windows.Forms.ComboBox();
            this.salvarBtn = new System.Windows.Forms.Button();
            this.limparBtn = new System.Windows.Forms.Button();
            this.infoPalest = new System.Windows.Forms.GroupBox();
            this.infoPalest.SuspendLayout();
            this.SuspendLayout();
            // 
            // nomeLbl
            // 
            this.nomeLbl.AutoSize = true;
            this.nomeLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nomeLbl.Location = new System.Drawing.Point(9, 41);
            this.nomeLbl.Name = "nomeLbl";
            this.nomeLbl.Size = new System.Drawing.Size(51, 20);
            this.nomeLbl.TabIndex = 0;
            this.nomeLbl.Text = "Nome";
            // 
            // titulacaoLbl
            // 
            this.titulacaoLbl.AutoSize = true;
            this.titulacaoLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titulacaoLbl.Location = new System.Drawing.Point(9, 77);
            this.titulacaoLbl.Name = "titulacaoLbl";
            this.titulacaoLbl.Size = new System.Drawing.Size(73, 20);
            this.titulacaoLbl.TabIndex = 1;
            this.titulacaoLbl.Text = "Titulação";
            // 
            // miniCLbl
            // 
            this.miniCLbl.AutoSize = true;
            this.miniCLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.miniCLbl.Location = new System.Drawing.Point(6, 169);
            this.miniCLbl.Name = "miniCLbl";
            this.miniCLbl.Size = new System.Drawing.Size(84, 40);
            this.miniCLbl.TabIndex = 2;
            this.miniCLbl.Text = "Mini\r\nCurriculum\r\n";
            this.miniCLbl.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // cidadeLbl
            // 
            this.cidadeLbl.AutoSize = true;
            this.cidadeLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cidadeLbl.Location = new System.Drawing.Point(218, 77);
            this.cidadeLbl.Name = "cidadeLbl";
            this.cidadeLbl.Size = new System.Drawing.Size(59, 20);
            this.cidadeLbl.TabIndex = 3;
            this.cidadeLbl.Text = "Cidade";
            // 
            // telefoneLbl
            // 
            this.telefoneLbl.AutoSize = true;
            this.telefoneLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.telefoneLbl.Location = new System.Drawing.Point(293, 120);
            this.telefoneLbl.Name = "telefoneLbl";
            this.telefoneLbl.Size = new System.Drawing.Size(71, 20);
            this.telefoneLbl.TabIndex = 4;
            this.telefoneLbl.Text = "Telefone";
            // 
            // emailLbl
            // 
            this.emailLbl.AutoSize = true;
            this.emailLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailLbl.Location = new System.Drawing.Point(9, 120);
            this.emailLbl.Name = "emailLbl";
            this.emailLbl.Size = new System.Drawing.Size(48, 20);
            this.emailLbl.TabIndex = 5;
            this.emailLbl.Text = "Email";
            // 
            // nomeTxt
            // 
            this.nomeTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nomeTxt.Location = new System.Drawing.Point(66, 38);
            this.nomeTxt.Name = "nomeTxt";
            this.nomeTxt.Size = new System.Drawing.Size(433, 26);
            this.nomeTxt.TabIndex = 1;
            this.nomeTxt.Tag = "Nome";
            // 
            // miniCTxt
            // 
            this.miniCTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.miniCTxt.Location = new System.Drawing.Point(88, 158);
            this.miniCTxt.Multiline = true;
            this.miniCTxt.Name = "miniCTxt";
            this.miniCTxt.Size = new System.Drawing.Size(411, 178);
            this.miniCTxt.TabIndex = 6;
            this.miniCTxt.Tag = "Mini curriculum";
            // 
            // cidadeTxt
            // 
            this.cidadeTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cidadeTxt.Location = new System.Drawing.Point(283, 74);
            this.cidadeTxt.Name = "cidadeTxt";
            this.cidadeTxt.Size = new System.Drawing.Size(216, 26);
            this.cidadeTxt.TabIndex = 3;
            this.cidadeTxt.Tag = "Cidade";
            // 
            // emailTxt
            // 
            this.emailTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailTxt.Location = new System.Drawing.Point(88, 117);
            this.emailTxt.Name = "emailTxt";
            this.emailTxt.Size = new System.Drawing.Size(189, 26);
            this.emailTxt.TabIndex = 4;
            this.emailTxt.Tag = "Email";
            // 
            // telMsk
            // 
            this.telMsk.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.telMsk.Location = new System.Drawing.Point(383, 117);
            this.telMsk.Mask = "(00) 0000-0000";
            this.telMsk.Name = "telMsk";
            this.telMsk.Size = new System.Drawing.Size(116, 26);
            this.telMsk.TabIndex = 5;
            this.telMsk.Tag = "Telefone";
            // 
            // titulacaoCB
            // 
            this.titulacaoCB.FormattingEnabled = true;
            this.titulacaoCB.Items.AddRange(new object[] {
            "Graduando",
            "Graduado",
            "Especialista",
            "Mestre",
            "Doutor",
            "Livre-docente"});
            this.titulacaoCB.Location = new System.Drawing.Point(88, 74);
            this.titulacaoCB.Name = "titulacaoCB";
            this.titulacaoCB.Size = new System.Drawing.Size(124, 28);
            this.titulacaoCB.TabIndex = 2;
            this.titulacaoCB.Tag = "Titulação";
            // 
            // salvarBtn
            // 
            this.salvarBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.salvarBtn.Location = new System.Drawing.Point(100, 370);
            this.salvarBtn.Name = "salvarBtn";
            this.salvarBtn.Size = new System.Drawing.Size(75, 30);
            this.salvarBtn.TabIndex = 8;
            this.salvarBtn.Text = "Salvar";
            this.salvarBtn.UseVisualStyleBackColor = true;
            this.salvarBtn.Click += new System.EventHandler(this.salvarBtn_Click);
            // 
            // limparBtn
            // 
            this.limparBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.limparBtn.Location = new System.Drawing.Point(358, 370);
            this.limparBtn.Name = "limparBtn";
            this.limparBtn.Size = new System.Drawing.Size(75, 30);
            this.limparBtn.TabIndex = 7;
            this.limparBtn.Text = "Limpar";
            this.limparBtn.UseVisualStyleBackColor = true;
            // 
            // infoPalest
            // 
            this.infoPalest.Controls.Add(this.nomeLbl);
            this.infoPalest.Controls.Add(this.nomeTxt);
            this.infoPalest.Controls.Add(this.titulacaoLbl);
            this.infoPalest.Controls.Add(this.miniCTxt);
            this.infoPalest.Controls.Add(this.emailTxt);
            this.infoPalest.Controls.Add(this.miniCLbl);
            this.infoPalest.Controls.Add(this.emailLbl);
            this.infoPalest.Controls.Add(this.telMsk);
            this.infoPalest.Controls.Add(this.titulacaoCB);
            this.infoPalest.Controls.Add(this.cidadeLbl);
            this.infoPalest.Controls.Add(this.cidadeTxt);
            this.infoPalest.Controls.Add(this.telefoneLbl);
            this.infoPalest.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.infoPalest.Location = new System.Drawing.Point(12, 12);
            this.infoPalest.Name = "infoPalest";
            this.infoPalest.Size = new System.Drawing.Size(510, 342);
            this.infoPalest.TabIndex = 14;
            this.infoPalest.TabStop = false;
            this.infoPalest.Text = "Informações do palestrante";
            // 
            // cadPalesForms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 412);
            this.Controls.Add(this.infoPalest);
            this.Controls.Add(this.limparBtn);
            this.Controls.Add(this.salvarBtn);
            this.Name = "cadPalesForms";
            this.Text = "cadPalesForms";
            this.infoPalest.ResumeLayout(false);
            this.infoPalest.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label nomeLbl;
        private System.Windows.Forms.Label titulacaoLbl;
        private System.Windows.Forms.Label miniCLbl;
        private System.Windows.Forms.Label cidadeLbl;
        private System.Windows.Forms.Label telefoneLbl;
        private System.Windows.Forms.Label emailLbl;
        private System.Windows.Forms.TextBox nomeTxt;
        private System.Windows.Forms.TextBox miniCTxt;
        private System.Windows.Forms.TextBox cidadeTxt;
        private System.Windows.Forms.TextBox emailTxt;
        private System.Windows.Forms.MaskedTextBox telMsk;
        private System.Windows.Forms.ComboBox titulacaoCB;
        private System.Windows.Forms.Button salvarBtn;
        private System.Windows.Forms.Button limparBtn;
        private System.Windows.Forms.GroupBox infoPalest;
    }
}