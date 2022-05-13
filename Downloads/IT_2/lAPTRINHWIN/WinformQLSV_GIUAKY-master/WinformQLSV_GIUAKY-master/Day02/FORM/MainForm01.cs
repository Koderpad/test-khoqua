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
    public partial class MainForm01 : Form
    {
        public MainForm01()
        {
            InitializeComponent();
        }

        private void addNewStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddStudentForm addStF = new AddStudentForm();
            addStF.Show(this);
        }

        private void studentsListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            studentsListForm StdList = new studentsListForm();
            StdList.Show();
        }

        private void staticsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StaticsForm StF = new StaticsForm();
            StF.Show(this);
        }

        private void manageStudentFormToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ManageStudentsForm mStdF = new ManageStudentsForm();
            mStdF.Show(this);
        }

        private void printToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PrintStudentsForm pr = new PrintStudentsForm();
            pr.Show(this);
        }

        private void addCourseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddCourseForm addCourseForm = new AddCourseForm();
            addCourseForm.Show(this);
        }

        private void removeCourseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RemoveCourse removeCourse = new RemoveCourse();
            removeCourse.Show(this);
        }

        private void editCourseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditCourseForm editCourseForm = new EditCourseForm();
            editCourseForm.Show(this);
        }

        private void manageCoursesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ManageCoursesForm manageCoursesForm = new ManageCoursesForm();
            manageCoursesForm.Show(this);
        }

        private void printToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            PrintCoursesForm printCoursesForm = new PrintCoursesForm();
            printCoursesForm.Show(this);
        }

        private void addScoreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddScoreForm addscForm = new AddScoreForm();
            addscForm.Show(this);
        }

        private void removeScoreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RemoveScoreForm removeScoreForm = new RemoveScoreForm();
            removeScoreForm.Show(this);
        }

        private void avgScoreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            avgScoreByCourseForm avgScoreByCourseForm = new avgScoreByCourseForm();
            avgScoreByCourseForm.Show(this);
        }

        private void manageScoreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ManageScoresForm manageScoresForm = new ManageScoresForm();
            manageScoresForm.Show(this);
        }

        private void staticsResultToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StaticsResultForm staticsResultForm = new StaticsResultForm();
            staticsResultForm.Show(this);
        }

        private void aVGResultByScoreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ResultForm resultForm = new ResultForm();
            resultForm.Show(this);
        }

        private void editRemoveToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }


    }
}
