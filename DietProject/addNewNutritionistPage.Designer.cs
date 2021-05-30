
namespace DietProject
{
    partial class addNewNutritionistPage
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
            this.Cb_citys = new System.Windows.Forms.ComboBox();
            this.Dtp_DateOfBirth = new System.Windows.Forms.DateTimePicker();
            this.Rb_fermale = new System.Windows.Forms.RadioButton();
            this.Rb_male = new System.Windows.Forms.RadioButton();
            this.Tx_Surname = new System.Windows.Forms.TextBox();
            this.Tx_Name = new System.Windows.Forms.TextBox();
            this.Tx_tcnumber = new System.Windows.Forms.TextBox();
            this.Lb_gender = new System.Windows.Forms.Label();
            this.Lb_City = new System.Windows.Forms.Label();
            this.Lb_DateOfBirth = new System.Windows.Forms.Label();
            this.Lb_Surname = new System.Windows.Forms.Label();
            this.Lb_Name = new System.Windows.Forms.Label();
            this.Lb_tc = new System.Windows.Forms.Label();
            this.Lb_AccountName = new System.Windows.Forms.Label();
            this.Lb_AccountPass = new System.Windows.Forms.Label();
            this.Tb_accountName = new System.Windows.Forms.TextBox();
            this.Tb_accountPass = new System.Windows.Forms.TextBox();
            this.UserInformation = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Lb_header = new System.Windows.Forms.Label();
            this.Pb_profilePhoto = new System.Windows.Forms.PictureBox();
            this.Btn_Register = new System.Windows.Forms.Button();
            this.UserInformation.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pb_profilePhoto)).BeginInit();
            this.SuspendLayout();
            // 
            // Cb_citys
            // 
            this.Cb_citys.FormattingEnabled = true;
            this.Cb_citys.Location = new System.Drawing.Point(163, 231);
            this.Cb_citys.Name = "Cb_citys";
            this.Cb_citys.Size = new System.Drawing.Size(121, 23);
            this.Cb_citys.TabIndex = 30;
            this.Cb_citys.SelectedIndexChanged += new System.EventHandler(this.Cb_citys_SelectedIndexChanged);
            // 
            // Dtp_DateOfBirth
            // 
            this.Dtp_DateOfBirth.Location = new System.Drawing.Point(163, 192);
            this.Dtp_DateOfBirth.Name = "Dtp_DateOfBirth";
            this.Dtp_DateOfBirth.Size = new System.Drawing.Size(121, 23);
            this.Dtp_DateOfBirth.TabIndex = 29;
            // 
            // Rb_fermale
            // 
            this.Rb_fermale.AutoSize = true;
            this.Rb_fermale.Checked = true;
            this.Rb_fermale.Location = new System.Drawing.Point(234, 157);
            this.Rb_fermale.Name = "Rb_fermale";
            this.Rb_fermale.Size = new System.Drawing.Size(40, 19);
            this.Rb_fermale.TabIndex = 28;
            this.Rb_fermale.TabStop = true;
            this.Rb_fermale.Text = "Kız";
            this.Rb_fermale.UseVisualStyleBackColor = true;
            // 
            // Rb_male
            // 
            this.Rb_male.AutoSize = true;
            this.Rb_male.Location = new System.Drawing.Point(163, 157);
            this.Rb_male.Name = "Rb_male";
            this.Rb_male.Size = new System.Drawing.Size(53, 19);
            this.Rb_male.TabIndex = 27;
            this.Rb_male.TabStop = true;
            this.Rb_male.Text = "Erkek";
            this.Rb_male.UseVisualStyleBackColor = true;
            // 
            // Tx_Surname
            // 
            this.Tx_Surname.Location = new System.Drawing.Point(163, 114);
            this.Tx_Surname.MaxLength = 25;
            this.Tx_Surname.Name = "Tx_Surname";
            this.Tx_Surname.Size = new System.Drawing.Size(121, 23);
            this.Tx_Surname.TabIndex = 26;
            // 
            // Tx_Name
            // 
            this.Tx_Name.Location = new System.Drawing.Point(163, 75);
            this.Tx_Name.MaxLength = 25;
            this.Tx_Name.Name = "Tx_Name";
            this.Tx_Name.Size = new System.Drawing.Size(121, 23);
            this.Tx_Name.TabIndex = 25;
            // 
            // Tx_tcnumber
            // 
            this.Tx_tcnumber.Location = new System.Drawing.Point(163, 36);
            this.Tx_tcnumber.MaxLength = 11;
            this.Tx_tcnumber.Name = "Tx_tcnumber";
            this.Tx_tcnumber.Size = new System.Drawing.Size(121, 23);
            this.Tx_tcnumber.TabIndex = 24;
            // 
            // Lb_gender
            // 
            this.Lb_gender.AutoSize = true;
            this.Lb_gender.Location = new System.Drawing.Point(23, 157);
            this.Lb_gender.Name = "Lb_gender";
            this.Lb_gender.Size = new System.Drawing.Size(49, 15);
            this.Lb_gender.TabIndex = 23;
            this.Lb_gender.Text = "Cinsiyet";
            // 
            // Lb_City
            // 
            this.Lb_City.AutoSize = true;
            this.Lb_City.Location = new System.Drawing.Point(23, 235);
            this.Lb_City.Name = "Lb_City";
            this.Lb_City.Size = new System.Drawing.Size(86, 15);
            this.Lb_City.TabIndex = 21;
            this.Lb_City.Text = "Doğduğu Şehir";
            // 
            // Lb_DateOfBirth
            // 
            this.Lb_DateOfBirth.AutoSize = true;
            this.Lb_DateOfBirth.Location = new System.Drawing.Point(23, 196);
            this.Lb_DateOfBirth.Name = "Lb_DateOfBirth";
            this.Lb_DateOfBirth.Size = new System.Drawing.Size(78, 15);
            this.Lb_DateOfBirth.TabIndex = 20;
            this.Lb_DateOfBirth.Text = "Doğum Tarihi";
            // 
            // Lb_Surname
            // 
            this.Lb_Surname.AutoSize = true;
            this.Lb_Surname.Location = new System.Drawing.Point(23, 118);
            this.Lb_Surname.Name = "Lb_Surname";
            this.Lb_Surname.Size = new System.Drawing.Size(42, 15);
            this.Lb_Surname.TabIndex = 19;
            this.Lb_Surname.Text = "Soyadı";
            // 
            // Lb_Name
            // 
            this.Lb_Name.AutoSize = true;
            this.Lb_Name.Location = new System.Drawing.Point(23, 79);
            this.Lb_Name.Name = "Lb_Name";
            this.Lb_Name.Size = new System.Drawing.Size(25, 15);
            this.Lb_Name.TabIndex = 18;
            this.Lb_Name.Text = "Adı";
            // 
            // Lb_tc
            // 
            this.Lb_tc.AutoSize = true;
            this.Lb_tc.Location = new System.Drawing.Point(23, 40);
            this.Lb_tc.Name = "Lb_tc";
            this.Lb_tc.Size = new System.Drawing.Size(117, 15);
            this.Lb_tc.TabIndex = 17;
            this.Lb_tc.Text = "T.C. Kimlik Numarası";
            // 
            // Lb_AccountName
            // 
            this.Lb_AccountName.AutoSize = true;
            this.Lb_AccountName.Location = new System.Drawing.Point(6, 22);
            this.Lb_AccountName.Name = "Lb_AccountName";
            this.Lb_AccountName.Size = new System.Drawing.Size(73, 15);
            this.Lb_AccountName.TabIndex = 32;
            this.Lb_AccountName.Text = "Kullanıcı Adı";
            // 
            // Lb_AccountPass
            // 
            this.Lb_AccountPass.AutoSize = true;
            this.Lb_AccountPass.Location = new System.Drawing.Point(6, 55);
            this.Lb_AccountPass.Name = "Lb_AccountPass";
            this.Lb_AccountPass.Size = new System.Drawing.Size(30, 15);
            this.Lb_AccountPass.TabIndex = 33;
            this.Lb_AccountPass.Text = "Şifre";
            // 
            // Tb_accountName
            // 
            this.Tb_accountName.Location = new System.Drawing.Point(106, 19);
            this.Tb_accountName.MaxLength = 25;
            this.Tb_accountName.Name = "Tb_accountName";
            this.Tb_accountName.Size = new System.Drawing.Size(100, 23);
            this.Tb_accountName.TabIndex = 34;
            // 
            // Tb_accountPass
            // 
            this.Tb_accountPass.Location = new System.Drawing.Point(106, 52);
            this.Tb_accountPass.MaxLength = 25;
            this.Tb_accountPass.Name = "Tb_accountPass";
            this.Tb_accountPass.Size = new System.Drawing.Size(100, 23);
            this.Tb_accountPass.TabIndex = 35;
            // 
            // UserInformation
            // 
            this.UserInformation.Controls.Add(this.Cb_citys);
            this.UserInformation.Controls.Add(this.Dtp_DateOfBirth);
            this.UserInformation.Controls.Add(this.Rb_fermale);
            this.UserInformation.Controls.Add(this.Rb_male);
            this.UserInformation.Controls.Add(this.Tx_Surname);
            this.UserInformation.Controls.Add(this.Tx_Name);
            this.UserInformation.Controls.Add(this.Tx_tcnumber);
            this.UserInformation.Controls.Add(this.Lb_gender);
            this.UserInformation.Controls.Add(this.Lb_City);
            this.UserInformation.Controls.Add(this.Lb_DateOfBirth);
            this.UserInformation.Controls.Add(this.Lb_Surname);
            this.UserInformation.Controls.Add(this.Lb_Name);
            this.UserInformation.Controls.Add(this.Lb_tc);
            this.UserInformation.Location = new System.Drawing.Point(256, 86);
            this.UserInformation.Name = "UserInformation";
            this.UserInformation.Size = new System.Drawing.Size(616, 304);
            this.UserInformation.TabIndex = 36;
            this.UserInformation.TabStop = false;
            this.UserInformation.Text = "Kullanıcı Bilgileri";
            this.UserInformation.Enter += new System.EventHandler(this.UserInformation_Enter);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Lb_AccountName);
            this.groupBox1.Controls.Add(this.Lb_AccountPass);
            this.groupBox1.Controls.Add(this.Tb_accountPass);
            this.groupBox1.Controls.Add(this.Tb_accountName);
            this.groupBox1.Location = new System.Drawing.Point(9, 285);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(241, 105);
            this.groupBox1.TabIndex = 37;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Hesap Bilgileri";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(884, 80);
            this.pictureBox1.TabIndex = 38;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Lb_header
            // 
            this.Lb_header.AutoSize = true;
            this.Lb_header.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.Lb_header.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Lb_header.ForeColor = System.Drawing.Color.White;
            this.Lb_header.Location = new System.Drawing.Point(0, 18);
            this.Lb_header.Name = "Lb_header";
            this.Lb_header.Size = new System.Drawing.Size(458, 45);
            this.Lb_header.TabIndex = 39;
            this.Lb_header.Text = "DİYETİSYEN EKLEME SİSTEMİ";
            // 
            // Pb_profilePhoto
            // 
            this.Pb_profilePhoto.BackColor = System.Drawing.Color.Transparent;
            this.Pb_profilePhoto.Image = global::DietProject.Properties.Resources.user_profile;
            this.Pb_profilePhoto.Location = new System.Drawing.Point(30, 86);
            this.Pb_profilePhoto.Name = "Pb_profilePhoto";
            this.Pb_profilePhoto.Size = new System.Drawing.Size(185, 188);
            this.Pb_profilePhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Pb_profilePhoto.TabIndex = 40;
            this.Pb_profilePhoto.TabStop = false;
            // 
            // Btn_Register
            // 
            this.Btn_Register.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.Btn_Register.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Btn_Register.FlatAppearance.BorderColor = System.Drawing.Color.MediumSeaGreen;
            this.Btn_Register.FlatAppearance.BorderSize = 0;
            this.Btn_Register.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.Btn_Register.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SpringGreen;
            this.Btn_Register.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Register.Font = new System.Drawing.Font("Yu Gothic UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Btn_Register.ForeColor = System.Drawing.Color.White;
            this.Btn_Register.Location = new System.Drawing.Point(0, 406);
            this.Btn_Register.Name = "Btn_Register";
            this.Btn_Register.Size = new System.Drawing.Size(884, 55);
            this.Btn_Register.TabIndex = 41;
            this.Btn_Register.Text = "KAYDET";
            this.Btn_Register.UseVisualStyleBackColor = false;
            this.Btn_Register.Click += new System.EventHandler(this.Btn_Register_Click);
            // 
            // addNewNutritionistPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(884, 461);
            this.Controls.Add(this.Btn_Register);
            this.Controls.Add(this.Pb_profilePhoto);
            this.Controls.Add(this.Lb_header);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.UserInformation);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "addNewNutritionistPage";
            this.Text = "addNewNutritionistPage";
            this.Load += new System.EventHandler(this.addNewNutritionistPage_Load);
            this.UserInformation.ResumeLayout(false);
            this.UserInformation.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pb_profilePhoto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox Cb_citys;
        private System.Windows.Forms.DateTimePicker Dtp_DateOfBirth;
        private System.Windows.Forms.RadioButton Rb_fermale;
        private System.Windows.Forms.RadioButton Rb_male;
        private System.Windows.Forms.TextBox Tx_Surname;
        private System.Windows.Forms.TextBox Tx_Name;
        private System.Windows.Forms.TextBox Tx_tcnumber;
        private System.Windows.Forms.Label Lb_gender;
        private System.Windows.Forms.Label Lb_City;
        private System.Windows.Forms.Label Lb_DateOfBirth;
        private System.Windows.Forms.Label Lb_Surname;
        private System.Windows.Forms.Label Lb_Name;
        private System.Windows.Forms.Label Lb_tc;
        private System.Windows.Forms.Label Lb_AccountName;
        private System.Windows.Forms.Label Lb_AccountPass;
        private System.Windows.Forms.TextBox Tb_accountName;
        private System.Windows.Forms.TextBox Tb_accountPass;
        private System.Windows.Forms.GroupBox UserInformation;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label Lb_header;
        private System.Windows.Forms.PictureBox Pb_profilePhoto;
        private System.Windows.Forms.Button Btn_Register;
    }
}