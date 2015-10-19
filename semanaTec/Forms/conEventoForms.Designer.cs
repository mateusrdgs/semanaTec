namespace semanaTec.Forms
{
    partial class conEventoForms
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
            this.eventoLbl = new System.Windows.Forms.Label();
            this.eventoCB = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.eventoGV = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.eventoGV)).BeginInit();
            this.SuspendLayout();
            // 
            // eventoLbl
            // 
            this.eventoLbl.AutoSize = true;
            this.eventoLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eventoLbl.Location = new System.Drawing.Point(149, 54);
            this.eventoLbl.Name = "eventoLbl";
            this.eventoLbl.Size = new System.Drawing.Size(59, 20);
            this.eventoLbl.TabIndex = 0;
            this.eventoLbl.Text = "Evento";
            // 
            // eventoCB
            // 
            this.eventoCB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.eventoCB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eventoCB.FormattingEnabled = true;
            this.eventoCB.Location = new System.Drawing.Point(214, 51);
            this.eventoCB.Name = "eventoCB";
            this.eventoCB.Size = new System.Drawing.Size(121, 28);
            this.eventoCB.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.eventoGV);
            this.groupBox1.Controls.Add(this.eventoCB);
            this.groupBox1.Controls.Add(this.eventoLbl);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(510, 388);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Informações do evento";
            // 
            // eventoGV
            // 
            this.eventoGV.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.eventoGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.eventoGV.Location = new System.Drawing.Point(6, 115);
            this.eventoGV.Name = "eventoGV";
            this.eventoGV.Size = new System.Drawing.Size(498, 267);
            this.eventoGV.TabIndex = 2;
            // 
            // conEventoForms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 412);
            this.Controls.Add(this.groupBox1);
            this.Name = "conEventoForms";
            this.Text = "conEventoForms";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.eventoGV)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label eventoLbl;
        private System.Windows.Forms.ComboBox eventoCB;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView eventoGV;

    }
}