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
