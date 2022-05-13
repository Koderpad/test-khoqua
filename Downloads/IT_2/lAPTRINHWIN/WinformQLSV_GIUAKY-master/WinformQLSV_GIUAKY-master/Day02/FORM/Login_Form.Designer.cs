
namespace Day02
{
    partial class Login_Form
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_passWord = new System.Windows.Forms.TextBox();
            this.textBox_UserName = new System.Windows.Forms.TextBox();
            this.bt_Login = new System.Windows.Forms.Button();
            this.bt_regis = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.progressBar_login = new System.Windows.Forms.ProgressBar();
            this.label5 = new System.Windows.Forms.Label();
            this.bt_createNUser = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label1.Location = new System.Drawing.Point(119, 267);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "Username:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label2.Location = new System.Drawing.Point(119, 354);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 31);
            this.label2.TabIndex = 2;
            this.label2.Text = "Password:";
            // 
            // textBox_passWord
            // 
            this.textBox_passWord.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_passWord.Location = new System.Drawing.Point(125, 389);
            this.textBox_passWord.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_passWord.Name = "textBox_passWord";
            this.textBox_passWord.PasswordChar = '*';
            this.textBox_passWord.Size = new System.Drawing.Size(374, 37);
            this.textBox_passWord.TabIndex = 3;
            this.toolTip1.SetToolTip(this.textBox_passWord, "Nhập mật khẩu");
            // 
            // textBox_UserName
            // 
            this.textBox_UserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_UserName.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.textBox_UserName.Location = new System.Drawing.Point(125, 313);
            this.textBox_UserName.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_UserName.Name = "textBox_UserName";
            this.textBox_UserName.Size = new System.Drawing.Size(374, 37);
            this.textBox_UserName.TabIndex = 4;
            this.toolTip1.SetToolTip(this.textBox_UserName, "Nhập tài khoản");
            // 
            // bt_Login
            // 
            this.bt_Login.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(157)))), ((int)(((byte)(88)))));
            this.bt_Login.FlatAppearance.BorderSize = 0;
            this.bt_Login.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Login.ForeColor = System.Drawing.Color.White;
            this.bt_Login.Location = new System.Drawing.Point(125, 481);
            this.bt_Login.Margin = new System.Windows.Forms.Padding(4);
            this.bt_Login.Name = "bt_Login";
            this.bt_Login.Size = new System.Drawing.Size(374, 51);
            this.bt_Login.TabIndex = 6;
            this.bt_Login.Text = "Login";
            this.bt_Login.UseVisualStyleBackColor = false;
            this.bt_Login.Click += new System.EventHandler(this.bt_Login_Click);
            // 
            // bt_regis
            // 
            this.bt_regis.AutoEllipsis = true;
            this.bt_regis.Cursor = System.Windows.Forms.Cursors.Default;
            this.bt_regis.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_regis.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.bt_regis.Location = new System.Drawing.Point(425, 590);
            this.bt_regis.Margin = new System.Windows.Forms.Padding(4);
            this.bt_regis.Name = "bt_regis";
            this.bt_regis.Size = new System.Drawing.Size(112, 30);
            this.bt_regis.TabIndex = 8;
            this.bt_regis.Text = "NewUser?";
            this.bt_regis.UseVisualStyleBackColor = false;
            // 
            // toolTip1
            // 
            this.toolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTip1.ToolTipTitle = "Gợi ý:";
            // 
            // progressBar_login
            // 
            this.progressBar_login.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.progressBar_login.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.progressBar_login.ForeColor = System.Drawing.Color.Honeydew;
            this.progressBar_login.Location = new System.Drawing.Point(-7, 572);
            this.progressBar_login.Margin = new System.Windows.Forms.Padding(4);
            this.progressBar_login.Name = "progressBar_login";
            this.progressBar_login.Size = new System.Drawing.Size(634, 10);
            this.progressBar_login.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label5.Location = new System.Drawing.Point(157, 197);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(313, 36);
            this.label5.TabIndex = 11;
            this.label5.Text = "Login to Your Account";
            // 
            // bt_createNUser
            // 
            this.bt_createNUser.BackColor = System.Drawing.Color.White;
            this.bt_createNUser.FlatAppearance.BorderSize = 0;
            this.bt_createNUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_createNUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_createNUser.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(157)))), ((int)(((byte)(88)))));
            this.bt_createNUser.Location = new System.Drawing.Point(287, 446);
            this.bt_createNUser.Margin = new System.Windows.Forms.Padding(4);
            this.bt_createNUser.Name = "bt_createNUser";
            this.bt_createNUser.Size = new System.Drawing.Size(212, 27);
            this.bt_createNUser.TabIndex = 12;
            this.bt_createNUser.Text = "Create New Account";
            this.bt_createNUser.UseVisualStyleBackColor = false;
            this.bt_createNUser.Click += new System.EventHandler(this.bt_createNUser_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Cross;
            this.pictureBox1.Image = global::Day02.Properties.Resources.icons8_male_user_64;
            this.pictureBox1.Location = new System.Drawing.Point(193, 13);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(255, 180);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Login_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(625, 593);
            this.Controls.Add(this.bt_createNUser);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.progressBar_login);
            this.Controls.Add(this.bt_regis);
            this.Controls.Add(this.bt_Login);
            this.Controls.Add(this.textBox_UserName);
            this.Controls.Add(this.textBox_passWord);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.ForeColor = System.Drawing.SystemColors.GrayText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Login_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login From";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ProgressBar progressBar_login;
        private System.Windows.Forms.Button bt_regis;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_passWord;
        private System.Windows.Forms.TextBox textBox_UserName;
        private System.Windows.Forms.Button bt_Login;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button bt_createNUser;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

