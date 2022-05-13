using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Day02
{
    public partial class PrintStudentsForm : Form
    {
        public PrintStudentsForm()
        {
            InitializeComponent();
        }

        STUDENT student = new STUDENT();

        private void Print_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'myDBDataSet.std' table. You can move, or remove it, as needed.
            //this.stdTableAdapter.Fill(this.myDBDataSet.std);
            FillGrid(new SqlCommand("SELECT * FROM std"));

            if (radioButton_No.Checked)
            {
                radioBtNo();
            }
        }

        private void radioBtYES()
        {
            dateTimePicker1.Enabled = true;
            dateTimePicker2.Enabled = true;
        }

        private void radioBtNo()
        {
            dateTimePicker1.Enabled = false;
            dateTimePicker2.Enabled = false;
        }

        private void FillGrid(SqlCommand cmd)
        {
            dataGridView1.ReadOnly = true;
            //xử lý hình ảnh
            DataGridViewImageColumn picCol = new DataGridViewImageColumn();
            dataGridView1.RowTemplate.Height = 80;
            dataGridView1.DataSource = student.getStudents(cmd);
            picCol = (DataGridViewImageColumn)dataGridView1.Columns[8];
            picCol.ImageLayout = DataGridViewImageCellLayout.Stretch;
            dataGridView1.AllowUserToAddRows = false;
        }

        private void radioButton_Yes_CheckedChanged(object sender, EventArgs e)
        {
            radioBtYES();
        }

        private void radioButton_No_CheckedChanged(object sender, EventArgs e)
        {
            radioBtNo();
        }

        private void button_Check_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand();
            string query="";
            if (radioButton_Yes.Checked)
            {
                string date1 = dateTimePicker1.Value.ToString("yyyy-MM-dd");
                string date2 = dateTimePicker2.Value.ToString("yyyy-MM-dd");

                if (radioButton_Male.Checked)
                {
                    query = "SELECT * FROM std WHERE gender = 'Male' and bdate BETWEEN '" + date1 + "' and '" +
                        date2 + "'";
                }
                if (radioButton_Female.Checked)
                {
                    query = "SELECT * FROM std WHERE gender = 'Female' and bdate BETWEEN '" + date1 + "' and '" +
                        date2 + "'";
                }
                if (radioButton_All.Checked)
                {
                    query = "SELECT * FROM std WHERE bdate BETWEEN '" + date1 + "' and '" +
                        date2 + "'";
                }
            }
            else
            {
                if (radioButton_Male.Checked)
                {
                    query = "SELECT * FROM std WHERE gender = 'Male'";
                }
                else if (radioButton_Female.Checked)
                {
                    query = "SELECT * FROM std WHERE gender = 'Female'";
                }
                else
                {
                    query = "SELECT * FROM std";
                }
            }
            cmd.CommandText = query;
            FillGrid(cmd);
        }

        private void button_SavetoTextFile_Click(object sender, EventArgs e)
        {
            String path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\students_List.txt";

            using (var writer = new StreamWriter(path))
            {
                if (!File.Exists(path))
                {
                    File.Create(path);
                }

                DateTime bdate;

                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    for (int j = 0; j < dataGridView1.Columns.Count-1; j++)
                    {
                        if (j == 3)
                        {
                            bdate = Convert.ToDateTime(dataGridView1.Rows[i].Cells[j].Value.ToString());

                            writer.Write("\t" + bdate.ToString("yyyy-MM-dd"));
                        }
                        else if (j == dataGridView1.Columns.Count - 2)
                        {
                            writer.Write("\t" + dataGridView1.Rows[i].Cells[j].Value.ToString());
                        }
                        else
                        {
                            writer.Write("\t" + dataGridView1.Rows[i].Cells[j].Value.ToString() + "\t" + "|");
                        }
                        
                    }
                    writer.WriteLine("");
                    writer.WriteLine("---------------------------------------------------------------------------------------------------------");
                }
            }
        }

        private void button_toPrint_Click(object sender, EventArgs e)
        {
            PrintDialog printDlg = new PrintDialog();
            PrintDocument prDoc = new PrintDocument();

            prDoc.DocumentName = "Print Document";
            printDlg.Document = prDoc;
            printDlg.AllowSelection = true;
            printDlg.AllowSomePages = true;

            if (printDlg.ShowDialog() == DialogResult.OK)
                prDoc.Print();
        }
    }
}
