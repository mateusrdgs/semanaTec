namespace semanaTec.Forms
{
    partial class editPartForms
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
            this.limparBtn = new System.Windows.Forms.Button();
            this.salvarBtn = new System.Windows.Forms.Button();
            this.infoAcadGB = new System.Windows.Forms.GroupBox();
            this.loginGnrBtn = new System.Windows.Forms.Button();
            this.confSenhaTxt = new System.Windows.Forms.TextBox();
            this.confSenhaLbl = new System.Windows.Forms.Label();
            this.cursoLbl = new System.Windows.Forms.Label();
            this.cursoCB = new System.Windows.Forms.ComboBox();
            this.perfilCB = new System.Windows.Forms.ComboBox();
            this.perfilLbl = new System.Windows.Forms.Label();
            this.periodoLbl = new System.Windows.Forms.Label();
            this.senhaTxt = new System.Windows.Forms.TextBox();
            this.periodoTxt = new System.Windows.Forms.TextBox();
            this.loginTxt = new System.Windows.Forms.TextBox();
            this.senhaLbl = new System.Windows.Forms.Label();
            this.loginLbl = new System.Windows.Forms.Label();
            this.infoPesGB = new System.Windows.Forms.GroupBox();
            this.cpfLbl = new System.Windows.Forms.Label();
            this.cpfMsk = new System.Windows.Forms.MaskedTextBox();
            this.nomeTxt = new System.Windows.Forms.TextBox();
            this.nomeLbl = new System.Windows.Forms.Label();
            this.telTxt = new System.Windows.Forms.MaskedTextBox();
            this.emailTxt = new System.Windows.Forms.TextBox();
            this.emailLbl = new System.Windows.Forms.Label();
            this.telefoneLbl = new System.Windows.Forms.Label();
            this.buscarBtn = new System.Windows.Forms.Button();
            this.infoAcadGB.SuspendLayout();
            this.infoPesGB.SuspendLayout();
            this.SuspendLayout();
            // 
            // limparBtn
            // 
            this.limparBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.limparBtn.Location = new System.Drawing.Point(156, 370);
            this.limparBtn.Name = "limparBtn";
            this.limparBtn.Size = new System.Drawing.Size(75, 30);
            this.limparBtn.TabIndex = 15;
            this.limparBtn.Text = "Limpar";
            this.limparBtn.UseVisualStyleBackColor = true;
            this.limparBtn.Click += new System.EventHandler(this.limparBtn_Click);
            // 
            // salvarBtn
            // 
            this.salvarBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.salvarBtn.Location = new System.Drawing.Point(293, 370);
            this.salvarBtn.Name = "salvarBtn";
            this.salvarBtn.Size = new System.Drawing.Size(75, 30);
            this.salvarBtn.TabIndex = 14;
            this.salvarBtn.Text = "Salvar";
            this.salvarBtn.UseVisualStyleBackColor = true;
            this.salvarBtn.Click += new System.EventHandler(this.salvarBtn_Click);
            // 
            // infoAcadGB
            // 
            this.infoAcadGB.Controls.Add(this.loginGnrBtn);
            this.infoAcadGB.Controls.Add(this.confSenhaTxt);
            this.infoAcadGB.Controls.Add(this.confSenhaLbl);
            this.infoAcadGB.Controls.Add(this.cursoLbl);
            this.infoAcadGB.Controls.Add(this.cursoCB);
            this.infoAcadGB.Controls.Add(this.perfilCB);
            this.infoAcadGB.Controls.Add(this.perfilLbl);
            this.infoAcadGB.Controls.Add(this.periodoLbl);
            this.infoAcadGB.Controls.Add(this.senhaTxt);
            this.infoAcadGB.Controls.Add(this.periodoTxt);
            this.infoAcadGB.Controls.Add(this.loginTxt);
            this.infoAcadGB.Controls.Add(this.senhaLbl);
            this.infoAcadGB.Controls.Add(this.loginLbl);
            this.infoAcadGB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.infoAcadGB.Location = new System.Drawing.Point(15, 180);
            this.infoAcadGB.Name = "infoAcadGB";
            this.infoAcadGB.Size = new System.Drawing.Size(510, 168);
            this.infoAcadGB.TabIndex = 7;
            this.infoAcadGB.TabStop = false;
            this.infoAcadGB.Text = "Informações acadêmicas";
            // 
            // loginGnrBtn
            // 
            this.loginGnrBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginGnrBtn.Location = new System.Drawing.Point(296, 84);
            this.loginGnrBtn.Name = "loginGnrBtn";
            this.loginGnrBtn.Size = new System.Drawing.Size(70, 26);
            this.loginGnrBtn.TabIndex = 10;
            this.loginGnrBtn.Text = "Gerar login";
            this.loginGnrBtn.UseVisualStyleBackColor = true;
            // 
            // confSenhaTxt
            // 
            this.confSenhaTxt.Location = new System.Drawing.Point(331, 125);
            this.confSenhaTxt.Name = "confSenhaTxt";
            this.confSenhaTxt.Size = new System.Drawing.Size(170, 26);
            this.confSenhaTxt.TabIndex = 13;
            this.confSenhaTxt.Tag = "Digite a senha novamente";
            this.confSenhaTxt.UseSystemPasswordChar = true;
            // 
            // confSenhaLbl
            // 
            this.confSenhaLbl.AutoSize = true;
            this.confSenhaLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confSenhaLbl.Location = new System.Drawing.Point(242, 121);
            this.confSenhaLbl.Name = "confSenhaLbl";
            this.confSenhaLbl.Size = new System.Drawing.Size(86, 30);
            this.confSenhaLbl.TabIndex = 10;
            this.confSenhaLbl.Text = "Digite a senha\r\nnovamente";
            // 
            // cursoLbl
            // 
            this.cursoLbl.AutoSize = true;
            this.cursoLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cursoLbl.Location = new System.Drawing.Point(9, 31);
            this.cursoLbl.Name = "cursoLbl";
            this.cursoLbl.Size = new System.Drawing.Size(51, 20);
            this.cursoLbl.TabIndex = 2;
            this.cursoLbl.Text = "Curso";
            // 
            // cursoCB
            // 
            this.cursoCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cursoCB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cursoCB.FormattingEnabled = true;
            this.cursoCB.Items.AddRange(new object[] {
            "Administração de Empresas",
            "Agronomia",
            "Biomedicina",
            "Ciências Biológicas",
            "Ciências Biológicas - Bacharelado",
            "Ciências Contábeis",
            "Direito",
            "Educação Física",
            "Educação Física - Bacharelado",
            "Enfermagem",
            "Engenharia Ambiental",
            "Engenharia Civil",
            "Engenharia de Produção",
            "Estética e Cosmética",
            "Gestão Comercial",
            "História",
            "Jornalismo",
            "Letras",
            "Matemática",
            "Moda e Design",
            "Nutrição",
            "Pedagogia",
            "Publicidade e Propaganda",
            "Serviço Social",
            "Sistemas de Informação"});
            this.cursoCB.Location = new System.Drawing.Point(66, 28);
            this.cursoCB.Name = "cursoCB";
            this.cursoCB.Size = new System.Drawing.Size(270, 28);
            this.cursoCB.TabIndex = 8;
            this.cursoCB.Tag = "Curso";
            // 
            // perfilCB
            // 
            this.perfilCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.perfilCB.Enabled = false;
            this.perfilCB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.perfilCB.FormattingEnabled = true;
            this.perfilCB.ItemHeight = 20;
            this.perfilCB.Items.AddRange(new object[] {
            "Aluno",
            "Administrador"});
            this.perfilCB.Location = new System.Drawing.Point(372, 84);
            this.perfilCB.Name = "perfilCB";
            this.perfilCB.Size = new System.Drawing.Size(129, 28);
            this.perfilCB.TabIndex = 11;
            this.perfilCB.Tag = "Perfil";
            // 
            // perfilLbl
            // 
            this.perfilLbl.AutoSize = true;
            this.perfilLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.perfilLbl.Location = new System.Drawing.Point(421, 65);
            this.perfilLbl.Name = "perfilLbl";
            this.perfilLbl.Size = new System.Drawing.Size(38, 16);
            this.perfilLbl.TabIndex = 8;
            this.perfilLbl.Text = "Perfil";
            // 
            // periodoLbl
            // 
            this.periodoLbl.AutoSize = true;
            this.periodoLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.periodoLbl.Location = new System.Drawing.Point(355, 31);
            this.periodoLbl.Name = "periodoLbl";
            this.periodoLbl.Size = new System.Drawing.Size(63, 20);
            this.periodoLbl.TabIndex = 3;
            this.periodoLbl.Text = "Período";
            // 
            // senhaTxt
            // 
            this.senhaTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.senhaTxt.Location = new System.Drawing.Point(66, 125);
            this.senhaTxt.Name = "senhaTxt";
            this.senhaTxt.Size = new System.Drawing.Size(170, 26);
            this.senhaTxt.TabIndex = 12;
            this.senhaTxt.Tag = "Senha";
            this.senhaTxt.UseSystemPasswordChar = true;
            // 
            // periodoTxt
            // 
            this.periodoTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.periodoTxt.Location = new System.Drawing.Point(424, 28);
            this.periodoTxt.Name = "periodoTxt";
            this.periodoTxt.Size = new System.Drawing.Size(60, 26);
            this.periodoTxt.TabIndex = 9;
            this.periodoTxt.Tag = "Período";
            // 
            // loginTxt
            // 
            this.loginTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginTxt.Location = new System.Drawing.Point(66, 84);
            this.loginTxt.Name = "loginTxt";
            this.loginTxt.ReadOnly = true;
            this.loginTxt.Size = new System.Drawing.Size(220, 26);
            this.loginTxt.TabIndex = 0;
            this.loginTxt.TabStop = false;
            this.loginTxt.Tag = "Login";
            this.loginTxt.Text = " ";
            // 
            // senhaLbl
            // 
            this.senhaLbl.AutoSize = true;
            this.senhaLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.senhaLbl.Location = new System.Drawing.Point(9, 128);
            this.senhaLbl.Name = "senhaLbl";
            this.senhaLbl.Size = new System.Drawing.Size(56, 20);
            this.senhaLbl.TabIndex = 7;
            this.senhaLbl.Text = "Senha";
            // 
            // loginLbl
            // 
            this.loginLbl.AutoSize = true;
            this.loginLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginLbl.Location = new System.Drawing.Point(12, 87);
            this.loginLbl.Name = "loginLbl";
            this.loginLbl.Size = new System.Drawing.Size(48, 20);
            this.loginLbl.TabIndex = 6;
            this.loginLbl.Text = "Login";
            // 
            // infoPesGB
            // 
            this.infoPesGB.Controls.Add(this.buscarBtn);
            this.infoPesGB.Controls.Add(this.cpfLbl);
            this.infoPesGB.Controls.Add(this.cpfMsk);
            this.infoPesGB.Controls.Add(this.nomeTxt);
            this.infoPesGB.Controls.Add(this.nomeLbl);
            this.infoPesGB.Controls.Add(this.telTxt);
            this.infoPesGB.Controls.Add(this.emailTxt);
            this.infoPesGB.Controls.Add(this.emailLbl);
            this.infoPesGB.Controls.Add(this.telefoneLbl);
            this.infoPesGB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.infoPesGB.Location = new System.Drawing.Point(15, 10);
            this.infoPesGB.Name = "infoPesGB";
            this.infoPesGB.Size = new System.Drawing.Size(510, 164);
            this.infoPesGB.TabIndex = 1;
            this.infoPesGB.TabStop = false;
            this.infoPesGB.Text = "Informações pessoais";
            // 
            // cpfLbl
            // 
            this.cpfLbl.AutoSize = true;
            this.cpfLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cpfLbl.Location = new System.Drawing.Point(12, 31);
            this.cpfLbl.Name = "cpfLbl";
            this.cpfLbl.Size = new System.Drawing.Size(40, 20);
            this.cpfLbl.TabIndex = 0;
            this.cpfLbl.Text = "CPF";
            // 
            // cpfMsk
            // 
            this.cpfMsk.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cpfMsk.Location = new System.Drawing.Point(86, 28);
            this.cpfMsk.Mask = "000,000,000-00";
            this.cpfMsk.Name = "cpfMsk";
            this.cpfMsk.Size = new System.Drawing.Size(121, 26);
            this.cpfMsk.TabIndex = 2;
            this.cpfMsk.Tag = "CPF";
            this.cpfMsk.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // nomeTxt
            // 
            this.nomeTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nomeTxt.Location = new System.Drawing.Point(86, 76);
            this.nomeTxt.Name = "nomeTxt";
            this.nomeTxt.Size = new System.Drawing.Size(415, 26);
            this.nomeTxt.TabIndex = 4;
            this.nomeTxt.Tag = "Nome completo";
            // 
            // nomeLbl
            // 
            this.nomeLbl.AutoSize = true;
            this.nomeLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nomeLbl.Location = new System.Drawing.Point(9, 70);
            this.nomeLbl.Name = "nomeLbl";
            this.nomeLbl.Size = new System.Drawing.Size(74, 40);
            this.nomeLbl.TabIndex = 1;
            this.nomeLbl.Text = "Nome\r\ncompleto";
            // 
            // telTxt
            // 
            this.telTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.telTxt.Location = new System.Drawing.Point(83, 125);
            this.telTxt.Mask = "(00) 0000-0000";
            this.telTxt.Name = "telTxt";
            this.telTxt.Size = new System.Drawing.Size(121, 26);
            this.telTxt.TabIndex = 5;
            this.telTxt.Tag = "Telefone";
            this.telTxt.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // emailTxt
            // 
            this.emailTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailTxt.Location = new System.Drawing.Point(278, 122);
            this.emailTxt.Name = "emailTxt";
            this.emailTxt.Size = new System.Drawing.Size(220, 26);
            this.emailTxt.TabIndex = 6;
            this.emailTxt.Tag = "Email";
            // 
            // emailLbl
            // 
            this.emailLbl.AutoSize = true;
            this.emailLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailLbl.Location = new System.Drawing.Point(210, 128);
            this.emailLbl.Name = "emailLbl";
            this.emailLbl.Size = new System.Drawing.Size(53, 20);
            this.emailLbl.TabIndex = 5;
            this.emailLbl.Text = "E-mail";
            // 
            // telefoneLbl
            // 
            this.telefoneLbl.AutoSize = true;
            this.telefoneLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.telefoneLbl.Location = new System.Drawing.Point(9, 131);
            this.telefoneLbl.Name = "telefoneLbl";
            this.telefoneLbl.Size = new System.Drawing.Size(71, 20);
            this.telefoneLbl.TabIndex = 4;
            this.telefoneLbl.Text = "Telefone";
            // 
            // buscarBtn
            // 
            this.buscarBtn.Location = new System.Drawing.Point(225, 26);
            this.buscarBtn.Name = "buscarBtn";
            this.buscarBtn.Size = new System.Drawing.Size(75, 30);
            this.buscarBtn.TabIndex = 3;
            this.buscarBtn.Text = "Buscar";
            this.buscarBtn.UseVisualStyleBackColor = true;
            this.buscarBtn.Click += new System.EventHandler(this.buscarBtn_Click);
            // 
            // editPartForms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 412);
            this.Controls.Add(this.limparBtn);
            this.Controls.Add(this.salvarBtn);
            this.Controls.Add(this.infoAcadGB);
            this.Controls.Add(this.infoPesGB);
            this.Name = "editPartForms";
            this.Text = "editPartForms";
            this.Load += new System.EventHandler(this.editPartForms_Load);
            this.infoAcadGB.ResumeLayout(false);
            this.infoAcadGB.PerformLayout();
            this.infoPesGB.ResumeLayout(false);
            this.infoPesGB.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button limparBtn;
        private System.Windows.Forms.Button salvarBtn;
        private System.Windows.Forms.GroupBox infoAcadGB;
        private System.Windows.Forms.Button loginGnrBtn;
        private System.Windows.Forms.TextBox confSenhaTxt;
        private System.Windows.Forms.Label confSenhaLbl;
        private System.Windows.Forms.Label cursoLbl;
        private System.Windows.Forms.ComboBox cursoCB;
        private System.Windows.Forms.ComboBox perfilCB;
        private System.Windows.Forms.Label perfilLbl;
        private System.Windows.Forms.Label periodoLbl;
        private System.Windows.Forms.TextBox senhaTxt;
        private System.Windows.Forms.TextBox periodoTxt;
        private System.Windows.Forms.TextBox loginTxt;
        private System.Windows.Forms.Label senhaLbl;
        private System.Windows.Forms.Label loginLbl;
        private System.Windows.Forms.GroupBox infoPesGB;
        private System.Windows.Forms.Label cpfLbl;
        private System.Windows.Forms.MaskedTextBox cpfMsk;
        private System.Windows.Forms.TextBox nomeTxt;
        private System.Windows.Forms.Label nomeLbl;
        private System.Windows.Forms.MaskedTextBox telTxt;
        private System.Windows.Forms.TextBox emailTxt;
        private System.Windows.Forms.Label emailLbl;
        private System.Windows.Forms.Label telefoneLbl;
        private System.Windows.Forms.Button buscarBtn;
    }
}