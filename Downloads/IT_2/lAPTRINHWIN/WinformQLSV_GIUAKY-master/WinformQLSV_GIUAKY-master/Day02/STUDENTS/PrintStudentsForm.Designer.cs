
namespace Day02
{
    partial class PrintStudentsForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button_Check = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.radioButton_No = new System.Windows.Forms.RadioButton();
            this.radioButton_Yes = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.radioButton_Male = new System.Windows.Forms.RadioButton();
            this.radioButton_Female = new System.Windows.Forms.RadioButton();
            this.radioButton_All = new System.Windows.Forms.RadioButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button_SavetoTextFile = new System.Windows.Forms.Button();
            this.button_toPrint = new System.Windows.Forms.Button();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button_Check);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.radioButton_Male);
            this.groupBox1.Controls.Add(this.radioButton_Female);
            this.groupBox1.Controls.Add(this.radioButton_All);
            this.groupBox1.Location = new System.Drawing.Point(16, 15);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(1792, 175);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // button_Check
            // 
            this.button_Check.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.button_Check.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Check.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button_Check.Location = new System.Drawing.Point(1437, 64);
            this.button_Check.Margin = new System.Windows.Forms.Padding(4);
            this.button_Check.Name = "button_Check";
            this.button_Check.Size = new System.Drawing.Size(209, 69);
            this.button_Check.TabIndex = 4;
            this.button_Check.Text = "Check";
            this.button_Check.UseVisualStyleBackColor = false;
            this.button_Check.Click += new System.EventHandler(this.button_Check_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.dateTimePicker2);
            this.groupBox2.Controls.Add(this.dateTimePicker1);
            this.groupBox2.Controls.Add(this.radioButton_No);
            this.groupBox2.Controls.Add(this.radioButton_Yes);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(545, 23);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(848, 144);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(537, 98);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 24);
            this.label3.TabIndex = 5;
            this.label3.Text = "And";
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker2.Location = new System.Drawing.Point(620, 95);
            this.dateTimePicker2.Margin = new System.Windows.Forms.Padding(4);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(153, 28);
            this.dateTimePicker2.TabIndex = 4;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(323, 94);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(4);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(183, 28);
            this.dateTimePicker1.TabIndex = 3;
            // 
            // radioButton_No
            // 
            this.radioButton_No.AutoSize = true;
            this.radioButton_No.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton_No.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.radioButton_No.Location = new System.Drawing.Point(496, 32);
            this.radioButton_No.Margin = new System.Windows.Forms.Padding(4);
            this.radioButton_No.Name = "radioButton_No";
            this.radioButton_No.Size = new System.Drawing.Size(66, 33);
            this.radioButton_No.TabIndex = 2;
            this.radioButton_No.TabStop = true;
            this.radioButton_No.Text = "No";
            this.radioButton_No.UseVisualStyleBackColor = true;
            this.radioButton_No.CheckedChanged += new System.EventHandler(this.radioButton_No_CheckedChanged);
            // 
            // radioButton_Yes
            // 
            this.radioButton_Yes.AutoSize = true;
            this.radioButton_Yes.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton_Yes.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.radioButton_Yes.Location = new System.Drawing.Point(349, 32);
            this.radioButton_Yes.Margin = new System.Windows.Forms.Padding(4);
            this.radioButton_Yes.Name = "radioButton_Yes";
            this.radioButton_Yes.Size = new System.Drawing.Size(76, 33);
            this.radioButton_Yes.TabIndex = 1;
            this.radioButton_Yes.TabStop = true;
            this.radioButton_Yes.Text = "Yes";
            this.radioButton_Yes.UseVisualStyleBackColor = true;
            this.radioButton_Yes.CheckedChanged += new System.EventHandler(this.radioButton_Yes_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(39, 94);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(207, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "Birthday Between:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(39, 34);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(195, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Use Date Range:";
            // 
            // radioButton_Male
            // 
            this.radioButton_Male.AutoSize = true;
            this.radioButton_Male.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton_Male.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.radioButton_Male.Location = new System.Drawing.Point(188, 78);
            this.radioButton_Male.Margin = new System.Windows.Forms.Padding(4);
            this.radioButton_Male.Name = "radioButton_Male";
            this.radioButton_Male.Size = new System.Drawing.Size(87, 33);
            this.radioButton_Male.TabIndex = 2;
            this.radioButton_Male.TabStop = true;
            this.radioButton_Male.Text = "Male";
            this.radioButton_Male.UseVisualStyleBackColor = true;
            // 
            // radioButton_Female
            // 
            this.radioButton_Female.AutoSize = true;
            this.radioButton_Female.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton_Female.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.radioButton_Female.Location = new System.Drawing.Point(352, 78);
            this.radioButton_Female.Margin = new System.Windows.Forms.Padding(4);
            this.radioButton_Female.Name = "radioButton_Female";
            this.radioButton_Female.Size = new System.Drawing.Size(116, 33);
            this.radioButton_Female.TabIndex = 1;
            this.radioButton_Female.TabStop = true;
            this.radioButton_Female.Text = "Female";
            this.radioButton_Female.UseVisualStyleBackColor = true;
            // 
            // radioButton_All
            // 
            this.radioButton_All.AutoSize = true;
            this.radioButton_All.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton_All.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.radioButton_All.Location = new System.Drawing.Point(52, 78);
            this.radioButton_All.Margin = new System.Windows.Forms.Padding(4);
            this.radioButton_All.Name = "radioButton_All";
            this.radioButton_All.Size = new System.Drawing.Size(61, 33);
            this.radioButton_All.TabIndex = 0;
            this.radioButton_All.TabStop = true;
            this.radioButton_All.Text = "All";
            this.radioButton_All.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(16, 197);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(1792, 594);
            this.dataGridView1.TabIndex = 1;
            // 
            // button_SavetoTextFile
            // 
            this.button_SavetoTextFile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.button_SavetoTextFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_SavetoTextFile.ForeColor = System.Drawing.Color.White;
            this.button_SavetoTextFile.Location = new System.Drawing.Point(424, 806);
            this.button_SavetoTextFile.Margin = new System.Windows.Forms.Padding(4);
            this.button_SavetoTextFile.Name = "button_SavetoTextFile";
            this.button_SavetoTextFile.Size = new System.Drawing.Size(340, 70);
            this.button_SavetoTextFile.TabIndex = 2;
            this.button_SavetoTextFile.Text = "Save To Text File";
            this.button_SavetoTextFile.UseVisualStyleBackColor = false;
            this.button_SavetoTextFile.Click += new System.EventHandler(this.button_SavetoTextFile_Click);
            // 
            // button_toPrint
            // 
            this.button_toPrint.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.button_toPrint.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_toPrint.ForeColor = System.Drawing.Color.White;
            this.button_toPrint.Location = new System.Drawing.Point(1069, 806);
            this.button_toPrint.Margin = new System.Windows.Forms.Padding(4);
            this.button_toPrint.Name = "button_toPrint";
            this.button_toPrint.Size = new System.Drawing.Size(340, 70);
            this.button_toPrint.TabIndex = 3;
            this.button_toPrint.Text = "To Printer";
            this.button_toPrint.UseVisualStyleBackColor = false;
            this.button_toPrint.Click += new System.EventHandler(this.button_toPrint_Click);
            // 
            // printDialog1
            // 
            this.printDialog1.UseEXDialog = true;
            // 
            // PrintStudentsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(1824, 891);
            this.Controls.Add(this.button_toPrint);
            this.Controls.Add(this.button_SavetoTextFile);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "PrintStudentsForm";
            this.Text = "Print";
            this.Load += new System.EventHandler(this.Print_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.RadioButton radioButton_No;
        private System.Windows.Forms.RadioButton radioButton_Yes;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton radioButton_Male;
        private System.Windows.Forms.RadioButton radioButton_Female;
        private System.Windows.Forms.RadioButton radioButton_All;
        private System.Windows.Forms.Button button_Check;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button_SavetoTextFile;
        private System.Windows.Forms.Button button_toPrint;
        private System.Windows.Forms.PrintDialog printDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
    }
}