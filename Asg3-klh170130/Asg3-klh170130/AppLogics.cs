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
 * This is the AppLogics module, which contains the main logics/operations of the program.
 * 
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Asg3_klh170130
{
    /* AppLogics class, the module to contain the main logics/operations behind the program
     * 
     */
    public class AppLogics
    {
        public DataSet dsData;

        /*
         * data members to store analysis data for output
         */
        public int countOfRecords;
        public int countOfBackspace;
        public TimeSpan totalTime;
        public TimeSpan maxEntryTime;
        public TimeSpan minEntryTime;
        public TimeSpan avgEntryTime;
        public TimeSpan maxInterTime;
        public TimeSpan minInterTime;
        public TimeSpan avgInterTime;


        /* constructor for this class
         * create the 1st data table, "RebateRecords", as it is constructed
         */
        public AppLogics()
        {
            this.dsData = new DataSet();
            this.dsData.Tables.Add("RebateRecords");
            this.dsData.Tables["RebateRecords"].Columns.Add("FirstName");
            this.dsData.Tables["RebateRecords"].Columns.Add("MiddleInitial");
            this.dsData.Tables["RebateRecords"].Columns.Add("LastName");
            this.dsData.Tables["RebateRecords"].Columns.Add("Address1");
            this.dsData.Tables["RebateRecords"].Columns.Add("Address2");
            this.dsData.Tables["RebateRecords"].Columns.Add("City");
            this.dsData.Tables["RebateRecords"].Columns.Add("State");
            this.dsData.Tables["RebateRecords"].Columns.Add("Zip");
            this.dsData.Tables["RebateRecords"].Columns.Add("Gender");
            this.dsData.Tables["RebateRecords"].Columns.Add("Phone");
            this.dsData.Tables["RebateRecords"].Columns.Add("Email");
            this.dsData.Tables["RebateRecords"].Columns.Add("Proof");
            this.dsData.Tables["RebateRecords"].Columns.Add("DateReceived");
            this.dsData.Tables["RebateRecords"].Columns.Add("EntryTime");
            this.dsData.Tables["RebateRecords"].Columns.Add("SaveTime");
            this.dsData.Tables["RebateRecords"].Columns.Add("BackspaceCount");

        }// end constructor


        /*
         * method to count the number of records (rows) in a table
         * tableName = name of target table to count, optional, default = "RebateRecords"
         */
        public int countRecords(string tableName="RebateRecords")
        {
            this.countOfRecords = this.dsData.Tables[tableName].Rows.Count;
            return this.countOfRecords;
        } // end countRecords()


        /*
         * method to analyze the data
         * assign the respective result values to this instance's member variables
         * return a boolean true/false indicating whether the process succeeded (without error)
         * tableName = name of target table to analyze, optional, default = "RebateRecords"
         */

        public bool analyzeData(string tableName = "RebateRecords")
        {
            bool success = false;

            this.countOfRecords = this.dsData.Tables[tableName].Rows.Count;
            this.countOfBackspace = 0; // reset count of backspaces
            
            try
            {
                // start time = entry time of 1st record
                DateTime startTime = DateTime.Parse(this.dsData.Tables[tableName].Rows[0]["EntryTime"].ToString());
                //end time = save time of last record
                DateTime endTime = DateTime.Parse(this.dsData.Tables[tableName].Rows[countOfRecords - 1]["SaveTime"].ToString());
                // total time = end time - start time 
                this.totalTime = endTime - startTime;

                TimeSpan[] entryDuration = new TimeSpan[this.countOfRecords];
                TimeSpan[] interDuration = new TimeSpan[this.countOfRecords - 1];

                for (int idx = 0; idx < countOfRecords; idx++)
                {
                    startTime = DateTime.Parse(this.dsData.Tables[tableName].Rows[idx]["EntryTime"].ToString());
                    endTime = DateTime.Parse(this.dsData.Tables[tableName].Rows[idx]["SaveTime"].ToString());
                    // entry duration = save time - entry time, same record
                    entryDuration[idx] = endTime - startTime;

                    // at the same time, count the total backspace
                    this.countOfBackspace += Convert.ToInt32( this.dsData.Tables[tableName].Rows[idx]["BackspaceCount"].ToString() );
                }
                for (int idx = 0; idx < (countOfRecords - 1); idx++)
                {
                    startTime = DateTime.Parse(this.dsData.Tables[tableName].Rows[idx]["SaveTime"].ToString());
                    endTime = DateTime.Parse(this.dsData.Tables[tableName].Rows[idx + 1]["EntryTime"].ToString());
                    // inter duration = entry time of next record - save time of this record,
                    // there will be 1 fewer inter duration than number of records, i.e. if 10 records then only 9 inter durations
                    interDuration[idx] = endTime - startTime;

                }

                // entry duration set
                this.minEntryTime = entryDuration.Min<TimeSpan>();
                this.maxEntryTime = entryDuration.Max<TimeSpan>();
                double dbAvgEntryTimeTicks = entryDuration.Average(timeSpan => timeSpan.Ticks);
                long longAvgEntryTimeTicks = Convert.ToInt64(dbAvgEntryTimeTicks);
                this.avgEntryTime = new TimeSpan(longAvgEntryTimeTicks);

                // inter duration set
                this.minInterTime = interDuration.Min<TimeSpan>();
                this.maxInterTime = interDuration.Max<TimeSpan>();
                double dbAvgInterTimeTicks = interDuration.Average(timeSpan => timeSpan.Ticks);
                long longAvgInterTimeTicks = Convert.ToInt64(dbAvgInterTimeTicks);
                this.avgInterTime = new TimeSpan(longAvgInterTimeTicks);

                return success = true;
            } // end try
            catch (Exception e)
            {
                return success = false;         
            }// end catch

        } // end of analyzeData()


    }//AppLogics class end
}//namespace end

