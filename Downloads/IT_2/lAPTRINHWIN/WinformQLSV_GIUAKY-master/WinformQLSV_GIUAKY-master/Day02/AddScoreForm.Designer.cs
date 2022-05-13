
namespace Day02
{
    partial class AddScoreForm
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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_StdID = new System.Windows.Forms.TextBox();
            this.tb_Score = new System.Windows.Forms.TextBox();
            this.tb_Des = new System.Windows.Forms.TextBox();
            this.comboBoxCourse = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.bt_AddScore = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(58, 211);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 25);
            this.label3.TabIndex = 7;
            this.label3.Text = "Description:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(103, 156);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 25);
            this.label4.TabIndex = 6;
            this.label4.Text = "Score:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(31, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "Select Course:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(63, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "Student ID:";
            // 
            // tb_StdID
            // 
            this.tb_StdID.Enabled = false;
            this.tb_StdID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_StdID.Location = new System.Drawing.Point(192, 45);
            this.tb_StdID.Multiline = true;
            this.tb_StdID.Name = "tb_StdID";
            this.tb_StdID.Size = new System.Drawing.Size(143, 36);
            this.tb_StdID.TabIndex = 8;
            // 
            // tb_Score
            // 
            this.tb_Score.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Score.Location = new System.Drawing.Point(192, 153);
            this.tb_Score.Multiline = true;
            this.tb_Score.Name = "tb_Score";
            this.tb_Score.Size = new System.Drawing.Size(143, 36);
            this.tb_Score.TabIndex = 9;
            // 
            // tb_Des
            // 
            this.tb_Des.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Des.Location = new System.Drawing.Point(192, 211);
            this.tb_Des.Multiline = true;
            this.tb_Des.Name = "tb_Des";
            this.tb_Des.Size = new System.Drawing.Size(319, 128);
            this.tb_Des.TabIndex = 10;
            // 
            // comboBoxCourse
            // 
            this.comboBoxCourse.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxCourse.FormattingEnabled = true;
            this.comboBoxCourse.Location = new System.Drawing.Point(192, 103);
            this.comboBoxCourse.Name = "comboBoxCourse";
            this.comboBoxCourse.Size = new System.Drawing.Size(319, 33);
            this.comboBoxCourse.TabIndex = 11;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(578, 45);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(523, 381);
            this.dataGridView1.TabIndex = 12;
            this.dataGridView1.Click += new System.EventHandler(this.dataGridView1_Click);
            // 
            // bt_AddScore
            // 
            this.bt_AddScore.BackColor = System.Drawing.Color.DodgerBlue;
            this.bt_AddScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_AddScore.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bt_AddScore.Location = new System.Drawing.Point(158, 364);
            this.bt_AddScore.Name = "bt_AddScore";
            this.bt_AddScore.Size = new System.Drawing.Size(177, 53);
            this.bt_AddScore.TabIndex = 13;
            this.bt_AddScore.Text = "Add Score";
            this.bt_AddScore.UseVisualStyleBackColor = false;
            this.bt_AddScore.Click += new System.EventHandler(this.bt_AddScore_Click);
            // 
            // AddScoreForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1158, 438);
            this.Controls.Add(this.bt_AddScore);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.comboBoxCourse);
            this.Controls.Add(this.tb_Des);
            this.Controls.Add(this.tb_Score);
            this.Controls.Add(this.tb_StdID);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AddScoreForm";
            this.Text = "AddScoreForm";
            this.Load += new System.EventHandler(this.AddScoreForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_StdID;
        private System.Windows.Forms.TextBox tb_Score;
        private System.Windows.Forms.TextBox tb_Des;
        private System.Windows.Forms.ComboBox comboBoxCourse;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button bt_AddScore;
    }
}