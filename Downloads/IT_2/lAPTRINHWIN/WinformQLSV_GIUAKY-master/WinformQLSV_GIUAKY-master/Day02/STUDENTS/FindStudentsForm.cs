using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Day02
{
    public partial class FindStudentsForm : Form
    {
        public FindStudentsForm()
        {
            InitializeComponent();
        }

        STUDENT student = new STUDENT();
        public string cmd;
        private void FindStudentsForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'myDBDataSet.std' table. You can move, or remove it, as needed.
            // TODO: This line of code loads data into the 'myDBDataSet1.std' table. You can move, or remove it, as needed.
            //            this.stdTableAdapter.Fill(this.myDBDataSet1.std);
            //SqlCommand command = new SqlCommand("SELECT * FROM std");
            SqlCommand command = new SqlCommand(cmd);
            DataGridView1.ReadOnly = true;
            //xử lý hình ảnh
            DataGridViewImageColumn picCol = new DataGridViewImageColumn();
            DataGridView1.RowTemplate.Height = 80;
            DataGridView1.DataSource = student.getStudents(command);
            picCol = (DataGridViewImageColumn)DataGridView1.Columns[8];
            picCol.ImageLayout = DataGridViewImageCellLayout.Stretch;
            DataGridView1.AllowUserToAddRows = false;
            

        }

        private void bt_Refresh_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand(cmd);
            DataGridView1.ReadOnly = true;
            //xử lý hình ảnh
            DataGridViewImageColumn picCol = new DataGridViewImageColumn();
            DataGridView1.RowTemplate.Height = 80;
            DataGridView1.DataSource = student.getStudents(command);
            picCol = (DataGridViewImageColumn)DataGridView1.Columns[8];
            picCol.ImageLayout = DataGridViewImageCellLayout.Stretch;
            DataGridView1.AllowUserToAddRows = false;
        }
    }
}
