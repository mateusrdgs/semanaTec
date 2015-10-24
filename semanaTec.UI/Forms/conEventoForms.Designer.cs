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
            this.Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Local = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Data = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Hora = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Duracao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CodPales = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Vagas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eventoInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.eventoGV)).BeginInit();
            this.SuspendLayout();
            // 
            // eventoLbl
            // 
            this.eventoLbl.AutoSize = true;
            this.eventoLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eventoLbl.Location = new System.Drawing.Point(149, 59);
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
            this.eventoCB.Size = new System.Drawing.Size(289, 28);
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
            this.eventoGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nome,
            this.Local,
            this.Data,
            this.Hora,
            this.Tipo,
            this.Duracao,
            this.Descricao,
            this.CodPales,
            this.Vagas});
            this.eventoGV.Location = new System.Drawing.Point(6, 137);
            this.eventoGV.Name = "eventoGV";
            this.eventoGV.ReadOnly = true;
            this.eventoGV.Size = new System.Drawing.Size(666, 267);
            this.eventoGV.TabIndex = 2;
            // 
            // Nome
            // 
            this.Nome.DataPropertyName = "sNome";
            this.Nome.HeaderText = "Nome";
            this.Nome.Name = "Nome";
            this.Nome.ReadOnly = true;
            // 
            // Local
            // 
            this.Local.DataPropertyName = "sData";
            this.Local.HeaderText = "Local";
            this.Local.Name = "Local";
            this.Local.ReadOnly = true;
            // 
            // Data
            // 
            this.Data.DataPropertyName = "sData";
            this.Data.HeaderText = "Data";
            this.Data.Name = "Data";
            this.Data.ReadOnly = true;
            // 
            // Hora
            // 
            this.Hora.DataPropertyName = "sHora";
            this.Hora.HeaderText = "Hora";
            this.Hora.Name = "Hora";
            this.Hora.ReadOnly = true;
            // 
            // Tipo
            // 
            this.Tipo.DataPropertyName = "sTipo";
            this.Tipo.HeaderText = "Tipo";
            this.Tipo.Name = "Tipo";
            this.Tipo.ReadOnly = true;
            // 
            // Duracao
            // 
            this.Duracao.DataPropertyName = "nDuracao";
            this.Duracao.HeaderText = "Duracao";
            this.Duracao.Name = "Duracao";
            this.Duracao.ReadOnly = true;
            // 
            // Descricao
            // 
            this.Descricao.DataPropertyName = "sDescricao";
            this.Descricao.HeaderText = "Descricao";
            this.Descricao.Name = "Descricao";
            this.Descricao.ReadOnly = true;
            // 
            // CodPales
            // 
            this.CodPales.DataPropertyName = "nCodPales";
            this.CodPales.HeaderText = "CodPales";
            this.CodPales.Name = "CodPales";
            this.CodPales.ReadOnly = true;
            // 
            // Vagas
            // 
            this.Vagas.DataPropertyName = "Vagas";
            this.Vagas.HeaderText = "Vagas";
            this.Vagas.Name = "Vagas";
            this.Vagas.ReadOnly = true;
            // 
            // conEventoForms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(702, 428);
            this.Controls.Add(this.eventoInfo);
            this.Name = "conEventoForms";
            this.Text = "conEventoForms";
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
        private System.Windows.Forms.DataGridViewTextBoxColumn Nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn Local;
        private System.Windows.Forms.DataGridViewTextBoxColumn Data;
        private System.Windows.Forms.DataGridViewTextBoxColumn Hora;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Duracao;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descricao;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodPales;
        private System.Windows.Forms.DataGridViewTextBoxColumn Vagas;

    }
}