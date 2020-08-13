namespace ServiceRequestInformationSystem
{
    partial class BackUpForm
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
            this.bt_BackUp = new System.Windows.Forms.Button();
            this.SaveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.bt_Restore = new System.Windows.Forms.Button();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.SuspendLayout();
            // 
            // bt_BackUp
            // 
            this.bt_BackUp.BackColor = System.Drawing.Color.DimGray;
            this.bt_BackUp.FlatAppearance.BorderSize = 0;
            this.bt_BackUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_BackUp.Location = new System.Drawing.Point(37, 44);
            this.bt_BackUp.Name = "bt_BackUp";
            this.bt_BackUp.Size = new System.Drawing.Size(271, 69);
            this.bt_BackUp.TabIndex = 0;
            this.bt_BackUp.Text = "BACKUP DATABASE";
            this.bt_BackUp.UseVisualStyleBackColor = false;
            this.bt_BackUp.Click += new System.EventHandler(this.bt_BackUp_Click);
            // 
            // bt_Restore
            // 
            this.bt_Restore.BackColor = System.Drawing.Color.DimGray;
            this.bt_Restore.FlatAppearance.BorderSize = 0;
            this.bt_Restore.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_Restore.Location = new System.Drawing.Point(37, 132);
            this.bt_Restore.Name = "bt_Restore";
            this.bt_Restore.Size = new System.Drawing.Size(271, 69);
            this.bt_Restore.TabIndex = 1;
            this.bt_Restore.Text = "RESTORE DATABASE";
            this.bt_Restore.UseVisualStyleBackColor = false;
            this.bt_Restore.Click += new System.EventHandler(this.bt_Restore_Click);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            // 
            // BackUpForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(357, 235);
            this.Controls.Add(this.bt_Restore);
            this.Controls.Add(this.bt_BackUp);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "BackUpForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manage Database";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bt_BackUp;
        private System.Windows.Forms.SaveFileDialog SaveFileDialog1;
        private System.Windows.Forms.Button bt_Restore;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
    }
}