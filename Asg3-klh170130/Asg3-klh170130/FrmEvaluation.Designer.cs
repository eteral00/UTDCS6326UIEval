namespace Asg3_klh170130
{
    partial class FrmEvaluation
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmEvaluation));
            this.stsMain = new System.Windows.Forms.StatusStrip();
            this.tssLabelMain = new System.Windows.Forms.ToolStripStatusLabel();
            this.grbControls = new System.Windows.Forms.GroupBox();
            this.txtInstructions = new System.Windows.Forms.TextBox();
            this.btnAnalyze = new System.Windows.Forms.Button();
            this.txtFilePath = new System.Windows.Forms.TextBox();
            this.btnOpen = new System.Windows.Forms.Button();
            this.grbResults = new System.Windows.Forms.GroupBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblTotalBackspaceData = new System.Windows.Forms.Label();
            this.lblBackspaceCount = new System.Windows.Forms.Label();
            this.lblTotalTimeData = new System.Windows.Forms.Label();
            this.lblTotalTime = new System.Windows.Forms.Label();
            this.lblAvgInterTimeData = new System.Windows.Forms.Label();
            this.lblAvgInterTime = new System.Windows.Forms.Label();
            this.lblMaxInterTimeData = new System.Windows.Forms.Label();
            this.lblMaxInterTime = new System.Windows.Forms.Label();
            this.lblMinInterTimeData = new System.Windows.Forms.Label();
            this.lblMinInterTime = new System.Windows.Forms.Label();
            this.lblAvgEntryTimeData = new System.Windows.Forms.Label();
            this.lblAvgEntryTime = new System.Windows.Forms.Label();
            this.lblMaxEntryTimeData = new System.Windows.Forms.Label();
            this.lblMaxEntryTime = new System.Windows.Forms.Label();
            this.lblMinEntryTimeData = new System.Windows.Forms.Label();
            this.lblNumOfRecordsData = new System.Windows.Forms.Label();
            this.lblMinEntryTime = new System.Windows.Forms.Label();
            this.lblNumOfRecords = new System.Windows.Forms.Label();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.stsMain.SuspendLayout();
            this.grbControls.SuspendLayout();
            this.grbResults.SuspendLayout();
            this.pnlMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // stsMain
            // 
            this.stsMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tssLabelMain});
            this.stsMain.Location = new System.Drawing.Point(0, 346);
            this.stsMain.Name = "stsMain";
            this.stsMain.Size = new System.Drawing.Size(668, 22);
            this.stsMain.TabIndex = 99;
            // 
            // tssLabelMain
            // 
            this.tssLabelMain.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tssLabelMain.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tssLabelMain.Name = "tssLabelMain";
            this.tssLabelMain.Overflow = System.Windows.Forms.ToolStripItemOverflow.Always;
            this.tssLabelMain.Size = new System.Drawing.Size(653, 17);
            this.tssLabelMain.Spring = true;
            // 
            // grbControls
            // 
            this.grbControls.Controls.Add(this.txtInstructions);
            this.grbControls.Controls.Add(this.btnAnalyze);
            this.grbControls.Controls.Add(this.txtFilePath);
            this.grbControls.Controls.Add(this.btnOpen);
            this.grbControls.Dock = System.Windows.Forms.DockStyle.Left;
            this.grbControls.Location = new System.Drawing.Point(0, 0);
            this.grbControls.Name = "grbControls";
            this.grbControls.Size = new System.Drawing.Size(351, 331);
            this.grbControls.TabIndex = 2;
            this.grbControls.TabStop = false;
            this.grbControls.Text = "Controls";
            // 
            // txtInstructions
            // 
            this.txtInstructions.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.txtInstructions.Enabled = false;
            this.txtInstructions.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInstructions.Location = new System.Drawing.Point(3, 92);
            this.txtInstructions.Multiline = true;
            this.txtInstructions.Name = "txtInstructions";
            this.txtInstructions.Size = new System.Drawing.Size(345, 236);
            this.txtInstructions.TabIndex = 102;
            this.txtInstructions.Text = resources.GetString("txtInstructions.Text");
            // 
            // btnAnalyze
            // 
            this.btnAnalyze.Location = new System.Drawing.Point(7, 52);
            this.btnAnalyze.Name = "btnAnalyze";
            this.btnAnalyze.Size = new System.Drawing.Size(75, 23);
            this.btnAnalyze.TabIndex = 2;
            this.btnAnalyze.Text = "Analyze";
            this.btnAnalyze.UseVisualStyleBackColor = true;
            this.btnAnalyze.Click += new System.EventHandler(this.btnAnalyze_Click);
            // 
            // txtFilePath
            // 
            this.txtFilePath.Enabled = false;
            this.txtFilePath.Location = new System.Drawing.Point(89, 22);
            this.txtFilePath.Name = "txtFilePath";
            this.txtFilePath.Size = new System.Drawing.Size(256, 22);
            this.txtFilePath.TabIndex = 1;
            // 
            // btnOpen
            // 
            this.btnOpen.Location = new System.Drawing.Point(7, 22);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(75, 23);
            this.btnOpen.TabIndex = 0;
            this.btnOpen.Text = "Open File";
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // grbResults
            // 
            this.grbResults.Controls.Add(this.btnExit);
            this.grbResults.Controls.Add(this.lblTotalBackspaceData);
            this.grbResults.Controls.Add(this.lblBackspaceCount);
            this.grbResults.Controls.Add(this.lblTotalTimeData);
            this.grbResults.Controls.Add(this.lblTotalTime);
            this.grbResults.Controls.Add(this.lblAvgInterTimeData);
            this.grbResults.Controls.Add(this.lblAvgInterTime);
            this.grbResults.Controls.Add(this.lblMaxInterTimeData);
            this.grbResults.Controls.Add(this.lblMaxInterTime);
            this.grbResults.Controls.Add(this.lblMinInterTimeData);
            this.grbResults.Controls.Add(this.lblMinInterTime);
            this.grbResults.Controls.Add(this.lblAvgEntryTimeData);
            this.grbResults.Controls.Add(this.lblAvgEntryTime);
            this.grbResults.Controls.Add(this.lblMaxEntryTimeData);
            this.grbResults.Controls.Add(this.lblMaxEntryTime);
            this.grbResults.Controls.Add(this.lblMinEntryTimeData);
            this.grbResults.Controls.Add(this.lblNumOfRecordsData);
            this.grbResults.Controls.Add(this.lblMinEntryTime);
            this.grbResults.Controls.Add(this.lblNumOfRecords);
            this.grbResults.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grbResults.Location = new System.Drawing.Point(351, 0);
            this.grbResults.Name = "grbResults";
            this.grbResults.Size = new System.Drawing.Size(285, 331);
            this.grbResults.TabIndex = 3;
            this.grbResults.TabStop = false;
            this.grbResults.Text = "Results";
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(204, 302);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 118;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblTotalBackspaceData
            // 
            this.lblTotalBackspaceData.AutoSize = true;
            this.lblTotalBackspaceData.Location = new System.Drawing.Point(171, 212);
            this.lblTotalBackspaceData.Name = "lblTotalBackspaceData";
            this.lblTotalBackspaceData.Size = new System.Drawing.Size(13, 14);
            this.lblTotalBackspaceData.TabIndex = 117;
            this.lblTotalBackspaceData.Text = "0";
            // 
            // lblBackspaceCount
            // 
            this.lblBackspaceCount.AutoSize = true;
            this.lblBackspaceCount.Location = new System.Drawing.Point(7, 212);
            this.lblBackspaceCount.Name = "lblBackspaceCount";
            this.lblBackspaceCount.Size = new System.Drawing.Size(131, 14);
            this.lblBackspaceCount.TabIndex = 116;
            this.lblBackspaceCount.Text = "Total Backspace Count:";
            // 
            // lblTotalTimeData
            // 
            this.lblTotalTimeData.AutoSize = true;
            this.lblTotalTimeData.Location = new System.Drawing.Point(171, 188);
            this.lblTotalTimeData.Name = "lblTotalTimeData";
            this.lblTotalTimeData.Size = new System.Drawing.Size(28, 14);
            this.lblTotalTimeData.TabIndex = 115;
            this.lblTotalTimeData.Text = "0:00";
            // 
            // lblTotalTime
            // 
            this.lblTotalTime.AutoSize = true;
            this.lblTotalTime.Location = new System.Drawing.Point(7, 188);
            this.lblTotalTime.Name = "lblTotalTime";
            this.lblTotalTime.Size = new System.Drawing.Size(67, 14);
            this.lblTotalTime.TabIndex = 114;
            this.lblTotalTime.Text = "Total Time:";
            // 
            // lblAvgInterTimeData
            // 
            this.lblAvgInterTimeData.AutoSize = true;
            this.lblAvgInterTimeData.Location = new System.Drawing.Point(171, 164);
            this.lblAvgInterTimeData.Name = "lblAvgInterTimeData";
            this.lblAvgInterTimeData.Size = new System.Drawing.Size(28, 14);
            this.lblAvgInterTimeData.TabIndex = 113;
            this.lblAvgInterTimeData.Text = "0:00";
            // 
            // lblAvgInterTime
            // 
            this.lblAvgInterTime.AutoSize = true;
            this.lblAvgInterTime.Location = new System.Drawing.Point(7, 164);
            this.lblAvgInterTime.Name = "lblAvgInterTime";
            this.lblAvgInterTime.Size = new System.Drawing.Size(150, 14);
            this.lblAvgInterTime.TabIndex = 112;
            this.lblAvgInterTime.Text = "Average Inter-record Time:";
            // 
            // lblMaxInterTimeData
            // 
            this.lblMaxInterTimeData.AutoSize = true;
            this.lblMaxInterTimeData.Location = new System.Drawing.Point(171, 140);
            this.lblMaxInterTimeData.Name = "lblMaxInterTimeData";
            this.lblMaxInterTimeData.Size = new System.Drawing.Size(28, 14);
            this.lblMaxInterTimeData.TabIndex = 111;
            this.lblMaxInterTimeData.Text = "0:00";
            // 
            // lblMaxInterTime
            // 
            this.lblMaxInterTime.AutoSize = true;
            this.lblMaxInterTime.Location = new System.Drawing.Point(6, 140);
            this.lblMaxInterTime.Name = "lblMaxInterTime";
            this.lblMaxInterTime.Size = new System.Drawing.Size(160, 14);
            this.lblMaxInterTime.TabIndex = 110;
            this.lblMaxInterTime.Text = "Maximum Inter-record Time:";
            // 
            // lblMinInterTimeData
            // 
            this.lblMinInterTimeData.AutoSize = true;
            this.lblMinInterTimeData.Location = new System.Drawing.Point(171, 116);
            this.lblMinInterTimeData.Name = "lblMinInterTimeData";
            this.lblMinInterTimeData.Size = new System.Drawing.Size(28, 14);
            this.lblMinInterTimeData.TabIndex = 109;
            this.lblMinInterTimeData.Text = "0:00";
            // 
            // lblMinInterTime
            // 
            this.lblMinInterTime.AutoSize = true;
            this.lblMinInterTime.Location = new System.Drawing.Point(7, 116);
            this.lblMinInterTime.Name = "lblMinInterTime";
            this.lblMinInterTime.Size = new System.Drawing.Size(159, 14);
            this.lblMinInterTime.TabIndex = 108;
            this.lblMinInterTime.Text = "Minimum Inter-record Time:";
            // 
            // lblAvgEntryTimeData
            // 
            this.lblAvgEntryTimeData.AutoSize = true;
            this.lblAvgEntryTimeData.Location = new System.Drawing.Point(171, 92);
            this.lblAvgEntryTimeData.Name = "lblAvgEntryTimeData";
            this.lblAvgEntryTimeData.Size = new System.Drawing.Size(28, 14);
            this.lblAvgEntryTimeData.TabIndex = 107;
            this.lblAvgEntryTimeData.Text = "0:00";
            // 
            // lblAvgEntryTime
            // 
            this.lblAvgEntryTime.AutoSize = true;
            this.lblAvgEntryTime.Location = new System.Drawing.Point(6, 92);
            this.lblAvgEntryTime.Name = "lblAvgEntryTime";
            this.lblAvgEntryTime.Size = new System.Drawing.Size(112, 14);
            this.lblAvgEntryTime.TabIndex = 106;
            this.lblAvgEntryTime.Text = "Average Entry Time:";
            // 
            // lblMaxEntryTimeData
            // 
            this.lblMaxEntryTimeData.AutoSize = true;
            this.lblMaxEntryTimeData.Location = new System.Drawing.Point(171, 68);
            this.lblMaxEntryTimeData.Name = "lblMaxEntryTimeData";
            this.lblMaxEntryTimeData.Size = new System.Drawing.Size(28, 14);
            this.lblMaxEntryTimeData.TabIndex = 105;
            this.lblMaxEntryTimeData.Text = "0:00";
            // 
            // lblMaxEntryTime
            // 
            this.lblMaxEntryTime.AutoSize = true;
            this.lblMaxEntryTime.Location = new System.Drawing.Point(6, 68);
            this.lblMaxEntryTime.Name = "lblMaxEntryTime";
            this.lblMaxEntryTime.Size = new System.Drawing.Size(122, 14);
            this.lblMaxEntryTime.TabIndex = 104;
            this.lblMaxEntryTime.Text = "Maximum Entry Time:";
            // 
            // lblMinEntryTimeData
            // 
            this.lblMinEntryTimeData.AutoSize = true;
            this.lblMinEntryTimeData.Location = new System.Drawing.Point(171, 44);
            this.lblMinEntryTimeData.Name = "lblMinEntryTimeData";
            this.lblMinEntryTimeData.Size = new System.Drawing.Size(28, 14);
            this.lblMinEntryTimeData.TabIndex = 103;
            this.lblMinEntryTimeData.Text = "0:00";
            // 
            // lblNumOfRecordsData
            // 
            this.lblNumOfRecordsData.AutoSize = true;
            this.lblNumOfRecordsData.Location = new System.Drawing.Point(171, 20);
            this.lblNumOfRecordsData.Name = "lblNumOfRecordsData";
            this.lblNumOfRecordsData.Size = new System.Drawing.Size(13, 14);
            this.lblNumOfRecordsData.TabIndex = 101;
            this.lblNumOfRecordsData.Text = "0";
            // 
            // lblMinEntryTime
            // 
            this.lblMinEntryTime.AutoSize = true;
            this.lblMinEntryTime.Location = new System.Drawing.Point(6, 44);
            this.lblMinEntryTime.Name = "lblMinEntryTime";
            this.lblMinEntryTime.Size = new System.Drawing.Size(121, 14);
            this.lblMinEntryTime.TabIndex = 102;
            this.lblMinEntryTime.Text = "Minimum Entry Time:";
            // 
            // lblNumOfRecords
            // 
            this.lblNumOfRecords.AutoSize = true;
            this.lblNumOfRecords.Location = new System.Drawing.Point(6, 20);
            this.lblNumOfRecords.Name = "lblNumOfRecords";
            this.lblNumOfRecords.Size = new System.Drawing.Size(113, 14);
            this.lblNumOfRecords.TabIndex = 100;
            this.lblNumOfRecords.Text = "Number of Records:";
            // 
            // pnlMain
            // 
            this.pnlMain.CausesValidation = false;
            this.pnlMain.Controls.Add(this.grbResults);
            this.pnlMain.Controls.Add(this.grbControls);
            this.pnlMain.Location = new System.Drawing.Point(16, 12);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(636, 331);
            this.pnlMain.TabIndex = 6;
            // 
            // FrmEvaluation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(668, 368);
            this.Controls.Add(this.pnlMain);
            this.Controls.Add(this.stsMain);
            this.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "FrmEvaluation";
            this.Text = "Evaluation";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmEvaluation_FormClosing);
            this.Load += new System.EventHandler(this.FrmEvaluation_Load);
            this.ResizeBegin += new System.EventHandler(this.FrmEvaluation_ResizeBegin);
            this.ResizeEnd += new System.EventHandler(this.FrmEvaluation_ResizeEnd);
            this.SizeChanged += new System.EventHandler(this.FrmEvaluation_SizeChanged);
            this.stsMain.ResumeLayout(false);
            this.stsMain.PerformLayout();
            this.grbControls.ResumeLayout(false);
            this.grbControls.PerformLayout();
            this.grbResults.ResumeLayout(false);
            this.grbResults.PerformLayout();
            this.pnlMain.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.StatusStrip stsMain;
        private System.Windows.Forms.GroupBox grbControls;
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.TextBox txtFilePath;
        private System.Windows.Forms.TextBox txtInstructions;
        private System.Windows.Forms.Button btnAnalyze;
        private System.Windows.Forms.GroupBox grbResults;
        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.Label lblMinEntryTimeData;
        private System.Windows.Forms.Label lblNumOfRecordsData;
        private System.Windows.Forms.Label lblMinEntryTime;
        private System.Windows.Forms.Label lblNumOfRecords;
        private System.Windows.Forms.Label lblAvgEntryTimeData;
        private System.Windows.Forms.Label lblAvgEntryTime;
        private System.Windows.Forms.Label lblMaxEntryTimeData;
        private System.Windows.Forms.Label lblMaxEntryTime;
        private System.Windows.Forms.Label lblMaxInterTimeData;
        private System.Windows.Forms.Label lblMaxInterTime;
        private System.Windows.Forms.Label lblMinInterTimeData;
        private System.Windows.Forms.Label lblMinInterTime;
        private System.Windows.Forms.Label lblAvgInterTimeData;
        private System.Windows.Forms.Label lblAvgInterTime;
        private System.Windows.Forms.Label lblTotalTimeData;
        private System.Windows.Forms.Label lblTotalTime;
        private System.Windows.Forms.Label lblTotalBackspaceData;
        private System.Windows.Forms.Label lblBackspaceCount;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.ToolStripStatusLabel tssLabelMain;
    }
}

