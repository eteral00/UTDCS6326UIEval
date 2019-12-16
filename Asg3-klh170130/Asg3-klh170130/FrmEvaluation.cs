/*
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
 * This is the Form module, which contains handlers for the UI (Wins Form)
 * 
 */


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Asg3_klh170130
{
    /*
     * main form class, FrmEvaluation
     */
    public partial class FrmEvaluation : Form
    {
        AppLogics myAppLogics;
        TechServices myTechServices;
        Point pnlMainLoc;
        int dHeight;
        int dWidth;

        bool fileReady;
        static string exitMsg = "Are you sure you want to close the application now?";
        static string exitLabel = "Exit";
        static string successLabel = "Success";
        static string errorLabel = "Error";
        static string statusLabel = "Status";
        static string statusReady = "Ready.";
        static string msgNoFile = "No input file selected. Please select an input file.";
        static string msgErr = "Error! Please verify that the following input file is in the correct format as per this program's Instructions: ";
        static string msgFileRead = "The Program has successfully read data from file: ";
        static string msgSuccess = "The Program has finished analyzing data (and produced an output file) from file: ";

        /*
         * constructor for form class frmEvaluation
         */
        public FrmEvaluation()
        {
            InitializeComponent();
            this.myAppLogics = new AppLogics();
            this.myTechServices = new TechServices();

        }

        /*
         * Handler for Form Load event
         */
        private void FrmEvaluation_Load(object sender, EventArgs e)
        {
            this.pnlMainLoc = pnlMain.Location;
            this.dHeight = this.Height;
            this.dWidth = this.Width;
            this.tssLabelMain.Text = statusLabel + ": " + statusReady + " " + msgNoFile;
            this.fileReady = false;
        }

        /*
         * Handler for Open File button's click event
         * bring up dialog box for user to select file (text file, *.txt)
         */
        private void btnOpen_Click(object sender, EventArgs e)
        {
            string filePath = string.Empty;
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Multiselect = false;
            ofd.Filter = "Text Files|*.txt";
            ofd.InitialDirectory = Application.StartupPath ;
            DialogResult dr = ofd.ShowDialog();
            if (dr == DialogResult.OK)
            {
                filePath = ofd.FileName;
                this.txtFilePath.Text = filePath;
                if(myTechServices.loadDataFromFile(myAppLogics, filePath))
                    // call TechServices method load, if return value == true, load success, else, error
                {
                    this.tssLabelMain.Text = statusLabel + ": " + msgFileRead + filePath;
                    this.fileReady = true;
                    
                }
                else
                {
                    this.tssLabelMain.Text = statusLabel + ": " + msgErr + filePath;
                    this.fileReady = false;
                }
            }
        }// end handler for Open button's click

        /* a combo of 2 handlers to handle Form Resize event
         * FrmEvaluation_ResizeBegin() + FrmEvaluation_ResizeEnd()
         * keep the main panel (which contains main elements) at the center of the form
         */
        private void FrmEvaluation_ResizeBegin(object sender, EventArgs e)
        {
            this.dHeight = this.Height;
            this.dWidth = this.Width;
            this.pnlMainLoc = this.pnlMain.Location;
        }
        /*
         * this one goes with FrmEvaluation_ResizeBegin to make a combo of handler
         */
        private void FrmEvaluation_ResizeEnd(object sender, EventArgs e)
        {
            this.dHeight = this.Height - this.dHeight;
            this.dWidth = this.Width - this.dWidth;
            this.pnlMainLoc.X += (this.dWidth/2);
            this.pnlMainLoc.Y += (this.dHeight/2);
            this.pnlMain.Location = this.pnlMainLoc;
            this.dHeight = this.Height;
            this.dWidth = this.Width;
        }

        /*
         * Handler for the Form Size Changed event
         * ensure the form size cannot get smaller than the main panel size + padding
         * keep the main panel (and main form elements with it) at the center of the form
         */
        private void FrmEvaluation_SizeChanged(object sender, EventArgs e)
        {
            if(this.Width < (this.pnlMain.Width + 48))
            {
                this.Width = this.pnlMain.Width + 48;
            }
            if (this.Height < (this.pnlMain.Height + 76))
            {
                this.Height = this.pnlMain.Height + 76;
            }

            if(this.dHeight != this.Height)
            {
                this.dHeight = this.Height - this.dHeight;
                this.pnlMainLoc.Y += (this.dHeight / 2);
                this.dHeight = this.Height;
            }
            if(this.dWidth != this.Width)
            {
                this.dWidth = this.Width - this.dWidth;
                this.pnlMainLoc.X += (this.dWidth / 2);
                this.dWidth = this.Width;
            }
            this.pnlMain.Location = this.pnlMainLoc;
        } // end handler for form size changed

        /*
         * Handler for Exit button's click event
         * transfer control to the form closing event
         */
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close(); // transfer to the form closing event
        }

        /*
         * Handler for Form's closing event
         */
        private void FrmEvaluation_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dlgResultExit = MessageBox.Show(FrmEvaluation.exitMsg, FrmEvaluation.exitLabel, MessageBoxButtons.YesNo);
            if (dlgResultExit == DialogResult.No)
            {
                e.Cancel = true;
            }
            else if (dlgResultExit == DialogResult.Yes)
            {
                e.Cancel = false;
            }
        }// end handler for form closing


        /*
         * Handler for Analyze button's click event
         * call the analyze method from AppLogics to analyze the data and return the results for display on form.
         */
        private void btnAnalyze_Click(object sender, EventArgs e)
        {
            if (this.fileReady)
            // only analyze if file is ready
            {
                if (this.myAppLogics.analyzeData())
                // call analyze method, check the return value to see if there was error
                // false = error, true = no error
                {
                    // displaying results
                    this.lblNumOfRecordsData.Text = this.myAppLogics.countOfRecords.ToString();
                    this.lblMinEntryTimeData.Text = this.myAppLogics.minEntryTime.Minutes.ToString() + ":" + this.myAppLogics.minEntryTime.Seconds.ToString();
                    this.lblMaxEntryTimeData.Text = this.myAppLogics.maxEntryTime.Minutes.ToString() + ":" + this.myAppLogics.maxEntryTime.Seconds.ToString();
                    this.lblAvgEntryTimeData.Text = this.myAppLogics.avgEntryTime.Minutes.ToString() + ":" + this.myAppLogics.avgEntryTime.Seconds.ToString();
                    this.lblMinInterTimeData.Text = this.myAppLogics.minInterTime.Minutes.ToString() + ":" + this.myAppLogics.minInterTime.Seconds.ToString();
                    this.lblMaxInterTimeData.Text = this.myAppLogics.maxInterTime.Minutes.ToString() + ":" + this.myAppLogics.maxInterTime.Seconds.ToString();
                    this.lblAvgInterTimeData.Text = this.myAppLogics.avgInterTime.Minutes.ToString() + ":" + this.myAppLogics.avgInterTime.Seconds.ToString();
                    this.lblTotalTimeData.Text = this.myAppLogics.totalTime.Minutes.ToString() + ":" + this.myAppLogics.totalTime.Seconds.ToString();
                    this.lblTotalBackspaceData.Text = this.myAppLogics.countOfBackspace.ToString();

                    // output to file
                    this.myTechServices.writeDataToFile(this.myAppLogics);

                    // change status bar, and
                    // bring up dialog box to indicate successful operation
                    tssLabelMain.Text = statusLabel + ": " + msgSuccess + txtFilePath.Text;
                    MessageBox.Show(msgSuccess + txtFilePath.Text, successLabel);
                }
                else
                // data type error
                {
                    // change status bar, and
                    // bring up dialog box to show error
                    tssLabelMain.Text = statusLabel + ": " + msgErr + txtFilePath.Text;
                    MessageBox.Show(msgErr + txtFilePath.Text, errorLabel);
                }
            }
            else
            // input file is not ready
            // bring up dialog box to show error
            {
                if (txtFilePath.Text == string.Empty)
                {
                    MessageBox.Show(msgErr + msgNoFile, errorLabel);
                }
                else
                {
                    MessageBox.Show(msgErr + txtFilePath.Text, errorLabel);
                }
                
            }
        } // end handler for Analyze button's click


    }// end form class
}// end namespace
