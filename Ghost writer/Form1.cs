using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Diagnostics;

namespace Ghost_writer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public int group_size;
        public int autostop_count;
        public int group_counter = 0;
        public int autostop_counter = 0;
        public int group_time;
        public int interval;
        public bool Group;
        public bool autostop;
        public bool spam = true;

        private async void Start_Click(object sender, EventArgs e)
        { // Button start
            spam = true;
            Clipboard.Clear();
            Clipboard.SetText(SpamText.Text.ToString());
            Form2 countdown = new Form2();  //Create form for time left before spamming
            countdown.ShowDialog();         //Activate form
            this.SendToBack();              //Hide main form
            countdown.Update();

            if (FBIdler.Checked == true)
            {
                interval = 1050;
            }
            else
            {
                interval = Convert.ToInt32(SpamTime.Text);

                if (AutoStop.Text != null)
                {
                    try
                    {
                        autostop = true;
                        autostop_count = Convert.ToInt16(AutoStop.Text);
                    }
                    catch (Exception)
                    {
                        autostop = false;
                    }
                }
                if (GroupCount.Text != null)
                {
                    try
                    {
                        Group = true;
                        group_size = Convert.ToInt16(GroupCount.Text);
                        group_time = Convert.ToInt16(GroupTime.Text);
                    }
                    catch (Exception)
                    {
                        Group = false;
                    }
                }
            }
            await PutTaskDelay(1000);
            backgroundWorker1.RunWorkerAsync();
        }

        private void Stop_Click(object sender, EventArgs e)
        {
            spam = false;
            if (backgroundWorker1.IsBusy == true)
            {
                backgroundWorker1.CancelAsync();
            }
        }

        private void FBIdler_CheckedChanged(object sender, EventArgs e)
        {
            if (FBIdler.Checked == true)
            {
                SpamTime.Enabled = false;
                EnterCheckbox.Enabled = false;
                GroupCount.Enabled = false;
                GroupTime.Enabled = false;
                AutoStop.Enabled = false;
            }
            else
            {
                SpamTime.Enabled = true;
                EnterCheckbox.Enabled = true;
                GroupCount.Enabled = true;
                GroupTime.Enabled = true;
                AutoStop.Enabled = true;
            }
        }

        public void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("After filling in all the settings, press the Start button. Ghostwriter will hide itself and give you 5 seconds to select place where you want to type." + Environment.NewLine + "Facebook Idler - click in facebook chat text box and Ghostwriter will keep pasting text there and then removing it again to make it look like you are tiping" + Environment.NewLine + "Ideal time delay for facebook chat spamming is 200ms");
        }

        async Task PutTaskDelay(int time)
        {
            await Task.Delay(time);
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            while (spam)
            {
                Paste();  // Paste
                if (EnterCheckbox.Checked == true)
                {
                    PressEnter();
                }
                group_counter++;
                autostop_counter++;
                if (FBIdler.Checked == true && autostop_counter % 6 == 0)
                {
                    Delete();
                }
                else if (FBIdler.Checked == true)
                {
                    Thread.Sleep(4500);
                }

                if (Group)
                {
                    if (group_counter == group_size)
                    {
                        try
                        {
                            Thread.Sleep(group_time - interval);
                            group_counter = 0;
                        }
                        catch (Exception)
                        {
                        }
                    }
                }
                if (autostop)
                {
                    if (autostop_counter == autostop_count)
                    {
                        spam = false;
                        autostop_counter = 0;
                        group_counter = 0;
                    }
                }
                Thread.Sleep(interval);
            }
        }
        public void Delete()
        {
            SendKeys.SendWait("^a");
            SendKeys.SendWait("{DEL}");
        }
        public void Paste()
        {
            SendKeys.SendWait("^v");
        }
        public void PressEnter()
        {
            SendKeys.SendWait("{ENTER}");
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            Stop.PerformClick();
        }
    }
}
