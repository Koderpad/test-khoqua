﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Day02
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new Login_Form());
            AddStudentForm add = new AddStudentForm();
            Login_Form flogin = new Login_Form();
            if (flogin.ShowDialog() == DialogResult.OK)
            {
                Application.Run(new MainForm01());
            }
            else
            {
                Application.Exit();
            }
        }
    }
}
