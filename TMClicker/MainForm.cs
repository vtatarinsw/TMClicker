using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowManager;

namespace TMClicker
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

            LinkLabel.Link link = new LinkLabel.Link();
            link.LinkData = "http://www.tacticalmonsters.com/";
            linkOfficialWebsite.Links.Add(link);

            link = new LinkLabel.Link();
            link.LinkData = "http://store.steampowered.com/app/705220/Tactical_Monsters_Rumble_Arena/";
            linkSteam.Links.Add(link);
        }


        Thread MainTask = null;
        bool MainTaskPause = false;
        bool MainTaskExist = false;

        private WinManager wm = new WinManager();
        private bool UseGetGoldSteps = false;

        private enum Stages { RunRumble = 1, StartAuto = 2, CheckAuto = 3, CheckWinLose = 4, CheckClaims = 5, CheckGoldChest = 6, ClaimGoldChest = 7 };

        private int StepDelay = 2000;
        private int LogsRecordLimit = 100;
        private int LogsRecordRemoveWhenCleanUp = 80;

        #region Dev Tab

        private void bCapture_Click(object sender, EventArgs e)
        {
            User32.SetForegroundWindow(wm.GetTMWindow());

            Bitmap bitmap = wm.GetScreenPart((int)nTop.Value, (int)nLeft.Value, (int)nWidth.Value, (int)nHeight.Value);

            pBox.Image = bitmap;
        }

        private void btnSaveAs_Click(object sender, EventArgs e)
        {
            Bitmap bitmap = wm.GetScreenPart((int)nTop.Value, (int)nLeft.Value, (int)nWidth.Value, (int)nHeight.Value);

            bitmap.Save(@"D:\Freelancer\Projects\MyProjects\TMClicker\" + tbFilename.Text, System.Drawing.Imaging.ImageFormat.Bmp);
        }

        private void btnCompare_Click(object sender, EventArgs e)
        {
            TMScreens tmScreens = new TMScreens();

            TMPart part = tmScreens.GetPart("RumbleStart");

            pBox.Image = part.Bitmap;

            Bitmap bitmap = wm.GetScreenPart(part.Position.Top, part.Position.Left, part.Position.Width, part.Position.Height);

            pBox2.Image = bitmap;

            if (wm.VerifyPart("RumbleStart"))
            {
                //wm.LeftMouseClick(part.Position.Left, part.Position.Top);
                MessageBox.Show("Equal!");
            }
            else
            {
                MessageBox.Show("NOT Equal!");
            }
        }

        #endregion

        /// <summary>
        /// Add log message to ListBox
        /// </summary>
        /// <param name="msg"></param>
        public void AddLog(string msg)
        {
            lbLog.Invoke((MethodInvoker)delegate
            {
                lbLog.Items.Insert(0, msg);

                // Clean up logs if they reach out the limit
                if (lbLog.Items.Count > LogsRecordLimit)
                {
                    for (int i = 0; i < LogsRecordRemoveWhenCleanUp; i++)
                        lbLog.Items.RemoveAt(lbLog.Items.Count - 1);
                }
            });
        }

        /// <summary>
        /// Main Run Cycle
        /// </summary>
        private void RunCycle()
        {
            int CommonDelay = StepDelay;

            // Set TM window active
            User32.SetForegroundWindow(wm.GetTMWindow());

            Thread.Sleep(CommonDelay);

            TMScreens tmScreens = new TMScreens();
            TMPart part = null;

            int rumbles = 0;
            Stages stage = Stages.RunRumble;
            Stages prevStage = Stages.RunRumble;
            int claimWait = 0;

            DateTime start = DateTime.Now;

            AddLog("--- TMClicker started");

            while (true)
            {
                switch (stage)
                {
                    case Stages.RunRumble:
                        // Check stage = Stages.RunRumble it means we don't run rumble yet
                        part = tmScreens.GetPart("RumbleStart");

                        claimWait++;

                        if (wm.VerifyPart(tmScreens, part) || claimWait > 10)
                        {
                            claimWait = 0;

                            AddLog("RumbleStarted - clicked to run it!");

                            wm.LeftMouseClick(part.Position.Left, part.Position.Top);
                            stage = Stages.StartAuto;

                            AddLog(string.Format("*** Finished {0} Rumble(s)", rumbles));
                            AddLog(string.Format("*** Time from start: {0:hh\\:mm\\:ss}", (DateTime.Now - start)));

                            rumbles++;
                        }
                        break;

                    case Stages.StartAuto:
                        // Check if we already started Rumble
                        part = tmScreens.GetPart("RumbleAuto");

                        if (wm.VerifyPart(tmScreens, part))
                        {
                            AddLog("RumbleAuto - clicked to turn Auto ON!");

                            wm.LeftMouseClick(part.Position.Left, part.Position.Top);
                            stage = Stages.CheckAuto;
                        }
                        break;

                    case Stages.CheckAuto:
                        // Confirm we started Auto battle
                        part = tmScreens.GetPart("RumbleAutoOn");

                        if (wm.VerifyPart(tmScreens, part))
                        {
                            AddLog("RumbleAuto - Auto is ON confirmed!");

                            stage = Stages.CheckWinLose;
                        }
                        break;

                    case Stages.CheckWinLose:
                        // Check if we already Won/Defeated
                        part = tmScreens.GetPart("RumbleWon");

                        if (wm.VerifyPart(tmScreens, part))
                        {
                            AddLog("Rumble has Won or Defeated!");

                            wm.LeftMouseClick(part.Position.Left, part.Position.Top);
                            stage = Stages.CheckClaims;
                        }
                        break;

                    case Stages.CheckClaims:
                        // Check if need claim
                        part = tmScreens.GetPart("RumbleClaim");

                        claimWait++;

                        if (wm.VerifyPart(tmScreens, part))
                        {
                            AddLog("Rumble Cards Prize has Claimed!");

                            wm.LeftMouseClick(part.Position.Left, part.Position.Top);
                            claimWait = 0;
                        }

                        // Check if it's Arena change
                        part = tmScreens.GetPart("RumbleArena");

                        if (wm.VerifyPart(tmScreens, part))
                        {
                            AddLog("Rumble Arena has been changed!");

                            wm.LeftMouseClick(part.Position.Left, part.Position.Top);
                            claimWait = 0;
                        }

                        // As after change Arena can be Claim prize, just wait 5 times before move with next Rumble
                        if (claimWait > 3)
                        {
                            AddLog("Claim and Arena checked!");

                            stage = UseGetGoldSteps ? Stages.CheckGoldChest : Stages.RunRumble;
                            claimWait = 0;
                        }
                        break;

                    case Stages.CheckGoldChest:
                        // Check if it's gold prize
                        part = tmScreens.GetPart("RumbleGold");

                        claimWait++;

                        if (wm.VerifyPart(tmScreens, part))
                        {
                            AddLog("Rumble Gold prize - clicked on it!");

                            wm.LeftMouseClick(part.Position.Left, part.Position.Top);
                            stage = Stages.ClaimGoldChest;
                        }

                        if (claimWait > 3)
                        {
                            AddLog("No Gold Prize - checked.");

                            stage = Stages.ClaimGoldChest;
                            claimWait = 0;
                        }

                        break;

                    case Stages.ClaimGoldChest:
                        // Check to claim gold prize
                        part = tmScreens.GetPart("RumbleGoldClaim");

                        claimWait++;

                        if (wm.VerifyPart(tmScreens, part))
                        {
                            AddLog("Rumble Gold Prize has Claimed!");

                            wm.LeftMouseClick(part.Position.Left, part.Position.Top);
                            stage = Stages.RunRumble;
                        }

                        if (claimWait > 3)
                        {
                            stage = Stages.RunRumble;
                            claimWait = 0;
                        }

                        break;

                }

                if (prevStage != stage)
                {
                    AddLog("Wait on stage = " + stage.ToString());
                    prevStage = stage;
                }

                Thread.Sleep(CommonDelay);

                if (MainTaskExist)
                    break;

                while (MainTaskPause)
                    Thread.Sleep(1000);
            }

        }

        private void RunClicker()
        {
            RunCycle();
        }

        private void btnRun_Click(object sender, EventArgs e)
        {
            if (MainTask == null)
            {
                btnRun.Text = "Pause";

                MainTask = new Thread(RunClicker);

                MainTask.Start();

            } else
            {
                if (MainTaskPause)
                {
                    btnRun.Text = "Pause";

                    AddLog("--- Resume the Clicker");

                    MainTaskPause = false;
                } else
                {
                    btnRun.Text = "Run";

                    AddLog("--- Pause the Clicker");

                    MainTaskPause = true;
                }
            }            
        }

        private void cbUseGoldSteps_CheckedChanged(object sender, EventArgs e)
        {
            UseGetGoldSteps = cbUseGoldSteps.Checked;
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MainTask != null)
            {
                MainTaskExist = true;
                MainTask.Abort();
            }
        }

        private void linkOfficialWebsite_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(e.Link.LinkData as string);
        }

        private void linkSteam_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(e.Link.LinkData as string);
        }
    }
}
