
namespace ServiceRequestInformationSystem.UserForm
{
    partial class RptInspectionReport
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
            this.crystalReportViewer1 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cb_UnitSpecification = new System.Windows.Forms.CheckBox();
            this.cb_Recommendation = new System.Windows.Forms.CheckBox();
            this.cb_Particulars = new System.Windows.Forms.CheckBox();
            this.cb_Procedure = new System.Windows.Forms.CheckBox();
            this.tb_ID = new System.Windows.Forms.TextBox();
            this.bt_Print = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // crystalReportViewer1
            // 
            this.crystalReportViewer1.ActiveViewIndex = -1;
            this.crystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crystalReportViewer1.Location = new System.Drawing.Point(0, 45);
            this.crystalReportViewer1.Name = "crystalReportViewer1";
            this.crystalReportViewer1.Size = new System.Drawing.Size(853, 422);
            this.crystalReportViewer1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cb_UnitSpecification);
            this.panel1.Controls.Add(this.cb_Recommendation);
            this.panel1.Controls.Add(this.cb_Particulars);
            this.panel1.Controls.Add(this.cb_Procedure);
            this.panel1.Controls.Add(this.tb_ID);
            this.panel1.Controls.Add(this.bt_Print);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(853, 45);
            this.panel1.TabIndex = 1;
            // 
            // cb_UnitSpecification
            // 
            this.cb_UnitSpecification.AutoSize = true;
            this.cb_UnitSpecification.Location = new System.Drawing.Point(512, 12);
            this.cb_UnitSpecification.Name = "cb_UnitSpecification";
            this.cb_UnitSpecification.Size = new System.Drawing.Size(109, 17);
            this.cb_UnitSpecification.TabIndex = 5;
            this.cb_UnitSpecification.Text = "Unit Specification";
            this.cb_UnitSpecification.UseVisualStyleBackColor = true;
            this.cb_UnitSpecification.Visible = false;
            // 
            // cb_Recommendation
            // 
            this.cb_Recommendation.AutoSize = true;
            this.cb_Recommendation.Location = new System.Drawing.Point(397, 12);
            this.cb_Recommendation.Name = "cb_Recommendation";
            this.cb_Recommendation.Size = new System.Drawing.Size(109, 17);
            this.cb_Recommendation.TabIndex = 4;
            this.cb_Recommendation.Text = "Recommendation";
            this.cb_Recommendation.UseVisualStyleBackColor = true;
            this.cb_Recommendation.Visible = false;
            // 
            // cb_Particulars
            // 
            this.cb_Particulars.AutoSize = true;
            this.cb_Particulars.Location = new System.Drawing.Point(304, 12);
            this.cb_Particulars.Name = "cb_Particulars";
            this.cb_Particulars.Size = new System.Drawing.Size(75, 17);
            this.cb_Particulars.TabIndex = 3;
            this.cb_Particulars.Text = "Particulars";
            this.cb_Particulars.UseVisualStyleBackColor = true;
            this.cb_Particulars.Visible = false;
            // 
            // cb_Procedure
            // 
            this.cb_Procedure.AutoSize = true;
            this.cb_Procedure.Location = new System.Drawing.Point(223, 12);
            this.cb_Procedure.Name = "cb_Procedure";
            this.cb_Procedure.Size = new System.Drawing.Size(75, 17);
            this.cb_Procedure.TabIndex = 2;
            this.cb_Procedure.Text = "Procedure";
            this.cb_Procedure.UseVisualStyleBackColor = true;
            this.cb_Procedure.Visible = false;
            // 
            // tb_ID
            // 
            this.tb_ID.Location = new System.Drawing.Point(27, 12);
            this.tb_ID.Name = "tb_ID";
            this.tb_ID.Size = new System.Drawing.Size(185, 20);
            this.tb_ID.TabIndex = 1;
            this.tb_ID.Visible = false;
            // 
            // bt_Print
            // 
            this.bt_Print.Location = new System.Drawing.Point(627, 8);
            this.bt_Print.Name = "bt_Print";
            this.bt_Print.Size = new System.Drawing.Size(75, 23);
            this.bt_Print.TabIndex = 0;
            this.bt_Print.Text = "Print";
            this.bt_Print.UseVisualStyleBackColor = true;
            this.bt_Print.Visible = false;
            this.bt_Print.Click += new System.EventHandler(this.bt_Print_Click);
            // 
            // RptInspectionReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(853, 467);
            this.Controls.Add(this.crystalReportViewer1);
            this.Controls.Add(this.panel1);
            this.Name = "RptInspectionReport";
            this.Text = "RptInspectionReport";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.RptInspectionReport_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox tb_ID;
        private System.Windows.Forms.Button bt_Print;
        private System.Windows.Forms.CheckBox cb_Recommendation;
        private System.Windows.Forms.CheckBox cb_Particulars;
        private System.Windows.Forms.CheckBox cb_Procedure;
        private System.Windows.Forms.CheckBox cb_UnitSpecification;
    }
}