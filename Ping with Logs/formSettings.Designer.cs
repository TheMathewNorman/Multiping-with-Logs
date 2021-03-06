﻿namespace Ping_with_Logs
{
    partial class formSettings
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
            this.gbPing = new System.Windows.Forms.GroupBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.listLocations = new System.Windows.Forms.ListBox();
            this.textAddressInput = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.nudTimeout = new System.Windows.Forms.NumericUpDown();
            this.cbCustomTimeout = new System.Windows.Forms.CheckBox();
            this.cbLogErrorsToSeparateFile = new System.Windows.Forms.CheckBox();
            this.cbLogTimestamps = new System.Windows.Forms.CheckBox();
            this.cbGenerateLogs = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.gbPing.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudTimeout)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbPing
            // 
            this.gbPing.Controls.Add(this.btnClear);
            this.gbPing.Controls.Add(this.btnRemove);
            this.gbPing.Controls.Add(this.btnAdd);
            this.gbPing.Controls.Add(this.label1);
            this.gbPing.Controls.Add(this.listLocations);
            this.gbPing.Controls.Add(this.textAddressInput);
            this.gbPing.Location = new System.Drawing.Point(12, 12);
            this.gbPing.Name = "gbPing";
            this.gbPing.Size = new System.Drawing.Size(396, 327);
            this.gbPing.TabIndex = 0;
            this.gbPing.TabStop = false;
            this.gbPing.Text = "Ping";
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(310, 94);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(80, 23);
            this.btnClear.TabIndex = 4;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(310, 65);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(80, 23);
            this.btnRemove.TabIndex = 3;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(310, 21);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(80, 23);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "IP Address or Hostname:";
            // 
            // listLocations
            // 
            this.listLocations.FormattingEnabled = true;
            this.listLocations.ItemHeight = 16;
            this.listLocations.Items.AddRange(new object[] {
            "127.0.0.1"});
            this.listLocations.Location = new System.Drawing.Point(6, 65);
            this.listLocations.Name = "listLocations";
            this.listLocations.Size = new System.Drawing.Size(298, 244);
            this.listLocations.TabIndex = 12;
            // 
            // textAddressInput
            // 
            this.textAddressInput.Location = new System.Drawing.Point(169, 21);
            this.textAddressInput.Name = "textAddressInput";
            this.textAddressInput.Size = new System.Drawing.Size(135, 22);
            this.textAddressInput.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.nudTimeout);
            this.groupBox1.Controls.Add(this.cbCustomTimeout);
            this.groupBox1.Controls.Add(this.cbLogErrorsToSeparateFile);
            this.groupBox1.Controls.Add(this.cbLogTimestamps);
            this.groupBox1.Controls.Add(this.cbGenerateLogs);
            this.groupBox1.Location = new System.Drawing.Point(414, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(280, 259);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Options";
            // 
            // nudTimeout
            // 
            this.nudTimeout.Location = new System.Drawing.Point(131, 22);
            this.nudTimeout.Name = "nudTimeout";
            this.nudTimeout.Size = new System.Drawing.Size(41, 22);
            this.nudTimeout.TabIndex = 5;
            this.nudTimeout.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.nudTimeout.Visible = false;
            // 
            // cbCustomTimeout
            // 
            this.cbCustomTimeout.AutoSize = true;
            this.cbCustomTimeout.Location = new System.Drawing.Point(6, 24);
            this.cbCustomTimeout.Name = "cbCustomTimeout";
            this.cbCustomTimeout.Size = new System.Drawing.Size(118, 20);
            this.cbCustomTimeout.TabIndex = 5;
            this.cbCustomTimeout.Text = "Custom timeout";
            this.cbCustomTimeout.UseVisualStyleBackColor = true;
            this.cbCustomTimeout.CheckedChanged += new System.EventHandler(this.cbCustomTimeout_CheckedChanged);
            // 
            // cbLogErrorsToSeparateFile
            // 
            this.cbLogErrorsToSeparateFile.AutoSize = true;
            this.cbLogErrorsToSeparateFile.Location = new System.Drawing.Point(25, 102);
            this.cbLogErrorsToSeparateFile.Name = "cbLogErrorsToSeparateFile";
            this.cbLogErrorsToSeparateFile.Size = new System.Drawing.Size(170, 20);
            this.cbLogErrorsToSeparateFile.TabIndex = 8;
            this.cbLogErrorsToSeparateFile.Text = "Log errors to another file";
            this.cbLogErrorsToSeparateFile.UseVisualStyleBackColor = true;
            this.cbLogErrorsToSeparateFile.Visible = false;
            // 
            // cbLogTimestamps
            // 
            this.cbLogTimestamps.AutoSize = true;
            this.cbLogTimestamps.Location = new System.Drawing.Point(25, 76);
            this.cbLogTimestamps.Name = "cbLogTimestamps";
            this.cbLogTimestamps.Size = new System.Drawing.Size(122, 20);
            this.cbLogTimestamps.TabIndex = 7;
            this.cbLogTimestamps.Text = "Log timestamps";
            this.cbLogTimestamps.UseVisualStyleBackColor = true;
            this.cbLogTimestamps.Visible = false;
            // 
            // cbGenerateLogs
            // 
            this.cbGenerateLogs.AutoSize = true;
            this.cbGenerateLogs.Location = new System.Drawing.Point(6, 50);
            this.cbGenerateLogs.Name = "cbGenerateLogs";
            this.cbGenerateLogs.Size = new System.Drawing.Size(112, 20);
            this.cbGenerateLogs.TabIndex = 6;
            this.cbGenerateLogs.Text = "Generate logs";
            this.cbGenerateLogs.UseVisualStyleBackColor = true;
            this.cbGenerateLogs.CheckedChanged += new System.EventHandler(this.cbGenerateLogs_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnExit);
            this.groupBox2.Controls.Add(this.btnStop);
            this.groupBox2.Controls.Add(this.btnStart);
            this.groupBox2.Location = new System.Drawing.Point(414, 291);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(280, 48);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Controls";
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(194, 19);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(80, 23);
            this.btnExit.TabIndex = 11;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(92, 19);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(80, 23);
            this.btnStop.TabIndex = 10;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Visible = false;
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(6, 19);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(80, 23);
            this.btnStart.TabIndex = 9;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            // 
            // formSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(706, 350);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gbPing);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "formSettings";
            this.Text = "Ping Settings";
            this.gbPing.ResumeLayout(false);
            this.gbPing.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudTimeout)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbPing;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listLocations;
        private System.Windows.Forms.TextBox textAddressInput;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.CheckBox cbLogTimestamps;
        private System.Windows.Forms.CheckBox cbGenerateLogs;
        private System.Windows.Forms.NumericUpDown nudTimeout;
        private System.Windows.Forms.CheckBox cbCustomTimeout;
        private System.Windows.Forms.CheckBox cbLogErrorsToSeparateFile;
    }
}

