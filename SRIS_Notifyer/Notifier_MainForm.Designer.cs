namespace SRIS_Notifier
{
    partial class Notifyer_MainForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Notifyer_MainForm));
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.rESTOREToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eXITToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridView_ListOfRequest = new System.Windows.Forms.DataGridView();
            this.timer_Start = new System.Windows.Forms.Timer(this.components);
            this.bt_Refresh = new System.Windows.Forms.Button();
            this.groupBox_NotifierSettings = new System.Windows.Forms.GroupBox();
            this.numericUpDown_TimeInterval = new System.Windows.Forms.NumericUpDown();
            this.bt_SaveNotifierSettings = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.checkBox_Status = new System.Windows.Forms.CheckBox();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_ListOfRequest)).BeginInit();
            this.groupBox_NotifierSettings.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_TimeInterval)).BeginInit();
            this.SuspendLayout();
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.ContextMenuStrip = this.contextMenuStrip1;
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseDoubleClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.rESTOREToolStripMenuItem,
            this.eXITToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(121, 48);
            // 
            // rESTOREToolStripMenuItem
            // 
            this.rESTOREToolStripMenuItem.Name = "rESTOREToolStripMenuItem";
            this.rESTOREToolStripMenuItem.Size = new System.Drawing.Size(120, 22);
            this.rESTOREToolStripMenuItem.Text = "RESTORE";
            this.rESTOREToolStripMenuItem.Click += new System.EventHandler(this.rESTOREToolStripMenuItem_Click);
            // 
            // eXITToolStripMenuItem
            // 
            this.eXITToolStripMenuItem.Name = "eXITToolStripMenuItem";
            this.eXITToolStripMenuItem.Size = new System.Drawing.Size(120, 22);
            this.eXITToolStripMenuItem.Text = "EXIT";
            this.eXITToolStripMenuItem.Click += new System.EventHandler(this.eXITToolStripMenuItem_Click);
            // 
            // dataGridView_ListOfRequest
            // 
            this.dataGridView_ListOfRequest.AllowUserToAddRows = false;
            this.dataGridView_ListOfRequest.AllowUserToDeleteRows = false;
            this.dataGridView_ListOfRequest.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView_ListOfRequest.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_ListOfRequest.Location = new System.Drawing.Point(3, 5);
            this.dataGridView_ListOfRequest.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridView_ListOfRequest.Name = "dataGridView_ListOfRequest";
            this.dataGridView_ListOfRequest.ReadOnly = true;
            this.dataGridView_ListOfRequest.RowHeadersVisible = false;
            this.dataGridView_ListOfRequest.Size = new System.Drawing.Size(1080, 288);
            this.dataGridView_ListOfRequest.TabIndex = 1;
            // 
            // timer_Start
            // 
            this.timer_Start.Interval = 300000;
            this.timer_Start.Tick += new System.EventHandler(this.timer_Start_Tick);
            // 
            // bt_Refresh
            // 
            this.bt_Refresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.bt_Refresh.Location = new System.Drawing.Point(8, 303);
            this.bt_Refresh.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.bt_Refresh.Name = "bt_Refresh";
            this.bt_Refresh.Size = new System.Drawing.Size(195, 103);
            this.bt_Refresh.TabIndex = 2;
            this.bt_Refresh.Text = "REFRESH";
            this.bt_Refresh.UseVisualStyleBackColor = true;
            this.bt_Refresh.Click += new System.EventHandler(this.bt_Refresh_Click);
            // 
            // groupBox_NotifierSettings
            // 
            this.groupBox_NotifierSettings.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox_NotifierSettings.Controls.Add(this.numericUpDown_TimeInterval);
            this.groupBox_NotifierSettings.Controls.Add(this.bt_SaveNotifierSettings);
            this.groupBox_NotifierSettings.Controls.Add(this.label1);
            this.groupBox_NotifierSettings.Controls.Add(this.checkBox_Status);
            this.groupBox_NotifierSettings.Location = new System.Drawing.Point(211, 303);
            this.groupBox_NotifierSettings.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox_NotifierSettings.Name = "groupBox_NotifierSettings";
            this.groupBox_NotifierSettings.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox_NotifierSettings.Size = new System.Drawing.Size(860, 97);
            this.groupBox_NotifierSettings.TabIndex = 3;
            this.groupBox_NotifierSettings.TabStop = false;
            this.groupBox_NotifierSettings.Text = "Notifier Settings";
            // 
            // numericUpDown_TimeInterval
            // 
            this.numericUpDown_TimeInterval.Location = new System.Drawing.Point(323, 46);
            this.numericUpDown_TimeInterval.Name = "numericUpDown_TimeInterval";
            this.numericUpDown_TimeInterval.Size = new System.Drawing.Size(61, 29);
            this.numericUpDown_TimeInterval.TabIndex = 5;
            // 
            // bt_SaveNotifierSettings
            // 
            this.bt_SaveNotifierSettings.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.bt_SaveNotifierSettings.Location = new System.Drawing.Point(501, 31);
            this.bt_SaveNotifierSettings.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.bt_SaveNotifierSettings.Name = "bt_SaveNotifierSettings";
            this.bt_SaveNotifierSettings.Size = new System.Drawing.Size(156, 52);
            this.bt_SaveNotifierSettings.TabIndex = 4;
            this.bt_SaveNotifierSettings.Text = "SAVE SETTINGS";
            this.bt_SaveNotifierSettings.UseVisualStyleBackColor = true;
            this.bt_SaveNotifierSettings.Click += new System.EventHandler(this.bt_SaveNotifierSettings_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(212, 47);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 21);
            this.label1.TabIndex = 2;
            this.label1.Text = "Time Interval:";
            // 
            // checkBox_Status
            // 
            this.checkBox_Status.AutoSize = true;
            this.checkBox_Status.Location = new System.Drawing.Point(30, 46);
            this.checkBox_Status.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.checkBox_Status.Name = "checkBox_Status";
            this.checkBox_Status.Size = new System.Drawing.Size(174, 25);
            this.checkBox_Status.TabIndex = 0;
            this.checkBox_Status.Text = "Recieve Notifications";
            this.checkBox_Status.UseVisualStyleBackColor = true;
            // 
            // Notifyer_MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1089, 409);
            this.Controls.Add(this.groupBox_NotifierSettings);
            this.Controls.Add(this.bt_Refresh);
            this.Controls.Add(this.dataGridView_ListOfRequest);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Notifyer_MainForm";
            this.Text = "Request List";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Notifyer_MainForm_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Notifyer_MainForm_FormClosed);
            this.Load += new System.EventHandler(this.Notifyer_MainForm_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_ListOfRequest)).EndInit();
            this.groupBox_NotifierSettings.ResumeLayout(false);
            this.groupBox_NotifierSettings.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_TimeInterval)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem eXITToolStripMenuItem;
        private System.Windows.Forms.DataGridView dataGridView_ListOfRequest;
        private System.Windows.Forms.Timer timer_Start;
        private System.Windows.Forms.Button bt_Refresh;
        private System.Windows.Forms.GroupBox groupBox_NotifierSettings;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox checkBox_Status;
        private System.Windows.Forms.Button bt_SaveNotifierSettings;
        private System.Windows.Forms.NumericUpDown numericUpDown_TimeInterval;
        private System.Windows.Forms.ToolStripMenuItem rESTOREToolStripMenuItem;
    }
}

