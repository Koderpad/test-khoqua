
namespace Day02
{
    partial class Form_registration
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_userRegis = new System.Windows.Forms.TextBox();
            this.tb_PasswordRegis = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_rePasswordRegis = new System.Windows.Forms.TextBox();
            this.bt_Regis = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label1.Location = new System.Drawing.Point(108, 40);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(627, 69);
            this.label1.TabIndex = 0;
            this.label1.Text = "New User Registration";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label2.Location = new System.Drawing.Point(64, 158);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(147, 31);
            this.label2.TabIndex = 1;
            this.label2.Text = "Username:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label3.Location = new System.Drawing.Point(64, 225);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(142, 31);
            this.label3.TabIndex = 2;
            this.label3.Text = "Password:";
            // 
            // tb_userRegis
            // 
            this.tb_userRegis.Location = new System.Drawing.Point(326, 158);
            this.tb_userRegis.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tb_userRegis.Name = "tb_userRegis";
            this.tb_userRegis.Size = new System.Drawing.Size(316, 22);
            this.tb_userRegis.TabIndex = 3;
            this.tb_userRegis.MouseMove += new System.Windows.Forms.MouseEventHandler(this.tb_userRegis_MouseMove);
            // 
            // tb_PasswordRegis
            // 
            this.tb_PasswordRegis.Location = new System.Drawing.Point(326, 230);
            this.tb_PasswordRegis.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tb_PasswordRegis.Name = "tb_PasswordRegis";
            this.tb_PasswordRegis.PasswordChar = '^';
            this.tb_PasswordRegis.Size = new System.Drawing.Size(316, 22);
            this.tb_PasswordRegis.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label4.Location = new System.Drawing.Point(64, 316);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(186, 31);
            this.label4.TabIndex = 5;
            this.label4.Text = "Re-Password:";
            // 
            // tb_rePasswordRegis
            // 
            this.tb_rePasswordRegis.Location = new System.Drawing.Point(326, 322);
            this.tb_rePasswordRegis.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tb_rePasswordRegis.Name = "tb_rePasswordRegis";
            this.tb_rePasswordRegis.PasswordChar = '^';
            this.tb_rePasswordRegis.Size = new System.Drawing.Size(316, 22);
            this.tb_rePasswordRegis.TabIndex = 6;
            this.tb_rePasswordRegis.Leave += new System.EventHandler(this.tb_rePasswordRegis_Leave);
            // 
            // bt_Regis
            // 
            this.bt_Regis.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.bt_Regis.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Regis.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.bt_Regis.Location = new System.Drawing.Point(325, 410);
            this.bt_Regis.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bt_Regis.Name = "bt_Regis";
            this.bt_Regis.Size = new System.Drawing.Size(317, 38);
            this.bt_Regis.TabIndex = 7;
            this.bt_Regis.Text = "New User Registration";
            this.bt_Regis.UseVisualStyleBackColor = false;
            this.bt_Regis.Click += new System.EventHandler(this.bt_Regis_Click);
            // 
            // Form_registration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(814, 554);
            this.Controls.Add(this.bt_Regis);
            this.Controls.Add(this.tb_rePasswordRegis);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tb_PasswordRegis);
            this.Controls.Add(this.tb_userRegis);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.SystemColors.Control;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form_registration";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form_registration";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_userRegis;
        private System.Windows.Forms.TextBox tb_PasswordRegis;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_rePasswordRegis;
        private System.Windows.Forms.Button bt_Regis;
    }
}