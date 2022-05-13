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
    public partial class RemoveCourse : Form
    {
        public RemoveCourse()
        {
            InitializeComponent();
        }
        COURSES course = new COURSES();
        private void bt_remove_Click(object sender, EventArgs e)
        {
            if (course.removeCourse(tb_courseID.Text))
            {
                MessageBox.Show("Success remove!!", "Annouce", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                MessageBox.Show("Fail remove!!", "Annouce", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
