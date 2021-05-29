
namespace DietProject
{
    partial class Login
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
            this.Lb_AccountName = new System.Windows.Forms.Label();
            this.Lb_AccountPass = new System.Windows.Forms.Label();
            this.Tx_accountName = new System.Windows.Forms.TextBox();
            this.Tx_accountPass = new System.Windows.Forms.TextBox();
            this.Btn_Login = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Lb_AccountName
            // 
            this.Lb_AccountName.AutoSize = true;
            this.Lb_AccountName.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Lb_AccountName.ForeColor = System.Drawing.Color.SeaGreen;
            this.Lb_AccountName.Location = new System.Drawing.Point(21, 86);
            this.Lb_AccountName.Name = "Lb_AccountName";
            this.Lb_AccountName.Size = new System.Drawing.Size(74, 15);
            this.Lb_AccountName.TabIndex = 0;
            this.Lb_AccountName.Text = "Kullanıcı Adı";
            // 
            // Lb_AccountPass
            // 
            this.Lb_AccountPass.AutoSize = true;
            this.Lb_AccountPass.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Lb_AccountPass.ForeColor = System.Drawing.Color.SeaGreen;
            this.Lb_AccountPass.Location = new System.Drawing.Point(21, 115);
            this.Lb_AccountPass.Name = "Lb_AccountPass";
            this.Lb_AccountPass.Size = new System.Drawing.Size(34, 15);
            this.Lb_AccountPass.TabIndex = 1;
            this.Lb_AccountPass.Text = "Şifre";
            // 
            // Tx_accountName
            // 
            this.Tx_accountName.BackColor = System.Drawing.Color.White;
            this.Tx_accountName.ForeColor = System.Drawing.Color.SeaGreen;
            this.Tx_accountName.Location = new System.Drawing.Point(115, 82);
            this.Tx_accountName.MaxLength = 25;
            this.Tx_accountName.Name = "Tx_accountName";
            this.Tx_accountName.Size = new System.Drawing.Size(100, 23);
            this.Tx_accountName.TabIndex = 2;
            // 
            // Tx_accountPass
            // 
            this.Tx_accountPass.BackColor = System.Drawing.Color.White;
            this.Tx_accountPass.ForeColor = System.Drawing.Color.SeaGreen;
            this.Tx_accountPass.Location = new System.Drawing.Point(115, 111);
            this.Tx_accountPass.MaxLength = 25;
            this.Tx_accountPass.Name = "Tx_accountPass";
            this.Tx_accountPass.PasswordChar = '*';
            this.Tx_accountPass.Size = new System.Drawing.Size(100, 23);
            this.Tx_accountPass.TabIndex = 3;
            // 
            // Btn_Login
            // 
            this.Btn_Login.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.Btn_Login.FlatAppearance.BorderSize = 0;
            this.Btn_Login.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Login.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Btn_Login.ForeColor = System.Drawing.Color.White;
            this.Btn_Login.Location = new System.Drawing.Point(115, 150);
            this.Btn_Login.Name = "Btn_Login";
            this.Btn_Login.Size = new System.Drawing.Size(100, 41);
            this.Btn_Login.TabIndex = 4;
            this.Btn_Login.Text = "Giriş";
            this.Btn_Login.UseVisualStyleBackColor = false;
            this.Btn_Login.Click += new System.EventHandler(this.Btn_Login_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.pictureBox1.Location = new System.Drawing.Point(-1, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(248, 64);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(37, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(168, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "DİYETİSYEN UYGULAMASI";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(243, 215);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Btn_Login);
            this.Controls.Add(this.Tx_accountPass);
            this.Controls.Add(this.Tx_accountName);
            this.Controls.Add(this.Lb_AccountPass);
            this.Controls.Add(this.Lb_AccountName);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Lb_AccountName;
        private System.Windows.Forms.Label Lb_AccountPass;
        private System.Windows.Forms.TextBox Tx_accountName;
        private System.Windows.Forms.TextBox Tx_accountPass;
        private System.Windows.Forms.Button Btn_Login;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
    }
}