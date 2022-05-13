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
    public partial class RemoveScoreForm : Form
    {
        public RemoveScoreForm()
        {
            InitializeComponent();
        }
        SCORE score = new SCORE();
        private void RemoveScoreForm_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = score.getScore();
        }

        private void RemoveScoreForm_Click(object sender, EventArgs e)
        {

        }

        private void bt_AddScore_Click(object sender, EventArgs e)
        {

            try
            {
                if ((MessageBox.Show("Are you sure you want to delete this student score", "Delete Student", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)) == DialogResult.OK)
                {
                    int stdId = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
                    int cId = Convert.ToInt32(dataGridView1.CurrentRow.Cells[1].Value);

                    if (score.deleteScore(stdId, cId))
                    {
                        MessageBox.Show("Score Deleted", "Delete Score", MessageBoxButtons.OK);
                    }
                    else
                    {
                        MessageBox.Show("Score Not Deleted", "Delete Score", MessageBoxButtons.OK);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Delete Student", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
