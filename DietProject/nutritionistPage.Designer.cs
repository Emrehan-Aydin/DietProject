
namespace DietProject
{
    partial class nutritionistPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(nutritionistPage));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.Lb_header = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Btn_addNutritionist = new System.Windows.Forms.Button();
            this.Dgw_DoctorTable = new System.Windows.Forms.DataGridView();
            this.Btn_DeleteNutritionist = new System.Windows.Forms.Button();
            this.Btn_UpdateNutritionist = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dgw_DoctorTable)).BeginInit();
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
            this.Lb_header.Size = new System.Drawing.Size(245, 32);
            this.Lb_header.TabIndex = 45;
            this.Lb_header.Text = "DİYETİSYEN LİSTESİ";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(143)))), ((int)(((byte)(98)))));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.Location = new System.Drawing.Point(10, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(830, 80);
            this.pictureBox1.TabIndex = 44;
            this.pictureBox1.TabStop = false;
            // 
            // Btn_addNutritionist
            // 
            this.Btn_addNutritionist.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.Btn_addNutritionist.FlatAppearance.BorderSize = 0;
            this.Btn_addNutritionist.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumAquamarine;
            this.Btn_addNutritionist.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_addNutritionist.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Btn_addNutritionist.ForeColor = System.Drawing.Color.White;
            this.Btn_addNutritionist.Image = ((System.Drawing.Image)(resources.GetObject("Btn_addNutritionist.Image")));
            this.Btn_addNutritionist.Location = new System.Drawing.Point(420, 0);
            this.Btn_addNutritionist.Name = "Btn_addNutritionist";
            this.Btn_addNutritionist.Size = new System.Drawing.Size(140, 80);
            this.Btn_addNutritionist.TabIndex = 47;
            this.Btn_addNutritionist.Text = "Diyetisyen Ekle";
            this.Btn_addNutritionist.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_addNutritionist.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.Btn_addNutritionist.UseVisualStyleBackColor = false;
            this.Btn_addNutritionist.Click += new System.EventHandler(this.Btn_addNutritionist_Click);
            // 
            // Dgw_DoctorTable
            // 
            this.Dgw_DoctorTable.AllowUserToAddRows = false;
            this.Dgw_DoctorTable.AllowUserToDeleteRows = false;
            this.Dgw_DoctorTable.AllowUserToResizeColumns = false;
            this.Dgw_DoctorTable.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(0, 10, 0, 10);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.MediumSeaGreen;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            this.Dgw_DoctorTable.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.Dgw_DoctorTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Dgw_DoctorTable.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.Dgw_DoctorTable.BackgroundColor = System.Drawing.Color.White;
            this.Dgw_DoctorTable.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Dgw_DoctorTable.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.Dgw_DoctorTable.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.MediumSeaGreen;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(0, 10, 0, 10);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.MediumSeaGreen;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Dgw_DoctorTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.Dgw_DoctorTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(0, 10, 0, 10);
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.MediumSeaGreen;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Dgw_DoctorTable.DefaultCellStyle = dataGridViewCellStyle3;
            this.Dgw_DoctorTable.EnableHeadersVisualStyles = false;
            this.Dgw_DoctorTable.GridColor = System.Drawing.Color.MediumSeaGreen;
            this.Dgw_DoctorTable.Location = new System.Drawing.Point(10, 90);
            this.Dgw_DoctorTable.MultiSelect = false;
            this.Dgw_DoctorTable.Name = "Dgw_DoctorTable";
            this.Dgw_DoctorTable.ReadOnly = true;
            this.Dgw_DoctorTable.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.Dgw_DoctorTable.RowHeadersVisible = false;
            this.Dgw_DoctorTable.RowTemplate.DividerHeight = 1;
            this.Dgw_DoctorTable.RowTemplate.Height = 30;
            this.Dgw_DoctorTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Dgw_DoctorTable.Size = new System.Drawing.Size(830, 360);
            this.Dgw_DoctorTable.TabIndex = 48;
            // 
            // Btn_DeleteNutritionist
            // 
            this.Btn_DeleteNutritionist.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(71)))), ((int)(((byte)(86)))));
            this.Btn_DeleteNutritionist.FlatAppearance.BorderSize = 0;
            this.Btn_DeleteNutritionist.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(91)))), ((int)(((byte)(106)))));
            this.Btn_DeleteNutritionist.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_DeleteNutritionist.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Btn_DeleteNutritionist.ForeColor = System.Drawing.Color.White;
            this.Btn_DeleteNutritionist.Image = ((System.Drawing.Image)(resources.GetObject("Btn_DeleteNutritionist.Image")));
            this.Btn_DeleteNutritionist.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_DeleteNutritionist.Location = new System.Drawing.Point(560, 0);
            this.Btn_DeleteNutritionist.Name = "Btn_DeleteNutritionist";
            this.Btn_DeleteNutritionist.Size = new System.Drawing.Size(140, 80);
            this.Btn_DeleteNutritionist.TabIndex = 49;
            this.Btn_DeleteNutritionist.Text = "Diyetisyen Sil";
            this.Btn_DeleteNutritionist.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.Btn_DeleteNutritionist.UseVisualStyleBackColor = false;
            this.Btn_DeleteNutritionist.Click += new System.EventHandler(this.Btn_DeleteNutritionist_Click_1);
            // 
            // Btn_UpdateNutritionist
            // 
            this.Btn_UpdateNutritionist.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(113)))), ((int)(((byte)(179)))));
            this.Btn_UpdateNutritionist.FlatAppearance.BorderSize = 0;
            this.Btn_UpdateNutritionist.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(133)))), ((int)(((byte)(199)))));
            this.Btn_UpdateNutritionist.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_UpdateNutritionist.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Btn_UpdateNutritionist.ForeColor = System.Drawing.Color.White;
            this.Btn_UpdateNutritionist.Image = ((System.Drawing.Image)(resources.GetObject("Btn_UpdateNutritionist.Image")));
            this.Btn_UpdateNutritionist.Location = new System.Drawing.Point(700, 0);
            this.Btn_UpdateNutritionist.Name = "Btn_UpdateNutritionist";
            this.Btn_UpdateNutritionist.Size = new System.Drawing.Size(140, 80);
            this.Btn_UpdateNutritionist.TabIndex = 50;
            this.Btn_UpdateNutritionist.Text = "Diyetisyen Güncelleştir";
            this.Btn_UpdateNutritionist.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_UpdateNutritionist.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.Btn_UpdateNutritionist.UseVisualStyleBackColor = false;
            this.Btn_UpdateNutritionist.Click += new System.EventHandler(this.Btn_UpdateNutritionist_Click);
            // 
            // nutritionistPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(834, 461);
            this.Controls.Add(this.Btn_UpdateNutritionist);
            this.Controls.Add(this.Btn_DeleteNutritionist);
            this.Controls.Add(this.Dgw_DoctorTable);
            this.Controls.Add(this.Btn_addNutritionist);
            this.Controls.Add(this.Lb_header);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "nutritionistPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "nutritionistPage";
            this.Load += new System.EventHandler(this.nutritionistPage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dgw_DoctorTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Lb_header;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button Btn_addNutritionist;
        private System.Windows.Forms.DataGridView Dgw_DoctorTable;
        private System.Windows.Forms.Button Btn_DeleteNutritionist;
        private System.Windows.Forms.Button Btn_UpdateNutritionist;
    }
}