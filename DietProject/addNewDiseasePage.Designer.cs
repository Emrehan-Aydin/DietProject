
namespace DietProject
{
    partial class addNewDiseasePage
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
            this.Btn_addNewDisease = new System.Windows.Forms.Button();
            this.Lb_header = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Tx_DiseaseDescription = new System.Windows.Forms.TextBox();
            this.Tx_DiseaseName = new System.Windows.Forms.TextBox();
            this.Lb_DiseaseDescription = new System.Windows.Forms.Label();
            this.Lb_diseaseName = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Btn_addNewDisease
            // 
            this.Btn_addNewDisease.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.Btn_addNewDisease.FlatAppearance.BorderColor = System.Drawing.Color.MediumSeaGreen;
            this.Btn_addNewDisease.FlatAppearance.BorderSize = 0;
            this.Btn_addNewDisease.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.Btn_addNewDisease.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SpringGreen;
            this.Btn_addNewDisease.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_addNewDisease.Font = new System.Drawing.Font("Yu Gothic UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Btn_addNewDisease.ForeColor = System.Drawing.Color.White;
            this.Btn_addNewDisease.Location = new System.Drawing.Point(0, 395);
            this.Btn_addNewDisease.Name = "Btn_addNewDisease";
            this.Btn_addNewDisease.Size = new System.Drawing.Size(800, 55);
            this.Btn_addNewDisease.TabIndex = 48;
            this.Btn_addNewDisease.Text = "KAYDET";
            this.Btn_addNewDisease.UseVisualStyleBackColor = false;
            this.Btn_addNewDisease.Click += new System.EventHandler(this.Btn_addNewDisease_Click);
            // 
            // Lb_header
            // 
            this.Lb_header.AutoSize = true;
            this.Lb_header.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.Lb_header.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Lb_header.ForeColor = System.Drawing.Color.White;
            this.Lb_header.Location = new System.Drawing.Point(198, 18);
            this.Lb_header.Name = "Lb_header";
            this.Lb_header.Size = new System.Drawing.Size(404, 45);
            this.Lb_header.TabIndex = 47;
            this.Lb_header.Text = "HASTALIK KAYIT SİSTEMİ";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(800, 81);
            this.pictureBox1.TabIndex = 46;
            this.pictureBox1.TabStop = false;
            // 
            // Tx_DiseaseDescription
            // 
            this.Tx_DiseaseDescription.Location = new System.Drawing.Point(172, 153);
            this.Tx_DiseaseDescription.MaxLength = 500;
            this.Tx_DiseaseDescription.Multiline = true;
            this.Tx_DiseaseDescription.Name = "Tx_DiseaseDescription";
            this.Tx_DiseaseDescription.Size = new System.Drawing.Size(579, 217);
            this.Tx_DiseaseDescription.TabIndex = 52;
            // 
            // Tx_DiseaseName
            // 
            this.Tx_DiseaseName.Location = new System.Drawing.Point(172, 115);
            this.Tx_DiseaseName.MaxLength = 20;
            this.Tx_DiseaseName.Name = "Tx_DiseaseName";
            this.Tx_DiseaseName.Size = new System.Drawing.Size(121, 23);
            this.Tx_DiseaseName.TabIndex = 51;
            // 
            // Lb_DiseaseDescription
            // 
            this.Lb_DiseaseDescription.AutoSize = true;
            this.Lb_DiseaseDescription.Location = new System.Drawing.Point(32, 157);
            this.Lb_DiseaseDescription.Name = "Lb_DiseaseDescription";
            this.Lb_DiseaseDescription.Size = new System.Drawing.Size(101, 15);
            this.Lb_DiseaseDescription.TabIndex = 50;
            this.Lb_DiseaseDescription.Text = "Hastalık Açıklama";
            // 
            // Lb_diseaseName
            // 
            this.Lb_diseaseName.AutoSize = true;
            this.Lb_diseaseName.Location = new System.Drawing.Point(32, 118);
            this.Lb_diseaseName.Name = "Lb_diseaseName";
            this.Lb_diseaseName.Size = new System.Drawing.Size(70, 15);
            this.Lb_diseaseName.TabIndex = 49;
            this.Lb_diseaseName.Text = "Hastalık Adı";
            // 
            // addNewDiseasePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Tx_DiseaseDescription);
            this.Controls.Add(this.Tx_DiseaseName);
            this.Controls.Add(this.Lb_DiseaseDescription);
            this.Controls.Add(this.Lb_diseaseName);
            this.Controls.Add(this.Btn_addNewDisease);
            this.Controls.Add(this.Lb_header);
            this.Controls.Add(this.pictureBox1);
            this.Name = "addNewDiseasePage";
            this.Text = "addNeDiseasePage";
            this.Load += new System.EventHandler(this.addNewDiseasePage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Btn_addNewDisease;
        private System.Windows.Forms.Label Lb_header;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox Tx_DiseaseDescription;
        private System.Windows.Forms.TextBox Tx_DiseaseName;
        private System.Windows.Forms.Label Lb_DiseaseDescription;
        private System.Windows.Forms.Label Lb_diseaseName;
    }
}