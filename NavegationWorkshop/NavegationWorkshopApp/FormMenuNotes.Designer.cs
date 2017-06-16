namespace NavegationWorkshopApp
{
    partial class FormMenuNotes
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
            this.btnSetPercentages = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblUserName = new System.Windows.Forms.Label();
            this.btnNewSubject = new System.Windows.Forms.Button();
            this.dgvListSubject = new System.Windows.Forms.DataGridView();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FinalNote = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtSearchSubject = new System.Windows.Forms.TextBox();
            this.btnLoadSubject = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListSubject)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSetPercentages
            // 
            this.btnSetPercentages.Location = new System.Drawing.Point(1, -1);
            this.btnSetPercentages.Name = "btnSetPercentages";
            this.btnSetPercentages.Size = new System.Drawing.Size(202, 23);
            this.btnSetPercentages.TabIndex = 0;
            this.btnSetPercentages.Text = "SET PERCENTAGES";
            this.btnSetPercentages.UseVisualStyleBackColor = true;
            this.btnSetPercentages.Click += new System.EventHandler(this.btnSetPercentages_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "WELCOME";
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Location = new System.Drawing.Point(82, 29);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(88, 13);
            this.lblUserName.TabIndex = 2;
            this.lblUserName.Text = "---------------------------";
            // 
            // btnNewSubject
            // 
            this.btnNewSubject.Location = new System.Drawing.Point(16, 56);
            this.btnNewSubject.Name = "btnNewSubject";
            this.btnNewSubject.Size = new System.Drawing.Size(144, 23);
            this.btnNewSubject.TabIndex = 3;
            this.btnNewSubject.Text = "New Subject";
            this.btnNewSubject.UseVisualStyleBackColor = true;
            // 
            // dgvListSubject
            // 
            this.dgvListSubject.AllowUserToAddRows = false;
            this.dgvListSubject.AllowUserToDeleteRows = false;
            this.dgvListSubject.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListSubject.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Codigo,
            this.Nombre,
            this.FinalNote});
            this.dgvListSubject.Location = new System.Drawing.Point(16, 96);
            this.dgvListSubject.Name = "dgvListSubject";
            this.dgvListSubject.ReadOnly = true;
            this.dgvListSubject.Size = new System.Drawing.Size(373, 150);
            this.dgvListSubject.TabIndex = 4;
            // 
            // Codigo
            // 
            this.Codigo.HeaderText = "Subject Code";
            this.Codigo.Name = "Codigo";
            this.Codigo.ReadOnly = true;
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Name";
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            // 
            // FinalNote
            // 
            this.FinalNote.HeaderText = "Final Note";
            this.FinalNote.Name = "FinalNote";
            this.FinalNote.ReadOnly = true;
            // 
            // txtSearchSubject
            // 
            this.txtSearchSubject.Location = new System.Drawing.Point(30, 255);
            this.txtSearchSubject.Name = "txtSearchSubject";
            this.txtSearchSubject.Size = new System.Drawing.Size(225, 20);
            this.txtSearchSubject.TabIndex = 5;
            // 
            // btnLoadSubject
            // 
            this.btnLoadSubject.Location = new System.Drawing.Point(261, 252);
            this.btnLoadSubject.Name = "btnLoadSubject";
            this.btnLoadSubject.Size = new System.Drawing.Size(118, 23);
            this.btnLoadSubject.TabIndex = 6;
            this.btnLoadSubject.Text = "Load";
            this.btnLoadSubject.UseVisualStyleBackColor = true;
            // 
            // FormMenuNotes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(401, 287);
            this.Controls.Add(this.btnLoadSubject);
            this.Controls.Add(this.txtSearchSubject);
            this.Controls.Add(this.dgvListSubject);
            this.Controls.Add(this.btnNewSubject);
            this.Controls.Add(this.lblUserName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSetPercentages);
            this.Name = "FormMenuNotes";
            this.Text = "FormMenuNotes";
            ((System.ComponentModel.ISupportInitialize)(this.dgvListSubject)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSetPercentages;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.Button btnNewSubject;
        private System.Windows.Forms.DataGridView dgvListSubject;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn FinalNote;
        private System.Windows.Forms.TextBox txtSearchSubject;
        private System.Windows.Forms.Button btnLoadSubject;
    }
}