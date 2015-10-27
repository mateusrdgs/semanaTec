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
            this.loginLbl = new System.Windows.Forms.Label();
            this.senhaLbl = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.newUserLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // loginTxt
            // 
            this.loginTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginTxt.Location = new System.Drawing.Point(213, 93);
            this.loginTxt.Name = "loginTxt";
            this.loginTxt.Size = new System.Drawing.Size(182, 26);
            this.loginTxt.TabIndex = 0;
            this.loginTxt.UseSystemPasswordChar = true;
            // 
            // senhaTxt
            // 
            this.senhaTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.senhaTxt.Location = new System.Drawing.Point(213, 138);
            this.senhaTxt.Name = "senhaTxt";
            this.senhaTxt.Size = new System.Drawing.Size(182, 26);
            this.senhaTxt.TabIndex = 1;
            this.senhaTxt.UseSystemPasswordChar = true;
            // 
            // loginLbl
            // 
            this.loginLbl.AutoSize = true;
            this.loginLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginLbl.Location = new System.Drawing.Point(125, 96);
            this.loginLbl.Name = "loginLbl";
            this.loginLbl.Size = new System.Drawing.Size(59, 20);
            this.loginLbl.TabIndex = 2;
            this.loginLbl.Text = "LOGIN";
            // 
            // senhaLbl
            // 
            this.senhaLbl.AutoSize = true;
            this.senhaLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.senhaLbl.Location = new System.Drawing.Point(125, 141);
            this.senhaLbl.Name = "senhaLbl";
            this.senhaLbl.Size = new System.Drawing.Size(65, 20);
            this.senhaLbl.TabIndex = 3;
            this.senhaLbl.Text = "SENHA";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(269, 180);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 30);
            this.button1.TabIndex = 4;
            this.button1.Text = "LOGAR";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // newUserLbl
            // 
            this.newUserLbl.AutoSize = true;
            this.newUserLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newUserLbl.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.newUserLbl.Location = new System.Drawing.Point(254, 227);
            this.newUserLbl.Name = "newUserLbl";
            this.newUserLbl.Size = new System.Drawing.Size(106, 15);
            this.newUserLbl.TabIndex = 5;
            this.newUserLbl.Text = "Criar novo usuário";
            this.newUserLbl.MouseLeave += new System.EventHandler(this.newUserLbl_MouseLeave);
            this.newUserLbl.MouseHover += new System.EventHandler(this.newUserLbl_MouseHover);
            // 
            // loginForms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(656, 294);
            this.Controls.Add(this.newUserLbl);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.senhaLbl);
            this.Controls.Add(this.loginLbl);
            this.Controls.Add(this.senhaTxt);
            this.Controls.Add(this.loginTxt);
            this.Name = "loginForms";
            this.Text = "loginForms";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox loginTxt;
        private System.Windows.Forms.TextBox senhaTxt;
        private System.Windows.Forms.Label loginLbl;
        private System.Windows.Forms.Label senhaLbl;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label newUserLbl;
    }
}