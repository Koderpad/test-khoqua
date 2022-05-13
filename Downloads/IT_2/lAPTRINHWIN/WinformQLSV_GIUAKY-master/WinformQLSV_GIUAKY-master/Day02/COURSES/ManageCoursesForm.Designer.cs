
namespace Day02
{
    partial class ManageCoursesForm
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
            this.tb_ID = new System.Windows.Forms.TextBox();
            this.tb_Label = new System.Windows.Forms.TextBox();
            this.tb_Description = new System.Windows.Forms.TextBox();
            this.numericUpDown_hoursNum = new System.Windows.Forms.NumericUpDown();
            this.bt_First = new System.Windows.Forms.Button();
            this.bt_Pre = new System.Windows.Forms.Button();
            this.bt_Next = new System.Windows.Forms.Button();
            this.bt_Last = new System.Windows.Forms.Button();
            this.bt_Edit = new System.Windows.Forms.Button();
            this.bt_Remove = new System.Windows.Forms.Button();
            this.bt_Add = new System.Windows.Forms.Button();
            this.listBoxCourses = new System.Windows.Forms.ListBox();
            this.lb_totalCourses = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_hoursNum)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(164, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(127, 131);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "Label:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(30, 218);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(176, 29);
            this.label3.TabIndex = 2;
            this.label3.Text = "Hours Number:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(65, 308);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(141, 29);
            this.label4.TabIndex = 3;
            this.label4.Text = "Description:";
            // 
            // tb_ID
            // 
            this.tb_ID.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_ID.Location = new System.Drawing.Point(235, 49);
            this.tb_ID.Multiline = true;
            this.tb_ID.Name = "tb_ID";
            this.tb_ID.Size = new System.Drawing.Size(154, 30);
            this.tb_ID.TabIndex = 4;
            // 
            // tb_Label
            // 
            this.tb_Label.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Label.Location = new System.Drawing.Point(235, 123);
            this.tb_Label.Multiline = true;
            this.tb_Label.Name = "tb_Label";
            this.tb_Label.Size = new System.Drawing.Size(308, 30);
            this.tb_Label.TabIndex = 6;
            // 
            // tb_Description
            // 
            this.tb_Description.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Description.Location = new System.Drawing.Point(235, 300);
            this.tb_Description.Multiline = true;
            this.tb_Description.Name = "tb_Description";
            this.tb_Description.Size = new System.Drawing.Size(308, 136);
            this.tb_Description.TabIndex = 7;
            // 
            // numericUpDown_hoursNum
            // 
            this.numericUpDown_hoursNum.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDown_hoursNum.Location = new System.Drawing.Point(235, 222);
            this.numericUpDown_hoursNum.Name = "numericUpDown_hoursNum";
            this.numericUpDown_hoursNum.Size = new System.Drawing.Size(153, 33);
            this.numericUpDown_hoursNum.TabIndex = 8;
            this.numericUpDown_hoursNum.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // bt_First
            // 
            this.bt_First.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.bt_First.Cursor = System.Windows.Forms.Cursors.Default;
            this.bt_First.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.bt_First.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_First.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_First.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bt_First.Location = new System.Drawing.Point(50, 484);
            this.bt_First.Name = "bt_First";
            this.bt_First.Size = new System.Drawing.Size(119, 66);
            this.bt_First.TabIndex = 10;
            this.bt_First.Text = "First";
            this.bt_First.UseVisualStyleBackColor = false;
            this.bt_First.Click += new System.EventHandler(this.bt_First_Click);
            // 
            // bt_Pre
            // 
            this.bt_Pre.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.bt_Pre.Cursor = System.Windows.Forms.Cursors.Default;
            this.bt_Pre.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.bt_Pre.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_Pre.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Pre.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bt_Pre.Location = new System.Drawing.Point(383, 484);
            this.bt_Pre.Name = "bt_Pre";
            this.bt_Pre.Size = new System.Drawing.Size(119, 66);
            this.bt_Pre.TabIndex = 11;
            this.bt_Pre.Text = "Previous";
            this.bt_Pre.UseVisualStyleBackColor = false;
            this.bt_Pre.Click += new System.EventHandler(this.bt_Pre_Click);
            // 
            // bt_Next
            // 
            this.bt_Next.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.bt_Next.Cursor = System.Windows.Forms.Cursors.Default;
            this.bt_Next.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.bt_Next.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_Next.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Next.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bt_Next.Location = new System.Drawing.Point(216, 484);
            this.bt_Next.Name = "bt_Next";
            this.bt_Next.Size = new System.Drawing.Size(119, 66);
            this.bt_Next.TabIndex = 12;
            this.bt_Next.Text = "Next";
            this.bt_Next.UseVisualStyleBackColor = false;
            this.bt_Next.Click += new System.EventHandler(this.bt_Next_Click);
            // 
            // bt_Last
            // 
            this.bt_Last.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.bt_Last.Cursor = System.Windows.Forms.Cursors.Default;
            this.bt_Last.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.bt_Last.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_Last.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Last.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bt_Last.Location = new System.Drawing.Point(554, 484);
            this.bt_Last.Name = "bt_Last";
            this.bt_Last.Size = new System.Drawing.Size(119, 66);
            this.bt_Last.TabIndex = 13;
            this.bt_Last.Text = "Last";
            this.bt_Last.UseVisualStyleBackColor = false;
            this.bt_Last.Click += new System.EventHandler(this.bt_Last_Click);
            // 
            // bt_Edit
            // 
            this.bt_Edit.BackColor = System.Drawing.SystemColors.Desktop;
            this.bt_Edit.Cursor = System.Windows.Forms.Cursors.Default;
            this.bt_Edit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.bt_Edit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_Edit.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Edit.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bt_Edit.Location = new System.Drawing.Point(290, 612);
            this.bt_Edit.Name = "bt_Edit";
            this.bt_Edit.Size = new System.Drawing.Size(127, 66);
            this.bt_Edit.TabIndex = 16;
            this.bt_Edit.Text = "Edit";
            this.bt_Edit.UseVisualStyleBackColor = false;
            this.bt_Edit.Click += new System.EventHandler(this.bt_Edit_Click);
            // 
            // bt_Remove
            // 
            this.bt_Remove.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.bt_Remove.Cursor = System.Windows.Forms.Cursors.Default;
            this.bt_Remove.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.bt_Remove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_Remove.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Remove.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bt_Remove.Location = new System.Drawing.Point(457, 612);
            this.bt_Remove.Name = "bt_Remove";
            this.bt_Remove.Size = new System.Drawing.Size(127, 66);
            this.bt_Remove.TabIndex = 15;
            this.bt_Remove.Text = "Remove";
            this.bt_Remove.UseVisualStyleBackColor = false;
            this.bt_Remove.Click += new System.EventHandler(this.bt_Remove_Click);
            // 
            // bt_Add
            // 
            this.bt_Add.BackColor = System.Drawing.Color.Red;
            this.bt_Add.Cursor = System.Windows.Forms.Cursors.Default;
            this.bt_Add.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.bt_Add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_Add.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Add.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bt_Add.Location = new System.Drawing.Point(124, 612);
            this.bt_Add.Name = "bt_Add";
            this.bt_Add.Size = new System.Drawing.Size(127, 66);
            this.bt_Add.TabIndex = 14;
            this.bt_Add.Text = "Add";
            this.bt_Add.UseVisualStyleBackColor = false;
            this.bt_Add.Click += new System.EventHandler(this.bt_Add_Click);
            // 
            // listBoxCourses
            // 
            this.listBoxCourses.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxCourses.FormattingEnabled = true;
            this.listBoxCourses.ItemHeight = 27;
            this.listBoxCourses.Location = new System.Drawing.Point(750, 49);
            this.listBoxCourses.MultiColumn = true;
            this.listBoxCourses.Name = "listBoxCourses";
            this.listBoxCourses.Size = new System.Drawing.Size(411, 544);
            this.listBoxCourses.TabIndex = 17;
            this.listBoxCourses.Click += new System.EventHandler(this.listBoxCourses_Click);
            // 
            // lb_totalCourses
            // 
            this.lb_totalCourses.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lb_totalCourses.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_totalCourses.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lb_totalCourses.Location = new System.Drawing.Point(949, 596);
            this.lb_totalCourses.Name = "lb_totalCourses";
            this.lb_totalCourses.Size = new System.Drawing.Size(212, 32);
            this.lb_totalCourses.TabIndex = 18;
            this.lb_totalCourses.Text = "Total Courses:";
            this.lb_totalCourses.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ManageCoursesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(1177, 704);
            this.Controls.Add(this.lb_totalCourses);
            this.Controls.Add(this.listBoxCourses);
            this.Controls.Add(this.bt_Edit);
            this.Controls.Add(this.bt_Remove);
            this.Controls.Add(this.bt_Add);
            this.Controls.Add(this.bt_Last);
            this.Controls.Add(this.bt_Next);
            this.Controls.Add(this.bt_Pre);
            this.Controls.Add(this.bt_First);
            this.Controls.Add(this.numericUpDown_hoursNum);
            this.Controls.Add(this.tb_Description);
            this.Controls.Add(this.tb_Label);
            this.Controls.Add(this.tb_ID);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft YaHei UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "ManageCoursesForm";
            this.Text = "ManageCoursesForm";
            this.Load += new System.EventHandler(this.ManageCoursesForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_hoursNum)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_ID;
        private System.Windows.Forms.TextBox tb_Label;
        private System.Windows.Forms.TextBox tb_Description;
        private System.Windows.Forms.NumericUpDown numericUpDown_hoursNum;
        private System.Windows.Forms.Button bt_First;
        private System.Windows.Forms.Button bt_Pre;
        private System.Windows.Forms.Button bt_Next;
        private System.Windows.Forms.Button bt_Last;
        private System.Windows.Forms.Button bt_Edit;
        private System.Windows.Forms.Button bt_Remove;
        private System.Windows.Forms.Button bt_Add;
        private System.Windows.Forms.ListBox listBoxCourses;
        private System.Windows.Forms.Label lb_totalCourses;
    }
}