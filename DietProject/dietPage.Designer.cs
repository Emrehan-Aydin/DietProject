
namespace DietProject
{
    partial class dietPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(dietPage));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Lb_header = new System.Windows.Forms.Label();
            this.Btn_UpdateDiet = new System.Windows.Forms.Button();
            this.Btn_DeleteDiet = new System.Windows.Forms.Button();
            this.Dgw_DietTable = new System.Windows.Forms.DataGridView();
            this.Btn_addDiet = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dgw_DietTable)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(143)))), ((int)(((byte)(98)))));
            this.pictureBox1.ImageLocation = "";
            this.pictureBox1.Location = new System.Drawing.Point(10, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(830, 80);
            this.pictureBox1.TabIndex = 46;
            this.pictureBox1.TabStop = false;
            // 
            // Lb_header
            // 
            this.Lb_header.AutoSize = true;
            this.Lb_header.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(143)))), ((int)(((byte)(98)))));
            this.Lb_header.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Lb_header.ForeColor = System.Drawing.Color.White;
            this.Lb_header.Location = new System.Drawing.Point(10, 22);
            this.Lb_header.Name = "Lb_header";
            this.Lb_header.Size = new System.Drawing.Size(331, 37);
            this.Lb_header.TabIndex = 47;
            this.Lb_header.Text = "DİYET YÖNETİM SİSTEMİ";
            // 
            // Btn_UpdateDiet
            // 
            this.Btn_UpdateDiet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(113)))), ((int)(((byte)(179)))));
            this.Btn_UpdateDiet.FlatAppearance.BorderSize = 0;
            this.Btn_UpdateDiet.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(133)))), ((int)(((byte)(199)))));
            this.Btn_UpdateDiet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_UpdateDiet.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Btn_UpdateDiet.ForeColor = System.Drawing.Color.White;
            this.Btn_UpdateDiet.Image = ((System.Drawing.Image)(resources.GetObject("Btn_UpdateDiet.Image")));
            this.Btn_UpdateDiet.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_UpdateDiet.Location = new System.Drawing.Point(700, 0);
            this.Btn_UpdateDiet.Name = "Btn_UpdateDiet";
            this.Btn_UpdateDiet.Size = new System.Drawing.Size(140, 80);
            this.Btn_UpdateDiet.TabIndex = 56;
            this.Btn_UpdateDiet.Text = "Diyet Güncelleştir";
            this.Btn_UpdateDiet.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.Btn_UpdateDiet.UseVisualStyleBackColor = false;
            this.Btn_UpdateDiet.Click += new System.EventHandler(this.Btn_UpdateDiet_Click);
            // 
            // Btn_DeleteDiet
            // 
            this.Btn_DeleteDiet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(71)))), ((int)(((byte)(86)))));
            this.Btn_DeleteDiet.FlatAppearance.BorderSize = 0;
            this.Btn_DeleteDiet.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(91)))), ((int)(((byte)(106)))));
            this.Btn_DeleteDiet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_DeleteDiet.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Btn_DeleteDiet.ForeColor = System.Drawing.Color.White;
            this.Btn_DeleteDiet.Image = ((System.Drawing.Image)(resources.GetObject("Btn_DeleteDiet.Image")));
            this.Btn_DeleteDiet.Location = new System.Drawing.Point(560, 0);
            this.Btn_DeleteDiet.Name = "Btn_DeleteDiet";
            this.Btn_DeleteDiet.Size = new System.Drawing.Size(140, 80);
            this.Btn_DeleteDiet.TabIndex = 55;
            this.Btn_DeleteDiet.Text = "Diyet Sil";
            this.Btn_DeleteDiet.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_DeleteDiet.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.Btn_DeleteDiet.UseVisualStyleBackColor = false;
            this.Btn_DeleteDiet.Click += new System.EventHandler(this.Btn_DeleteDiet_Click);
            // 
            // Dgw_DietTable
            // 
            this.Dgw_DietTable.AllowUserToAddRows = false;
            this.Dgw_DietTable.AllowUserToDeleteRows = false;
            this.Dgw_DietTable.AllowUserToResizeColumns = false;
            this.Dgw_DietTable.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(0, 10, 0, 10);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.MediumSeaGreen;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            this.Dgw_DietTable.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.Dgw_DietTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Dgw_DietTable.BackgroundColor = System.Drawing.Color.White;
            this.Dgw_DietTable.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Dgw_DietTable.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.Dgw_DietTable.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.MediumSeaGreen;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(0, 10, 0, 10);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.MediumSeaGreen;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Dgw_DietTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.Dgw_DietTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(0, 10, 0, 10);
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.MediumSeaGreen;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Dgw_DietTable.DefaultCellStyle = dataGridViewCellStyle3;
            this.Dgw_DietTable.EnableHeadersVisualStyles = false;
            this.Dgw_DietTable.GridColor = System.Drawing.Color.MediumSeaGreen;
            this.Dgw_DietTable.Location = new System.Drawing.Point(10, 90);
            this.Dgw_DietTable.MultiSelect = false;
            this.Dgw_DietTable.Name = "Dgw_DietTable";
            this.Dgw_DietTable.ReadOnly = true;
            this.Dgw_DietTable.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.Dgw_DietTable.RowHeadersVisible = false;
            this.Dgw_DietTable.RowHeadersWidth = 40;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Dgw_DietTable.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.Dgw_DietTable.RowTemplate.DefaultCellStyle.Padding = new System.Windows.Forms.Padding(10);
            this.Dgw_DietTable.RowTemplate.DividerHeight = 1;
            this.Dgw_DietTable.RowTemplate.Height = 100;
            this.Dgw_DietTable.RowTemplate.ReadOnly = true;
            this.Dgw_DietTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Dgw_DietTable.Size = new System.Drawing.Size(828, 362);
            this.Dgw_DietTable.TabIndex = 54;
            // 
            // Btn_addDiet
            // 
            this.Btn_addDiet.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.Btn_addDiet.FlatAppearance.BorderSize = 0;
            this.Btn_addDiet.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumAquamarine;
            this.Btn_addDiet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_addDiet.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Btn_addDiet.ForeColor = System.Drawing.Color.White;
            this.Btn_addDiet.Image = ((System.Drawing.Image)(resources.GetObject("Btn_addDiet.Image")));
            this.Btn_addDiet.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_addDiet.Location = new System.Drawing.Point(420, 0);
            this.Btn_addDiet.Name = "Btn_addDiet";
            this.Btn_addDiet.Size = new System.Drawing.Size(140, 80);
            this.Btn_addDiet.TabIndex = 53;
            this.Btn_addDiet.Text = "Diyet Ekle";
            this.Btn_addDiet.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.Btn_addDiet.UseVisualStyleBackColor = false;
            this.Btn_addDiet.Click += new System.EventHandler(this.Btn_addDiet_Click);
            // 
            // dietPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(834, 461);
            this.Controls.Add(this.Btn_UpdateDiet);
            this.Controls.Add(this.Btn_DeleteDiet);
            this.Controls.Add(this.Dgw_DietTable);
            this.Controls.Add(this.Btn_addDiet);
            this.Controls.Add(this.Lb_header);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "dietPage";
            this.Text = "dietPage";
            this.Load += new System.EventHandler(this.dietPage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dgw_DietTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label Lb_header;
        private System.Windows.Forms.Button Btn_UpdateDiet;
        private System.Windows.Forms.Button Btn_DeleteDiet;
        private System.Windows.Forms.DataGridView Dgw_DietTable;
        private System.Windows.Forms.Button Btn_addDiet;
    }
}