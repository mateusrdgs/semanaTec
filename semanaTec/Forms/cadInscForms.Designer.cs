﻿namespace semanaTec.Forms
{
    partial class cadInscForms
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
            this.palestraCB = new System.Windows.Forms.ComboBox();
            this.cpfMsk = new System.Windows.Forms.MaskedTextBox();
            this.dataPck = new System.Windows.Forms.DateTimePicker();
            this.limparBtn = new System.Windows.Forms.Button();
            this.salvarBtn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Palestra";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "CPF";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Data";
            // 
            // palestraCB
            // 
            this.palestraCB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.palestraCB.FormattingEnabled = true;
            this.palestraCB.Location = new System.Drawing.Point(79, 21);
            this.palestraCB.Name = "palestraCB";
            this.palestraCB.Size = new System.Drawing.Size(187, 28);
            this.palestraCB.TabIndex = 3;
            // 
            // cpfMsk
            // 
            this.cpfMsk.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cpfMsk.Location = new System.Drawing.Point(79, 67);
            this.cpfMsk.Mask = "000,000,000-00";
            this.cpfMsk.Name = "cpfMsk";
            this.cpfMsk.Size = new System.Drawing.Size(121, 26);
            this.cpfMsk.TabIndex = 4;
            // 
            // dataPck
            // 
            this.dataPck.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataPck.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dataPck.Location = new System.Drawing.Point(79, 111);
            this.dataPck.Name = "dataPck";
            this.dataPck.Size = new System.Drawing.Size(100, 26);
            this.dataPck.TabIndex = 5;
            // 
            // limparBtn
            // 
            this.limparBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.limparBtn.Location = new System.Drawing.Point(137, 199);
            this.limparBtn.Name = "limparBtn";
            this.limparBtn.Size = new System.Drawing.Size(75, 30);
            this.limparBtn.TabIndex = 6;
            this.limparBtn.Text = "Limpar";
            this.limparBtn.UseVisualStyleBackColor = true;
            // 
            // salvarBtn
            // 
            this.salvarBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.salvarBtn.Location = new System.Drawing.Point(300, 199);
            this.salvarBtn.Name = "salvarBtn";
            this.salvarBtn.Size = new System.Drawing.Size(75, 30);
            this.salvarBtn.TabIndex = 7;
            this.salvarBtn.Text = "Salvar";
            this.salvarBtn.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.palestraCB);
            this.groupBox1.Controls.Add(this.cpfMsk);
            this.groupBox1.Controls.Add(this.dataPck);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(510, 161);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Inscrição de evento";
            // 
            // cadInscForms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(527, 241);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.salvarBtn);
            this.Controls.Add(this.limparBtn);
            this.Name = "cadInscForms";
            this.Text = "cadInscForms";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox palestraCB;
        private System.Windows.Forms.MaskedTextBox cpfMsk;
        private System.Windows.Forms.DateTimePicker dataPck;
        private System.Windows.Forms.Button limparBtn;
        private System.Windows.Forms.Button salvarBtn;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}