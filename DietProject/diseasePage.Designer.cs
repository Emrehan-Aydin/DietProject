
namespace DietProject
{
    partial class diseasePage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(diseasePage));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.Lb_header = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Btn_UpdateDisease = new System.Windows.Forms.Button();
            this.Btn_DeleteDisease = new System.Windows.Forms.Button();
            this.Dgw_DiseaseTable = new System.Windows.Forms.DataGridView();
            this.Btn_addDisease = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dgw_DiseaseTable)).BeginInit();
            this.SuspendLayout();
            // 
            // Lb_header
            // 
            this.Lb_header.AutoSize = true;
            this.Lb_header.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(143)))), ((int)(((byte)(98)))));
            this.Lb_header.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Lb_header.ForeColor = System.Drawing.Color.White;
            this.Lb_header.Location = new System.Drawing.Point(10, 22);
            this.Lb_header.Name = "Lb_header";
            this.Lb_header.Size = new System.Drawing.Size(385, 37);
            this.Lb_header.TabIndex = 49;
            this.Lb_header.Text = "HASTALIK YÖNETİM SİSTEMİ";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(143)))), ((int)(((byte)(98)))));
            this.pictureBox1.Location = new System.Drawing.Point(10, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(810, 80);
            this.pictureBox1.TabIndex = 48;
            this.pictureBox1.TabStop = false;
            // 
            // Btn_UpdateDisease
            // 
            this.Btn_UpdateDisease.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(113)))), ((int)(((byte)(179)))));
            this.Btn_UpdateDisease.FlatAppearance.BorderSize = 0;
            this.Btn_UpdateDisease.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(133)))), ((int)(((byte)(199)))));
            this.Btn_UpdateDisease.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_UpdateDisease.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Btn_UpdateDisease.ForeColor = System.Drawing.Color.White;
            this.Btn_UpdateDisease.Image = ((System.Drawing.Image)(resources.GetObject("Btn_UpdateDisease.Image")));
            this.Btn_UpdateDisease.Location = new System.Drawing.Point(700, 0);
            this.Btn_UpdateDisease.Name = "Btn_UpdateDisease";
            this.Btn_UpdateDisease.Size = new System.Drawing.Size(140, 80);
            this.Btn_UpdateDisease.TabIndex = 56;
            this.Btn_UpdateDisease.Text = "Hastalık Güncelleştir";
            this.Btn_UpdateDisease.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_UpdateDisease.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.Btn_UpdateDisease.UseVisualStyleBackColor = false;
            this.Btn_UpdateDisease.Click += new System.EventHandler(this.Btn_UpdateDisease_Click);
            // 
            // Btn_DeleteDisease
            // 
            this.Btn_DeleteDisease.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(71)))), ((int)(((byte)(86)))));
            this.Btn_DeleteDisease.FlatAppearance.BorderSize = 0;
            this.Btn_DeleteDisease.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(91)))), ((int)(((byte)(106)))));
            this.Btn_DeleteDisease.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_DeleteDisease.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Btn_DeleteDisease.ForeColor = System.Drawing.Color.White;
            this.Btn_DeleteDisease.Image = ((System.Drawing.Image)(resources.GetObject("Btn_DeleteDisease.Image")));
            this.Btn_DeleteDisease.Location = new System.Drawing.Point(560, 0);
            this.Btn_DeleteDisease.Name = "Btn_DeleteDisease";
            this.Btn_DeleteDisease.Size = new System.Drawing.Size(140, 80);
            this.Btn_DeleteDisease.TabIndex = 55;
            this.Btn_DeleteDisease.Text = "Hastalık Sil";
            this.Btn_DeleteDisease.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_DeleteDisease.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.Btn_DeleteDisease.UseVisualStyleBackColor = false;
            this.Btn_DeleteDisease.Click += new System.EventHandler(this.Btn_DeletDeleteDisease_Click);
            // 
            // Dgw_DiseaseTable
            // 
            this.Dgw_DiseaseTable.AllowUserToAddRows = false;
            this.Dgw_DiseaseTable.AllowUserToDeleteRows = false;
            this.Dgw_DiseaseTable.AllowUserToResizeColumns = false;
            this.Dgw_DiseaseTable.AllowUserToResizeRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.Padding = new System.Windows.Forms.Padding(0, 10, 0, 10);
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.MediumSeaGreen;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            this.Dgw_DiseaseTable.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.Dgw_DiseaseTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Dgw_DiseaseTable.BackgroundColor = System.Drawing.Color.White;
            this.Dgw_DiseaseTable.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Dgw_DiseaseTable.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.Dgw_DiseaseTable.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.MediumSeaGreen;
            dataGridViewCellStyle5.Padding = new System.Windows.Forms.Padding(0, 10, 0, 10);
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.MediumSeaGreen;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Dgw_DiseaseTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.Dgw_DiseaseTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.Padding = new System.Windows.Forms.Padding(0, 10, 0, 10);
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.MediumSeaGreen;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Dgw_DiseaseTable.DefaultCellStyle = dataGridViewCellStyle6;
            this.Dgw_DiseaseTable.EnableHeadersVisualStyles = false;
            this.Dgw_DiseaseTable.GridColor = System.Drawing.Color.MediumSeaGreen;
            this.Dgw_DiseaseTable.Location = new System.Drawing.Point(10, 90);
            this.Dgw_DiseaseTable.MultiSelect = false;
            this.Dgw_DiseaseTable.Name = "Dgw_DiseaseTable";
            this.Dgw_DiseaseTable.ReadOnly = true;
            this.Dgw_DiseaseTable.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.Dgw_DiseaseTable.RowHeadersVisible = false;
            this.Dgw_DiseaseTable.RowTemplate.DefaultCellStyle.Padding = new System.Windows.Forms.Padding(10);
            this.Dgw_DiseaseTable.RowTemplate.DefaultCellStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Dgw_DiseaseTable.RowTemplate.DividerHeight = 1;
            this.Dgw_DiseaseTable.RowTemplate.Height = 100;
            this.Dgw_DiseaseTable.RowTemplate.ReadOnly = true;
            this.Dgw_DiseaseTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Dgw_DiseaseTable.Size = new System.Drawing.Size(828, 362);
            this.Dgw_DiseaseTable.TabIndex = 54;
            // 
            // Btn_addDisease
            // 
            this.Btn_addDisease.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.Btn_addDisease.FlatAppearance.BorderSize = 0;
            this.Btn_addDisease.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumAquamarine;
            this.Btn_addDisease.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_addDisease.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Btn_addDisease.ForeColor = System.Drawing.Color.White;
            this.Btn_addDisease.Image = ((System.Drawing.Image)(resources.GetObject("Btn_addDisease.Image")));
            this.Btn_addDisease.Location = new System.Drawing.Point(420, 0);
            this.Btn_addDisease.Name = "Btn_addDisease";
            this.Btn_addDisease.Size = new System.Drawing.Size(140, 80);
            this.Btn_addDisease.TabIndex = 53;
            this.Btn_addDisease.Text = "Hastalık Ekle";
            this.Btn_addDisease.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_addDisease.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.Btn_addDisease.UseVisualStyleBackColor = false;
            this.Btn_addDisease.Click += new System.EventHandler(this.Btn_addDisease_Click);
            // 
            // diseasePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(834, 461);
            this.Controls.Add(this.Btn_UpdateDisease);
            this.Controls.Add(this.Btn_DeleteDisease);
            this.Controls.Add(this.Dgw_DiseaseTable);
            this.Controls.Add(this.Btn_addDisease);
            this.Controls.Add(this.Lb_header);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "diseasePage";
            this.Text = "diseasePage";
            this.Load += new System.EventHandler(this.diseasePage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dgw_DiseaseTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Lb_header;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button Btn_UpdateDisease;
        private System.Windows.Forms.Button Btn_DeleteDisease;
        private System.Windows.Forms.DataGridView Dgw_DiseaseTable;
        private System.Windows.Forms.Button Btn_addDisease;
    }
}