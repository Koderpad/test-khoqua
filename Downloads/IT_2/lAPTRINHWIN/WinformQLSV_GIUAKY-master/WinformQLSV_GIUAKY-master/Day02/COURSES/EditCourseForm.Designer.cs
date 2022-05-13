
namespace Day02
{
    partial class EditCourseForm
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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBox_CourseID = new System.Windows.Forms.ComboBox();
            this.courseBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.myDBDataSet = new Day02.myDBDataSet();
            this.tb_Label = new System.Windows.Forms.TextBox();
            this.tb_Des = new System.Windows.Forms.TextBox();
            this.bt_Edit = new System.Windows.Forms.Button();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.courseTableAdapter = new Day02.myDBDataSetTableAdapters.courseTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.courseBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.myDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Cornsilk;
            this.label1.Location = new System.Drawing.Point(66, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Select Course:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Cornsilk;
            this.label2.Location = new System.Drawing.Point(142, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Label:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Cornsilk;
            this.label3.Location = new System.Drawing.Point(134, 183);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Period:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Cornsilk;
            this.label4.Location = new System.Drawing.Point(93, 261);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "Description:";
            // 
            // comboBox_CourseID
            // 
            this.comboBox_CourseID.DataSource = this.courseBindingSource;
            this.comboBox_CourseID.DisplayMember = "Id";
            this.comboBox_CourseID.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.comboBox_CourseID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_CourseID.Location = new System.Drawing.Point(232, 58);
            this.comboBox_CourseID.Name = "comboBox_CourseID";
            this.comboBox_CourseID.Size = new System.Drawing.Size(310, 33);
            this.comboBox_CourseID.TabIndex = 4;
            this.comboBox_CourseID.ValueMember = "Id";
            this.comboBox_CourseID.SelectedIndexChanged += new System.EventHandler(this.comboBox_CourseID_SelectedIndexChanged);
            // 
            // courseBindingSource
            // 
            this.courseBindingSource.DataMember = "course";
            this.courseBindingSource.DataSource = this.myDBDataSet;
            // 
            // myDBDataSet
            // 
            this.myDBDataSet.DataSetName = "myDBDataSet";
            this.myDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tb_Label
            // 
            this.tb_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Label.Location = new System.Drawing.Point(232, 121);
            this.tb_Label.Multiline = true;
            this.tb_Label.Name = "tb_Label";
            this.tb_Label.Size = new System.Drawing.Size(310, 43);
            this.tb_Label.TabIndex = 5;
            // 
            // tb_Des
            // 
            this.tb_Des.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Des.Location = new System.Drawing.Point(232, 261);
            this.tb_Des.Multiline = true;
            this.tb_Des.Name = "tb_Des";
            this.tb_Des.Size = new System.Drawing.Size(309, 100);
            this.tb_Des.TabIndex = 6;
            // 
            // bt_Edit
            // 
            this.bt_Edit.BackColor = System.Drawing.Color.Green;
            this.bt_Edit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Edit.ForeColor = System.Drawing.SystemColors.Control;
            this.bt_Edit.Location = new System.Drawing.Point(71, 384);
            this.bt_Edit.Name = "bt_Edit";
            this.bt_Edit.Size = new System.Drawing.Size(471, 52);
            this.bt_Edit.TabIndex = 7;
            this.bt_Edit.Text = "Edit";
            this.bt_Edit.UseVisualStyleBackColor = false;
            this.bt_Edit.Click += new System.EventHandler(this.bt_Edit_Click);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDown1.Location = new System.Drawing.Point(232, 188);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(309, 30);
            this.numericUpDown1.TabIndex = 8;
            // 
            // courseTableAdapter
            // 
            this.courseTableAdapter.ClearBeforeFill = true;
            // 
            // EditCourseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(711, 445);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.bt_Edit);
            this.Controls.Add(this.tb_Des);
            this.Controls.Add(this.tb_Label);
            this.Controls.Add(this.comboBox_CourseID);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "EditCourseForm";
            this.Text = "EditCourseForm";
            this.Load += new System.EventHandler(this.EditCourseForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.courseBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.myDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBox_CourseID;
        private System.Windows.Forms.TextBox tb_Label;
        private System.Windows.Forms.TextBox tb_Des;
        private System.Windows.Forms.Button bt_Edit;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private myDBDataSet myDBDataSet;
        private System.Windows.Forms.BindingSource courseBindingSource;
        private myDBDataSetTableAdapters.courseTableAdapter courseTableAdapter;
    }
}