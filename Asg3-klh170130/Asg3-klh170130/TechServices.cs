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
 * This is the TechServices module, which handles technical services such as input/output
 * 
 */


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Data;


namespace Asg3_klh170130
{   
    /* TechServices class, 
     * a module to handle technical services such as I/O 
     */
    public class TechServices
    {

        /*
         * constructor for this class
        */
        public TechServices()
        {
        }

        /* A method to open/load/read data from file into memory for this program
            * anAppLogics, the AppLogics instance of the program
            * fileName: or file path, location and name of file to read, optional, default value = "CS6326Asg2.txt"
            * tableName: name of the target table within the AppLogics's dataset member, optional, default value = "RebateRecords"
            * return a bool value indicating if the load process was successful or not, true = successfull, false = error
            */
        public bool loadDataFromFile(AppLogics anAppLogics, string fileName = "CS6326Asg2.txt", string tableName="RebateRecords" )
        {
            bool success = false;
            try
            {
                if (File.Exists(fileName))
                // if file exists, read
                {

                    StreamReader srFile = new StreamReader(fileName);

                    int colsCount = anAppLogics.dsData.Tables[tableName].Columns.Count;
                    object[] obData = new object[colsCount];
                    // * important, clear current rows
                    anAppLogics.dsData.Tables[tableName].Rows.Clear();

                    while (!srFile.EndOfStream)
                    {
                        string strDataLine = srFile.ReadLine(); // read a data line
                        string[] dataElements = strDataLine.Split('\t'); // split on tab
                        if (dataElements.Length != 16)
                            // format requires 16 columns, wrong format will cause error, so return
                        {
                            return success = false;
                        }
                        for (int i = 0; i < dataElements.Length; i++)
                        {
                            obData[i] = dataElements[i]; // assign to corresponding element in memory
                        }
                        anAppLogics.dsData.Tables[tableName].Rows.Add(obData); // add a data row to table

                    }
                    srFile.Close();
                    return success = true;
                }
                else
                {
                    return success = false;
                }
                

            }
            catch (IOException e)
            {
                throw e;
            }

        }


        /* A method to write/save data from memory into file 
            * anAppLogics, the AppLogics instance of the program
            * fileName: or file path, location and name of file to write, is optional, default value = "CS6326Asg3.txt"
            */
        public void writeDataToFile(AppLogics anAppLogics, string fileName = "CS6326Asg3.txt")
        {
            try
            {
                StreamWriter swFile = new StreamWriter(fileName);

                swFile.Write("Number of Records: ");
                swFile.WriteLine(anAppLogics.countOfRecords.ToString());

                swFile.Write("Minimum Entry Time: ");
                swFile.WriteLine(anAppLogics.minEntryTime.Minutes.ToString() + ":" + anAppLogics.minEntryTime.Seconds.ToString());

                swFile.Write("Maximum Entry Time: ");
                swFile.WriteLine(anAppLogics.maxEntryTime.Minutes.ToString() + ":" + anAppLogics.maxEntryTime.Seconds.ToString());

                swFile.Write("Average Entry Time: ");
                swFile.WriteLine(anAppLogics.avgEntryTime.Minutes.ToString() + ":" + anAppLogics.avgEntryTime.Seconds.ToString());

                swFile.Write("Minimum Inter-record Time: ");
                swFile.WriteLine(anAppLogics.minInterTime.Minutes.ToString() + ":" + anAppLogics.minInterTime.Seconds.ToString());

                swFile.Write("Maximum Inter-record Time: ");
                swFile.WriteLine(anAppLogics.maxInterTime.Minutes.ToString() + ":" + anAppLogics.maxInterTime.Seconds.ToString());

                swFile.Write("Average Inter-record Time: ");
                swFile.WriteLine(anAppLogics.avgInterTime.Minutes.ToString() + ":" + anAppLogics.avgInterTime.Seconds.ToString());

                swFile.Write("Total Time: ");
                swFile.WriteLine(anAppLogics.totalTime.Minutes.ToString() + ":" + anAppLogics.totalTime.Seconds.ToString());

                swFile.Write("Total Backspace Count: ");
                swFile.WriteLine(anAppLogics.countOfBackspace.ToString());

                swFile.Close();
            }
            catch (IOException e)
            {
                throw e;
            }

        }

    }//TechServices class end
}//namespace end
