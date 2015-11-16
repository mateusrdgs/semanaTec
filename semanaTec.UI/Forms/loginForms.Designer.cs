namespace semanaTec.Forms
{
    partial class loginForms
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
            this.loginTxt = new System.Windows.Forms.TextBox();
            this.senhaTxt = new System.Windows.Forms.TextBox();
            this.loginButton = new System.Windows.Forms.Button();
            this.newUserLbl = new System.Windows.Forms.Label();
            this.loginLbl = new System.Windows.Forms.Label();
            this.senhaLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // loginTxt
            // 
            this.loginTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginTxt.Location = new System.Drawing.Point(216, 92);
            this.loginTxt.Name = "loginTxt";
            this.loginTxt.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.loginTxt.Size = new System.Drawing.Size(182, 26);
            this.loginTxt.TabIndex = 0;
            this.loginTxt.Tag = "Login";
            // 
            // senhaTxt
            // 
            this.senhaTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.senhaTxt.Location = new System.Drawing.Point(216, 162);
            this.senhaTxt.Name = "senhaTxt";
            this.senhaTxt.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.senhaTxt.Size = new System.Drawing.Size(182, 26);
            this.senhaTxt.TabIndex = 1;
            this.senhaTxt.Tag = "Senha";
            this.senhaTxt.UseSystemPasswordChar = true;
            // 
            // loginButton
            // 
            this.loginButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginButton.Location = new System.Drawing.Point(272, 204);
            this.loginButton.Name = "loginButton";
            this.loginButton.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.loginButton.Size = new System.Drawing.Size(75, 30);
            this.loginButton.TabIndex = 4;
            this.loginButton.Tag = "Logar";
            this.loginButton.Text = "LOGAR";
            this.loginButton.UseVisualStyleBackColor = true;
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // newUserLbl
            // 
            this.newUserLbl.AutoSize = true;
            this.newUserLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newUserLbl.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.newUserLbl.Location = new System.Drawing.Point(257, 251);
            this.newUserLbl.Name = "newUserLbl";
            this.newUserLbl.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.newUserLbl.Size = new System.Drawing.Size(106, 15);
            this.newUserLbl.TabIndex = 5;
            this.newUserLbl.Tag = "Criar novo usuário";
            this.newUserLbl.Text = "Criar novo usuário";
            this.newUserLbl.Click += new System.EventHandler(this.newUserLbl_Click);
            this.newUserLbl.MouseLeave += new System.EventHandler(this.newUserLbl_MouseLeave);
            this.newUserLbl.MouseHover += new System.EventHandler(this.newUserLbl_MouseHover);
            // 
            // loginLbl
            // 
            this.loginLbl.AutoSize = true;
            this.loginLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginLbl.Location = new System.Drawing.Point(284, 73);
            this.loginLbl.Name = "loginLbl";
            this.loginLbl.Size = new System.Drawing.Size(41, 16);
            this.loginLbl.TabIndex = 6;
            this.loginLbl.Tag = "Entrar";
            this.loginLbl.Text = "Login";
            // 
            // senhaLbl
            // 
            this.senhaLbl.AutoSize = true;
            this.senhaLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.senhaLbl.Location = new System.Drawing.Point(284, 143);
            this.senhaLbl.Name = "senhaLbl";
            this.senhaLbl.Size = new System.Drawing.Size(47, 16);
            this.senhaLbl.TabIndex = 7;
            this.senhaLbl.Text = "Senha";
            // 
            // loginForms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(656, 294);
            this.Controls.Add(this.senhaLbl);
            this.Controls.Add(this.loginLbl);
            this.Controls.Add(this.newUserLbl);
            this.Controls.Add(this.loginButton);
            this.Controls.Add(this.senhaTxt);
            this.Controls.Add(this.loginTxt);
            this.Name = "loginForms";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox loginTxt;
        private System.Windows.Forms.TextBox senhaTxt;
        private System.Windows.Forms.Button loginButton;
        private System.Windows.Forms.Label newUserLbl;
        private System.Windows.Forms.Label loginLbl;
        private System.Windows.Forms.Label senhaLbl;
    }
}