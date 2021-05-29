
namespace DietProject
{
    partial class adminIndex
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(adminIndex));
            this.panel1 = new System.Windows.Forms.Panel();
            this.Btn_diseasePage = new System.Windows.Forms.Button();
            this.Btn_dietPage = new System.Windows.Forms.Button();
            this.Btn_nutritionistPage = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Btn_diseasePage);
            this.panel1.Controls.Add(this.Btn_dietPage);
            this.panel1.Controls.Add(this.Btn_nutritionistPage);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(160, 458);
            this.panel1.TabIndex = 0;
            // 
            // Btn_diseasePage
            // 
            this.Btn_diseasePage.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.Btn_diseasePage.FlatAppearance.BorderSize = 0;
            this.Btn_diseasePage.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumAquamarine;
            this.Btn_diseasePage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_diseasePage.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Btn_diseasePage.ForeColor = System.Drawing.Color.White;
            this.Btn_diseasePage.Image = ((System.Drawing.Image)(resources.GetObject("Btn_diseasePage.Image")));
            this.Btn_diseasePage.Location = new System.Drawing.Point(0, 306);
            this.Btn_diseasePage.Name = "Btn_diseasePage";
            this.Btn_diseasePage.Size = new System.Drawing.Size(160, 153);
            this.Btn_diseasePage.TabIndex = 51;
            this.Btn_diseasePage.Text = "Hastalık Sistemi";
            this.Btn_diseasePage.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_diseasePage.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.Btn_diseasePage.UseVisualStyleBackColor = false;
            this.Btn_diseasePage.Click += new System.EventHandler(this.Btn_diseasePage_Click);
            // 
            // Btn_dietPage
            // 
            this.Btn_dietPage.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.Btn_dietPage.FlatAppearance.BorderSize = 0;
            this.Btn_dietPage.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumAquamarine;
            this.Btn_dietPage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_dietPage.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Btn_dietPage.ForeColor = System.Drawing.Color.White;
            this.Btn_dietPage.Image = ((System.Drawing.Image)(resources.GetObject("Btn_dietPage.Image")));
            this.Btn_dietPage.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_dietPage.Location = new System.Drawing.Point(0, 153);
            this.Btn_dietPage.Name = "Btn_dietPage";
            this.Btn_dietPage.Size = new System.Drawing.Size(160, 153);
            this.Btn_dietPage.TabIndex = 50;
            this.Btn_dietPage.Text = "Diyet Sistemi";
            this.Btn_dietPage.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.Btn_dietPage.UseVisualStyleBackColor = false;
            this.Btn_dietPage.Click += new System.EventHandler(this.Btn_dietPage_Click);
            // 
            // Btn_nutritionistPage
            // 
            this.Btn_nutritionistPage.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.Btn_nutritionistPage.FlatAppearance.BorderSize = 0;
            this.Btn_nutritionistPage.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumAquamarine;
            this.Btn_nutritionistPage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_nutritionistPage.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Btn_nutritionistPage.ForeColor = System.Drawing.Color.White;
            this.Btn_nutritionistPage.Image = ((System.Drawing.Image)(resources.GetObject("Btn_nutritionistPage.Image")));
            this.Btn_nutritionistPage.Location = new System.Drawing.Point(0, 0);
            this.Btn_nutritionistPage.Name = "Btn_nutritionistPage";
            this.Btn_nutritionistPage.Size = new System.Drawing.Size(160, 153);
            this.Btn_nutritionistPage.TabIndex = 49;
            this.Btn_nutritionistPage.Text = "Diyetisyen Sistemi";
            this.Btn_nutritionistPage.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_nutritionistPage.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.Btn_nutritionistPage.UseVisualStyleBackColor = false;
            this.Btn_nutritionistPage.Click += new System.EventHandler(this.Btn_nutritionistPage_Click_1);
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(160, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(840, 461);
            this.panel2.TabIndex = 1;
            // 
            // adminIndex
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(994, 458);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.IsMdiContainer = true;
            this.Name = "adminIndex";
            this.Text = "Admin Anasayfa";
            this.Load += new System.EventHandler(this.adminIndex_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button Btn_nutritionistPage;
        private System.Windows.Forms.Button Btn_diseasePage;
        private System.Windows.Forms.Button Btn_dietPage;
    }
}