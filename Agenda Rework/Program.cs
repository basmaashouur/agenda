﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Agenda_Rework
{
    static class Program
    {
       public static bool load_flag = false;
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        /// 
        //[STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new splash());
            Application.Exit();
        }
    }
}
