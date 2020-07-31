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
            this.bt_BackUp = new System.Windows.Forms.Button();
            this.SaveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.SuspendLayout();
            // 
            // bt_BackUp
            // 
            this.bt_BackUp.BackColor = System.Drawing.Color.DimGray;
            this.bt_BackUp.FlatAppearance.BorderSize = 0;
            this.bt_BackUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_BackUp.Location = new System.Drawing.Point(73, 119);
            this.bt_BackUp.Name = "bt_BackUp";
            this.bt_BackUp.Size = new System.Drawing.Size(184, 69);
            this.bt_BackUp.TabIndex = 0;
            this.bt_BackUp.Text = "Backup";
            this.bt_BackUp.UseVisualStyleBackColor = false;
            this.bt_BackUp.Click += new System.EventHandler(this.bt_BackUp_Click);
            // 
            // BackUpForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(357, 235);
            this.Controls.Add(this.bt_BackUp);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "BackUpForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Backup Database";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bt_BackUp;
        private System.Windows.Forms.SaveFileDialog SaveFileDialog1;
    }
}