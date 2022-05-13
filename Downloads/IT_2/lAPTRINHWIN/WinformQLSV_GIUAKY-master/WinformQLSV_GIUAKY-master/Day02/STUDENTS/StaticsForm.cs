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
    public partial class StaticsForm : Form
    {
        public StaticsForm()
        {
            InitializeComponent();
        }
        Color paTotalcol;
        Color paMalecol;
        Color paFemalecol;
        private void StaticsForm_Load(object sender, EventArgs e)
        {
            ///
            paTotalcol = panel_Total.BackColor;
            paMalecol = panel_Male.BackColor;
            paFemalecol = panel_Female.BackColor;
            //
            STUDENT std = new STUDENT();
            double total = Convert.ToDouble(std.totalStudent());
            double totalMa = Convert.ToDouble(std.totalMaleStudent());
            double totalFe = Convert.ToDouble(std.totalFemaleStudent());
            //
            double malePer = (totalMa * (100 / total));
            double FemalePer = (totalFe * (100 / total));
            labelTotal.Text = ("Total Students: " + total.ToString());
            labelMale.Text = ("Male: " + (malePer.ToString("0.00")) + "%");
            labelFemale.Text = ("Female: " + (FemalePer.ToString("0.00")) + "%");

        }

        private void labelTotal_MouseEnter(object sender, EventArgs e)
        {
            labelTotal.ForeColor = paTotalcol;
            panel_Total.BackColor = Color.White;
        }

        private void labelTotal_MouseLeave(object sender, EventArgs e)
        {
            labelTotal.ForeColor = Color.White;
            panel_Total.BackColor = paTotalcol;
        }
    }
}
