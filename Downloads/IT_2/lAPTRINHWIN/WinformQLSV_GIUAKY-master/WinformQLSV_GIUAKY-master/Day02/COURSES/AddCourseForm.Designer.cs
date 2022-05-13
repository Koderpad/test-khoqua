
namespace Day02
{
    partial class AddCourseForm
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
            this.label4 = new System.Windows.Forms.Label();
            this.tb_CourseID = new System.Windows.Forms.TextBox();
            this.tb_Period = new System.Windows.Forms.TextBox();
            this.tb_Label = new System.Windows.Forms.TextBox();
            this.tb_Description = new System.Windows.Forms.TextBox();
            this.bt_AddCourse = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(47, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Course ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(87, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Label:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(38, 213);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 25);
            this.label3.TabIndex = 3;
            this.label3.Text = "Description:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(79, 153);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 25);
            this.label4.TabIndex = 2;
            this.label4.Text = "Period:";
            // 
            // tb_CourseID
            // 
            this.tb_CourseID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_CourseID.Location = new System.Drawing.Point(222, 40);
            this.tb_CourseID.Multiline = true;
            this.tb_CourseID.Name = "tb_CourseID";
            this.tb_CourseID.Size = new System.Drawing.Size(255, 30);
            this.tb_CourseID.TabIndex = 4;
            // 
            // tb_Period
            // 
            this.tb_Period.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Period.Location = new System.Drawing.Point(222, 153);
            this.tb_Period.Multiline = true;
            this.tb_Period.Name = "tb_Period";
            this.tb_Period.Size = new System.Drawing.Size(255, 30);
            this.tb_Period.TabIndex = 5;
            // 
            // tb_Label
            // 
            this.tb_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Label.Location = new System.Drawing.Point(222, 92);
            this.tb_Label.Multiline = true;
            this.tb_Label.Name = "tb_Label";
            this.tb_Label.Size = new System.Drawing.Size(371, 40);
            this.tb_Label.TabIndex = 6;
            // 
            // tb_Description
            // 
            this.tb_Description.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Description.Location = new System.Drawing.Point(222, 213);
            this.tb_Description.Multiline = true;
            this.tb_Description.Name = "tb_Description";
            this.tb_Description.Size = new System.Drawing.Size(371, 108);
            this.tb_Description.TabIndex = 7;
            // 
            // bt_AddCourse
            // 
            this.bt_AddCourse.BackColor = System.Drawing.Color.DodgerBlue;
            this.bt_AddCourse.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_AddCourse.Location = new System.Drawing.Point(276, 385);
            this.bt_AddCourse.Name = "bt_AddCourse";
            this.bt_AddCourse.Size = new System.Drawing.Size(177, 53);
            this.bt_AddCourse.TabIndex = 8;
            this.bt_AddCourse.Text = "Add";
            this.bt_AddCourse.UseVisualStyleBackColor = false;
            this.bt_AddCourse.Click += new System.EventHandler(this.bt_AddCourse_Click);
            // 
            // AddCourseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Blue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bt_AddCourse);
            this.Controls.Add(this.tb_Description);
            this.Controls.Add(this.tb_Label);
            this.Controls.Add(this.tb_Period);
            this.Controls.Add(this.tb_CourseID);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AddCourseForm";
            this.Text = "AddCourseForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_CourseID;
        private System.Windows.Forms.TextBox tb_Period;
        private System.Windows.Forms.TextBox tb_Label;
        private System.Windows.Forms.TextBox tb_Description;
        private System.Windows.Forms.Button bt_AddCourse;
    }
}