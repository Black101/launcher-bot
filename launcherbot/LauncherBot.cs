using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using EveComFramework.LoginControl;
using EveComFramework.Core;
namespace launcherbot
{
    public partial class LauncherBot : Form
    {

        LoginControl LoginControl = LoginControl.Instance;
        public LauncherBot()
        {
            InitializeComponent();
            foreach (Logger l in LoggerHelper.Instance.Loggers)
            {
                l.RichEvent += l_RichEvent;
            }
            LoginControl.DTControl.DTStarting += DTControl_DTStarting;
            LoginControl.DTControl.DTEnded += DTControl_DTEnded;
            LoginControl.DTControl.DTStarted += DTControl_DTStarted;
        }

        void DTControl_DTStarted()
        {
            if (dtBoolLabel.InvokeRequired)
            {
                dtBoolLabel.BeginInvoke(new Action(DTControl_DTEnded));
            }
            else
            {
                dtBoolLabel.Text = String.Format("Is DT : {0}", LoginControl.DTControl.IsDT);
            }
        }

        void DTControl_DTEnded()
        {
            if (dtBoolLabel.InvokeRequired)
            {
                dtBoolLabel.BeginInvoke(new Action(DTControl_DTEnded));
            }
            else
            {
                dtBoolLabel.Text = String.Format("Is DT : {0}", LoginControl.DTControl.IsDT);
            }
        }

        void DTControl_DTStarting(double obj)
        {
            if (dtInXLabel.InvokeRequired)
            {
                dtInXLabel.BeginInvoke(new Action<double>(DTControl_DTStarting), obj);
            }
            else
            {
                dtInXLabel.Text = String.Format("Down time starting in {0} minutes", obj);
                dtBoolLabel.Text = String.Format("Is DT : {0}", LoginControl.DTControl.IsDT);
            }
        }

        void l_RichEvent(string Module, string Message)
        {
            if (loggingRTB.InvokeRequired)
            {
                loggingRTB.BeginInvoke(new Logger.RichLogEvent(l_RichEvent), Module, Message);
            }
            else
            {
                LoggerHelper.Instance.RichTextboxUpdater(loggingRTB, Module, Message);
            }
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            LoginControl.DoLogin(profileCombo.Text);
        }

        private void logOutButton_Click(object sender, EventArgs e)
        {
            LoginControl.DoLogout();
        }

        private void LauncherBot_Load(object sender, EventArgs e)
        {
            foreach (string charname in LoginControl.Config.Profiles.Keys)
            {
                profileCombo.Items.Add(charname);
            }

        }

        private void configButton_Click(object sender, EventArgs e)
        {
            LoginControl.Configure();
            profileCombo.Items.Clear();
            foreach (string charname in LoginControl.Config.Profiles.Keys)
            {
                profileCombo.Items.Add(charname);
            }
        }
    }
}
