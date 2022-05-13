using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Day02
{
    public partial class avgScoreByCourseForm : Form
    {
        public avgScoreByCourseForm()
        {
            InitializeComponent();
        }
        SCORE score = new SCORE();
        private void avgScoreByCourseForm_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = score.getAvgScoreByCourse();
        }
    }
}
