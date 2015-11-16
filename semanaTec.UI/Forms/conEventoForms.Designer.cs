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
            this.eventoInfo = new System.Windows.Forms.GroupBox();
            this.eventoGV = new System.Windows.Forms.DataGridView();
            this.eventoInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.eventoGV)).BeginInit();
            this.SuspendLayout();
            // 
            // eventoLbl
            // 
            this.eventoLbl.AutoSize = true;
            this.eventoLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eventoLbl.Location = new System.Drawing.Point(45, 41);
            this.eventoLbl.Name = "eventoLbl";
            this.eventoLbl.Size = new System.Drawing.Size(59, 20);
            this.eventoLbl.TabIndex = 0;
            this.eventoLbl.Text = "Evento";
            // 
            // eventoCB
            // 
            this.eventoCB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.eventoCB.DisplayMember = "sNome";
            this.eventoCB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eventoCB.FormattingEnabled = true;
            this.eventoCB.Location = new System.Drawing.Point(110, 38);
            this.eventoCB.Name = "eventoCB";
            this.eventoCB.Size = new System.Drawing.Size(524, 28);
            this.eventoCB.TabIndex = 1;
            this.eventoCB.ValueMember = "sNome";
            this.eventoCB.SelectedIndexChanged += new System.EventHandler(this.eventoCB_SelectedIndexChanged);
            // 
            // eventoInfo
            // 
            this.eventoInfo.Controls.Add(this.eventoGV);
            this.eventoInfo.Controls.Add(this.eventoCB);
            this.eventoInfo.Controls.Add(this.eventoLbl);
            this.eventoInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eventoInfo.Location = new System.Drawing.Point(12, 12);
            this.eventoInfo.Name = "eventoInfo";
            this.eventoInfo.Size = new System.Drawing.Size(678, 416);
            this.eventoInfo.TabIndex = 2;
            this.eventoInfo.TabStop = false;
            this.eventoInfo.Text = "Informações do evento";
            // 
            // eventoGV
            // 
            this.eventoGV.AllowUserToAddRows = false;
            this.eventoGV.AllowUserToDeleteRows = false;
            this.eventoGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.eventoGV.Location = new System.Drawing.Point(6, 85);
            this.eventoGV.Name = "eventoGV";
            this.eventoGV.ReadOnly = true;
            this.eventoGV.Size = new System.Drawing.Size(666, 319);
            this.eventoGV.TabIndex = 2;
            // 
            // conEventoForms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(702, 428);
            this.Controls.Add(this.eventoInfo);
            this.Name = "conEventoForms";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Consulta de eventos";
            this.Load += new System.EventHandler(this.conEventoForms_Load);
            this.eventoInfo.ResumeLayout(false);
            this.eventoInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.eventoGV)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label eventoLbl;
        private System.Windows.Forms.ComboBox eventoCB;
        private System.Windows.Forms.GroupBox eventoInfo;
        private System.Windows.Forms.DataGridView eventoGV;

    }
}