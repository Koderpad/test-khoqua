
namespace Day02
{
    partial class RemoveCourse
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
            this.bt_remove = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_courseID = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // bt_remove
            // 
            this.bt_remove.BackColor = System.Drawing.Color.Red;
            this.bt_remove.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_remove.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bt_remove.Location = new System.Drawing.Point(593, 80);
            this.bt_remove.Name = "bt_remove";
            this.bt_remove.Size = new System.Drawing.Size(148, 42);
            this.bt_remove.TabIndex = 0;
            this.bt_remove.Text = "Remove";
            this.bt_remove.UseVisualStyleBackColor = false;
            this.bt_remove.Click += new System.EventHandler(this.bt_remove_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(42, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(197, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Enter The Course ID:";
            // 
            // tb_courseID
            // 
            this.tb_courseID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_courseID.Location = new System.Drawing.Point(245, 86);
            this.tb_courseID.Name = "tb_courseID";
            this.tb_courseID.Size = new System.Drawing.Size(296, 30);
            this.tb_courseID.TabIndex = 2;
            // 
            // RemoveCourse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumTurquoise;
            this.ClientSize = new System.Drawing.Size(800, 191);
            this.Controls.Add(this.tb_courseID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bt_remove);
            this.Name = "RemoveCourse";
            this.Text = "RemoveCourse";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bt_remove;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_courseID;
    }
}