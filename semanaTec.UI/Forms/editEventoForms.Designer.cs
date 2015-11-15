namespace semanaTec.Forms
{
    partial class editEventoForms
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
            this.salvarBtn = new System.Windows.Forms.Button();
            this.limparBtn = new System.Windows.Forms.Button();
            this.eventoInfo = new System.Windows.Forms.GroupBox();
            this.nomeLbl = new System.Windows.Forms.Label();
            this.descricaoTxt = new System.Windows.Forms.TextBox();
            this.horaPck = new System.Windows.Forms.DateTimePicker();
            this.descricaoLbl = new System.Windows.Forms.Label();
            this.vagasTxt = new System.Windows.Forms.TextBox();
            this.minicursoRB = new System.Windows.Forms.RadioButton();
            this.codPTxt = new System.Windows.Forms.TextBox();
            this.nomeTxt = new System.Windows.Forms.TextBox();
            this.vagasLbl = new System.Windows.Forms.Label();
            this.duracaoTxt = new System.Windows.Forms.TextBox();
            this.codPLbl = new System.Windows.Forms.Label();
            this.palestraRB = new System.Windows.Forms.RadioButton();
            this.dataPck = new System.Windows.Forms.DateTimePicker();
            this.dataLbl = new System.Windows.Forms.Label();
            this.horaLbl = new System.Windows.Forms.Label();
            this.duracaoLbl = new System.Windows.Forms.Label();
            this.localLbl = new System.Windows.Forms.Label();
            this.localTxt = new System.Windows.Forms.TextBox();
            this.tipoLbl = new System.Windows.Forms.Label();
            this.eventoLbl = new System.Windows.Forms.Label();
            this.eventoCB = new System.Windows.Forms.ComboBox();
            this.eventoInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // salvarBtn
            // 
            this.salvarBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.salvarBtn.Location = new System.Drawing.Point(289, 420);
            this.salvarBtn.Name = "salvarBtn";
            this.salvarBtn.Size = new System.Drawing.Size(75, 30);
            this.salvarBtn.TabIndex = 20;
            this.salvarBtn.Text = "Salvar";
            this.salvarBtn.UseVisualStyleBackColor = true;
            this.salvarBtn.Click += new System.EventHandler(this.salvarBtn_Click);
            // 
            // limparBtn
            // 
            this.limparBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.limparBtn.Location = new System.Drawing.Point(143, 420);
            this.limparBtn.Name = "limparBtn";
            this.limparBtn.Size = new System.Drawing.Size(75, 30);
            this.limparBtn.TabIndex = 21;
            this.limparBtn.Text = "Limpar";
            this.limparBtn.UseVisualStyleBackColor = true;
            // 
            // eventoInfo
            // 
            this.eventoInfo.Controls.Add(this.nomeLbl);
            this.eventoInfo.Controls.Add(this.descricaoTxt);
            this.eventoInfo.Controls.Add(this.horaPck);
            this.eventoInfo.Controls.Add(this.descricaoLbl);
            this.eventoInfo.Controls.Add(this.vagasTxt);
            this.eventoInfo.Controls.Add(this.minicursoRB);
            this.eventoInfo.Controls.Add(this.codPTxt);
            this.eventoInfo.Controls.Add(this.nomeTxt);
            this.eventoInfo.Controls.Add(this.vagasLbl);
            this.eventoInfo.Controls.Add(this.duracaoTxt);
            this.eventoInfo.Controls.Add(this.codPLbl);
            this.eventoInfo.Controls.Add(this.palestraRB);
            this.eventoInfo.Controls.Add(this.dataPck);
            this.eventoInfo.Controls.Add(this.dataLbl);
            this.eventoInfo.Controls.Add(this.horaLbl);
            this.eventoInfo.Controls.Add(this.duracaoLbl);
            this.eventoInfo.Controls.Add(this.localLbl);
            this.eventoInfo.Controls.Add(this.localTxt);
            this.eventoInfo.Controls.Add(this.tipoLbl);
            this.eventoInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eventoInfo.Location = new System.Drawing.Point(12, 55);
            this.eventoInfo.Name = "eventoInfo";
            this.eventoInfo.Size = new System.Drawing.Size(510, 359);
            this.eventoInfo.TabIndex = 22;
            this.eventoInfo.TabStop = false;
            this.eventoInfo.Text = "Informações do evento";
            // 
            // nomeLbl
            // 
            this.nomeLbl.AutoSize = true;
            this.nomeLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nomeLbl.Location = new System.Drawing.Point(5, 38);
            this.nomeLbl.Name = "nomeLbl";
            this.nomeLbl.Size = new System.Drawing.Size(51, 20);
            this.nomeLbl.TabIndex = 0;
            this.nomeLbl.Text = "Nome";
            // 
            // descricaoTxt
            // 
            this.descricaoTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descricaoTxt.Location = new System.Drawing.Point(9, 227);
            this.descricaoTxt.Multiline = true;
            this.descricaoTxt.Name = "descricaoTxt";
            this.descricaoTxt.Size = new System.Drawing.Size(490, 126);
            this.descricaoTxt.TabIndex = 10;
            this.descricaoTxt.Tag = "Descrição";
            // 
            // horaPck
            // 
            this.horaPck.CustomFormat = "hh:mm";
            this.horaPck.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.horaPck.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.horaPck.Location = new System.Drawing.Point(62, 108);
            this.horaPck.Name = "horaPck";
            this.horaPck.ShowUpDown = true;
            this.horaPck.Size = new System.Drawing.Size(150, 26);
            this.horaPck.TabIndex = 4;
            this.horaPck.Value = new System.DateTime(2015, 10, 17, 16, 3, 0, 0);
            // 
            // descricaoLbl
            // 
            this.descricaoLbl.AutoSize = true;
            this.descricaoLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descricaoLbl.Location = new System.Drawing.Point(5, 204);
            this.descricaoLbl.Name = "descricaoLbl";
            this.descricaoLbl.Size = new System.Drawing.Size(80, 20);
            this.descricaoLbl.TabIndex = 6;
            this.descricaoLbl.Text = "Descrição";
            // 
            // vagasTxt
            // 
            this.vagasTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vagasTxt.Location = new System.Drawing.Point(431, 152);
            this.vagasTxt.Name = "vagasTxt";
            this.vagasTxt.Size = new System.Drawing.Size(68, 26);
            this.vagasTxt.TabIndex = 9;
            this.vagasTxt.Tag = "Nº de vagas";
            // 
            // minicursoRB
            // 
            this.minicursoRB.AutoSize = true;
            this.minicursoRB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minicursoRB.Location = new System.Drawing.Point(405, 111);
            this.minicursoRB.Name = "minicursoRB";
            this.minicursoRB.Size = new System.Drawing.Size(94, 24);
            this.minicursoRB.TabIndex = 6;
            this.minicursoRB.Text = "Minicurso";
            this.minicursoRB.UseVisualStyleBackColor = true;
            // 
            // codPTxt
            // 
            this.codPTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.codPTxt.Location = new System.Drawing.Point(106, 152);
            this.codPTxt.Name = "codPTxt";
            this.codPTxt.Size = new System.Drawing.Size(86, 26);
            this.codPTxt.TabIndex = 7;
            this.codPTxt.Tag = "Código do palestrante";
            // 
            // nomeTxt
            // 
            this.nomeTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nomeTxt.Location = new System.Drawing.Point(62, 35);
            this.nomeTxt.Name = "nomeTxt";
            this.nomeTxt.Size = new System.Drawing.Size(439, 26);
            this.nomeTxt.TabIndex = 1;
            this.nomeTxt.Tag = "Nome";
            // 
            // vagasLbl
            // 
            this.vagasLbl.AutoSize = true;
            this.vagasLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vagasLbl.Location = new System.Drawing.Point(370, 152);
            this.vagasLbl.Name = "vagasLbl";
            this.vagasLbl.Size = new System.Drawing.Size(55, 40);
            this.vagasLbl.TabIndex = 8;
            this.vagasLbl.Text = "Nº \r\nVagas";
            this.vagasLbl.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // duracaoTxt
            // 
            this.duracaoTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.duracaoTxt.Location = new System.Drawing.Point(287, 152);
            this.duracaoTxt.Name = "duracaoTxt";
            this.duracaoTxt.Size = new System.Drawing.Size(65, 26);
            this.duracaoTxt.TabIndex = 8;
            this.duracaoTxt.Tag = "Duração";
            // 
            // codPLbl
            // 
            this.codPLbl.AutoSize = true;
            this.codPLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.codPLbl.Location = new System.Drawing.Point(5, 152);
            this.codPLbl.Name = "codPLbl";
            this.codPLbl.Size = new System.Drawing.Size(90, 40);
            this.codPLbl.TabIndex = 7;
            this.codPLbl.Text = "Código do\r\nPalestrante";
            // 
            // palestraRB
            // 
            this.palestraRB.AutoSize = true;
            this.palestraRB.Checked = true;
            this.palestraRB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.palestraRB.Location = new System.Drawing.Point(318, 111);
            this.palestraRB.Name = "palestraRB";
            this.palestraRB.Size = new System.Drawing.Size(85, 24);
            this.palestraRB.TabIndex = 5;
            this.palestraRB.TabStop = true;
            this.palestraRB.Text = "Palestra";
            this.palestraRB.UseVisualStyleBackColor = true;
            // 
            // dataPck
            // 
            this.dataPck.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataPck.CustomFormat = "dd/MM/yy";
            this.dataPck.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataPck.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dataPck.Location = new System.Drawing.Point(351, 71);
            this.dataPck.Name = "dataPck";
            this.dataPck.Size = new System.Drawing.Size(150, 26);
            this.dataPck.TabIndex = 3;
            // 
            // dataLbl
            // 
            this.dataLbl.AutoSize = true;
            this.dataLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataLbl.Location = new System.Drawing.Point(301, 74);
            this.dataLbl.Name = "dataLbl";
            this.dataLbl.Size = new System.Drawing.Size(44, 20);
            this.dataLbl.TabIndex = 2;
            this.dataLbl.Text = "Data";
            // 
            // horaLbl
            // 
            this.horaLbl.AutoSize = true;
            this.horaLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.horaLbl.Location = new System.Drawing.Point(8, 113);
            this.horaLbl.Name = "horaLbl";
            this.horaLbl.Size = new System.Drawing.Size(44, 20);
            this.horaLbl.TabIndex = 3;
            this.horaLbl.Text = "Hora";
            // 
            // duracaoLbl
            // 
            this.duracaoLbl.AutoSize = true;
            this.duracaoLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.duracaoLbl.Location = new System.Drawing.Point(205, 152);
            this.duracaoLbl.Name = "duracaoLbl";
            this.duracaoLbl.Size = new System.Drawing.Size(70, 40);
            this.duracaoLbl.TabIndex = 5;
            this.duracaoLbl.Text = "Duração\r\n(min)";
            this.duracaoLbl.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // localLbl
            // 
            this.localLbl.AutoSize = true;
            this.localLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.localLbl.Location = new System.Drawing.Point(5, 76);
            this.localLbl.Name = "localLbl";
            this.localLbl.Size = new System.Drawing.Size(47, 20);
            this.localLbl.TabIndex = 1;
            this.localLbl.Text = "Local";
            // 
            // localTxt
            // 
            this.localTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.localTxt.Location = new System.Drawing.Point(62, 73);
            this.localTxt.Name = "localTxt";
            this.localTxt.Size = new System.Drawing.Size(233, 26);
            this.localTxt.TabIndex = 2;
            this.localTxt.Tag = "Local";
            // 
            // tipoLbl
            // 
            this.tipoLbl.AutoSize = true;
            this.tipoLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tipoLbl.Location = new System.Drawing.Point(273, 113);
            this.tipoLbl.Name = "tipoLbl";
            this.tipoLbl.Size = new System.Drawing.Size(39, 20);
            this.tipoLbl.TabIndex = 4;
            this.tipoLbl.Text = "Tipo";
            // 
            // eventoLbl
            // 
            this.eventoLbl.AutoSize = true;
            this.eventoLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eventoLbl.Location = new System.Drawing.Point(17, 21);
            this.eventoLbl.Name = "eventoLbl";
            this.eventoLbl.Size = new System.Drawing.Size(67, 20);
            this.eventoLbl.TabIndex = 23;
            this.eventoLbl.Text = "Evento: ";
            // 
            // eventoCB
            // 
            this.eventoCB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eventoCB.FormattingEnabled = true;
            this.eventoCB.Location = new System.Drawing.Point(81, 18);
            this.eventoCB.Name = "eventoCB";
            this.eventoCB.Size = new System.Drawing.Size(441, 28);
            this.eventoCB.TabIndex = 24;
            this.eventoCB.SelectedIndexChanged += new System.EventHandler(this.eventoCB_SelectedIndexChanged);
            // 
            // editEventoForms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 462);
            this.Controls.Add(this.eventoCB);
            this.Controls.Add(this.eventoLbl);
            this.Controls.Add(this.salvarBtn);
            this.Controls.Add(this.limparBtn);
            this.Controls.Add(this.eventoInfo);
            this.Name = "editEventoForms";
            this.Text = "editEventoForms";
            this.Load += new System.EventHandler(this.editEventoForms_Load);
            this.eventoInfo.ResumeLayout(false);
            this.eventoInfo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button salvarBtn;
        private System.Windows.Forms.Button limparBtn;
        private System.Windows.Forms.GroupBox eventoInfo;
        private System.Windows.Forms.Label nomeLbl;
        private System.Windows.Forms.TextBox descricaoTxt;
        private System.Windows.Forms.DateTimePicker horaPck;
        private System.Windows.Forms.Label descricaoLbl;
        private System.Windows.Forms.TextBox vagasTxt;
        private System.Windows.Forms.RadioButton minicursoRB;
        private System.Windows.Forms.TextBox codPTxt;
        private System.Windows.Forms.TextBox nomeTxt;
        private System.Windows.Forms.Label vagasLbl;
        private System.Windows.Forms.TextBox duracaoTxt;
        private System.Windows.Forms.Label codPLbl;
        private System.Windows.Forms.RadioButton palestraRB;
        private System.Windows.Forms.DateTimePicker dataPck;
        private System.Windows.Forms.Label dataLbl;
        private System.Windows.Forms.Label horaLbl;
        private System.Windows.Forms.Label duracaoLbl;
        private System.Windows.Forms.Label localLbl;
        private System.Windows.Forms.TextBox localTxt;
        private System.Windows.Forms.Label tipoLbl;
        private System.Windows.Forms.Label eventoLbl;
        private System.Windows.Forms.ComboBox eventoCB;
    }
}