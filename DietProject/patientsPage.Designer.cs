
namespace DietProject
{
    partial class patientsPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(patientsPage));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.Lb_header = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Btn_addPatient = new System.Windows.Forms.Button();
            this.Btn_Report = new System.Windows.Forms.Button();
            this.Btn_Update = new System.Windows.Forms.Button();
            this.Dgw_PatientTable = new System.Windows.Forms.DataGridView();
            this.Btn_DeletePatient = new System.Windows.Forms.Button();
            this.Lb_Nutritionist = new System.Windows.Forms.Label();
            this.FirtReporthealth = new System.Windows.Forms.RadioButton();
            this.FirstReportId = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.Cb_Fileformat = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dgw_PatientTable)).BeginInit();
            this.SuspendLayout();
            // 
            // Lb_header
            // 
            this.Lb_header.AutoSize = true;
            this.Lb_header.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(143)))), ((int)(((byte)(98)))));
            this.Lb_header.Font = new System.Drawing.Font("Century Gothic", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Lb_header.ForeColor = System.Drawing.Color.White;
            this.Lb_header.Location = new System.Drawing.Point(10, 24);
            this.Lb_header.Name = "Lb_header";
            this.Lb_header.Size = new System.Drawing.Size(284, 32);
            this.Lb_header.TabIndex = 47;
            this.Lb_header.Text = "HASTA RAPOR LİSTESİ";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(143)))), ((int)(((byte)(98)))));
            this.pictureBox1.Location = new System.Drawing.Point(10, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(830, 80);
            this.pictureBox1.TabIndex = 46;
            this.pictureBox1.TabStop = false;
            // 
            // Btn_addPatient
            // 
            this.Btn_addPatient.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.Btn_addPatient.FlatAppearance.BorderSize = 0;
            this.Btn_addPatient.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumAquamarine;
            this.Btn_addPatient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_addPatient.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Btn_addPatient.ForeColor = System.Drawing.Color.White;
            this.Btn_addPatient.Image = ((System.Drawing.Image)(resources.GetObject("Btn_addPatient.Image")));
            this.Btn_addPatient.Location = new System.Drawing.Point(420, 0);
            this.Btn_addPatient.Name = "Btn_addPatient";
            this.Btn_addPatient.Size = new System.Drawing.Size(140, 80);
            this.Btn_addPatient.TabIndex = 50;
            this.Btn_addPatient.Text = "Hasta Ekle";
            this.Btn_addPatient.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_addPatient.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.Btn_addPatient.UseVisualStyleBackColor = false;
            this.Btn_addPatient.Click += new System.EventHandler(this.Btn_addNewPatient_Click);
            // 
            // Btn_Report
            // 
            this.Btn_Report.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.Btn_Report.FlatAppearance.BorderSize = 0;
            this.Btn_Report.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SpringGreen;
            this.Btn_Report.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Report.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Btn_Report.ForeColor = System.Drawing.Color.White;
            this.Btn_Report.Location = new System.Drawing.Point(424, 399);
            this.Btn_Report.Name = "Btn_Report";
            this.Btn_Report.Size = new System.Drawing.Size(399, 53);
            this.Btn_Report.TabIndex = 51;
            this.Btn_Report.Text = "Rapor Oluştur";
            this.Btn_Report.UseVisualStyleBackColor = false;
            this.Btn_Report.Click += new System.EventHandler(this.Btn_Report_Click);
            // 
            // Btn_Update
            // 
            this.Btn_Update.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(113)))), ((int)(((byte)(179)))));
            this.Btn_Update.FlatAppearance.BorderSize = 0;
            this.Btn_Update.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(133)))), ((int)(((byte)(199)))));
            this.Btn_Update.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Update.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Btn_Update.ForeColor = System.Drawing.Color.White;
            this.Btn_Update.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Update.Image")));
            this.Btn_Update.Location = new System.Drawing.Point(700, 0);
            this.Btn_Update.Name = "Btn_Update";
            this.Btn_Update.Size = new System.Drawing.Size(140, 80);
            this.Btn_Update.TabIndex = 52;
            this.Btn_Update.Text = "Hasta Güncelle";
            this.Btn_Update.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_Update.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.Btn_Update.UseVisualStyleBackColor = false;
            this.Btn_Update.Click += new System.EventHandler(this.Btn_Update_Click);
            // 
            // Dgw_PatientTable
            // 
            this.Dgw_PatientTable.AllowUserToAddRows = false;
            this.Dgw_PatientTable.AllowUserToDeleteRows = false;
            this.Dgw_PatientTable.AllowUserToResizeColumns = false;
            this.Dgw_PatientTable.AllowUserToResizeRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.Padding = new System.Windows.Forms.Padding(0, 10, 0, 10);
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.MediumSeaGreen;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            this.Dgw_PatientTable.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.Dgw_PatientTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Dgw_PatientTable.BackgroundColor = System.Drawing.Color.White;
            this.Dgw_PatientTable.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Dgw_PatientTable.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.Dgw_PatientTable.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.MediumSeaGreen;
            dataGridViewCellStyle5.Padding = new System.Windows.Forms.Padding(0, 10, 0, 10);
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.MediumSeaGreen;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Dgw_PatientTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.Dgw_PatientTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.Padding = new System.Windows.Forms.Padding(0, 10, 0, 10);
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.MediumSeaGreen;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Dgw_PatientTable.DefaultCellStyle = dataGridViewCellStyle6;
            this.Dgw_PatientTable.EnableHeadersVisualStyles = false;
            this.Dgw_PatientTable.GridColor = System.Drawing.Color.MediumSeaGreen;
            this.Dgw_PatientTable.Location = new System.Drawing.Point(10, 90);
            this.Dgw_PatientTable.MultiSelect = false;
            this.Dgw_PatientTable.Name = "Dgw_PatientTable";
            this.Dgw_PatientTable.ReadOnly = true;
            this.Dgw_PatientTable.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.Dgw_PatientTable.RowHeadersVisible = false;
            this.Dgw_PatientTable.RowTemplate.DividerHeight = 1;
            this.Dgw_PatientTable.RowTemplate.Height = 40;
            this.Dgw_PatientTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Dgw_PatientTable.Size = new System.Drawing.Size(830, 300);
            this.Dgw_PatientTable.TabIndex = 53;
            // 
            // Btn_DeletePatient
            // 
            this.Btn_DeletePatient.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(71)))), ((int)(((byte)(86)))));
            this.Btn_DeletePatient.FlatAppearance.BorderSize = 0;
            this.Btn_DeletePatient.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(91)))), ((int)(((byte)(106)))));
            this.Btn_DeletePatient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_DeletePatient.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Btn_DeletePatient.ForeColor = System.Drawing.Color.White;
            this.Btn_DeletePatient.Image = ((System.Drawing.Image)(resources.GetObject("Btn_DeletePatient.Image")));
            this.Btn_DeletePatient.Location = new System.Drawing.Point(560, 0);
            this.Btn_DeletePatient.Name = "Btn_DeletePatient";
            this.Btn_DeletePatient.Size = new System.Drawing.Size(140, 80);
            this.Btn_DeletePatient.TabIndex = 54;
            this.Btn_DeletePatient.Text = "Hasta Sil";
            this.Btn_DeletePatient.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_DeletePatient.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.Btn_DeletePatient.UseVisualStyleBackColor = false;
            this.Btn_DeletePatient.Click += new System.EventHandler(this.Btn_DeletePatient_Click);
            // 
            // Lb_Nutritionist
            // 
            this.Lb_Nutritionist.AutoSize = true;
            this.Lb_Nutritionist.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.Lb_Nutritionist.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Lb_Nutritionist.ForeColor = System.Drawing.Color.White;
            this.Lb_Nutritionist.Location = new System.Drawing.Point(21, 9);
            this.Lb_Nutritionist.Name = "Lb_Nutritionist";
            this.Lb_Nutritionist.Size = new System.Drawing.Size(0, 15);
            this.Lb_Nutritionist.TabIndex = 55;
            // 
            // FirtReporthealth
            // 
            this.FirtReporthealth.AutoSize = true;
            this.FirtReporthealth.Location = new System.Drawing.Point(161, 406);
            this.FirtReporthealth.Name = "FirtReporthealth";
            this.FirtReporthealth.Size = new System.Drawing.Size(239, 19);
            this.FirtReporthealth.TabIndex = 56;
            this.FirtReporthealth.TabStop = true;
            this.FirtReporthealth.Text = "Önce Kimlik bilgileri Sonra Sağlık Raporu";
            this.FirtReporthealth.UseVisualStyleBackColor = true;
            // 
            // FirstReportId
            // 
            this.FirstReportId.AutoSize = true;
            this.FirstReportId.Location = new System.Drawing.Point(161, 431);
            this.FirstReportId.Name = "FirstReportId";
            this.FirstReportId.Size = new System.Drawing.Size(240, 19);
            this.FirstReportId.TabIndex = 57;
            this.FirstReportId.TabStop = true;
            this.FirstReportId.Text = "Önce Sağlık Bilgileri Sonra Kimlik Bilgileri";
            this.FirstReportId.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 406);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 15);
            this.label1.TabIndex = 58;
            this.label1.Text = "Dosya Formatı";
            // 
            // Cb_Fileformat
            // 
            this.Cb_Fileformat.FormattingEnabled = true;
            this.Cb_Fileformat.Items.AddRange(new object[] {
            "JSON",
            "HTML"});
            this.Cb_Fileformat.Location = new System.Drawing.Point(21, 424);
            this.Cb_Fileformat.Name = "Cb_Fileformat";
            this.Cb_Fileformat.Size = new System.Drawing.Size(121, 23);
            this.Cb_Fileformat.TabIndex = 59;
            // 
            // patientsPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(834, 461);
            this.Controls.Add(this.Cb_Fileformat);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.FirstReportId);
            this.Controls.Add(this.FirtReporthealth);
            this.Controls.Add(this.Lb_Nutritionist);
            this.Controls.Add(this.Btn_DeletePatient);
            this.Controls.Add(this.Dgw_PatientTable);
            this.Controls.Add(this.Btn_Update);
            this.Controls.Add(this.Btn_Report);
            this.Controls.Add(this.Btn_addPatient);
            this.Controls.Add(this.Lb_header);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "patientsPage";
            this.Text = "Hasta Anasayfa";
            this.Load += new System.EventHandler(this.patientsPage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dgw_PatientTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label Lb_header;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button Btn_addPatient;
        private System.Windows.Forms.Button Btn_Report;
        private System.Windows.Forms.Button Btn_Update;
        private System.Windows.Forms.DataGridView Dgw_PatientTable;
        private System.Windows.Forms.Button Btn_DeletePatient;
        private System.Windows.Forms.Label Lb_Nutritionist;
        private System.Windows.Forms.RadioButton FirtReporthealth;
        private System.Windows.Forms.RadioButton FirstReportId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox Cb_Fileformat;
    }
}