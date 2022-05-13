
namespace Day02
{
    partial class ManageScoresForm
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
            this.bt_AddScore = new System.Windows.Forms.Button();
            this.comboBoxCourse = new System.Windows.Forms.ComboBox();
            this.tb_Score = new System.Windows.Forms.TextBox();
            this.tb_StdID = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.bt_AvgSByCourse = new System.Windows.Forms.Button();
            this.bt_Remove = new System.Windows.Forms.Button();
            this.bt_showStd = new System.Windows.Forms.Button();
            this.bt_showScore = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tb_Des = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // bt_AddScore
            // 
            this.bt_AddScore.BackColor = System.Drawing.Color.DodgerBlue;
            this.bt_AddScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_AddScore.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bt_AddScore.Location = new System.Drawing.Point(92, 407);
            this.bt_AddScore.Name = "bt_AddScore";
            this.bt_AddScore.Size = new System.Drawing.Size(177, 53);
            this.bt_AddScore.TabIndex = 22;
            this.bt_AddScore.Text = "Add Score";
            this.bt_AddScore.UseVisualStyleBackColor = false;
            // 
            // comboBoxCourse
            // 
            this.comboBoxCourse.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxCourse.FormattingEnabled = true;
            this.comboBoxCourse.Location = new System.Drawing.Point(176, 118);
            this.comboBoxCourse.Name = "comboBoxCourse";
            this.comboBoxCourse.Size = new System.Drawing.Size(319, 33);
            this.comboBoxCourse.TabIndex = 21;
            // 
            // tb_Score
            // 
            this.tb_Score.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Score.Location = new System.Drawing.Point(176, 168);
            this.tb_Score.Multiline = true;
            this.tb_Score.Name = "tb_Score";
            this.tb_Score.Size = new System.Drawing.Size(143, 36);
            this.tb_Score.TabIndex = 19;
            // 
            // tb_StdID
            // 
            this.tb_StdID.Enabled = false;
            this.tb_StdID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_StdID.Location = new System.Drawing.Point(176, 60);
            this.tb_StdID.Multiline = true;
            this.tb_StdID.Name = "tb_StdID";
            this.tb_StdID.Size = new System.Drawing.Size(143, 36);
            this.tb_StdID.TabIndex = 18;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(42, 226);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 25);
            this.label3.TabIndex = 17;
            this.label3.Text = "Description:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(87, 171);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 25);
            this.label4.TabIndex = 16;
            this.label4.Text = "Score:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(15, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 25);
            this.label2.TabIndex = 15;
            this.label2.Text = "Select Course:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(47, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 25);
            this.label1.TabIndex = 14;
            this.label1.Text = "Student ID:";
            // 
            // bt_AvgSByCourse
            // 
            this.bt_AvgSByCourse.BackColor = System.Drawing.Color.SteelBlue;
            this.bt_AvgSByCourse.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_AvgSByCourse.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bt_AvgSByCourse.Location = new System.Drawing.Point(92, 511);
            this.bt_AvgSByCourse.Name = "bt_AvgSByCourse";
            this.bt_AvgSByCourse.Size = new System.Drawing.Size(421, 53);
            this.bt_AvgSByCourse.TabIndex = 23;
            this.bt_AvgSByCourse.Text = "Averange Score By Course";
            this.bt_AvgSByCourse.UseVisualStyleBackColor = false;
            this.bt_AvgSByCourse.Click += new System.EventHandler(this.bt_AvgSByCourse_Click);
            // 
            // bt_Remove
            // 
            this.bt_Remove.BackColor = System.Drawing.Color.Red;
            this.bt_Remove.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Remove.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bt_Remove.Location = new System.Drawing.Point(336, 407);
            this.bt_Remove.Name = "bt_Remove";
            this.bt_Remove.Size = new System.Drawing.Size(177, 53);
            this.bt_Remove.TabIndex = 24;
            this.bt_Remove.Text = "Remove";
            this.bt_Remove.UseVisualStyleBackColor = false;
            // 
            // bt_showStd
            // 
            this.bt_showStd.Location = new System.Drawing.Point(572, 60);
            this.bt_showStd.Name = "bt_showStd";
            this.bt_showStd.Size = new System.Drawing.Size(196, 36);
            this.bt_showStd.TabIndex = 25;
            this.bt_showStd.Text = "Show Students";
            this.bt_showStd.UseVisualStyleBackColor = true;
            this.bt_showStd.Click += new System.EventHandler(this.bt_showStd_Click);
            // 
            // bt_showScore
            // 
            this.bt_showScore.Location = new System.Drawing.Point(1016, 60);
            this.bt_showScore.Name = "bt_showScore";
            this.bt_showScore.Size = new System.Drawing.Size(196, 36);
            this.bt_showScore.TabIndex = 26;
            this.bt_showScore.Text = "Show Score";
            this.bt_showScore.UseVisualStyleBackColor = true;
            this.bt_showScore.Click += new System.EventHandler(this.bt_showScore_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(572, 110);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(640, 349);
            this.dataGridView1.TabIndex = 27;
            this.dataGridView1.Click += new System.EventHandler(this.dataGridView1_Click_1);
            this.dataGridView1.DoubleClick += new System.EventHandler(this.dataGridView1_DoubleClick);
            // 
            // tb_Des
            // 
            this.tb_Des.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Des.Location = new System.Drawing.Point(176, 226);
            this.tb_Des.Multiline = true;
            this.tb_Des.Name = "tb_Des";
            this.tb_Des.Size = new System.Drawing.Size(319, 128);
            this.tb_Des.TabIndex = 28;
            // 
            // ManageScoresForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1238, 597);
            this.Controls.Add(this.tb_Des);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.bt_showScore);
            this.Controls.Add(this.bt_showStd);
            this.Controls.Add(this.bt_Remove);
            this.Controls.Add(this.bt_AvgSByCourse);
            this.Controls.Add(this.bt_AddScore);
            this.Controls.Add(this.comboBoxCourse);
            this.Controls.Add(this.tb_Score);
            this.Controls.Add(this.tb_StdID);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ManageScoresForm";
            this.Text = "ManageScoresForm";
            this.Load += new System.EventHandler(this.ManageScoresForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bt_AddScore;
        private System.Windows.Forms.ComboBox comboBoxCourse;
        private System.Windows.Forms.TextBox tb_Score;
        private System.Windows.Forms.TextBox tb_StdID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bt_AvgSByCourse;
        private System.Windows.Forms.Button bt_Remove;
        private System.Windows.Forms.Button bt_showStd;
        private System.Windows.Forms.Button bt_showScore;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox tb_Des;
    }
}