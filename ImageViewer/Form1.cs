﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImageViewer
{
    public partial class Form1 : Form
    {
        static Dictionary<string, List<string>> dicsFiles;
        static List<string> listPriority;
        static Random random;
        static Random trueOrFalse;
        static Random randomInstruction;
        static Random randomTimer;
        static List<string> instructions;
        int paneltyVal = 0;

        int timerVal = 0;
        int maxTimer = Properties.Settings.Default.MaxTimer;
        int minTimer = Properties.Settings.Default.MinTimer;

        public Form1()
        {
            InitializeComponent();

            var dirPath = Properties.Settings.Default.DirPath;
            txtDir.Text = string.IsNullOrWhiteSpace(dirPath) ? "c:\temp" : dirPath;
            btnLaunch.Enabled = false;
            btnPrioritise.Enabled = false;
            btnUnPrioritise.Enabled = false;
            btnPanelty.Visible = false;
            lblBox.Visible = false;
            progress.Visible = false;

            instructions = new List<string>
            {
                "XX times",
                "skip or panelty - ££",
                "follow timer",
                "do nothing or panelty - ££"
            };
        }

        private void BtnBrowse_Click(object sender, EventArgs e)
        {
            var folderDlg = new FolderBrowserDialog();
            folderDlg.SelectedPath = txtDir.Text;

            var result = folderDlg.ShowDialog();
            if (result == DialogResult.OK)
            {
                Properties.Settings.Default.DirPath = folderDlg.SelectedPath;
                Properties.Settings.Default.Save();

                txtDir.Text = folderDlg.SelectedPath;
                Environment.SpecialFolder root = folderDlg.RootFolder;
            }
        }


        private void BtnAnalyse_Click(object sender, EventArgs e)
        {
            btnPrioritise.Enabled = false;
            btnUnPrioritise.Enabled = false;

            dicsFiles = new Dictionary<string, List<string>>();
            listPriority = null;

            random = new Random();
            trueOrFalse = new Random();
            randomInstruction = new Random();
            randomTimer = new Random();

            var dics = DirectoryOperator.GetAnalysis(txtDir.Text);
            dicsFiles = DirectoryOperator.CreateFilesList(dics);
            btnLaunch.Enabled = dicsFiles.Any();

            btnAnalyse.Enabled = false;
        }


        private void Launch()
        {
            if (!dicsFiles.Any())
                MessageBox.Show("There are no files to display");
            else
            {
                var fileName = DirectoryOperator.ChooseOne(random, trueOrFalse, dicsFiles, listPriority);
                if (!lstBoxFiles.Items.Contains(fileName))
                {
                    lstBoxFiles.Items.Add(fileName);
                    lstBoxFiles.SelectedIndex = lstBoxFiles.Items.Count - 1;
                    lstBoxFiles.SelectedIndex = -1;
                }

                lblInstruction.Text = instructions.ElementAt(randomInstruction.Next(instructions.Count()))?.ToUpper();
                if (lblInstruction.Text?.ToLower() == "follow timer")
                {
                    timerVal = randomTimer.Next(minTimer, maxTimer);

                    timer1.Enabled = true;
                    timer1.Start();
                    timer1.Interval = 1000;
                    progress.Maximum = timerVal;
                    progress.Visible = true;

                    lblInstruction.Text += " " + timerVal + " seconds";
                }

                if (lblInstruction.Text?.ToLower() == "xx times")
                {
                    var noOfTimes = new Random().Next(5, 30);
                    var arraySpeed = new string[4] { "slow", "very slow", "fast", "vigrous" };
                    var speed = new Random().Next(arraySpeed.Length);
                    lblInstruction.Text = $"{noOfTimes} times {arraySpeed[speed]}";
                    lblInstruction.Text = lblInstruction.Text.ToUpper();
                }

                if (lblInstruction.Text.ToLower().Contains("panelty"))
                {
                    btnPanelty.Visible = true;
                }
                else
                {
                    btnPanelty.Visible = false;
                }

                Process.Start(fileName);
            }
        }

        private void BtnLaunch_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            timer1.Stop();
            progress.Visible = false;

            lblInstruction.Text += " " + timerVal + " seconds";

            Launch();
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            if (progress.Value != timerVal)
                progress.Value++;
            else
            {
                timer1.Stop();
                progress.Value = 0;
                lblInstruction.Text = "";

                progress.Visible = false;
                btnLaunch.Enabled = true;
                Launch();
            }
        }







        private void BtnPrioritise_Click(object sender, EventArgs e)
        {
            var selectedFile = lstBoxFiles.SelectedItem?.ToString();
            if (selectedFile == null)
                MessageBox.Show("Please select a file");
            else
            {
                listPriority = listPriority ?? new List<string>();
                listPriority.Add(selectedFile);

                lstBoxPriority.Items.Add(selectedFile);
            }
        }

        private void BtnUnPrioritise_Click(object sender, EventArgs e)
        {
            var selectedFile = lstBoxPriority.SelectedItem?.ToString();

            if (selectedFile == null)
                MessageBox.Show("Please select a file");
            else
                lstBoxPriority.Items.Remove(lstBoxPriority.SelectedItem);
        }

        private void LstBoxFiles_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnPrioritise.Enabled = lstBoxFiles.SelectedItem != null;
        }

        private void LstBoxPriority_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnUnPrioritise.Enabled = lstBoxPriority.SelectedItem != null;
        }










        private void LstBoxFiles_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            timer1.Stop();
            lblInstruction.Text = "";
            progress.Value = 0;

            var file = lstBoxFiles.SelectedItem?.ToString();
            if (file != null)
                Process.Start(file);
        }







        int interval = 0;
        private void BtnPanelty_Click(object sender, EventArgs e)
        {
            lblInstruction.Text = lblInstruction.Text.Replace("££", new Random().Next(50, 300).ToString());
            paneltyVal = Convert.ToInt32(lblInstruction.Text.Split('-')[1].Trim());

            timer2.Interval = 1000;
            interval = 0;
            timer2.Start();
        }

        private void Timer2_Tick(object sender, EventArgs e)
        {
            if (interval < paneltyVal)
            {
                timer2.Interval = new Random().Next(100, 500);
                lblInstruction.Visible = false;
                lblBox.Visible = true;
                lblBox.Text = interval.ToString();
                lblBox.BackColor = lblBox.BackColor == Color.Indigo ? Color.BlueViolet : Color.Indigo;
                lblBox.ForeColor = lblBox.BackColor == Color.BlueViolet ? Color.Indigo : Color.BlueViolet;

                interval++;
            }
            else
            {
                timer2.Stop();
                interval = 0;
                lblBox.Visible = false;
                lblInstruction.Visible = true;
                paneltyVal = 0;
                btnPanelty.Visible = false;

                Launch();
            }
        }

        private void ChkHide_CheckedChanged(object sender, EventArgs e)
        {
            if (chkHide.Checked)
                this.Opacity = 0.1;
            else
                this.Opacity = 1;
        }
    }
}