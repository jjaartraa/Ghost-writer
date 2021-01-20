namespace Ghost_writer
{
    partial class Form1
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
            this.GroupCount = new System.Windows.Forms.TextBox();
            this.GroupTime = new System.Windows.Forms.TextBox();
            this.SpamTime = new System.Windows.Forms.TextBox();
            this.SpamText = new System.Windows.Forms.TextBox();
            this.Start = new System.Windows.Forms.Button();
            this.Stop = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.AutoStop = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.EnterCheckbox = new System.Windows.Forms.CheckBox();
            this.FBIdler = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.SuspendLayout();
            // 
            // GroupCount
            // 
            this.GroupCount.Location = new System.Drawing.Point(12, 207);
            this.GroupCount.Name = "GroupCount";
            this.GroupCount.Size = new System.Drawing.Size(100, 20);
            this.GroupCount.TabIndex = 0;
            // 
            // GroupTime
            // 
            this.GroupTime.Location = new System.Drawing.Point(12, 233);
            this.GroupTime.Name = "GroupTime";
            this.GroupTime.Size = new System.Drawing.Size(100, 20);
            this.GroupTime.TabIndex = 1;
            // 
            // SpamTime
            // 
            this.SpamTime.Location = new System.Drawing.Point(12, 105);
            this.SpamTime.Name = "SpamTime";
            this.SpamTime.Size = new System.Drawing.Size(100, 20);
            this.SpamTime.TabIndex = 2;
            this.SpamTime.Text = "500";
            // 
            // SpamText
            // 
            this.SpamText.Location = new System.Drawing.Point(12, 40);
            this.SpamText.Multiline = true;
            this.SpamText.Name = "SpamText";
            this.SpamText.Size = new System.Drawing.Size(330, 59);
            this.SpamText.TabIndex = 3;
            this.SpamText.Text = "Spam";
            // 
            // Start
            // 
            this.Start.Location = new System.Drawing.Point(12, 263);
            this.Start.Name = "Start";
            this.Start.Size = new System.Drawing.Size(121, 45);
            this.Start.TabIndex = 4;
            this.Start.Text = "Start";
            this.Start.UseVisualStyleBackColor = true;
            this.Start.Click += new System.EventHandler(this.Start_Click);
            // 
            // Stop
            // 
            this.Stop.Location = new System.Drawing.Point(221, 263);
            this.Stop.Name = "Stop";
            this.Stop.Size = new System.Drawing.Size(121, 46);
            this.Stop.TabIndex = 5;
            this.Stop.Text = "Stop";
            this.Stop.UseVisualStyleBackColor = true;
            this.Stop.Click += new System.EventHandler(this.Stop_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(119, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 24);
            this.label1.TabIndex = 6;
            this.label1.Text = "Text to paste";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(118, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(187, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Time between messages (miliseconds)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(118, 210);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Number of texts in group";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(118, 236);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(172, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Time between groups (miliseconds)";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 139);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(154, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "----------------- Optional -----------------";
            // 
            // AutoStop
            // 
            this.AutoStop.Location = new System.Drawing.Point(12, 181);
            this.AutoStop.Name = "AutoStop";
            this.AutoStop.Size = new System.Drawing.Size(100, 20);
            this.AutoStop.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(118, 184);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(236, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Stop automatically after this number of messages";
            // 
            // EnterCheckbox
            // 
            this.EnterCheckbox.AutoSize = true;
            this.EnterCheckbox.Location = new System.Drawing.Point(12, 158);
            this.EnterCheckbox.Name = "EnterCheckbox";
            this.EnterCheckbox.Size = new System.Drawing.Size(176, 17);
            this.EnterCheckbox.TabIndex = 13;
            this.EnterCheckbox.Text = "Press Enter after each message";
            this.EnterCheckbox.UseVisualStyleBackColor = true;
            // 
            // FBIdler
            // 
            this.FBIdler.AutoSize = true;
            this.FBIdler.Location = new System.Drawing.Point(12, 314);
            this.FBIdler.Name = "FBIdler";
            this.FBIdler.Size = new System.Drawing.Size(336, 17);
            this.FBIdler.TabIndex = 14;
            this.FBIdler.Text = "Facebook Idler (shows the person that you are permanently tiping)";
            this.FBIdler.UseVisualStyleBackColor = true;
            this.FBIdler.CheckedChanged += new System.EventHandler(this.FBIdler_CheckedChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(148, 263);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(58, 45);
            this.button1.TabIndex = 15;
            this.button1.Text = "Help";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.WorkerSupportsCancellation = true;
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(354, 337);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.FBIdler);
            this.Controls.Add(this.EnterCheckbox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.AutoStop);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Stop);
            this.Controls.Add(this.Start);
            this.Controls.Add(this.SpamText);
            this.Controls.Add(this.SpamTime);
            this.Controls.Add(this.GroupTime);
            this.Controls.Add(this.GroupCount);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "Ghostwirter";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox GroupCount;
        private System.Windows.Forms.TextBox GroupTime;
        private System.Windows.Forms.TextBox SpamTime;
        private System.Windows.Forms.TextBox SpamText;
        private System.Windows.Forms.Button Start;
        private System.Windows.Forms.Button Stop;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox AutoStop;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox EnterCheckbox;
        private System.Windows.Forms.CheckBox FBIdler;
        private System.Windows.Forms.Button button1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}

