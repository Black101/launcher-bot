namespace launcherbot
{
    partial class LauncherBot
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
            this.loggingRTB = new System.Windows.Forms.RichTextBox();
            this.loginButton = new System.Windows.Forms.Button();
            this.logOutButton = new System.Windows.Forms.Button();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.gb2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dtInXLabel = new System.Windows.Forms.Label();
            this.dtBoolLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.gb2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // loggingRTB
            // 
            this.loggingRTB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.loggingRTB.Location = new System.Drawing.Point(0, 0);
            this.loggingRTB.Name = "loggingRTB";
            this.loggingRTB.Size = new System.Drawing.Size(502, 318);
            this.loggingRTB.TabIndex = 0;
            this.loggingRTB.Text = "";
            // 
            // loginButton
            // 
            this.loginButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.loginButton.Location = new System.Drawing.Point(3, 16);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(75, 110);
            this.loginButton.TabIndex = 1;
            this.loginButton.Text = "Login";
            this.loginButton.UseVisualStyleBackColor = true;
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // logOutButton
            // 
            this.logOutButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.logOutButton.Location = new System.Drawing.Point(159, 16);
            this.logOutButton.Name = "logOutButton";
            this.logOutButton.Size = new System.Drawing.Size(75, 110);
            this.logOutButton.TabIndex = 2;
            this.logOutButton.Text = "Logout";
            this.logOutButton.UseVisualStyleBackColor = true;
            this.logOutButton.Click += new System.EventHandler(this.logOutButton_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.loggingRTB);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.groupBox1);
            this.splitContainer1.Size = new System.Drawing.Size(502, 470);
            this.splitContainer1.SplitterDistance = 318;
            this.splitContainer1.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.gb2);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(502, 148);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "LoginControl";
            // 
            // gb2
            // 
            this.gb2.Controls.Add(this.loginButton);
            this.gb2.Controls.Add(this.logOutButton);
            this.gb2.Dock = System.Windows.Forms.DockStyle.Right;
            this.gb2.Location = new System.Drawing.Point(262, 16);
            this.gb2.Name = "gb2";
            this.gb2.Size = new System.Drawing.Size(237, 129);
            this.gb2.TabIndex = 0;
            this.gb2.TabStop = false;
            this.gb2.Text = "Do";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dtBoolLabel);
            this.groupBox3.Controls.Add(this.dtInXLabel);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox3.Location = new System.Drawing.Point(3, 16);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(200, 129);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "DT Status";
            // 
            // dtInXLabel
            // 
            this.dtInXLabel.AutoSize = true;
            this.dtInXLabel.Location = new System.Drawing.Point(6, 27);
            this.dtInXLabel.Name = "dtInXLabel";
            this.dtInXLabel.Size = new System.Drawing.Size(83, 13);
            this.dtInXLabel.TabIndex = 0;
            this.dtInXLabel.Text = "DT in X Minutes";
            // 
            // dtBoolLabel
            // 
            this.dtBoolLabel.AutoSize = true;
            this.dtBoolLabel.Location = new System.Drawing.Point(6, 55);
            this.dtBoolLabel.Name = "dtBoolLabel";
            this.dtBoolLabel.Size = new System.Drawing.Size(100, 13);
            this.dtBoolLabel.TabIndex = 1;
            this.dtBoolLabel.Text = "Currently DT : False";
            // 
            // LauncherBot
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(502, 470);
            this.Controls.Add(this.splitContainer1);
            this.Name = "LauncherBot";
            this.Text = "LauncherBot";
            this.Load += new System.EventHandler(this.LauncherBot_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.gb2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox loggingRTB;
        private System.Windows.Forms.Button loginButton;
        private System.Windows.Forms.Button logOutButton;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label dtBoolLabel;
        private System.Windows.Forms.Label dtInXLabel;
        private System.Windows.Forms.GroupBox gb2;
    }
}