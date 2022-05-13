
namespace Day02
{
    partial class StaticsForm
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
            this.panel_Total = new System.Windows.Forms.Panel();
            this.labelTotal = new System.Windows.Forms.Label();
            this.panel_Male = new System.Windows.Forms.Panel();
            this.labelMale = new System.Windows.Forms.Label();
            this.panel_Female = new System.Windows.Forms.Panel();
            this.labelFemale = new System.Windows.Forms.Label();
            this.panel_Total.SuspendLayout();
            this.panel_Male.SuspendLayout();
            this.panel_Female.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_Total
            // 
            this.panel_Total.BackColor = System.Drawing.Color.SpringGreen;
            this.panel_Total.Controls.Add(this.labelTotal);
            this.panel_Total.Location = new System.Drawing.Point(7, 5);
            this.panel_Total.Name = "panel_Total";
            this.panel_Total.Size = new System.Drawing.Size(699, 316);
            this.panel_Total.TabIndex = 0;
            // 
            // labelTotal
            // 
            this.labelTotal.BackColor = System.Drawing.Color.SlateBlue;
            this.labelTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotal.Location = new System.Drawing.Point(-3, 0);
            this.labelTotal.Name = "labelTotal";
            this.labelTotal.Size = new System.Drawing.Size(701, 316);
            this.labelTotal.TabIndex = 0;
            this.labelTotal.Text = "Total Student: 100%";
            this.labelTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelTotal.MouseEnter += new System.EventHandler(this.labelTotal_MouseEnter);
            this.labelTotal.MouseLeave += new System.EventHandler(this.labelTotal_MouseLeave);
            // 
            // panel_Male
            // 
            this.panel_Male.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel_Male.Controls.Add(this.labelMale);
            this.panel_Male.Location = new System.Drawing.Point(4, 327);
            this.panel_Male.Name = "panel_Male";
            this.panel_Male.Size = new System.Drawing.Size(344, 239);
            this.panel_Male.TabIndex = 1;
            // 
            // labelMale
            // 
            this.labelMale.BackColor = System.Drawing.SystemColors.Desktop;
            this.labelMale.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMale.Location = new System.Drawing.Point(-3, 0);
            this.labelMale.Name = "labelMale";
            this.labelMale.Size = new System.Drawing.Size(344, 239);
            this.labelMale.TabIndex = 0;
            this.labelMale.Text = "Male: 50%";
            this.labelMale.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel_Female
            // 
            this.panel_Female.BackColor = System.Drawing.SystemColors.MenuBar;
            this.panel_Female.Controls.Add(this.labelFemale);
            this.panel_Female.Location = new System.Drawing.Point(354, 327);
            this.panel_Female.Name = "panel_Female";
            this.panel_Female.Size = new System.Drawing.Size(351, 238);
            this.panel_Female.TabIndex = 2;
            // 
            // labelFemale
            // 
            this.labelFemale.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.labelFemale.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFemale.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelFemale.Location = new System.Drawing.Point(0, 0);
            this.labelFemale.Name = "labelFemale";
            this.labelFemale.Size = new System.Drawing.Size(352, 237);
            this.labelFemale.TabIndex = 0;
            this.labelFemale.Text = "Female: 50%";
            this.labelFemale.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // StaticsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(712, 573);
            this.Controls.Add(this.panel_Female);
            this.Controls.Add(this.panel_Male);
            this.Controls.Add(this.panel_Total);
            this.Name = "StaticsForm";
            this.Text = "StaticsForm";
            this.Load += new System.EventHandler(this.StaticsForm_Load);
            this.panel_Total.ResumeLayout(false);
            this.panel_Male.ResumeLayout(false);
            this.panel_Female.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_Total;
        private System.Windows.Forms.Label labelTotal;
        private System.Windows.Forms.Panel panel_Male;
        private System.Windows.Forms.Panel panel_Female;
        private System.Windows.Forms.Label labelMale;
        private System.Windows.Forms.Label labelFemale;
    }
}