﻿/*
 * Written by Khoa L. D. Ho (klh170130) 
 * for Assignment 3 for class CS6326 Falll 2019, by Professor J. Cole, at UT Dallas,
 * starting Sep 29, 2019, using Visual Studio 2017 on OS Windows 8.1
 * 
 * UI Evaluation Program
 * This program is used to evaluate the usage of the "Rebate Record" program written for another assignment previously.
 * 
 * The user will select an input file, which is an output file from the Rebate Record Program 
 * (That file should contain 16 columns for each record: 13 fields on screen + start time, end/save time, and count of backspace pressed). 
 *
 * The output from this Evaluation program will be displayed on screen, as well as recorded into a file.
 * The output contains analysis on the user's operation on the Rebate Record program through that program's output file.
 * The output will be in this form: 
 * * Number of Records: ##
 * * Minimum entry time: MM:ss
 * * Maximum entry time: MM:nn
 * * Average entry time: MM:nn
 * * Minimum inter-record time: MM:nn
 * * Maximum inter-record time: MM:nn
 * * Average inter-record time: MM:nn
 * * Total time: MM:nn
 * * Total backspace count: ##
 * 
 * This is the ("main") Program class auto generated by Visual Studio
 * 
 */


using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Asg3_klh170130
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
            Application.Run(new FrmEvaluation());
        }
    }
}
